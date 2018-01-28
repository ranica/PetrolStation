 using BaseDAL.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace GasStation
{
    static class __Program
    {
        public static int hasLogin;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            prepare();


            //// Initilization
            //string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            //Common.Initializer.init(Path.Combine(Application.StartupPath, "log.txt"), exePath);



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //// TEST
            //Application.Run(new Forms.testForm());
            //return;
            while (hasLogin != 2)
            {
                Application.Run(new Forms.User.LoginForm());

                if (hasLogin == 1)
                    Application.Run(new Forms.Forms.MainForm());
            }
        }

        /// <summary>
        /// Prepare
        /// </summary>
        private static void prepare()
        {
            // Prepare
            __Program.hasLogin = 0;

            // Initilization
            string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            Common.Initializer.init(Path.Combine(Application.StartupPath, "log.txt"), exePath);

            ///FOR TEST
            Common.BLL.Entity.GasStation.User user = new Common.BLL.Entity.GasStation.User();
            Common.BLL.Logic.GasStation.User luser = new Common.BLL.Logic.GasStation.User(Common.Enum.EDatabase.GasStation);
            user.id = 2;
            luser.read(user);
            Common.GlobalData.UserManager.currentUser = user;

            Helper.GridHeaderMaker.makeHeaderOwnerUserControls();
            //Helper.GridHeaderMaker.makeHeaderCarUserControls();
            //Helper.GridHeaderMaker.makeHeaderTrafficUserControls();
            //Helper.GridHeaderMaker.makeHeaderSearchOwner();

            //Helper.GridHeaderMaker.makeHeaderTrafficUserControls();
            //Helper.GridHeaderMaker.makeHeaderReportTraffic();
            //Helper.GridHeaderMaker.makeHeaderLotteryForm();

            //Helper.GridHeaderMaker.makeHeaderReportCountTraffic();
            //Helper.GridHeaderMaker.makeHeaderOwner();
            //Helper.GridHeaderMaker.makeHeaderCarColor();
            //Helper.GridHeaderMaker.makeHeaderCarLevel();
            //Helper.GridHeaderMaker.makeHeaderCarFuel();
            //Helper.GridHeaderMaker.makeHeaderCarSystem();
            //Helper.GridHeaderMaker.makeHeaderCarType();
            //Helper.GridHeaderMaker.makeHeaderPlateType();
            //Helper.GridHeaderMaker.makeHeaderPlateCity();


            // Add the event handler for handling UI thread exceptions to the event.
            Application.ThreadException += Application_ThreadException;

            // Set the unhandled exception mode to force all Windows Forms errors
            // to go through our handler.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // Add the event handler for handling non-UI thread exceptions to the event. 
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }
        /// <summary>
        /// Thread Exception
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            e.Exception.log();
        }
        /// <summary>
        /// Unhandled Exception
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            (e.ExceptionObject as Exception).log();
        }
    }
}

