using BaseDAL.Model;
using Common.Enum;
using Common.Helper.Logger;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GasStation.Forms.Reports
{
    public partial class ReportTrafficForm : General.SuperForm
    {
        #region Variables
        Common.BLL.Entity.GasStation.Plate plateModel = new Common.BLL.Entity.GasStation.Plate();
        private DataTable resultDataTable;
        private Thread readTrafficThread;
        private TimeSpan _readInterval;
        private bool _selectItem = false, turn = false;
       
        #endregion

        #region Properties
        public TimeSpan readInterval
        {
            get
            {
                if (_readInterval == null)
                    _readInterval = new TimeSpan(0, 0, 30);
                return _readInterval;
            }
            set
            {
                _readInterval = value;
            }
        }
        #endregion

        #region Method			
        public ReportTrafficForm()
        {
            InitializeComponent();
            init();
        }

        /// <summary>
        /// Initilizer
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
            showButton.Click += showButton_Click;
            //printButton.Click += printButton_Click;
            typeComboBox.SelectedIndexChanged += TypeComboBox_SelectedIndexChanged;
            plateTypeComboBox.SelectedIndexChanged += PlateTypeComboBox_SelectedIndexChanged;
            this.FormClosing += ReportTrafficForm_FormClosing;
            //searchButton.Click += SearchButton_Click;
            nextButton.Click += NextButton_Click;
            previousButton.Click += PreviousButton_Click;
            pageIndexComboBox.SelectedIndexChanged += PageIndexComboBox_SelectedIndexChanged;
        }

        private void PageIndexComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tryToReadTraffic();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Common.BLL.Logic.GasStation.Traffic lTraffic = new Common.BLL.Logic.GasStation.Traffic(Common.Enum.EDatabase.GasStation);
            int PI = Convert.ToInt32(pageIndexComboBox.Text);
            int PS = Convert.ToInt32(pageSizeComboBox.Text);
            CommandResult opResult = lTraffic.loadPaginate(1, 10);
            DataTable resultData = ExtensionsDateTable.makePersianDate(opResult.model as DataTable, "_Shamsi", true);
            stateTabPage.Controls.Clear();
            UserControls.StateTrafficUserControl stateTraffic = new UserControls.StateTrafficUserControl(resultData);

            stateTabPage.Controls.Add(stateTraffic);
        }

        

        /// <summary>
        /// Prepare
        /// </summary>
        private void prepare()
        {
            dateStartMaskedTextBox.Text =
            dateEndMaskedTextBox.Text = ExtensionsDateTime.toPersianDate(DateTime.Now);
            typeComboBox.SelectedIndex = 0;
            pageIndexComboBox.SelectedIndex = 0;
            reloadCombo();
           
            //tryToReadTraffic();
        }

        /// <summary>
        /// Relaod Combobox
        /// </summary>
        private void reloadCombo()
        {
            //Plate type 
            Common.BLL.Logic.GasStation.Base__PlateType lPlateType = new Common.BLL.Logic.GasStation.Base__PlateType(Common.Enum.EDatabase.GasStation);
            DataTable resultPlateType = lPlateType.allData("", "", false).model as DataTable;
            plateTypeComboBox.fillByTable(resultPlateType, "id", "type");
        }

        /// <summary>
        /// Try To Read Traffic
        /// </summary>
        private void tryToReadTraffic()
        {
            //readTrafficThread = new Thread(new ThreadStart(delegate
            //{
            //    try
            //    {
            //        while (true)
            //        {
            //            Thread.Sleep(readInterval);

                        string dateStart = dateStartMaskedTextBox.Text.Trim();
                        string dateEnd = dateEndMaskedTextBox.Text.Trim();

                        if (ExtensionsDateTime.isValidDate(dateStart) && ExtensionsDateTime.isValidDate(dateEnd))
                        {
                            DateTime date1 = ExtensionsDateTime.persianToMiladi(dateStart);
                            DateTime date2 = ExtensionsDateTime.persianToMiladi(dateEnd);
                            if (!_selectItem)
                            {
                                loadTraffic(date1, date2);
                                //loadCountTraffic(date1, date2);
                            }

                        }

                        if (readInterval != TimeSpan.Parse(ConfigurationManager.AppSettings["Interval"]))
                            readInterval = TimeSpan.Parse(ConfigurationManager.AppSettings["Interval"]);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        LoggerExtensions.log(ex);
            //    }
            //}));

            //readTrafficThread.Start();
        }
        /// <summary>
        /// Plate Type ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlateTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int palteType = (int)plateTypeComboBox.SelectedValue;
            SelectPlateType(palteType);
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeComboBox.SelectedIndex == 1)
            {
                //if (readTrafficThread != null)
                //    readTrafficThread.Abort();
                _selectItem = true;
                nationalCodeMaskedTextBox.Visible = true;
                plateDataGroupBox.Visible = false;
                nationalCodeMaskedTextBox.Clear();
                nationalCodeMaskedTextBox.Focus();
            }
            else if (typeComboBox.SelectedIndex == 2)
            {
                _selectItem = true;
                //if (readTrafficThread != null)
                //    readTrafficThread.Abort();

                plateDataGroupBox.Visible = true;
                nationalCodeMaskedTextBox.Visible = false;
            }
            else if (typeComboBox.SelectedIndex == 0)
            {
                _selectItem = false;
                nationalCodeMaskedTextBox.Visible = false;
                plateDataGroupBox.Visible = false;
            }
        }


        private void SelectPlateType(int type)
        {
            switch (type)
            {
                case ((int)enumPlateType.Personal):
                    updatePlate(Color.White, Color.Black);
                    break;
                case ((int)enumPlateType.Taxi):
                    updatePlate(Color.Yellow, Color.Black, "ت");
                    break;
                case ((int)enumPlateType.Polity):
                    updatePlate(Color.Red, Color.White, "الف");
                    break;
                case ((int)enumPlateType.Malulin):
                    {
                        mainPlatePanel.Visible = false;
                        motorPlatePanel.Visible = false;
                        malulinPlatePanel.Visible = true;
                        malulinPlatePanel.Location = new Point(mainPlatePanel.Location.X, mainPlatePanel.Location.Y);

                    }
                    break;
                case ((int)enumPlateType.Motor): // موتور سیکلت
                    {
                        mainPlatePanel.Visible = false;
                        malulinPlatePanel.Visible = false;
                        motorPlatePanel.Visible = true;
                        motorPlatePanel.Location = new Point(mainPlatePanel.Location.X, mainPlatePanel.Location.Y);
                    }
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Upadte Panel Plate
        /// </summary>
        /// <param name="backColorPart"></param>
        /// <param name="foreColorPart"></param>
        /// <param name="character"></param>
        private void updatePlate(Color backColorPart, Color foreColorPart, string character = null)
        {
            mainPlatePanel.Visible = true;
            malulinPlatePanel.Visible = false;
            motorPlatePanel.Visible = false;
            part1MainTextBox.BackColor =
            part2MainTextBox.BackColor = backColorPart;
            part1MainTextBox.ForeColor =
            part2MainTextBox.ForeColor = foreColorPart;
        }
        /// <summary>
        /// Print Reoort
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printButton_Click(object sender, EventArgs e)
        {
            try
            {
                StiReport mainreport = new StiReport();

                mainreport.RegBusinessObject("traffic", resultDataTable);
                mainreport.Load(Application.StartupPath + "\\Reports\\traffic.mrt");
                mainreport.Compile();
                mainreport["myDate"] = ExtensionsDateTime.toPersianDate(DateTime.Now);
                mainreport.Render();
                mainreport.Show();
            }
            catch (Exception ex)
            {

                LoggerExtensions.log(ex);
            }

        }
        /// <summary>
        /// Show Report 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showButton_Click(object sender, EventArgs e)
        {
            try
            {
                string dateStart = dateStartMaskedTextBox.Text.Trim();
                string dateEnd = dateEndMaskedTextBox.Text.Trim();

                if (ExtensionsDateTime.isValidDate(dateStart) && ExtensionsDateTime.isValidDate(dateEnd))
                {
                    DateTime date1 = ExtensionsDateTime.persianToMiladi(dateStart);
                    DateTime date2 = ExtensionsDateTime.persianToMiladi(dateEnd).Add(new TimeSpan(23, 59, 59));

                    if (typeComboBox.SelectedIndex == 0)
                    {
                        loadTraffic(date1, date2);

                       // loadCountTraffic(date1, date2);
                    }
                    else if (typeComboBox.SelectedIndex == 1)
                    {
                        string nationalcode = nationalCodeMaskedTextBox.Text.Trim();
                        CommandResult opResult = null;
                        opResult = validateNationalCode();
                        if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
                        {
                            loadTrafficByNationalCode(date1, date2, nationalcode);

                            LoadCountTrafficByNationalCode(date1, date2, nationalcode);
                        }
                        else
                            MessageBox.Show(opResult.model.ToString(), "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    }
                    else if (typeComboBox.SelectedIndex == 2)
                    {
                        //TODO: fill plate
                        string plate = string.Empty;

                        BaseBLL.General.FormModelHelper<Common.BLL.Entity.GasStation.Plate>.fillModel(plateDataGroupBox, plateModel);
                        switch (plateModel.plateTypeId)
                        {
                            case ((int)enumPlateType.Personal):
                            case ((int)enumPlateType.Taxi):
                            case ((int)enumPlateType.Polity):
                                plate = part1MainTextBox.Text + "_" + characterDomainUpDown.Text + "_" + part2MainTextBox.Text + "_" + code1Numeric.Text;
                                break;
                            case ((int)enumPlateType.Malulin):
                                plate = part1MalulinTextBox.Text + "_" + part2MaluinTextBox.Text + "_" + code2Numeric.Text;
                                break;
                            case ((int)enumPlateType.Motor):
                                plate = part1MotorTextBox.Text + "_" + part2MotorTextBox.Text;
                                break;
                            default:
                                break;
                        }

                        CommandResult opResult = null;
                        opResult = validatePlateData();

                        if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
                        {
                            loadTrafficByPlate(date1, date2, plate);

                            loadCountTrafficByPlate(date1, date2, plate);
                        }
                        else
                            MessageBox.Show(opResult.model.ToString(), "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                    //resultGrid.DataSource = result;
                    //resultGrid.loadHeader(this.GetType().Name);		

                }
                else
                {
                    //TODO: Date isnot Valid
                }

            }
            catch (Exception ex)
            {
                LoggerExtensions.log(ex);
            }
        }

        /// <summary>
        /// Validation National code
        /// </summary>
        /// <returns></returns>
        private CommandResult validateNationalCode()
        {
            CommandResult result;
            string natioal = nationalCodeMaskedTextBox.Text.Trim();
            if (natioal.isNullOrEmptyOrWhiteSpaceOrLen(10))
                result = CommandResult.makeErrorResult("ERROR", "کد ملی وارد شده نامعتبر است");
            else
                result = CommandResult.makeSuccessResult("OK");

            return result;
        }
        /// <summary>
        /// Validate Plate data
        /// </summary>
        /// <returns></returns>
        private CommandResult validatePlateData()
        {
            CommandResult result;

            List<string> err = new List<string>();
            string part1Main = part1MainTextBox.Text.Trim();
            string part2Main = part2MainTextBox.Text.Trim();
            string code1 = code1Numeric.Text.Trim();
            string character = characterDomainUpDown.Text.Trim();
            string part1Malulin = part1MalulinTextBox.Text.Trim();
            string part2Maluin = part2MaluinTextBox.Text.Trim();
            string code2 = code2Numeric.Text.Trim();
            string part1Motor = part1MotorTextBox.Text.Trim();
            string part2Motor = part2MotorTextBox.Text.Trim();

            #region Validate
            switch ((int)plateTypeComboBox.SelectedValue)
            {
                case ((int)enumPlateType.Personal):
                case ((int)enumPlateType.Taxi):
                case ((int)enumPlateType.Polity):
                    {
                        if (part1Main.isNullOrEmptyOrWhiteSpaceOrLen(2))
                            err.Add("بخش اول پلاک وارد شده نامعتبر می باشد");
                        if (part2Main.isNullOrEmptyOrWhiteSpaceOrLen(3))
                            err.Add("بخش دوم پلاک وارد شده نامعتبر می باشد");
                        if (code1.isNullOrEmptyOrWhiteSpaceOrLen(2))
                            err.Add("کد شهر پلاک وارد شده نامعتبر می باشد");
                        else if (null == getNameCity(code1))
                            err.Add("کد شهر پلاک وارد شده نامعتبر می باشد");
                        if (character.isNullOrEmptyOrWhiteSpaceOrLen(3))
                            err.Add("حرف وارد شده نامعتبر است");
                    }
                    break;

                case ((int)enumPlateType.Malulin):
                    {
                        if (part1Malulin.isNullOrEmptyOrWhiteSpaceOrLen(2))
                            err.Add("بخش اول پلاک وارد شده نامعتبر می باشد");
                        if (part2Maluin.isNullOrEmptyOrWhiteSpaceOrLen(3))
                            err.Add("بخش دوم پلاک وارد شده نامعتبر می باشد");
                        if (code2.isNullOrEmptyOrWhiteSpaceOrLen(2))
                            err.Add("کد شهر پلاک وارد شده نامعتبر می باشد");
                        else if (null == getNameCity(code2))
                            err.Add("کد شهر پلاک وارد شده نامعتبر می باشد");

                    }
                    break;
                case ((int)enumPlateType.Motor): // موتور سیکلت
                    {
                        if (part1Motor.isNullOrEmptyOrWhiteSpaceOrLen(6))
                            err.Add("بخش اول پلاک وارد شده نامعتبر می باشد");
                        if (part2Motor.isNullOrEmptyOrWhiteSpaceOrLen(6))
                            err.Add("بخش دوم پلاک وارد شده نامعتبر می باشد");
                    }
                    break;

                default:
                    break;
            }
            #endregion

            // Check for errors
            if (err.Count > 0)
                result = CommandResult.makeErrorResult("ERROR", String.Join("\r\n", err.ToArray()));
            else
                result = CommandResult.makeSuccessResult("OK");

            return result;
        }
        /// <summary>
        /// Get Name City and Get cityId
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        private string getNameCity(string code)
        {
            string result = null;
            Common.BLL.Logic.GasStation.Base__PlateCity lPlateCity = new Common.BLL.Logic.GasStation.Base__PlateCity(Common.Enum.EDatabase.GasStation);
            DataTable resultPlateCity = lPlateCity.allData("", "", false).model as DataTable;

            var resultItem = (from myRow in resultPlateCity.AsEnumerable()
                              where myRow.Field<string>("code") == code
                              select myRow).FirstOrDefault();
            if (null != resultItem)
            {
                plateModel.plateCityId = (int)resultItem.ItemArray[0];
                result = resultItem.ItemArray[3].ToString();
            }

            return result;
        }


        #region Load Traffic

        /// <summary>
        /// Load Traffic
        /// </summary>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        private void loadTraffic(DateTime date1, DateTime date2)
        {
            try
            {
                //Invoke((Action)delegate
                //{
                    Common.BLL.Logic.GasStation.Traffic lTraffic = new Common.BLL.Logic.GasStation.Traffic(Common.Enum.EDatabase.GasStation);
                    int PI = Convert.ToInt32(pageIndexComboBox.Text);
                    //int PS = Convert.ToInt32(pageSizeComboBox.Text);
                    int PS = 10;
                    CommandResult opResult = lTraffic.loadTraffic(date1, date2, PI, PS);
                    DataTable resultData = ExtensionsDateTable.makePersianDate(opResult.model as DataTable, "_Shamsi", true);

                    if (!turn)
                    {
                        int total = Convert.ToInt16(resultData.Rows[1].ItemArray[1]);

                        pageIndexComboBox.Items.Clear();
                        //pageSizeComboBox.Items.Clear();

                        for (int i = 1; i <= (total / PS); i++)
                        {
                            pageIndexComboBox.Items.Add(i);
                            //pageSizeComboBox.Items.Add(10 * i);
                        }

                        pageIndexComboBox.SelectedIndex = 0;
                        //pageSizeComboBox.SelectedIndex = 0;


                        if (pageIndexComboBox.Text == "1")
                        {
                            previousButton.Visible = false;
                        }

                        turn = true;
                    }



                    stateTabPage.Controls.Clear();
                    UserControls.StateTrafficUserControl stateTraffic = new UserControls.StateTrafficUserControl(resultData);
                    stateTabPage.Controls.Add(stateTraffic);

                    //stateTabPage.Controls.Clear();
                    ////UserControls.StateTrafficUserControl stateTraffic = new UserControls.StateTrafficUserControl(resultData);
                    //UserControls.StateTrafficUserControl stateTraffic = new UserControls.StateTrafficUserControl(date1, date2);
                    //stateTabPage.Controls.Add(stateTraffic);

                //});
            }
            catch (Exception ex)
            {
                LoggerExtensions.log(ex);
            }

        }
        /// <summary>
        /// Load Traffic By National code
        /// </summary>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        /// <param name="nationalcode"></param>
        private void loadTrafficByNationalCode(DateTime date1, DateTime date2, string nationalcode)
        {
            Common.BLL.Logic.GasStation.Traffic lTraffic = new Common.BLL.Logic.GasStation.Traffic(Common.Enum.EDatabase.GasStation);
            CommandResult opResult = lTraffic.loadTrafficByNationalcode(date1, date2, nationalcode);
            DataTable resultData = ExtensionsDateTable.makePersianDate(opResult.model as DataTable, "_Shamsi", true);
            //stateTabPage.Controls.Clear();
            //UserControls.StateTrafficUserControl stateTraffic = new UserControls.StateTrafficUserControl(resultData);
            //stateTabPage.Controls.Add(stateTraffic);
        }
        /// <summary>
        /// Load Traffic By Plate
        /// </summary>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        /// <param name="plate"></param>
		private void loadTrafficByPlate(DateTime date1, DateTime date2, string plate)
        {
            Common.BLL.Logic.GasStation.Traffic lTraffic = new Common.BLL.Logic.GasStation.Traffic(Common.Enum.EDatabase.GasStation);
            CommandResult opResult = lTraffic.loadTrafficByPlate(date1, date2, plate);
            DataTable resultData = ExtensionsDateTable.makePersianDate(opResult.model as DataTable, "_Shamsi", true);
            //stateTabPage.Controls.Clear();
            //UserControls.StateTrafficUserControl stateTraffic = new UserControls.StateTrafficUserControl(resultData);
            //stateTabPage.Controls.Add(stateTraffic);
        }

        #endregion

        #region Load  Count Traffic
        /// <summary>
        /// Load Count Traffic
        /// </summary>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
		private void loadCountTraffic(DateTime date1, DateTime date2)
        {
            try
            {
                Invoke((Action)delegate
                {
                    Common.BLL.Logic.GasStation.Traffic lTraffic = new Common.BLL.Logic.GasStation.Traffic(Common.Enum.EDatabase.GasStation);
                    CommandResult opResult = lTraffic.loadTrafficCount(date1, date2);
                    DataTable resultData = opResult.model as DataTable;
                    countTabPage.Controls.Clear();
                    UserControls.CountTrafficUserControl countTraffic = new UserControls.CountTrafficUserControl(resultData);
                    countTabPage.Controls.Add(countTraffic);
                });

            }
            catch (Exception ex)
            {
                LoggerExtensions.log(ex);
            }
        }

        /// <summary>
        /// Load Count Traffic By Nationalcode
        /// </summary>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        /// <param name="nationalcode"></param>
        private void LoadCountTrafficByNationalCode(DateTime date1, DateTime date2, string nationalcode)
        {
            Common.BLL.Logic.GasStation.Traffic lTraffic = new Common.BLL.Logic.GasStation.Traffic(Common.Enum.EDatabase.GasStation);
            CommandResult opResult = lTraffic.loadReportTrafficCountByNationalcode(date1, date2, nationalcode);
            DataTable resultData = opResult.model as DataTable;
            countTabPage.Controls.Clear();
            UserControls.CountTrafficUserControl countTraffic = new UserControls.CountTrafficUserControl(resultData);
            countTabPage.Controls.Add(countTraffic);
        }

        /// <summary>
        /// Load count Traffic By Plate
        /// </summary>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        /// <param name="plate"></param>
        private void loadCountTrafficByPlate(DateTime date1, DateTime date2, string plate)
        {
            Common.BLL.Logic.GasStation.Traffic lTraffic = new Common.BLL.Logic.GasStation.Traffic(Common.Enum.EDatabase.GasStation);
            CommandResult opResult = lTraffic.loadReportTrafficCountByPlate(date1, date2, plate);
            DataTable resultData = opResult.model as DataTable;
            countTabPage.Controls.Clear();
            UserControls.CountTrafficUserControl countTraffic = new UserControls.CountTrafficUserControl(resultData);
            countTabPage.Controls.Add(countTraffic);
        }

        #endregion
        
        private void ReportTrafficForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (null != readTrafficThread)
                    readTrafficThread.Abort();
            }
            catch (Exception ex)
            {
                LoggerExtensions.log(ex);
            }

        }

        private void updateUi()
        {
            int page = Convert.ToInt16(pageIndexComboBox.Text);
            int count = pageIndexComboBox.Items.Count;

            previousButton.Visible = (page > 1);
            nextButton.Visible = (page < count);

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            int page = 1;

            // Get page
            page = Convert.ToInt16(pageIndexComboBox.Text);
            nextStep(page);

        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            int page = 1;
            page = Convert.ToInt16(pageIndexComboBox.Text);
            // Get page
            previousePage(page);
        }

        private void nextStep(int page)
        {
            if (page == pageIndexComboBox.Items.Count - 1)
            {
                pageIndexComboBox.SelectedIndex = page;
                updateUi();
            }
            else if (++page < pageIndexComboBox.Items.Count)
            {
                pageIndexComboBox.SelectedIndex = page - 1;
                updateUi();
            }
        }

        private void previousePage(int page)
        {
            if (--page > -1)
            {
                pageIndexComboBox.SelectedIndex = page - 1;
                updateUi();
            }
        }


        #endregion


    }
}
