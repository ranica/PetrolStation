using BaseDAL.Model;
using Common.Helper.Antenna;
using Common.Network.Core;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;
using System.Threading;

namespace AntennaService
{
    public partial class AntennaService : ServiceBase
    {
        #region Constants
        /// <summary>
        /// Antenna Event Source name 
        /// </summary>
        public const string C_ANTENNA_EVENT_SOURCE = "GasAntennaService";

        /// <summary>
        /// Antenna Event Log name 
        /// </summary>
        public const string C_ANTENNA_EVENT_LOG = "GasAntennaLog";

        /// <summary>
        /// Buffer size
        /// </summary>
        private const int C_BufferSize = 1024;
        #endregion

        #region	Variables
        /// <summary>
        /// Event Log 
        /// </summary>
        private EventLog eventLog;

        private byte tag_flag = 0;
        private int tagCount = 0;
        private int lastStatus = 0;
        private byte[,] tagData = null;

        private MR6100 antennaWrapper = null;
        private NetTcpServer tcpServer = null;
        private ManualResetEvent mrs = null;
        private Thread tagReadThread = null;

        private SqlConnection dbConnection = null;
        private string antHost = "";
        private int antPort = 0;
        private int sPort = 0;
        private int interval = 0;
        private Thread connectThread = null;

        private Thread powerThread = null;
        private int powerInterval = 0;

        private Common.BLL.Entity.GasStation.User serviceUser;
        #endregion

        #region Methods

        /// <summary>
        /// Constrcutor 
        /// </summary>
        public AntennaService()
        {
            InitializeComponent();

            init();
            //System.Diagnostics.Debugger.Launch();
        }

        /// <summary>
        /// Initialize 
        /// </summary>
        private void init()
        {
            prepare();
        }

        /// <summary>
        /// Prepare 
        /// </summary>
        private void prepare()
        {
            mrs = new ManualResetEvent(true);
            makeEventLog();

            #region Get Service User
            Common.BLL.Logic.GasStation.User lUser = new Common.BLL.Logic.GasStation.User(
                Common.Enum.EDatabase.GasStation);
            CommandResult opResult = lUser.getServiceUser();

            serviceUser = opResult.model as Common.BLL.Entity.GasStation.User;
            #endregion
        }

