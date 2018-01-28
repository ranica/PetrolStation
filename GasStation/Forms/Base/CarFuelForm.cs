using BaseDAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GasStation.Forms.Base
{
	public partial class CarFuelForm : General.SuperForm
	{
		#region Variables

		#endregion

		#region Properties

		#endregion

		#region Methods
		/// <summary>
		/// Constructor
		/// </summary>
		public CarFuelForm ()
		{
			InitializeComponent ();
			Init ();
		}
		/// <summary>
		/// Initilize
		/// </summary>
		private void Init ()
		{
			bindEvents ();
			prepare ();
		}
		/// <summary>
		/// Prepare
		/// </summary>
		private void prepare ()
		{
			reload();
		}
		/// <summary>
		/// Bind Events
		/// </summary>
		private void bindEvents ()
		{
			reloadMenu.Click	+= reloadMenu_Click;
			insertMenu.Click	+= insertMenu_Click;
			modifyMenu.Click	+= modifyMenu_Click;
			deleteMenu.Click	+= deleteMenu_Click;
			exitMenu.Click		+= exitMenu_Click;
		}

		/// <summary>
		/// Exit Menu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void exitMenu_Click (object sender, EventArgs e)
		{
			Close ();
		}

		/// <summary>
		/// Delete Menu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void deleteMenu_Click (object sender, EventArgs e)
		{
			if ((null != resultGrid.CurrentRow) && 
				(MessageBox.Show (this, "آیا برای حذف اطمینان دارید؟", "حذف رکورد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes))
			{ 
				int	id;

				// Get id
				id	= Convert.ToInt32 (resultGrid.CurrentRow.Cells["id"].Value);

				Common.BLL.Entity.GasStation.Base__CarFuel	model	= new Common.BLL.Entity.GasStation.Base__CarFuel()
				{
					id	= id
				};

				Common.BLL.Logic.GasStation.Base__CarFuel	lCarFuel	= new Common.BLL.Logic.GasStation.Base__CarFuel (Common.Enum.EDatabase.GasStation);
				CommandResult	opResult	= lCarFuel.delete (model);
				
				if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
					reload ();
			}
			else

				MessageBox.Show ("رکوردی انتخاب نشده است", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		/// <summary>
		/// Modify Menu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void modifyMenu_Click (object sender, EventArgs e)
		{
			if (null != resultGrid.CurrentRow)
			{ 
				int	id;

				// Get id
				id	= Convert.ToInt32 (resultGrid.CurrentRow.Cells["id"].Value);

				Common.BLL.Entity.GasStation.Base__CarFuel	model	= new Common.BLL.Entity.GasStation.Base__CarFuel ()
				{
					id	= id
				};

				CarFuelEntryForm	form	= new CarFuelEntryForm (model);
				if (form.ShowDialog () == System.Windows.Forms.DialogResult.OK)
					reload ();
			}
			else
				MessageBox.Show (this, "رکوردی انتخاب نشده است", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				
		}

		/// <summary>
		/// Insert Menu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void insertMenu_Click (object sender, EventArgs e)
		{
			CarFuelEntryForm  form	= new CarFuelEntryForm ();		 

			if (form.ShowDialog () == System.Windows.Forms.DialogResult.OK)
				reload ();    

		}

		/// <summary>
		/// Reload Menu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void reloadMenu_Click (object sender, EventArgs e)
		{
			reload();
		}			

		

			/// <summary>
		/// Reload data
		/// </summary>
		void reload ()
		{
			Common.BLL.Logic.GasStation.Base__CarFuel	lCarFuel	= new Common.BLL.Logic.GasStation.Base__CarFuel (Common.Enum.EDatabase.GasStation);

			CommandResult opResult	= lCarFuel.allData ("", "", false);
			resultGrid.DataSource	= opResult.model;		
			resultGrid.loadHeader (this.GetType ().Name);
		}
			
		#endregion
	}
}
