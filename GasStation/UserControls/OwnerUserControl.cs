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
	public partial class OwnerUserControl : UserControl
	{
		#region Properties
		public object owner
		{ 
			get;
			set;
		}

		#endregion
		public OwnerUserControl (object OwnerData)
		{
			InitializeComponent ();
			owner = OwnerData;
			Init();
		}

		private void Init ()
		{
			prepar();
		}

		private void prepar ()
		{
			showDataGrid();
		}

		private void showDataGrid ()
		{
			ownerGrid.DataSource = owner;
			ownerGrid.loadHeader(this.GetType().Name);
		}
	}
}