        /// <summary>
        /// Make event log 
        /// </summary>
        private void makeEventLog()
        {
            try
            {
                eventLog = new EventLog();
                eventLog.Source = C_ANTENNA_EVENT_SOURCE;
                eventLog.Log = C_ANTENNA_EVENT_LOG;

                if (!EventLog.Exists(C_ANTENNA_EVENT_LOG))
                    EventLog.CreateEventSource(C_ANTENNA_EVENT_SOURCE, C_ANTENNA_EVENT_LOG);
                //else 
                //	EventLog.Delete(C_ANTENNA_EVENT_LOG);
            }
            catch (Exception ex)
            {
                LoggerExtensions.log(ex);
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Write log 
        /// </summary>
        /// <param name="log"></param>
        private void writeLog(string log)
        {
            if (null != eventLog)
            {
                log += "\r\n" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                eventLog.WriteEntry(log);
            }
        }

        /// <summary>
        /// On Start 
        /// </summary>
        /// <param name="args"></param>
        protected override void OnStart(string[] args)
        {
            #region Parse Args
            try
            {
                writeLog("Service Starting . . .");

                antHost = ConfigurationManager.AppSettings["AntennaHost"];
                antPort = ConfigurationManager.AppSettings["AntennaPort"].toInt(0);
                sPort = ConfigurationManager.AppSettings["ServerPort"].toInt(0);
                interval = ConfigurationManager.AppSettings["Interval"].toInt(15);
                powerInterval = ConfigurationManager.AppSettings["IntervalRF"].toInt(15);
                dbConnection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);

                tryToConnect();
            }
            catch (Exception ex)
            {
                LoggerExtensions.log(ex);
                writeLog("ERR: INVALID CONFIG DATA");
            }
            #endregion
        }

        /// <summary>
        /// On Stop 
        /// </summary>
        protected override void OnStop()
        {
            stop();
        }

        /// <summary>
        /// On Stop 
        /// </summary>
        private void stop()
        {
            antennaWrapper?.CloseCommPort();
            stopClientListener();
            stopConnectThread();

            writeLog("INF: Service Stopped successfully");
        }

        /// <summary>
        /// Stop Connect Thread
        /// </summary>
        private void stopConnectThread()
        {
            try
            {
                connectThread?.Abort();
            }
            catch (Exception ex)
            {
                LoggerExtensions.log(ex);
            }
        }

        /// <summary>
        /// On Continue
        /// </summary>
        protected override void OnContinue()
        {
            resume();
            base.OnContinue();
        }

        /// <summary>
        /// On Pause
        /// </summary>
        protected override void OnPause()
        {
            pause();
            base.OnPause();
        }

        /// <summary>
        /// Pause
        /// </summary>
        private void pause()
        {
            if (null != mrs)
                mrs.Reset();
        }

        /// <summary>
        /// Resume
        /// </summary>
        private void resume()
        {
            if (null != mrs)
                mrs.Set();
        }

        /// <summary>
        /// Try to connect
        /// </summary>
        private void tryToConnect()
        {
            //System.Diagnostics.Debugger.Launch();	
            connectThread = new Thread(new ThreadStart(connectToAntenna));
            connectThread.Start();
        }

        /// <summary>
        /// Try to connect to antenna
        /// </summary>
        private void connectToAntenna()
        {
            while (true)
            {
                // Try to connect to Antenna
                bool result = connectToAntenna(antHost, antPort);

                // Try to start client listener
                if (result)
                {
                    writeLog("INF: Connect To Antenna");
                    //writeLog("INF: start client listener");
                    //startClientListener(sPort);
                    break;
                }

                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// Start Tag Listen Thread
        /// </summary>
        private void startTagListenThread()
        {
            try
            {
                tagReadThread = new Thread(() =>
                {
                    bool reconnect = false;

                    try
                    {
                        while (null != antennaWrapper)
                        {
                            // Wait - if need
                            mrs.WaitOne();

                            lastStatus = antennaWrapper.EpcMultiTagIdentify(255, ref tagData,
                                ref tagCount, ref tag_flag);

                            if (lastStatus == MR6100.SUCCESS_RETURN)
                            {
                                parseTag(tagData, tagCount, tag_flag);
                            }
                            else
                            {
                                reconnect = true;
                                break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        LoggerExtensions.log(ex);
                        reconnect = true;
                        writeLog("ERR " + ex.Message);
                    }

                    if (reconnect)
                    {
                        try
                        {
                            tagReadThread?.Abort();
                        }
                        catch
                        {
                        }

                        tryToConnect();
                    }
                });

                tagReadThread.Start();
            }
            catch (Exception ex)
            {

                LoggerExtensions.log(ex);
            }            
        }

        /// <summary>
        /// Parse a tag
        /// </summary>
        /// <param name="tagData"></param>
        /// <param name="tagCount"></param>
        /// <param name="tag_flag"></param>
        private void parseTag(byte[,] tagData, int tagCount, byte tag_flag)
        {
            try
            {
                #region Parse ID
                string strAnteNo = "", strID = "", strTemp = "";
                int j = 0;

                for (int i = 0; i < tagCount; i++)
                {
                    j = 0;
                    strID = "";
                    strAnteNo = string.Format("{0:X2}", tagData[i, 1]);

                    // update: 0->2, 12->14
                    for (j = 2; j < 14; j++)
                    {
                        strTemp = string.Format("{0:X2}", tagData[i, j]);
                        strID += strTemp;
                    }

                    if (strID != "000000000000000000000000")
                    {
                        tagDetected(strID);
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                LoggerExtensions.log(ex);
            }
        }

        /// <summary>
        /// Tag Detected
        /// </summary>
        /// <param name="tagId"></param>
        private void tagDetected(string tagId)
        {
            try
            {
                //System.Diagnostics.Debugger.Launch();

                writeLog("tag detected:  " + tagId);
                if (tagId.StartsWith("E200"))
                    writeToDB(tagId);

                #region Send to clients
                /*if (null != tcpServer)
                    tcpServer.write (string.Format ("\nTAG\t{0}\t{1}\n", tagId, DateTime.Now));*/

                #endregion
            }
            catch (Exception ex)
            {
                LoggerExtensions.log(ex);
            }           
        }

        /// <summary>
        /// Write tag to db
        /// </summary>
        /// <param name="tagId"></param>
        private void writeToDB(string tagId)
        {
            try
            {
                Common.BLL.Logic.GasStation.Traffic lTraffic = new Common.BLL.Logic.GasStation.Traffic(Common.Enum.EDatabase.GasStation);
                Common.BLL.Entity.GasStation.Tag tag = new Common.BLL.Entity.GasStation.Tag()
                {
                    tag = tagId
                };

                lTraffic.insertTagByService(tag, serviceUser, DateTime.Now, interval);
            }
            catch (Exception ex)
            {

                LoggerExtensions.log(ex);
            }

        }

        /// <summary>
        /// Connect to antenna
        /// </summary>
        private bool connectToAntenna(string host, int port)
        {
            bool hasError = false;

            if (null == antennaWrapper)
                antennaWrapper = new MR6100();

            tag_flag = 0;
            tagCount = 0;
            tagData = new byte[500, 14];

            // Start Reader
            lastStatus = antennaWrapper.TcpConnectReader(host, port);

            // Check result
            if (lastStatus != MR6100.SUCCESS_RETURN)
            {
                hasError = true;
                writeLog("ERR: Connect to antenna failed");
            }
            else
            {
                hasError = false;
                startTagListenThread();
                //tryToSetPower();

                writeLog("INF: Service Started Successfully");
            }

            return !hasError;
        }

        /// <summary>
        /// Start Client Listener
        /// </summary>
        private void startClientListener(int port)
        {
            if (null == tcpServer)
            {
                tcpServer = new NetTcpServer(port, C_BufferSize);
                tcpServer.onReceiveData += TcpServer_onReceiveData;
                tcpServer.start();
                writeLog("INF: start tcpServer ");
            }
        }

        /// <summary>
        /// Stop Client Listener
        /// </summary>
        private void stopClientListener()
        {
            if (null != tcpServer)
                tcpServer.stop();
            tcpServer = null;
        }

        /// <summary>
        /// TcpServer 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="client"></param>
        /// <param name="data"></param>
        private void TcpServer_onReceiveData(NetTcpServer sender, NetTcpClient client, CommandResult data)
        {
            writeLog("INF: " + client.host + "- > Receive: " + Encoding.UTF8.GetString(data.model as byte[]));
            //Helper.ClientMethodParser.parseCmd (client, data);
        }

       /// <summary>
       /// Try to Set Power Antenna
       /// </summary>
        private void tryToSetPower()
        {
            powerThread = new Thread(new ThreadStart(() =>
            {
                try
                {
                    Thread.Sleep(powerInterval);
                    int rf = 0;
                    int[] power = new int[4];

                    if (antennaWrapper.GetRf(255, ref power) == MR6100.SUCCESS_RETURN)
                        rf = Convert.ToInt16(power[0]);

                    int setRF = ConfigurationManager.AppSettings["PowerRF"].toInt(0);
                    writeLog("rf value: " + rf.ToString());

                    if (rf != setRF)
                    {
                        if (antennaWrapper.SetRf(255, setRF, 0, 0, 0) == MR6100.SUCCESS_RETURN)
                        {
                            writeLog("Set Power success = " + setRF.ToString() );
                        }
                    }
                    else
                        writeLog("Get Power : " + rf.ToString());
                }
                catch (Exception ex)
                {
                    LoggerExtensions.log(ex);
                }
            }));
            powerThread.Start();            
        }     

        #endregion
    }
}
