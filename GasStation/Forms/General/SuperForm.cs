using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GasStation.Forms.General
{
	public partial class SuperForm : System.Windows.Forms.Form
	{
		public SuperForm ()
		{
			InitializeComponent ();

			#region Initialize
			CultureInfo TypeOfLanguage = CultureInfo.CreateSpecificCulture ("fa-IR");
			System.Threading.Thread.CurrentThread.CurrentCulture = TypeOfLanguage;
			InputLanguage l = InputLanguage.FromCulture (TypeOfLanguage);
			InputLanguage.CurrentInputLanguage = l;

			//SetStyle (ControlStyles.OptimizedDoubleBuffer, true);
			//DoubleBuffered	= true;
			#endregion
		}

		///// <summary>
		///// Create params
		///// </summary>
		//protected override CreateParams CreateParams
		//{
		//	get
		//	{
		//		CreateParams cp = base.CreateParams;
		//		cp.ExStyle |= 0x02000000;
		//		return cp;
		//	}
		//}
	}
}
