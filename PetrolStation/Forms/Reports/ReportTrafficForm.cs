using BaseDAL.Model;
using Common.Enum;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace PetrolStation.Forms.Reports
{
    public partial class ReportTrafficForm : General.SuperForm
    {
        #region Variables
        Common.BLL.Entity.PetrolStation.Plate plateModel
                                            = new Common.BLL.Entity.PetrolStation.Plate();
        private DataTable resultDataTable;
        private Thread readTrafficThread;
        private TimeSpan _readInterval;
        private bool _selectItem = false;
        private bool loadData = true;        

        #endregion

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
            pageSizeComboBox.SelectedIndex = 0;
            pageIndexComboBox.SelectedIndex = 0;

            bindEvents();
            prepare();
        }

        /// <summary>
        /// Bind Events
        /// </summary>
        private void bindEvents()
        {
            this.FormClosing                        += ReportTrafficForm_FormClosing;

            showButton.Click                        += showButton_Click;
            typeComboBox.SelectedIndexChanged       += TypeComboBox_SelectedIndexChanged;
            plateTypeComboBox.SelectedIndexChanged  += PlateTypeComboBox_SelectedIndexChanged;

            nextButton.Click                        += NextButton_Click;
            previousButton.Click                    += PreviousButton_Click;

            pageIndexComboBox.SelectedIndexChanged  += PageIndexComboBox_SelectedIndexChanged;
            pageSizeComboBox.SelectedIndexChanged   += PageSizeComboBox_SelectedIndexChanged;

        }

        /// <summary>
        /// Prepare
        /// </summary>
        private void prepare()
        {
            String beginDate = ExtensionsDateTime.toPersianDate(DateTime.Now.AddMonths(-9));
            String endDate = ExtensionsDateTime.toPersianDate(DateTime.Now);

            dateStartMaskedTextBox.Text = beginDate;
            dateEndMaskedTextBox.Text = endDate;
            typeComboBox.SelectedIndex = 0;

            reloadCombo();

            tryToReadTraffic();

        }

        /// <summary>
        /// Relaod Combobox
        /// </summary>
        private void reloadCombo()
        {
            Common.BLL.Logic.PetrolStation.Base__PlateType lPlateType =
                new Common.BLL.Logic.PetrolStation.Base__PlateType(Common.Enum.EDatabase.PetrolStation);

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
            //try
            //{
            //    while (true)
            //    {
            //        Thread.Sleep(readInterval);

            string dateStart = dateStartMaskedTextBox.Text.Trim();
            string dateEnd = dateEndMaskedTextBox.Text.Trim();

            if (ExtensionsDateTime.isValidDate(dateStart) && ExtensionsDateTime.isValidDate(dateEnd))
            {
                DateTime begin_date = ExtensionsDateTime.persianToMiladi(dateStart);
                DateTime end_date = ExtensionsDateTime.persianToMiladi(dateEnd);
                if (!_selectItem)
                {                                          
                   loadTraffic(begin_date, end_date); 
                }

            }

            if (readInterval != TimeSpan.Parse(ConfigurationManager.AppSettings["Interval"]))
                readInterval = TimeSpan.Parse(ConfigurationManager.AppSettings["Interval"]);
            //}
            //    }
            //    catch (Exception ex)
            //    {
            //        LoggerExtensions.log(ex);
            //    }
            //}));

            //readTrafficThread.Start();
        }

        /// <summary>
        /// Page Index ComboBox Selected_Index_Changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void PageIndexComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set visible of buttons
            //previousButton.Enabled  = (pageIndexComboBox.SelectedIndex > 1);
            //nextButton.Enabled      = (pageIndexComboBox.SelectedIndex < pageIndexComboBox.Items.Count - 1);

            tryToReadTraffic();
            updateUi();

        }

        /// <summary>
        /// Page Size ComboBox Selected_Index_Changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PageSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tryToReadTraffic();
        }

        /// <summary>
        /// Plate Type ComboBox Selected_Index_Change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlateTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int palteType = (int)plateTypeComboBox.SelectedValue;
            SelectPlateType(palteType);
        }

        /// <summary>
        /// Type ComboBox Selected_Index_Change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Select Plate Type
        /// </summary>
        /// <param name="type"> Type is : Personal, Taxi, Polity, Malulin, Motor, </param>

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
        /// Show Report 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showButton_Click(object sender, EventArgs e)
        {
            try
            {
                pageIndexComboBox.SelectedIndex = 0;
                loadData = true;                

                string dateStart = dateStartMaskedTextBox.Text.Trim();
                string dateEnd = dateEndMaskedTextBox.Text.Trim();

                if (ExtensionsDateTime.isValidDate(dateStart) && ExtensionsDateTime.isValidDate(dateEnd))
                {
                    DateTime begin_date = ExtensionsDateTime.persianToMiladi(dateStart);
                    DateTime end_date = ExtensionsDateTime.persianToMiladi(dateEnd).Add(new TimeSpan(23, 59, 59));

                    if (typeComboBox.SelectedIndex == 0)
                    {
                        loadTraffic(begin_date, end_date);                       
                    }
                    else if (typeComboBox.SelectedIndex == 1)
                    {
                        string nationalcode = nationalCodeMaskedTextBox.Text.Trim();
                        CommandResult opResult = null;

                        opResult = validateNationalCode();

                        if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
                        {
                            loadTrafficByNationalCode(begin_date, end_date, nationalcode);
                        }
                        else
                        {
                            MessageBox.Show(opResult.model.ToString(), "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    else if (typeComboBox.SelectedIndex == 2)
                    {
                        //TODO: fill plate
                        string plate = string.Empty;

                        BaseBLL.General.FormModelHelper<Common.BLL.Entity.PetrolStation.Plate>.fillModel(plateDataGroupBox, plateModel);

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
                            loadTrafficByPlate(begin_date, end_date, plate);
                        }
                        else
                            MessageBox.Show(opResult.model.ToString(), "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }

                else
                {
                    //TODO: Date isnot Valid

                    /// TODO: Show a convenient alarm
                }

                updateUi();
                
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
            Common.BLL.Logic.PetrolStation.Base__PlateCity lPlateCity = new Common.BLL.Logic.PetrolStation.Base__PlateCity(Common.Enum.EDatabase.PetrolStation);
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
        /// Update Pages count comboBox
        /// </summary>
        /// <param name="total"></param>
        private void updatePagesCount(int total, int pageSize, TabPage tabPage)
        {
            int count = (total / pageSize) + (total % pageSize == 0 ? 0 : 1);

            if (count == 0)
            {
                count = 1;
            }

            int currentPage;

            if (!int.TryParse(pageIndexComboBox.Text, out currentPage))
            {
                return;
            }

            pageIndexComboBox.Items.Clear();
            for (int i = 1; i <= count; i++)
            {
                pageIndexComboBox.Items.Add(i.ToString());
            }

            currentPage = (int)Math.Min(count, currentPage);
            
            loadData = false;
            
            pageIndexComboBox.SelectedIndex = currentPage - 1;
        }
        
       

        /// <summary>
        /// Load Traffic
        /// </summary>
        /// <param name="date1"> Begin Date</param>
        /// <param name="date2">End Date</param>
        private void loadTraffic(DateTime begindate, DateTime enddate)
        {

            int PI;
            int PS;
            try
            {
               
                if (!int.TryParse(pageIndexComboBox.Text, out PI) ||
                    !int.TryParse(pageSizeComboBox.Text, out PS))
                {
                    MessageBox.Show("شماره صفحه و تعداد سطرها را مشخص نمایید", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }


                if (!loadData)
                {
                    loadData = true;

                    return;
                }


                Common.BLL.Logic.PetrolStation.Traffic lTraffic =
                new Common.BLL.Logic.PetrolStation.Traffic(Common.Enum.EDatabase.PetrolStation);

                CommandResult opResult = lTraffic.loadTraffic(begindate, enddate, PI, PS, Common.GlobalData.UserManager.currentUser.id);
                DataTable resultData = ExtensionsDateTable.makePersianDate(opResult.model as DataTable, "_Shamsi", true);

                if (resultData.Rows.Count > 0)
                {
                    int total = Convert.ToInt32(resultData.Rows[0]["total"]);

                    updatePagesCount(total, PS, mainTabControl.SelectedTab);
                }

                #region Add Result Grid
                stateTabPage.Controls.Clear();

                UserControls.StateTrafficUserControl stateTraffic = new UserControls.StateTrafficUserControl(resultData);

                stateTabPage.Controls.Add(stateTraffic);
                stateTraffic.Dock = DockStyle.Fill;
                #endregion

                
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
        private void loadTrafficByNationalCode(DateTime begindate, DateTime enddate, string nationalcode)
        {
            int PI;
            int PS;
            try
            {
                if (!int.TryParse(pageIndexComboBox.Text, out PI) ||
                    !int.TryParse(pageSizeComboBox.Text, out PS))
                {
                    MessageBox.Show("شماره صفحه و تعداد سطرها را مشخص نمایید", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }


                if (!loadData)
                {
                    loadData = true;

                    return;
                }


                Common.BLL.Logic.PetrolStation.Traffic lTraffic =
                                        new Common.BLL.Logic.PetrolStation.Traffic(Common.Enum.EDatabase.PetrolStation);

                CommandResult opResult = lTraffic.loadTByNC(begindate, enddate, nationalcode, PI, PS, Common.GlobalData.UserManager.currentUser.id);

                DataTable resultData = ExtensionsDateTable.makePersianDate(opResult.model as DataTable, "_Shamsi", true);

                if (resultData.Rows.Count > 0)
                {
                    int total = Convert.ToInt32(resultData.Rows[0]["total"]);

                    updatePagesCount(total, PS, mainTabControl.SelectedTab);
                }

                #region Add Result Grid
                stateTabPage.Controls.Clear();

                UserControls.StateTrafficUserControl stateTraffic = new UserControls.StateTrafficUserControl(resultData);

                stateTabPage.Controls.Add(stateTraffic);
                stateTraffic.Dock = DockStyle.Fill;
                #endregion

                
            }
            catch (Exception ex)
            {
                LoggerExtensions.log(ex);
            }
        }

        /// <summary>
        /// Load Traffic By Plate
        /// </summary>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        /// <param name="plate"></param>
		private void loadTrafficByPlate(DateTime begindate, DateTime enddate, string plate)
        {
            int PI;
            int PS;
            try
            {
                if (!int.TryParse(pageIndexComboBox.Text, out PI) ||
                    !int.TryParse(pageSizeComboBox.Text, out PS))
                {
                    MessageBox.Show("شماره صفحه و تعداد سطرها را مشخص نمایید", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }


                if (!loadData)
                {
                    loadData = true;

                    return;
                }


                Common.BLL.Logic.PetrolStation.Traffic lTraffic =
                                                    new Common.BLL.Logic.PetrolStation.Traffic(Common.Enum.EDatabase.PetrolStation);

                CommandResult opResult = lTraffic.loadTByP(begindate, enddate, plate, PI, PS, Common.GlobalData.UserManager.currentUser.id);

                DataTable resultData = ExtensionsDateTable.makePersianDate(opResult.model as DataTable, "_Shamsi", true);

                if (resultData.Rows.Count > 0)
                {
                    int total = Convert.ToInt32(resultData.Rows[0]["total"]);

                    updatePagesCount(total, PS, mainTabControl.SelectedTab);
                }

                #region Add Result Grid
                stateTabPage.Controls.Clear();

                UserControls.StateTrafficUserControl stateTraffic = new UserControls.StateTrafficUserControl(resultData);

                stateTabPage.Controls.Add(stateTraffic);
                stateTraffic.Dock = DockStyle.Fill;
                #endregion


            }
            catch (Exception ex)
            {
                LoggerExtensions.log(ex);
            }

            
           
            //DataTable resultData = ExtensionsDateTable.makePersianDate(opResult.model as DataTable, "_Shamsi", true);
            //stateTabPage.Controls.Clear();
            //UserControls.StateTrafficUserControl stateTraffic = new UserControls.StateTrafficUserControl(resultData);
            //stateTabPage.Controls.Add(stateTraffic);
        }

        #endregion
             

        /// <summary>
        /// Closing Report Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Update Ui
        /// </summary>

        private void updateUi()
        {
            int page = Convert.ToInt16(pageIndexComboBox.Text);
            int count = pageIndexComboBox.Items.Count;

            previousButton.Visible = (page > 1);
            nextButton.Visible = (page < count);

        }

        /// <summary>
        /// Next Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void NextButton_Click(object sender, EventArgs e)
        {
            int page = 1;

            // Get page
            page = Convert.ToInt16(pageIndexComboBox.Text);
            nextPage(page);

        }

        /// <summary>
        /// Previous Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreviousButton_Click(object sender, EventArgs e)
        {
            int page = 1;
            page = Convert.ToInt16(pageIndexComboBox.Text);
            // Get page
            previousPage(page);
        }

        /// <summary>
        /// Next Page
        /// </summary>
        /// <param name="page"></param>
        private void nextPage(int page)
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

        /// <summary>
        /// Previouse Page
        /// </summary>
        /// <param name="page"></param>
        private void previousPage(int page)
        {
            if (--page > -1)
            {
                pageIndexComboBox.SelectedIndex = page - 1;
                updateUi();
            }
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

        #endregion
    }
}
