using BaseDAL.Model;
using PetrolStation.Forms.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common.BLL.Entity.PetrolStation;
using PetrolStation.Forms.Base;
using System.Reflection;
using Stimulsoft.Report;
using PetrolStation.Forms.Reports;
using System.Threading;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;

namespace PetrolStation.Forms.Forms
{
    public partial class MainForm : General.SuperForm
    {
        #region Properties
        public TimeSpan readInterval
        {
            get
            {
                if (_readInterval == null)
                {
                    _readInterval = new TimeSpan(0, 0, 30);
                }

                return _readInterval;
            }
            set
            {
                _readInterval = value;
            }
        }
        #endregion

        #region Variable
        //Common.BLL.Logic.PetrolStation.User	lUser;
        //Common.BLL.Entity.PetrolStation.User	user;
        Common.BLL.Entity.PetrolStation.System__Data model;

        Series series;

        private Thread readTrafficThread;
        private TimeSpan _readInterval;

        private object obj = new object();

        #endregion

        #region Methods
        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            init();
        }

        /// <summary>
        /// Init
        /// </summary>
        private void init()
        {
            bindEvents();
            prepare();
        }

        /// <summary>
		/// Bind Events
		/// </summary>
		private void bindEvents()
        {
            // Menus	
            logoffMenuItem.Click += LogoffMenuItem_Click;
            exitMenuItem.Click += ExitMenuItem_Click;

            //Customer
            customerMenuItem.Click += CustomerMenuItem_Click;
            customerShowMenuItem.Click += CustomerShowMenuItem_Click;
            customerSerachMenuItem.Click += CustomerSerachMenuItem_Click;

            //Car
            carTypeMenuItem.Click += CarTypeMenuItem_Click;
            carSystemMenuItem.Click += CarSystemMenuItem_Click;
            carFuelMenuItem.Click += CarFuelMenuItem_Click;
            carLevelMenuItem.Click += CarLevelMenuItem_Click;
            carColorMenuItem.Click += CarColorMenuItem_Click;

            //Plate
            plateCityMenuItem.Click += PlateCityMenuItem_Click;
            plateTypeMenuItem.Click += PlateTypeMenuItem_Click;

            //Lottery
            lotteryToolStripMenuItem.Click += LotteryToolStripMenuItem_Click;

            //Report
            reportCustomerMenuItem.Click += ReportCustomerMenuItem_Click;
            reportCarMenuItem.Click += ReportCarMenuItem_Click;

            //Report Traffic
            stateReportToolStripMenuItem.Click += StateReportToolStripMenuItem_Click;
            countReportToolStripMenuItem.Click += CountReportToolStripMenuItem_Click;


            aboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
        }


        /// <summary>
        /// Prepare
        /// </summary>
        private void prepare()
        {
            __Program.hasLogin = 0;     // Default exit menu (Logoff)

            model = new Common.BLL.Entity.PetrolStation.System__Data()
            {
                name = "DB-Version"
            };
            Common.BLL.Logic.PetrolStation.System__Data lSystemData = new Common.BLL.Logic.PetrolStation.System__Data(Common.Enum.EDatabase.PetrolStation);
            CommandResult opResult = lSystemData.read(model, "name");
            if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
                versionToolStripStatusLabel.Text = model.value;

            userToolStripStatusLabel.Text = Common.GlobalData.UserManager.currentUser.name + " " +
                                            Common.GlobalData.UserManager.currentUser.lastname;

            // Get Version
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            versionToolStripStatusLabel.Text = version;
            dateToolStripStatusLabel.Text = ExtensionsDateTime.getWeekDay(DateTime.Now) + "  " + ExtensionsDateTime.toPersianDate(DateTime.Now);

            createChart();

            startLoadThread();

        }

        /// <summary>
        /// Create Chart
        /// </summary>
        private void createChart()
        {
            series = this.trafficChart.Series.Add("تردد ها");
            series.ChartType = SeriesChartType.RangeColumn;
            series.Color = Color.SteelBlue;
            //series.Font = new Font("BYekan", 15.0f, FontStyle.Italic); //changes nothing
            series.Font = new System.Drawing.Font("Trebuchet MS", 9F);

            trafficChart.Titles.Add("نمودار تردد های هفته جاری");
        }

