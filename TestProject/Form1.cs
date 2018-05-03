using BaseDAL.Model;
using Common.Helper.Antenna;
using Common.Network.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TestProject
{
    public partial class Form1 : Form
    {
        #region	Variables
        /// <summary>
        /// Event Log 
        /// </summary>
        //private EventLog eventLog;

        private byte tag_flag = 0;
        private int tagCount = 0;
        private int lastStatus = 0;
        private byte[,] tagData = null;

        private MR6100 antennaWrapper = null;
        private NetTcpServer tcpServer = null;
        private ManualResetEvent mrs = null;
        private Thread tagReadThread = null;

        //private SqlConnection dbConnection = null;
        private string antName = "";
        private int antPort = 0;
        private int serverPort = 0;
        private int interval = 0;
        private Thread connectThread = null;

        private Thread powerThread = null;
        private int powerInterval = 0;

        private Common.BLL.Entity.PetrolStation.User serviceUser;
        private Common.BLL.Entity.PetrolStation.UHF antenna;
        #endregion
        public Form1()
        {
            InitializeComponent();

            init();
        }

        private void init()
        {
            prepare();
        }

        private void prepare()
        {

            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            Common.Initializer.init(Path.Combine(Application.StartupPath, "log.txt"), path);

            antName = ConfigurationManager.AppSettings["AntennaName"];

            mrs = new ManualResetEvent(true);
            

            #region Get Service User
            Common.BLL.Logic.PetrolStation.User lUser = new Common.BLL.Logic.PetrolStation.User(
                Common.Enum.EDatabase.PetrolStation);
            CommandResult opResult = lUser.getServiceUser();

            serviceUser = opResult.model as Common.BLL.Entity.PetrolStation.User;
            #endregion


            #region Get Antenna
            Common.BLL.Logic.PetrolStation.UHF lUHF = new Common.BLL.Logic.PetrolStation.UHF(
                Common.Enum.EDatabase.PetrolStation);

            CommandResult opResultUHF = lUHF.getAntenna(antName);

            antenna = opResultUHF.model as Common.BLL.Entity.PetrolStation.UHF;

            if (null != antenna)
            {
                writeLog(antenna.IP + " " + antenna.Port);
            }
            else
            {
                writeLog("Error in antenna");
            }


            #endregion
        }



        private void startButton_Click(object sender, EventArgs e)
        {
            #region Parse Args
            try
            {
                listBox1.Items.Insert(0, "Service Starting . . .");
                               

                serverPort = ConfigurationManager.AppSettings["ServerPort"].toInt(0);
                interval = ConfigurationManager.AppSettings["Interval"].toInt(15);
                powerInterval = ConfigurationManager.AppSettings["IntervalRF"].toInt(15);
                //dbConnection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);


                tryToConnect();
            }
            catch (Exception ex)
            {
                LoggerExtensions.log(ex);
                writeLog( "ERR: INVALID CONFIG DATA");
            }
            #endregion
        }

        private void stopButton_Click(object sender, EventArgs e)
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

            writeLog( "INF: Service Stopped successfully");
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
            if (null != connectThread)
            {
                try
                {
                    connectThread.Abort();
                }
                finally
                {
                    connectThread = null;
                }
            }


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
                bool result = connectToAntenna(antenna.IP, antenna.Port);
                //bool result = connectToAntenna(antenna.IP, antenna.Port);

                // Try to start client listener
                if (result)
                {
                    startTagListenThread();

                    writeLog( "INF: Connect To Antenna");
                    
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
                try
                {
                    tagReadThread?.Abort();
                }
                finally
                {
                    tagReadThread = null;
                }

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
                        finally
                        {
                            tagReadThread = null;
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

        private void writeLog(string v)
        {
            if (InvokeRequired)
            {
                this.Invoke((Action)delegate
                {

                    writeLog(v);
                });


                return;
            }

            listBox1.Items.Insert(0, v);
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
                writeLog("Enter DB");
                Common.BLL.Logic.PetrolStation.Traffic lTraffic = new Common.BLL.Logic.PetrolStation.Traffic(Common.Enum.EDatabase.PetrolStation);
                Common.BLL.Entity.PetrolStation.Tag tag = new Common.BLL.Entity.PetrolStation.Tag()
                {
                    tag = tagId
                };

                lTraffic.insertTagByService(antenna.id, tag, serviceUser, DateTime.Now, interval);
                //lTraffic.insertTagByService(antenna.id, tag, serviceUser, DateTime.Now, interval);

                writeLog("Exit DB");
            }
            catch (Exception ex)
            {
                writeLog("Exception DB");
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
                //tryToSetPower();

                writeLog("INF: Service Started Successfully");
            }

            return !hasError;
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
                            writeLog("Set Power success = " + setRF.ToString());
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
    }
}
