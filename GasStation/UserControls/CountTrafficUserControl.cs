using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GasStation.UserControls
{
	public partial class CountTrafficUserControl : UserControl
	{
		#region Properties
		public DataTable tableResult 
		{
			get;
			set;
		}
		#endregion
		public CountTrafficUserControl (DataTable tbResult)
		{
			InitializeComponent ();
			tableResult = tbResult;

			Init();
		}	

		private void Init ()
		{
			prepare();
		}

		private void prepare ()
		{
			showData();
		}

		private void showData ()
		{
			countTrafficGrid.DataSource = tableResult;
			countTrafficGrid.loadHeader(this.GetType().Name);
		}
	}
}
