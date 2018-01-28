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
	public partial class TrafficUserControl : UserControl
	{
		#region Properties
		public DataTable tableTraffic
		{
			get;
			set;
		}

		#endregion

		public TrafficUserControl (DataTable tbTraffic)
		{
			InitializeComponent ();
			tableTraffic = tbTraffic;
			Init ();
		}
		private void Init ()
		{
			prepare();
		}

		private void prepare ()
		{
			showDataGrid ();
		}

		private void showDataGrid ()
		{
			trafficGrid.DataSource = tableTraffic;
			trafficGrid.loadHeader(this.GetType().Name);
		}
	}
}
