using BaseDAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GasStation.Forms.Forms
{
	public partial class ExistenceCustomerForm : General.SuperForm
	{

		#region Variables
		/// <summary>
		/// Model
		/// </summary>
		Common.BLL.Entity.GasStation.Owner	model;
		string nationalcode = null;
		#endregion

		#region Properties

		#endregion

		#region Methods
		/// <summary>
		/// Constructor
		/// </summary>
		public ExistenceCustomerForm (string natioalCode)
		{
			
			InitializeComponent ();
			// Set data
			nationalcode = natioalCode;

			init ();
		}

		/// <summary>
		/// Initilize
		/// </summary>
		private void init ()
		{
			bindEvents ();
			prepare ();
		}

		/// <summary>
		/// Prepare
		/// </summary>
		private void prepare ()
		{
			model 	= new Common.BLL.Entity.GasStation.Owner ()
			{
				nationalCode = nationalcode
			};
			Common.BLL.Logic.GasStation.Owner	lOwner	= new Common.BLL.Logic.GasStation.Owner(Common.Enum.EDatabase.GasStation);
			CommandResult	opResult	= lOwner.read(model, "nationalCode");	
			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
			{
				// Fill Controls
				BaseBLL.General.FormModelHelper<Common.BLL.Entity.GasStation.Owner>.fillControl (ownerDataGroupBox, model);	
				birthdateLabel.Text = Convert.ToDateTime(model.birthdate).ToString("yyyy/MM/dd");
			}		
		}

		/// <summary>
		/// Bind Events
		/// </summary>
		private void bindEvents ()
		{
			getButton.Click	+= getButton_Click;
			
		}

		private void getButton_Click (object sender, EventArgs e)
		{
			if (model.id != 0)
				CustomerForm.existOwner =  model.id;
			Close();
		}

		#endregion
	}
}
