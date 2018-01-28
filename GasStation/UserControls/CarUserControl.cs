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
	public partial class CarUserControl : UserControl
	{
		#region Properties

		public DataTable tableCar
		{ 
			get;
			set; 
		}

		#endregion
		public CarUserControl (DataTable tbCar)
		{
			InitializeComponent ();
			tableCar = tbCar;

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
			carGrid.DataSource = tableCar;
			carGrid.loadHeader(this.GetType().Name);
		}
	}
}
