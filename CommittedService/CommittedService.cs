using BaseDAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;

namespace CommittedService
{
    public partial class CommittedService : ServiceBase
    {

        #region Constants
        public const string C_COMMITTED_EVENT_SOURCE = "GasCommittedService";
        public const string C_COMMITTED_EVENT_LOG = "GasCommittedLog";
        #endregion

        #region Variable 
        private string serviceName;
        private string hostName;
        private EventLog eventLog;
        string status = string.Empty;
        private Thread connectThread = null, updateThread = null, resumeThread = null;
        private Common.BLL.Entity.GasStation.User serviceUser;
        private ManualResetEvent mrs = null;
        Common.BLL.Logic.GasStation.UHF lUHF;
        Common.BLL.Entity.GasStation.UHF uhfModel;
        Common.BLL.Logic.GasStation.User lUser;
        #endregion

        #region Method   

        public CommittedService()
        {
            InitializeComponent();

            Init();
        }
        /// <summary>
        /// Initializer
        /// </summary>
        private void Init()
        {
            prepare();
            writeLog("Init");
        }
        /// <summary>
        /// Prepare
        /// </summary>
        private void prepare()
        {
            mrs = new ManualResetEvent(true);
            makeEventLog();
            serviceName = ConfigurationManager.AppSettings["serviceName"];
            hostName = ConfigurationManager.AppSettings["hostName"];

            #region Get Service User
            lUser = new Common.BLL.Logic.GasStation.User(
                Common.Enum.EDatabase.GasStation);
            CommandResult opResult = lUser.getServiceUser();

            serviceUser = opResult.model as Common.BLL.Entity.GasStation.User;
            writeLog("Service Name: " + serviceUser.name);
            #endregion

            #region Get UHF
            lUHF = new Common.BLL.Logic.GasStation.UHF(
                Common.Enum.EDatabase.GasStation);

            uhfModel = new Common.BLL.Entity.GasStation.UHF
            {
                IP = hostName
            };

            //System.Diagnostics.Debugger.Launch();
            CommandResult result = lUHF.read(uhfModel, "IP", true);

            if ((result.status == BaseDAL.Base.EnumCommandStatus.success) && (uhfModel.id > 0))
            {
                writeLog("Network Status: " + uhfModel.netStatus + " , Port: " + uhfModel.Port);
            }

            #endregion
        }
        /// <summary>
        /// Make event log 
        /// </summary>        
        private void makeEventLog()
        {
            try
            {
                //System.Diagnostics.Debugger.Launch();
                eventLog = new EventLog();
                eventLog.Source = C_COMMITTED_EVENT_SOURCE;
                eventLog.Log = C_COMMITTED_EVENT_LOG;

                if (!EventLog.Exists(C_COMMITTED_EVENT_LOG))
                    EventLog.CreateEventSource(C_COMMITTED_EVENT_SOURCE, C_COMMITTED_EVENT_LOG);

            }
            catch (Exception ex)
            {
                LoggerExtensions.log(ex);
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Write log 
        /// </summary>
        /// <param name="log"></param>
        private void writeLog(string log)
        {
            try
            {
                if (null != eventLog)
                {
                    log += "\r\n" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                    eventLog.WriteEntry(log);
                }
            }
            catch (Exception ex)
            {
                LoggerExtensions.log(ex);
            }

        }

        protected override void OnStart(string[] args)
        {
            writeLog("Start Service Committed");
            tryToConnect();
        }
       
        /// <summary>
        /// Try to Strat Service
        /// </summary>
        private void tryToConnect()
        {
            connectThread = new Thread(new ThreadStart(StartService));
            connectThread.Start();
        }

        /// <summary>
        /// Try to Resume Service
        /// </summary>
        private void tryToResume()
        {
            resumeThread = new Thread(new ThreadStart(ResumeService));
            resumeThread.Start();
        }
        /// <summary>
        ///Start Service
        /// </summary>
        private void StartService()
        {
            try
            {
                Common.Helper.Windows.ServiceHelper.startService(serviceName, hostName);
                ServiceControllerStatus opResult = Common.Helper.Windows.ServiceHelper.serviceStatus(serviceName, hostName);
                updateStatus();
            }
            catch (Exception ex)
            {
                LoggerExtensions.log(ex);
            }
        }

        /// <summary>
        ///Resume Service
        /// </summary>
        private void ResumeService()
        {
            try
            {
                Common.Helper.Windows.ServiceHelper.resumeService(serviceName, hostName);
                ServiceControllerStatus opResult = Common.Helper.Windows.ServiceHelper.serviceStatus(serviceName, hostName);
                updateStatus();
            }
            catch (Exception ex)
            {
                LoggerExtensions.log(ex);
            }
        }
        /// <summary>
        /// Update Status Service
        /// </summary>
        private void updateStatus()
        {
            //mrs.Reset();
            updateThread = new Thread(new ThreadStart(() =>
            {
                try
                {
                    while (true)
                    {
                        Thread.Sleep(5000);
                        mrs.WaitOne();

                        ServiceControllerStatus opResult = Common.Helper.Windows.ServiceHelper.serviceStatus(serviceName, hostName);

                        if ((opResult == ServiceControllerStatus.Running) || (opResult == ServiceControllerStatus.StartPending))
                        {
                            writeLog("Status Service: " + Enum.GetName(typeof(ServiceControllerStatus), ServiceControllerStatus.Running));
                            UpdateService(true, ServiceControllerStatus.Running);
                        }

                        else if ((opResult == ServiceControllerStatus.Stopped) || (opResult == ServiceControllerStatus.StopPending))
                        {
                            writeLog("Status Service: " + Enum.GetName(typeof(ServiceControllerStatus), ServiceControllerStatus.Stopped));
                            UpdateService(true, ServiceControllerStatus.Stopped);
                            tryToConnect();
                            break;
                        }

                        else if ((opResult == ServiceControllerStatus.Paused) || (opResult == ServiceControllerStatus.PausePending))
                        {
                            writeLog("Status Service: " + Enum.GetName(typeof(ServiceControllerStatus), ServiceControllerStatus.Paused));
                            UpdateService(true, ServiceControllerStatus.Paused);
                            tryToResume();
                            break;
                        }

                        else
                        {
                            //UpdateService(false, ServiceControllerStatus.);
                            //status = "نامشخص";
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    LoggerExtensions.log(ex);
                }
            }));
            updateThread.Start();
        }        

        /// <summary>
        /// Update Service 
        /// </summary>
        /// <param name="netStatus">  Network Status </param>
        /// <param name="serveStatus"> Service Status</param>
        private void UpdateService(bool netStatus, ServiceControllerStatus serveStatus)
        {
            try
            {
                if (uhfModel.id > 0)
                {
                    uhfModel.netStatus = netStatus;
                    uhfModel.serviceStatus = Enum.GetName(typeof(ServiceControllerStatus), serveStatus);

                    bool result = lUHF.updateStatusService(uhfModel, serviceUser, DateTime.Now);
                    if (result)
                        writeLog("Update Status Service Successsful.");
                }
            }
            catch (Exception ex)
            {
                LoggerExtensions.log(ex);
            }
        }

        /// <summary>
        /// Stop
        /// </summary>
        protected override void OnStop()
        {
            writeLog("Stop Committed Service");
            connectThread?.Abort();
            resumeThread?.Abort();
        }

        #endregion
    }
}
