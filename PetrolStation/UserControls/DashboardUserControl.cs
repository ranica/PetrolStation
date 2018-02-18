using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PetrolStation.UserControls
{
    public partial class DashboardUserControl : UserControl
    {
        #region Properties
        public DataTable tableResult
        {
            get;
            set;
        }
        #endregion
        public DashboardUserControl(DataTable tbResult)
        {
            InitializeComponent();
            tableResult = tbResult;

            Init();
        }
        /// <summary>
        /// Initialize
        /// </summary>
        private void Init()
        {
            prepare();
        }

        /// <summary>
        /// Prepare
        /// </summary>
        private void prepare()
        {
            showData();
        }

        /// <summary>
        /// Show Data in Grid
        /// </summary>
        private void showData()
        {
            countTrafficGrid.DataSource = tableResult;
            countTrafficGrid.loadHeader(this.GetType().Name);
        }
    }
}