        /// <summary>
        /// Load Info Chart Traffic
        /// </summary> 
        private void fillChart()
        {
            Common.BLL.Logic.PetrolStation.Traffic lTraffic =
                                        new Common.BLL.Logic.PetrolStation.Traffic(Common.Enum.EDatabase.PetrolStation);

            CommandResult opResult = lTraffic.fillChart(DateTime.Now, Common.GlobalData.UserManager.currentUser.id);

            DataTable resultData = ExtensionsDateTable.makeWeekDay(opResult.model as DataTable, "_WeekDay", true);

            // Add remaining days
            //if (7 > resultData.Rows.Count)
            //{
            //    int lastRow = resultData.Rows.Count - 1;
            //    DateTime? lastDate = resultData.Rows[lastRow]["dat"].ToString().toDateTime();

            //    for (int i = lastRow; i < 7; ++i)
            //    {
            //        lastDate.Value.AddDays(1);

            //        resultData.Rows.Add(lastDate, 0);
            //    }
            //}
            
            Invoke((Action)delegate
            {
                series.Points.Clear();

                // Add series.
                for (int i = 0; i < resultData.Rows.Count; i++)
                {
                    // Add point.
                    series.Points.AddXY(resultData.Rows[i]["dat_WeekDay"].ToString(), resultData.Rows[i]["count"]);
                }

            });
        }

        /// <summary>
        /// Start reload thread
        /// </summary>
        private void startLoadThread()
        {
            readTrafficThread = new Thread(new ThreadStart(delegate
            {
                try
                {
                    while (true)
                    {
                        Thread.Sleep(readInterval);

                        tryToReadTraffic();

                        fillChart();
                    }
                }
                catch (Exception ex)
                {
                    LoggerExtensions.log(ex);
                }
            }));

            readTrafficThread.Start();
        }

        /// <summary>
        /// Try To Read Traffic
        /// </summary>
        private void tryToReadTraffic()
        {
            lock (obj)
            {
                DateTime beginDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

                loadTraffic(beginDate);

                if (readInterval != TimeSpan.Parse(ConfigurationManager.AppSettings["Interval"]))
                {
                    readInterval = TimeSpan.Parse(ConfigurationManager.AppSettings["Interval"]);
                }
            }
        }

