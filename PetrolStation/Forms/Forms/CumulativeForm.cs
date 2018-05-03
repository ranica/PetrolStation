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

namespace PetrolStation.Forms.Forms
{
    public partial class CumulativeForm : General.SuperForm
    {
        #region Variable

        Common.BLL.Entity.PetrolStation.Base__Month monthModel =
                                                    new Common.BLL.Entity.PetrolStation.Base__Month();
        DataTable resultDataTable;

        static Random rand = new Random();
        DateTime startDate, endDate = new DateTime();
        #endregion

        #region Method
        public CumulativeForm()
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

            monthComboBox.SelectedIndexChanged += MonthComboBox_SelectedIndexChanged;

            monthRadioButton.CheckedChanged += MonthRadioButton_CheckedChanged;
            yearRadioButton.CheckedChanged += YearRadioButton_CheckedChanged;
        }
        /// <summary>
        /// Month ComboBox for data ComboBox Date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void MonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            reloadMaskDate();
        }

        /// <summary>
        /// Checked Year RadioButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Checked Month RadioButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            reloadAntenna();
        }
        /// <summary>
        /// Reload Antenna Name by User Id
        /// </summary>
        private void reloadAntenna()
        {
            //Common.BLL.Logic.PetrolStation.UHFPermit lUHFPermit = new 
            //                            Common.BLL.Logic.PetrolStation.UHFPermit(Common.Enum.EDatabase.PetrolStation);

            //DataTable myTable = lUHFPermit.getUHF(Convert.ToInt16(Common.GlobalData.UserManager.currentUser.id));


            //if (myTable.Rows.Count > 0)
            //{
               
            //    for (int i = 0; i < myTable.Rows.Count; i++)
            //    {
            //        antennaComboBox.

            //    }
            //}
        }

        /// <summary>
        /// Reload Data from ComboBox
        /// </summary>
        private void reloadCombo()
        {
            Common.BLL.Logic.PetrolStation.Base__Month lMonth = new 
                                        Common.BLL.Logic.PetrolStation.Base__Month(Common.Enum.EDatabase.PetrolStation);

            DataTable resultMonth = lMonth.allData("", "", false).model as DataTable;
            monthComboBox.fillByTable(resultMonth, "id", "month");

            reloadMaskDate();
        }

        /// <summary>
        /// Reload Mask Textbox Dates
        /// </summary>
        private void reloadMaskDate()
        {
            BaseBLL.General.FormModelHelper<Common.BLL.Entity.PetrolStation.Base__Month>.fillModel(dataGroupBox, monthModel);
            startDate = ExtensionsDateTime.persianToMiladi(DateTime.Now.toPersianDate().Substring(0, 4) + "/" + monthModel.code + "/1");

            begindateTextBox.Text = DateTime.Now.toPersianDate().Substring(0, 4) +
                                    (monthModel.code.ToString().Length < 2 ? "0" + monthModel.code.ToString() : monthModel.code.ToString()) +
                                    "01";
            endDate = ExtensionsDateTime.getMiladiEndDate(Convert.ToInt32(monthModel.code));
            endDateTextBox.Text = DateTime.Now.toPersianDate().Substring(0, 4) +
                                (monthModel.code.ToString().Length < 2 ? "0" + monthModel.code.ToString() : monthModel.code.ToString()) +
                                ExtensionsDateTime.getMiladiDay(Convert.ToInt32(monthModel.code));
        }


        /// <summary>
        /// Start Lottery
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                int countLottery = 0;
                Lottery<string> lottery = new Lottery<string>();
                //List<int> winnerKey = new List<int>();

                //Get Date
                BaseBLL.General.FormModelHelper<Common.BLL.Entity.PetrolStation.Base__Month>.fillModel(dataGroupBox, monthModel);

                //Validate Date
                if (monthRadioButton.Checked)
                {
                    startDate = ExtensionsDateTime.persianToMiladi(begindateTextBox.Text);
                    endDate = ExtensionsDateTime.persianToMiladi(endDateTextBox.Text);
                    //startDate = ExtensionsDateTime.persianToMiladi(DateTime.Now.toPersianDate().Substring(0, 4) + "/" + monthModel.code + "/1");
                    //endDate = ExtensionsDateTime.getMiladiEndDate(Convert.ToInt32(monthModel.code));
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

                //Check It has not already been lottery this month

                if (!GetDataLottery(startDate, endDate))
                {
                    //Get Query
                    Common.BLL.Logic.PetrolStation.Traffic lTraffic = new Common.BLL.Logic.PetrolStation.Traffic(Common.Enum.EDatabase.PetrolStation);
                    CommandResult opResult = lTraffic.loadCumulative(startDate, endDate);


                    #region Cumulative

                    if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
                    {
                        if (((DataTable)opResult.model).Rows.Count > 0)
                        {
                            DataTable resultData = opResult.model as DataTable;

                            //while (lottery.Count() <= StringExtension.toInt(numberTextBox.Text.Trim(), 0))
                            //{ 

                            for (int i = 0; i < StringExtension.toInt(numberTextBox.Text.Trim(), 0); i++)
                            {
                                int count = Convert.ToInt32(resultData.Rows[resultData.Rows.Count - 1]["total"].ToString());
                                int r = rand.Next(1, count);

                                
                                foreach (DataRow row in ((DataTable)opResult.model).Rows)
                                {
                                    if (Convert.ToInt16(row["total"]) >= r)
                                    {
                                        if (!lottery.Compare(row["nationalCode"].ToString()))
                                        {
                                            lottery.Add(row["countValue"].ToString(), row["nationalCode"].ToString());
                                            if (lottery.Count() > StringExtension.toInt(numberTextBox.Text.Trim(), 0))
                                            {
                                                GetDataLottery(startDate, endDate);
                                                break;
                                            }
                                            saveDataLottery(row["id"], row["countValue"], startDate, endDate);
                                        }
                                    }
                                }//end foreach
                               

                            }// end for


                        }
                        else
                            MessageBox.Show("اطلاعاتی برای قرعه کشی وجود ندارد", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("ترددی در این تاریخ ثبت نشده است", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resultGrid.DataSource = null;
                    }
                    #endregion

                }


            }
            catch (Exception ex)
            {
                LoggerExtensions.log(ex);
            }


            #region Get Query for Lottery			

            /*if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
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
            }*/

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
            try
            {
                bool result = false;
                //Get Query
                Common.BLL.Logic.PetrolStation.Lottery lLottery = new Common.BLL.Logic.PetrolStation.Lottery(Common.Enum.EDatabase.PetrolStation);
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
            catch (Exception ex)
            {

                LoggerExtensions.log(ex);
                return false;
            }

        }

        /// <summary>
        /// Save Data Lottery
        /// </summary>
        /// <param name="id"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        private bool saveDataLottery(object id, object total, DateTime startDate, DateTime endDate)
        {
            try
            {
                bool result = false;
                CommandResult opResult = null;
                Common.BLL.Logic.PetrolStation.Lottery lLottey = new Common.BLL.Logic.PetrolStation.Lottery(Common.Enum.EDatabase.PetrolStation);
                Common.BLL.Entity.PetrolStation.Lottery lotteryModel = new Common.BLL.Entity.PetrolStation.Lottery();

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
            catch (Exception ex)
            {

                LoggerExtensions.log(ex);
                return false;
            }

        }

        /// <summary>
        /// Print Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintButton_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {

                LoggerExtensions.log(ex);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString());
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
