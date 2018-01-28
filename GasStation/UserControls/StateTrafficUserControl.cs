using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BaseDAL.Model;

namespace GasStation.UserControls
{
	public partial class StateTrafficUserControl : UserControl
	{
		#region Properties

		public DataTable tableResult 
		{
			get;
			set;
		}

        bool turn = false;

        #endregion

        //public StateTrafficUserControl ()
        public StateTrafficUserControl(DataTable tbResult)
        {
			InitializeComponent ();
            tableResult = tbResult;
            Init();
		}    
               

        /// <summary>
        /// Initializer
        /// </summary>
        private void Init ()
		{
			prepare();
            //bindEvent();
		}       
        /// <summary>
        /// Prepare
        /// </summary>

        private void prepare ()
		{

            stateTrafficGrid.DataSource = tableResult;
            stateTrafficGrid.loadHeader(this.GetType().Name);


            //pageIndexComboBox.SelectedIndex = 0;
            ////pageSizeComboBox.SelectedIndex = 0;

            //LoadFun();		

            //updateUi();
        }
        /// <summary>
        /// Bind Event
        /// </summary>
        private void bindEvent()
        {
            //previousButton.Click += PreviousButton_Click;
            //nextButton.Click += NextButton_Click;
            //pageIndexComboBox.TextChanged += PageIndexComboBox_TextChanged;
            //pageIndexComboBox.SelectedIndexChanged += PageIndexComboBox_SelectedIndexChanged;
            //pageSizeComboBox.SelectedIndexChanged += PageSizeComboBox_SelectedIndexChanged;
        }
        /// <summary>
        /// Page Index ComboBox - Text Changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void PageIndexComboBox_TextChanged(object sender, EventArgs e)
        {
            //if (pageIndexComboBox.Items.Count == pageIndexComboBox.SelectedIndex)
            //{
            //}
            //else
               // LoadFun();

        }

        /// <summary>
        /// Page Index ComboBox - Selected Index Change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PageIndexComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           // LoadFun();
        }

        private void PageSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadFun();
            //pageIndexComboBox.SelectedIndex = 0;
            //pageSizeComboBox.SelectedIndex = 0;
        }
        private void updateUi()
        {
            //int page = Convert.ToInt16(pageIndexComboBox.Text);
            //int count = pageIndexComboBox.Items.Count;

            //previousButton.Visible = (page > 1);
            //nextButton.Visible = (page < count);

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            int page = 1;

            // Get page
            //page = Convert.ToInt16(pageIndexComboBox.Text);
            nextStep(page);

        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            int page = 1;
            //page = Convert.ToInt16(pageIndexComboBox.Text);
            // Get page
            previousePage(page);
        }

        private void nextStep(int page)
        {
            //if (page == pageIndexComboBox.Items.Count - 1)
            //{
            //    pageIndexComboBox.SelectedIndex = page;
            //    updateUi();
            //}
            //else if (++page < pageIndexComboBox.Items.Count)
            //{
            //    pageIndexComboBox.SelectedIndex = page - 1;
            //    updateUi();
            //}
        }

        private void previousePage(int page)
        {
            //if (--page > -1)
            //{
            //    pageIndexComboBox.SelectedIndex = page - 1;
            //    updateUi();
            //}            
        }       

       /* private void LoadFun()
        {
            Common.BLL.Logic.GasStation.Traffic lTraffic = new Common.BLL.Logic.GasStation.Traffic(Common.Enum.EDatabase.GasStation);
            int PI = Convert.ToInt32(pageIndexComboBox.Text);
            //int PS = Convert.ToInt32(pageSizeComboBox.Text);
            int PS = 10;
            CommandResult opResult = lTraffic.loadPaginate(PI, PS);
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

            stateTrafficGrid.DataSource = resultData;
            stateTrafficGrid.loadHeader(this.GetType().Name);
        }           
        */
    }
}
