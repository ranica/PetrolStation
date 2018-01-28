using BaseDAL.Model;
using Common.Helper.Logger;
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
	public partial class CarFuelEntryForm  : General.SuperForm
	{

		#region Variables
		/// <summary>
		/// Model
		/// </summary>
		Common.BLL.Entity.GasStation.Base__CarFuel model;

		#endregion

		#region Properties

		#endregion

		#region Methods
		/// <summary>
		/// Constructor	
		/// </summary>
		public CarFuelEntryForm (Common.BLL.Entity.GasStation.Base__CarFuel model = null)
		{
			InitializeComponent ();
			
			//Set Data
			this.model = model;

			Init ();
		}

		/// <summary>
		/// Initilize
		/// </summary>
		private void Init ()
		{
			bindEvents();
			prepare();
		}

		/// <summary>
		/// Prepare
		/// </summary>
		private void prepare ()
		{
			if (null == model)
				model = new Common.BLL.Entity.GasStation.Base__CarFuel();
			else
			{
				//Load model data from db
				Common.BLL.Logic.GasStation.Base__CarFuel lCarFuel	= new Common.BLL.Logic.GasStation.Base__CarFuel(Common.Enum.EDatabase.GasStation );
				CommandResult	opResult	= lCarFuel.read(model);
	
				//TODO: Check errors
				//if(opResult .status ==  BaseDAL.Base.EnumCommandStatus.success)

			}
			//Fill Controls
			BaseBLL.General.FormModelHelper<Common.BLL.Entity.GasStation.Base__CarFuel>.fillControl	(dataGroupBox,model);
		}

		/// <summary>
		/// Bind Events
		/// </summary>
		private void bindEvents ()
		{
			exitButton.Click	+=exitButton_Click;
			saveButton.Click	+=saveButton_Click;

		}
		/// <summary>
		/// Validate data
		/// </summary>
		/// <returns></returns>
		private CommandResult validate()
		{
			CommandResult	result	= null;
			string	fuel	= fuelTextBox.Text.Trim();

			#region Validate

			bool err	= fuel.isNullOrEmptyOrWhiteSpaceOrLen(50);
			if (err)
				result = CommandResult.makeErrorResult("مقدار وارد شده نامعتبر می باشد");
			else 
				result = CommandResult.makeSuccessResult();

			#endregion

			return result;
		}

		/// <summary>
		/// Save Button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void saveButton_Click (object sender, EventArgs e)
		{
			
			CommandResult	opResult	= validate ();

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
			{ 
				// Fill Model
				BaseBLL.General.FormModelHelper<Common.BLL.Entity.GasStation.Base__CarFuel>.fillModel (dataGroupBox, model);

				// Save
				saveRecord ();
			}
			else
				MessageBox.Show (this, opResult.message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		/// <summary>
		/// Insert new Record
		/// </summary>

		private void saveRecord ()
		{
			CommandResult	opResult	= null;
			Common.BLL.Logic.GasStation.Base__CarFuel	lCarFuel	= new Common.BLL.Logic.GasStation.Base__CarFuel (Common.Enum.EDatabase.GasStation);
			

			// Set author data
			if (model.id == 0)
			{
				#region Insert
				model.insertedById = Common.GlobalData.UserManager.currentUser.id;
				model.insertDate = DateTime.Now;

				opResult = lCarFuel.create (model); 
				#endregion
			}
			else
			{
				#region Modify
				model.updatedById = Common.GlobalData.UserManager.currentUser.id;
				model.updateDate = DateTime.Now;

				opResult = lCarFuel.update (model); 
				#endregion
			}

			// Create/Modify data

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				CloseSuccess ();
			else
			{
				Logger.logger.log (opResult);
 				MessageBox.Show (this, "خطا در ذخیره اطلاعات", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void CloseSuccess ()
		{
			DialogResult	= System.Windows.Forms.DialogResult.OK;
			Close ();
		}

		/// <summary>
		/// Exit Button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void exitButton_Click (object sender, EventArgs e)
		{
			DialogResult =  System.Windows.Forms.DialogResult.OK;
			if (MessageBox.Show(this,"آیا از خروج مطمئن می باشید؟","خروج",MessageBoxButtons.OKCancel,MessageBoxIcon.Question )== DialogResult)
				Close();
			
		}
		#endregion
	}
}
