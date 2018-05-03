using BaseDAL.Model;
using Common.Helper.Lottery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PetrolStation.Forms
{
    public partial class testForm : Form
    {

        Common.BLL.Entity.PetrolStation.UHF uhfModel;
        Common.BLL.Logic.PetrolStation.UHF lUHF;
        Common.BLL.Entity.PetrolStation.User serviceUser;
        Common.BLL.Logic.PetrolStation.User lUser;
        public testForm()
        {
            InitializeComponent();
            //fillChart();

            //fillChartByDB();
        }

        private void fillChartByDB()
        {
            Common.BLL.Logic.PetrolStation.Traffic lTraffic =
                                        new Common.BLL.Logic.PetrolStation.Traffic(Common.Enum.EDatabase.PetrolStation);

            //CommandResult opResult = lTraffic.fillChart(DateTime.Now, Common.GlobalData.UserManager.currentUser.id);
            CommandResult opResult = lTraffic.fillChart(DateTime.Now.AddDays(-1), 2);
            DataTable resultData = ExtensionsDateTable.makeWeekDay(opResult.model as DataTable, "_WeekDay", true);
            //chart1.DataSource = resultData;

            Series series = this.chart1.Series.Add("تردد ها");
            series.ChartType = SeriesChartType.RangeColumn;
            series.Color = Color.SteelBlue;
            series.Font = new Font("BYekan", 15.0f, FontStyle.Italic); //changes nothing


            // Add series.
            for (int i = 0; i < resultData.Rows.Count; i++)
            {
                // Add series.

                //Series series = this.chart1.Series.Add(resultData.Rows[i]["dat_WeekDay"].ToString());
                //series.Points.Add(int.Parse(resultData.Rows[i]["count"].ToString()));


                // Add point.
                series.Points.AddXY(resultData.Rows[i]["dat_WeekDay"].ToString(), resultData.Rows[i]["count"]);
            }

            carGrid.DataSource = resultData;
            //chart1.Series["dat_WeekDay"].XValueMember = "dat_WeekDay";
            //chart1.Series["dat_WeekDay"].XValueMember = resultData.Rows[i]["dat_WeekDay"].ToString();
            ////set the member columns of the chart data source used to data bind to the X-values of the series  
            //chart1.Series["count"].YValueMembers = "Count";
            chart1.Titles.Add("نمودار تردد های هفته جاری");

        }

        private void fillChart()
        {
            // Data arrays.
            string[] seriesArray = { "Cats", "Dogs", "Fogs" };
            int[] pointsArray = { 1, 2, 3 };

            // Set palette.
            this.chart1.Palette = ChartColorPalette.SeaGreen;

            // Set title.
            this.chart1.Titles.Add("Pets");

            // Add series.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                // Add series.
                Series series = this.chart1.Series.Add(seriesArray[i]);

                // Add point.
                series.Points.Add(pointsArray[i]);
            }

            //MessageBox.Show(ExtensionsDateTime.getWeekDay(DateTime.Now));
        }

        static Random rand = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            double r = rand.Next(1, 20);

            textBox1.Text = r.ToString();

            //lUser = new Common.BLL.Logic.PetrolStation.User(
            //   Common.Enum.EDatabase.PetrolStation);
            //CommandResult opResult = lUser.getServiceUser();

            //serviceUser = opResult.model as Common.BLL.Entity.PetrolStation.User;
            //MessageBox.Show(serviceUser.name + " " + serviceUser.lastname);


            //#region Get UHF
            //lUHF = new Common.BLL.Logic.PetrolStation.UHF(Common.Enum.EDatabase.PetrolStation);

            //uhfModel = new Common.BLL.Entity.PetrolStation.UHF
            //{
            //    IP = "127.0.0.1"
            //};
            //CommandResult result = lUHF.read(uhfModel, "IP");
            //if ((result.status != BaseDAL.Base.EnumCommandStatus.success) && (uhfModel.id <= 0))
            //{
            //    //writeLog("Error Load Info UHF");
            //}
            //MessageBox.Show(uhfModel.IP + " , " + uhfModel.netStatus + " , " + uhfModel.Port);


            //Common.BLL.Entity.PetrolStation.Owner model = new Common.BLL.Entity.PetrolStation.Owner()
            //{
            //    nationalCode = "4324260869"
            //};
            //Common.BLL.Logic.PetrolStation.Owner lOwner = new Common.BLL.Logic.PetrolStation.Owner(Common.Enum.EDatabase.PetrolStation);
            //CommandResult opResult1 = lOwner.read(model, "nationalCode");

            //if (opResult1.status == BaseDAL.Base.EnumCommandStatus.success)
            //{
            //    MessageBox.Show(model.name);
            //}


            //#endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = new DateTime();
                DateTime endDate = new DateTime();
                List<int> winnerKey = new List<int>();
                Lottery<string> lottery = new Lottery<string>();

                startDate = Convert.ToDateTime("2018-01-01");
                endDate = Convert.ToDateTime("2018-02-17");


                //Check It has not already been lottery this month
                //Get Query
                Common.BLL.Logic.PetrolStation.Traffic lTraffic = new Common.BLL.Logic.PetrolStation.Traffic(Common.Enum.EDatabase.PetrolStation);
                CommandResult opResult = lTraffic.loadCumulative(startDate, endDate);


                #region Cumulative

                if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
                {
                    if (((DataTable)opResult.model).Rows.Count > 0)
                    {
                        DataTable resultData = opResult.model as DataTable;

                        for (int i = 0; i < StringExtension.toInt("5", 0); i++)
                        {
                            int count = Convert.ToInt32(resultData.Rows[resultData.Rows.Count - 1]["total"].ToString());
                            int r = rand.Next(1, count);


                            foreach (DataRow row in ((DataTable)opResult.model).Rows)
                            {

                                if (Convert.ToInt16(row["total"]) >= r)
                                {
                                    if (!lottery.Compare(row["nationalCode"].ToString()))
                                    {
                                        lottery.Add(row["total"].ToString(), row["nationalCode"].ToString());
                                    }
                                }
                            }



                        }

                    }
                }
            }
            catch (Exception ex)
            {

                LoggerExtensions.log(ex);
            }

            #endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fillMultiColumnChart();
            //FillCurveChart();

        }

        
        /// <summary>
        /// Fill Multi Column Chart
        /// </summary>
        private void fillMultiColumnChart()
        {
            Series[] seriesArray = new Series[2];
           
            int countAntenna = 0;
            int[] UHFArray = new int[10];
            DataTable[] dtArray = new DataTable[10];
           
            Common.BLL.Logic.PetrolStation.UHFPermit lUHFPermit =
                                                        new Common.BLL.Logic.PetrolStation.UHFPermit(Common.Enum.EDatabase.PetrolStation);

            DataTable myTable = lUHFPermit.getUHF(Convert.ToInt16("6"));


           if (myTable.Rows.Count > 0)
            {
                countAntenna = myTable.Rows.Count;

                for (int i = 0; i < myTable.Rows.Count; i++)
                {
                    // Add point.
                    UHFArray[i]  = Convert.ToInt16(myTable.Rows[i]["uhfId"]);
                    dtArray[i] =lUHFPermit.DrawChart(UHFArray[i]);
                   
                }
            }
            //carGrid.DataSource = dtArray[0];
            //dataGridView1.DataSource = dtArray[1];

            

            curveChart.Series.Clear();



            for (int k = 0; k < countAntenna; k++)
            {
                seriesArray[k] = this.curveChart.Series.Add("آنتن  " + (k + 1).ToString());
                seriesArray[k].Color = Color.FromArgb(240,k*250, k*200);
            }

           
            for (int i = 0; i < countAntenna; i++)
            {
                seriesArray[i].ChartType = SeriesChartType.RangeColumn;
                seriesArray[i].Font = new Font("BYekan", 15.0f, FontStyle.Italic); //changes nothing
            }
            
           

            for (int i = 0; i < countAntenna; i++)
            {
                // Add series.
                SetChart(dtArray[i], seriesArray[i]);
            }

           
        }

        private void SetChart(DataTable dataTable, Series series)
        {
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                // Add point.
                series.Points.AddXY(dataTable.Rows[i]["dat_WeekDay"].ToString(), dataTable.Rows[i]["count"]);

            }
        }

      

        private void FillCurveChart()
        {
            curveChart.Series.Clear();
            curveChart.Series.Add("Series1");
            curveChart.Series["Series1"].XValueType = ChartValueType.DateTime;
            curveChart.Series["Series1"].Points.AddXY(DateTime.Now, 12.00m);
            curveChart.Series["Series1"].Points.AddXY(DateTime.Now.AddDays(1), 13m);
            curveChart.Series["Series1"].Points.AddXY(DateTime.Now.AddDays(2), 8m);
            curveChart.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            curveChart.Series["Series1"].BorderWidth = 3;
            curveChart.ChartAreas["0"].AxisX.Interval = 1;

            curveChart.Series.Add("Series2");
            curveChart.Series["Series2"].XValueType = ChartValueType.DateTime;
            curveChart.Series["Series2"].Points.AddXY(DateTime.Now, 5.00m);
            curveChart.Series["Series2"].Points.AddXY(DateTime.Now.AddDays(1), 7m);
            curveChart.Series["Series2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            curveChart.Series["Series2"].BorderWidth = 3;
            curveChart.ChartAreas["0"].AxisX.Interval = 1;
        }
    }
}
