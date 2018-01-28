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
	public partial class PlateCityEntryForm	: General.SuperForm
	{
		#region Variables
		/// <summary>
		/// Model
		/// </summary>
		Common.BLL.Entity.GasStation.Base__PlateCity	model;
		#endregion

		#region Properties

		#endregion

		#region Methods
		/// <summary>
		/// Constructor
		/// </summary>
		public PlateCityEntryForm (Common.BLL.Entity.GasStation.Base__PlateCity model = null)
		{
			InitializeComponent ();

			// Set data
			this.model	= model;

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
			if (null == model)
				model	= new Common.BLL.Entity.GasStation.Base__PlateCity ();
			else
			{
				// Load model data from db
				Common.BLL.Logic.GasStation.Base__PlateCity	lPlateCity	= new Common.BLL.Logic.GasStation.Base__PlateCity(Common.Enum.EDatabase.GasStation);
				CommandResult	opResult	= lPlateCity.read (model);

				///TODO: CHECK ERRORS
				//if (opResult.status ==  BaseDAL.Base.EnumCommandStatus.success)					
					//reload ();
			}

			// Fill Controls
			BaseBLL.General.FormModelHelper<Common.BLL.Entity.GasStation.Base__PlateCity>.fillControl (dataGroupBox, model);
		}

		/// <summary>
		/// Bind Events
		/// </summary>
		private void bindEvents ()
		{
			exitButton.Click	+= exitButton_Click;
			saveButton.Click	+= saveButton_Click;
		}

		/// <summary>
		/// Save Button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void saveButton_Click (object sender, EventArgs e)
		{
			//String s = "";

			CommandResult	opResult	= validate ();

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
			{ 
				// Fill Model
				BaseBLL.General.FormModelHelper<Common.BLL.Entity.GasStation.Base__PlateCity>.fillModel (dataGroupBox, model);

				// Save
				saveRecord ();
			}
			else
				MessageBox.Show (this, opResult.message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		/// <summary>
		/// Insert new record
		/// </summary>
		private void saveRecord ()
		{
			CommandResult	opResult	= null;
			Common.BLL.Logic.GasStation.Base__PlateCity	lPlateCity	= new Common.BLL.Logic.GasStation.Base__PlateCity (Common.Enum.EDatabase.GasStation);
			

			// Set author data
			if (model.id == 0)
			{
				#region Insert
				model.insertedById	= Common.GlobalData.UserManager.currentUser.id;
				model.insertDate	= DateTime.Now;

				opResult = lPlateCity.create (model); 
				#endregion
			}
			else
			{
				#region Modify
				model.updatedById = Common.GlobalData.UserManager.currentUser.id;
				model.updateDate = DateTime.Now;

				opResult = lPlateCity.update (model); 
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

		/// <summary>
		/// Validate data
		/// </summary>
		/// <returns></returns>
		private CommandResult validate ()
		{
			CommandResult result	= null;
			List<string>	err			= new List<string> ();
			string	city	= cityTextBox.Text.Trim ();
			string	code	= codeTextBox.Text.Trim ();

			#region Validate
			 if (city.isNullOrEmptyOrWhiteSpaceOrLen (50))
				 err.Add("شهر وارد شده نامعتبر می باشد");
			if (code.isNullOrEmptyOrWhiteSpaceOrLen(2))
				err.Add("کد وارد شده نامعتبر است");

			if (err.Count > 0)
				result = CommandResult.makeErrorResult("ERROR", String.Join ("\r\n", err.ToArray ()));
			else
				result = CommandResult.makeSuccessResult (); 
			#endregion

			return result;
		}

		/// <summary>
		/// Exit Button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void exitButton_Click (object sender, EventArgs e)
		{
			DialogResult	= System.Windows.Forms.DialogResult.Cancel;
			Close ();
		} 

		/// <summary>
		/// Close Success
		/// </summary>
		private void CloseSuccess ()
		{
			DialogResult	= System.Windows.Forms.DialogResult.OK;
			Close ();
		}
		#endregion
	}
}
