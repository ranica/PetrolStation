using BaseDAL.Model;
using Common.Helper.Logger;
using Common.Helper.Lottery;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GasStation.Forms.Forms
{
    public partial class LotteryForm : General.SuperForm
    {
        #region Variable

        Common.BLL.Entity.GasStation.Base__Month monthModel = new Common.BLL.Entity.GasStation.Base__Month();
        DataTable resultDataTable;
        #endregion

        #region Method
        public LotteryForm()
        {
            InitializeComponent();

            Init();
        }
        /// <summary>
        /// Initializer
        /// </summary>
        private void Init()
        {
            bindEvent();

            prepare();
        }

        /// <summary>
		/// Bind Events
		/// </summary>
		private void bindEvent()
        {
            startButton.Click += StartButton_Click;
            printButton.Click += PrintButton_Click;

            monthRadioButton.CheckedChanged += MonthRadioButton_CheckedChanged;
            yearRadioButton.CheckedChanged += YearRadioButton_CheckedChanged;
        }

        private void YearRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (yearRadioButton.Checked)
            {
                yearTextBox.Enabled = true;
                yearTextBox.Text = ExtensionsDateTime.getPersianYear(DateTime.Now).ToString();
            }
            else
                yearTextBox.Enabled = false;
        }

        private void MonthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (monthRadioButton.Checked)
                monthComboBox.Enabled = true;
            else
                monthComboBox.Enabled = false;
        }

        /// <summary>
        /// Prepare
        /// </summary>
        private void prepare()
        {
            reloadCombo();
        }

        /// <summary>
        /// Relaod Data fr Combo Box
        /// </summary>
        private void reloadCombo()
        {
            Common.BLL.Logic.GasStation.Base__Month lMonth = new Common.BLL.Logic.GasStation.Base__Month(Common.Enum.EDatabase.GasStation);
            DataTable resultMonth = lMonth.allData("", "", false).model as DataTable;
            monthComboBox.fillByTable(resultMonth, "id", "month");
        }

        /// <summary>
        /// Start Lottery
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartButton_Click(object sender, EventArgs e)
        {
            DateTime startDate = new DateTime();
            DateTime endDate = new DateTime();
            List<int> winnerKey = new List<int>();

            //Get Date
            BaseBLL.General.FormModelHelper<Common.BLL.Entity.GasStation.Base__Month>.fillModel(dataGroupBox, monthModel);

            //Validate Date
            if (monthRadioButton.Checked)
            {
                startDate = ExtensionsDateTime.persianToMiladi(DateTime.Now.toPersianDate().Substring(0, 4) + "/" + monthModel.code + "/1");
                endDate = ExtensionsDateTime.getMiladiEndDate(Convert.ToInt32(monthModel.code));
                //endDate     = ExtensionsDateTime.getMiladiEndDate(Convert.ToInt32(monthModel.code)).AddDays(1);
            }
            else
            {
                CommandResult result = validateDate();
                if (result.status == BaseDAL.Base.EnumCommandStatus.success)
                {
                    startDate = ExtensionsDateTime.persianToMiladi(DateTime.Now.toPersianDate().Substring(0, 4) + "/1/1");
                    endDate = ExtensionsDateTime.persianToMiladi(DateTime.Now.toPersianDate().Substring(0, 4) + "/12/29");
                }
                else
                    MessageBox.Show(result.model.ToString(), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Check Last Lottery
          
            if (!GetDataLottery(startDate, endDate))
            {
                //Get Query
                Common.BLL.Logic.GasStation.Traffic lTraffic = new Common.BLL.Logic.GasStation.Traffic(Common.Enum.EDatabase.GasStation);
                CommandResult opResult = lTraffic.loadCumulative(startDate, endDate);

                #region Get Query for Lottery			

                if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
                {
                    Lottery<string> lottery = new Lottery<string>();

                    if (((DataTable)opResult.model).Rows.Count > 0)
                    {
                        foreach (DataRow row in ((DataTable)opResult.model).Rows)
                        {
                            string a = row["total"].ToString();
                            lottery.Add(row["id"].ToString(), Convert.ToDouble(row["total"]));
                        }

                        if (null != lottery)
                        {
                            for (int i = 0; i < StringExtension.toInt(numberTextBox.Text, 0); i++)
                            {
                                var winner = lottery.Draw(true);
                                if (null != winner)
                                    winnerKey.Add(StringExtension.toInt(winner.Key, 0));
                            }

                            if (null != winnerKey)
                            {
                                foreach (var key in winnerKey)
                                {
                                    foreach (DataRow row in ((DataTable)opResult.model).Rows)
                                    {
                                        if (Convert.ToInt32(row["id"]) == key)
                                        {
                                            saveDataLottery(row["id"], row["total"], startDate, endDate);
                                        }
                                    }
                                }
                            }
                        }

                        GetDataLottery(startDate, endDate);
                       
                    }
                    else
                    {
                        MessageBox.Show("ترددی در این تاریخ ثبت نشده است", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resultGrid.DataSource = null;
                    }
                        
                }
                else
                    MessageBox.Show("اطلاعاتی برای قرعه کشی وجود ندارد", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            #endregion
        }

        /// <summary>
        /// Get Data LotteryS
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        private bool GetDataLottery(DateTime startDate, DateTime endDate)
        {
            bool result = false;
            //Get Query
            Common.BLL.Logic.GasStation.Lottery lLottery = new Common.BLL.Logic.GasStation.Lottery(Common.Enum.EDatabase.GasStation);
            CommandResult opResultLottery = lLottery.loadLottery(startDate, endDate);
            if (opResultLottery.status == BaseDAL.Base.EnumCommandStatus.success)
            {
                if (((DataTable)opResultLottery.model).Rows.Count > 0)
                {
                    resultDataTable = opResultLottery.model as DataTable;
                    resultGrid.DataSource = opResultLottery.model;
                    resultGrid.loadHeader(this.GetType().Name);
                    result = true;
                }
                else                
                    result = false;
            }

            return result;

        }

        /// <summary>
        /// Save Data Lottery
        /// </summary>
        /// <param name="id"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        private bool saveDataLottery(object id, object total, DateTime startDate, DateTime endDate)
        {
            bool result = false;
            CommandResult opResult = null;
            Common.BLL.Logic.GasStation.Lottery lLottey = new Common.BLL.Logic.GasStation.Lottery(Common.Enum.EDatabase.GasStation);
            Common.BLL.Entity.GasStation.Lottery lotteryModel = new Common.BLL.Entity.GasStation.Lottery();

            #region Insert
            lotteryModel.startDate = startDate;
            lotteryModel.endDate = endDate;
            lotteryModel.lotteryDate = DateTime.Now;

            lotteryModel.ownerId = Convert.ToInt32(id);
            lotteryModel.total = Convert.ToInt32(total);
            lotteryModel.month = monthComboBox.Text.Trim();
            lotteryModel.insertedById = Common.GlobalData.UserManager.currentUser.id;
            lotteryModel.insertDate = DateTime.Now;

            opResult = lLottey.create(lotteryModel);
            #endregion

            // Create data
            if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
                result = true;
            else
            {
                result = false;
                Logger.logger.log(opResult);
                MessageBox.Show(this, "خطا در ذخیره اطلاعات قرعه کشی وجود دارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        /// <summary>
        /// Print Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintButton_Click(object sender, EventArgs e)
        {
            StiReport mainreport = new StiReport();
            if ((resultDataTable != null) && (resultDataTable.Rows.Count > 0))
            {
                mainreport.RegBusinessObject("lottery", resultDataTable);
                mainreport.Load(Application.StartupPath + "\\Reports\\lottery.mrt");
                mainreport.Compile();
                mainreport["myDate"] = ExtensionsDateTime.toPersianDate(DateTime.Now);
                mainreport.Render();
                mainreport.Show();
            }
            else
                MessageBox.Show("اطلاعاتی موجود نمی باشد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        /// <summary>
        /// Validate Date
        /// </summary>      
        /// <returns></returns>
        private CommandResult validateDate()
        {
            CommandResult result = null;
            string year = yearTextBox.Text.Trim();

            if (year.isNullOrEmptyOrWhiteSpaceOrLen(4))
                result = CommandResult.makeErrorResult("Error", "سال وارد شده نامعتبر می باشد");
            else
                result = CommandResult.makeSuccessResult("Ok");

            return result;
        }

        #endregion

    }
}