        /// <summary>
        /// Load Traffic
        /// </summary>
        /// <param name="date1"> Begin Date</param>
        /// <param name="date2">End Date</param>
        private void loadTraffic(DateTime begindate)
        {
            try
            {
                Common.BLL.Logic.PetrolStation.Traffic lTraffic =
                                        new Common.BLL.Logic.PetrolStation.Traffic(Common.Enum.EDatabase.PetrolStation);

                CommandResult opResult = lTraffic.getTraffic(begindate, Common.GlobalData.UserManager.currentUser.id);
                DataTable resultData = ExtensionsDateTable.makePersianDate(opResult.model as DataTable, "_Shamsi", true);

                #region Add Result Grid
                Invoke((Action)delegate
                {
                    if ((0 < resultData.Rows.Count) && (null != resultData))
                    {
                        dashboardTabPage.Controls.Clear();

                        UserControls.DashboardUserControl dashboardTraffic = new UserControls.DashboardUserControl(resultData);

                        dashboardTabPage.Controls.Add(dashboardTraffic);
                        dashboardTraffic.Dock = DockStyle.Fill;
                    }
                    #endregion

                });

            }
            catch (Exception ex)
            {
                LoggerExtensions.log(ex);
            }

        }
        /// <summary>
        /// Lottery
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LotteryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CumulativeForm lotteryform = new CumulativeForm();
            lotteryform.ShowDialog();
        }

        /// <summary>
        /// Search Customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void CustomerSerachMenuItem_Click(object sender, EventArgs e)
        {
            CustomerSearchForm customerSerach = new CustomerSearchForm();
            customerSerach.ShowDialog();
        }

        /// <summary>
        /// About
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Count Report Traffic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportCountTrafficForm TCForm = new ReportCountTrafficForm();
            TCForm.ShowDialog();
        }

        /// <summary>
        /// State Report Traffic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportTrafficForm trafficReportForm = new ReportTrafficForm();
            trafficReportForm.ShowDialog();
        }

        /// <summary>
        /// Report Car and Tag 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportCarMenuItem_Click(object sender, EventArgs e)
        {
            Common.BLL.Logic.PetrolStation.Owner lOwner = new Common.BLL.Logic.PetrolStation.Owner(Common.Enum.EDatabase.PetrolStation);
            CommandResult opResult = lOwner.loadTag();
            DataTable result = opResult.model as DataTable;
            StiReport mainreport = new StiReport();
            StiOptions.Viewer.RightToLeft = StiRightToLeftType.Yes;
            mainreport.RegBusinessObject("report", result);
            mainreport.Load(Application.StartupPath + "\\Reports\\report.mrt");
            mainreport.Compile();
            mainreport["myDate"] = ExtensionsDateTime.toPersianDate(DateTime.Now);
            mainreport.Render();
            mainreport.Show();
        }

        /// <summary>
        /// Report Customer Menu Item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportCustomerMenuItem_Click(object sender, EventArgs e)
        {

            Common.BLL.Logic.PetrolStation.Owner lOwner = new Common.BLL.Logic.PetrolStation.Owner(Common.Enum.EDatabase.PetrolStation);
            CommandResult opResult = lOwner.loadReportOwner();
            DataTable result = opResult.model as DataTable;
            StiReport mainreport = new StiReport();
            mainreport.RegBusinessObject("owner", result);
            mainreport.Load(Application.StartupPath + "\\Reports\\owner.mrt");
            mainreport.Compile();
            mainreport["myDate"] = ExtensionsDateTime.toPersianDate(DateTime.Now);
            mainreport.Render();
            mainreport.Show();
        }

        /// <summary>
        /// Show Customer Menu Item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerShowMenuItem_Click(object sender, EventArgs e)
        {
            CustomerViewForm form = new CustomerViewForm();
            form.ShowDialog();
        }
        /// <summary>
        /// Customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm();
            form.ShowDialog();
        }

        /// <summary>
        /// Car Level Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CarLevelMenuItem_Click(object sender, EventArgs e)
        {
            CarLevelForm form = new CarLevelForm();
            form.ShowDialog();
        }

        /// <summary>
        /// Car Fuel Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CarFuelMenuItem_Click(object sender, EventArgs e)
        {
            CarFuelForm form = new CarFuelForm();
            form.ShowDialog();
        }

        /// <summary>
        /// Car System Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void CarSystemMenuItem_Click(object sender, EventArgs e)
        {
            CarSystemForm form = new CarSystemForm();
            form.ShowDialog();
        }

        /// <summary>
        /// Car Type Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CarTypeMenuItem_Click(object sender, EventArgs e)
        {
            CarTypeForm form = new CarTypeForm();
            form.ShowDialog();
        }

        /// <summary>
        /// Car Color Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CarColorMenuItem_Click(object sender, EventArgs e)
        {
            CarColorForm form = new CarColorForm();
            form.ShowDialog();
        }

        /// <summary>
        /// Plate City
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlateCityMenuItem_Click(object sender, EventArgs e)
        {
            PlateCityForm form = new PlateCityForm();
            form.ShowDialog();
        }

        /// <summary>
        /// Plate Type Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlateTypeMenuItem_Click(object sender, EventArgs e)
        {
            PlateTypeForm form = new PlateTypeForm();
            form.ShowDialog();
        }

        /// <summary>
        /// Exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            __Program.hasLogin = 2;
            readTrafficThread.Abort();

            Close();
        }

        /// <summary>
        /// Logoff Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoffMenuItem_Click(object sender, EventArgs e)
        {
            __Program.hasLogin = 0;
            Close();
        }

        /// <summary>
        /// OnClose
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }
        #endregion

    }
}
