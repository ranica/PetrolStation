using BaseDAL.Model;
using Common.Enum;
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
	public partial class CustomerSearchForm : General.SuperForm
	{
		#region Variables
		Common.BLL.Entity.GasStation.Plate			plateModel = new Common.BLL.Entity.GasStation.Plate ();
		#endregion

		#region Method
		public CustomerSearchForm ()
		{
			InitializeComponent ();

			Init();
		}
		/// <summary>
		/// Initializer
		/// </summary>
		private void Init ()
		{
			bindEvents();
			prepare();
		}
		/// <summary>
		/// Bind Events
		/// </summary>
		private void bindEvents ()
		{
			plateTypeComboBox.SelectedIndexChanged	+= PlateTypeComboBox_SelectedIndexChanged;
			plateRadioButton.CheckedChanged			+= PlateRadioButton_CheckedChanged;
			nationalCodeRadioButton.CheckedChanged	+= NationalCodeRadioButton_CheckedChanged;
			serachButton.Click						+= SerachButton_Click;
		}

		/// <summary>
		/// Prepare
		/// </summary>
		private void prepare ()
		{
			reloadCombo ();
		}

		private void reloadCombo ()
		{
			//Plate type 
			Common.BLL.Logic.GasStation.Base__PlateType lPlateType = new Common.BLL.Logic.GasStation.Base__PlateType (Common.Enum.EDatabase.GasStation);
			DataTable resultPlateType = lPlateType.allData ("", "", false).model as DataTable;
			plateTypeComboBox.fillByTable (resultPlateType, "id", "type");
		}
		private void NationalCodeRadioButton_CheckedChanged (object sender, EventArgs e)
		{
			if (nationalCodeRadioButton.Checked)
			{
				ownerTabPage.Controls.Clear();
				carTabPage.Controls.Clear();
				trafficTabPage.Controls.Clear();
				nationalCodeMaskedTextBox.Enabled = true;
				nationalCodeMaskedTextBox.Focus();
				nationalCodeMaskedTextBox.Clear();
			}
			else
			{
				nationalCodeMaskedTextBox.Enabled = true;
				nationalCodeMaskedTextBox.Clear();
			}
		}

		private void PlateRadioButton_CheckedChanged (object sender, EventArgs e)
		{
			if (plateRadioButton.Checked)		
			{
				ownerTabPage.Controls.Clear();
				carTabPage.Controls.Clear();
				trafficTabPage.Controls.Clear();
				plateDataGroupBox.Visible = true;
			}
				
			else 
				plateDataGroupBox.Visible = false;
		}		
		private void PlateTypeComboBox_SelectedIndexChanged (object sender, EventArgs e)
		{
			int palteType = (int)plateTypeComboBox.SelectedValue;
			SelectPlateType (palteType);
		}

		private void SelectPlateType (int type)
		{
			switch (type)
			{
				case ((int)enumPlateType.Personal):
					updatePlate (Color.White, Color.Black);
					break;
				case ((int)enumPlateType.Taxi):
					updatePlate (Color.Yellow, Color.Black, "ت");
					break;
				case ((int)enumPlateType.Polity):
					updatePlate (Color.Red, Color.White, "الف");
					break;
				case ((int)enumPlateType.Malulin):
					{
						mainPlatePanel.Visible = false;
						motorPlatePanel.Visible = false;
						malulinPlatePanel.Visible = true;
						malulinPlatePanel.Location = new Point (mainPlatePanel.Location.X, mainPlatePanel.Location.Y);

					} break;
				case ((int)enumPlateType.Motor): // موتور سیکلت
					{
						mainPlatePanel.Visible = false;
						malulinPlatePanel.Visible = false;
						motorPlatePanel.Visible = true;
						motorPlatePanel.Location = new Point (mainPlatePanel.Location.X, mainPlatePanel.Location.Y);
					}
					break;

				default:
					break;
			}
		}

		/// <summary>
		/// Upadte Panel Plate
		/// </summary>
		/// <param name="backColorPart"></param>
		/// <param name="foreColorPart"></param>
		/// <param name="character"></param>
		private void updatePlate (Color backColorPart, Color foreColorPart, string character = null)
		{
			mainPlatePanel.Visible		= true;
			malulinPlatePanel.Visible	= false;
			motorPlatePanel.Visible		= false;
			part1MainTextBox.BackColor	= 
			part2MainTextBox.BackColor	= backColorPart;
			part1MainTextBox.ForeColor	= 
			part2MainTextBox.ForeColor	= foreColorPart;		
		}		

		private void SerachButton_Click (object sender, EventArgs e)
		{
			CommandResult	opResult	= null;
			var checkedButton = dataGroupBox.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);

			opResult	= validate (checkedButton);
			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
			{
				searchData(checkedButton);
			}		
			else
				MessageBox.Show (opResult.model.ToString (), "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void searchData (RadioButton checkedButton)
		{
			string nationalcode = string.Empty;
			string plate = string.Empty;

			switch (checkedButton.Name)
			{
				case "nationalCodeRadioButton":
					{
						nationalcode = nationalCodeMaskedTextBox.Text.Trim ();
						reloadOwnerByNationalcode(nationalcode);
						reloadCarByNationalcode(nationalcode);
						reloadTrafficByNationalcode(nationalcode);
					}
					
					 break;
				case "plateRadioButton":
					 {
						 BaseBLL.General.FormModelHelper<Common.BLL.Entity.GasStation.Plate>.fillModel (plateDataGroupBox, plateModel);
						 switch (plateModel.plateTypeId)
							{
								case ((int)enumPlateType.Personal) :
								case ((int)enumPlateType.Taxi) :
								case ((int)enumPlateType.Polity) :
									plate = part1MainTextBox.Text + "_" + characterDomainUpDown.Text + "_" + part2MainTextBox.Text + "_" + code1Numeric.Text;
									break;
								case ((int)enumPlateType.Malulin):
									plate = part1MalulinTextBox.Text + "_" + part2MaluinTextBox.Text + "_" + code2Numeric.Text;
									break;
								case ((int)enumPlateType.Motor):
									plate = part1MotorTextBox.Text + "_" + part2MotorTextBox.Text;
									break;
								default:
									break;
							}


						 reloadOwnerByPlate(plate);
						 reloadCarByPlate(plate);
						 reloadTrafficByPlate(plate);

					 }					
					break;
			}
		}		

		private void reloadOwnerByNationalcode (string natioanlcode)
		{
			Common.BLL.Entity.GasStation.Owner model = new Common.BLL.Entity.GasStation.Owner ()
			{
				nationalCode = natioanlcode
			};
			Common.BLL.Logic.GasStation.Owner lOwner = new Common.BLL.Logic.GasStation.Owner (Common.Enum.EDatabase.GasStation);
			CommandResult opResult = lOwner.read (model, "nationalCode");
			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
			{
				UserControls.OwnerUserControl owner = new UserControls.OwnerUserControl (opResult.model);
                ownerTabPage.Controls.Clear();
                ownerTabPage.Controls.Add(owner);	
			}
		}
		private void reloadCarByNationalcode (string nationalcode)
		{
			Common.BLL.Logic.GasStation.Car			lCar = new Common.BLL.Logic.GasStation.Car (Common.Enum.EDatabase.GasStation);
			CommandResult opResult = lCar.searchCar(nationalcode);		
			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
			{
				DataTable 	result			= opResult.model as DataTable;
				UserControls.CarUserControl  car = new UserControls.CarUserControl (result);
                carTabPage.Controls.Clear();
                carTabPage.Controls.Add(car);
			}
		}

		private void reloadTrafficByNationalcode (string nationalcode)
		{
			Common.BLL.Logic.GasStation.Traffic			lTraffic  = new Common.BLL.Logic.GasStation.Traffic (Common.Enum.EDatabase.GasStation);
			CommandResult opResult = lTraffic.searchTraffic(nationalcode);		
			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
			{
				DataTable 	result			= ExtensionsDateTable.makePersianDate (opResult.model as DataTable,"_Shamsi",true);
				UserControls.TrafficUserControl  car = new UserControls.TrafficUserControl (result);
                trafficTabPage.Controls.Clear();
                trafficTabPage.Controls.Add(car);
			}
		}
				
		private void reloadOwnerByPlate (string plate)
		{
			Common.BLL.Logic.GasStation.Owner			lOwner  = new Common.BLL.Logic.GasStation.Owner(Common.Enum.EDatabase.GasStation);
			CommandResult opResult = lOwner.searchOwnerByPlate(plate);		
			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
			{
				DataTable 	result			= opResult.model as DataTable;
				UserControls.OwnerUserControl  owner = new UserControls.OwnerUserControl (result);
                ownerTabPage.Controls.Clear();
				ownerTabPage.Controls.Add(owner);
			}
		}
		private void reloadCarByPlate (string plate)
		{
			Common.BLL.Logic.GasStation.Car			lCar = new Common.BLL.Logic.GasStation.Car (Common.Enum.EDatabase.GasStation);
			CommandResult opResult = lCar.searchCarByPlate(plate);		
			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
			{
				DataTable 	result			= opResult.model as DataTable;
				UserControls.CarUserControl  car = new UserControls.CarUserControl (result);
                carTabPage.Controls.Clear();
				carTabPage.Controls.Add(car);
			}
		}

		private void reloadTrafficByPlate (string plate)
		{
			Common.BLL.Logic.GasStation.Traffic			lTraffic  = new Common.BLL.Logic.GasStation.Traffic (Common.Enum.EDatabase.GasStation);
			CommandResult opResult = lTraffic.searchTrafficByPlate(plate);		
			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
			{
				DataTable 	result			= ExtensionsDateTable.makePersianDate (opResult.model as DataTable, "_Shamsi", true);
				
				UserControls.TrafficUserControl  car = new UserControls.TrafficUserControl (result);
                trafficTabPage.Controls.Clear();
                trafficTabPage.Controls.Add(car);
			}
		}

		private CommandResult validate (RadioButton checkedButton)
		{
			CommandResult result	= null;
			switch (checkedButton.Name)
			{
				case "nationalCodeRadioButton":
					result = validateNationalCode(); break;
				case "plateRadioButton":
					result = validatePlateData();	break;
			}

			return result;
		}

		private CommandResult validateNationalCode()
		{
			CommandResult result;
			string natioal = nationalCodeMaskedTextBox.Text.Trim();
			if (natioal.isNullOrEmptyOrWhiteSpaceOrLen(10))
				result	= CommandResult.makeErrorResult ("ERROR","کد ملی وارد شده نامعتبر است");
			else 
				result = CommandResult.makeSuccessResult("OK");

			return result;
		}
		/// <summary>
		/// Validate Plate data
		/// </summary>
		/// <returns></returns>
		private CommandResult validatePlateData ()
		{
			CommandResult	result;
			
			List<string>	err			= new List<string> ();
			string		part1Main		= part1MainTextBox.Text.Trim();
			string		part2Main		= part2MainTextBox.Text.Trim();
			string		code1			= code1Numeric.Text.Trim();
			string		character		= characterDomainUpDown.Text.Trim();
			string		part1Malulin	= part1MalulinTextBox.Text.Trim();
			string		part2Maluin		= part2MaluinTextBox.Text.Trim();
			string		code2			= code2Numeric.Text.Trim();
			string		part1Motor		= part1MotorTextBox.Text.Trim();
			string		part2Motor		= part2MotorTextBox.Text.Trim();

			#region Validate
			switch ((int)plateTypeComboBox.SelectedValue)
			{
				case ((int)enumPlateType.Personal) :
				case ((int)enumPlateType.Taxi) :
				case ((int)enumPlateType.Polity) : 
					{
						if (part1Main.isNullOrEmptyOrWhiteSpaceOrLen(2))
							err.Add("بخش اول پلاک وارد شده نامعتبر می باشد");
						if (part2Main.isNullOrEmptyOrWhiteSpaceOrLen(3))
							err.Add("بخش دوم پلاک وارد شده نامعتبر می باشد");
						if (code1.isNullOrEmptyOrWhiteSpaceOrLen(2))
							err.Add("کد شهر پلاک وارد شده نامعتبر می باشد");
						else if (null == getNameCity(code1))
							err.Add("کد شهر پلاک وارد شده نامعتبر می باشد");
						if (character.isNullOrEmptyOrWhiteSpaceOrLen(3))
							err.Add("حرف وارد شده نامعتبر است");
					}
					break;								
						
				case ((int)enumPlateType.Malulin) : 
					{		
						if (part1Malulin.isNullOrEmptyOrWhiteSpaceOrLen(2))
							err.Add("بخش اول پلاک وارد شده نامعتبر می باشد");
						if (part2Maluin.isNullOrEmptyOrWhiteSpaceOrLen(3))
							err.Add("بخش دوم پلاک وارد شده نامعتبر می باشد");
						if (code2.isNullOrEmptyOrWhiteSpaceOrLen(2))
							err.Add("کد شهر پلاک وارد شده نامعتبر می باشد");
						else if (null == getNameCity(code2))
							err.Add("کد شهر پلاک وارد شده نامعتبر می باشد");						

					}break;
				case ((int)enumPlateType.Motor) : // موتور سیکلت
					{
						if (part1Motor.isNullOrEmptyOrWhiteSpaceOrLen(6))
							err.Add("بخش اول پلاک وارد شده نامعتبر می باشد");
						if (part2Motor.isNullOrEmptyOrWhiteSpaceOrLen(6))
							err.Add("بخش دوم پلاک وارد شده نامعتبر می باشد");	
					}
					break;
				
				default:
					break;
			}			
			#endregion

			// Check for errors
			if (err.Count > 0)
				result	= CommandResult.makeErrorResult ("ERROR", String.Join ("\r\n", err.ToArray ()));
			else
				result	= CommandResult.makeSuccessResult ("OK");

			return result;
		}				
		/// <summary>
		/// Get Name City and Get cityId
		/// </summary>
		/// <param name="code"></param>
		/// <returns></returns>
		private string getNameCity(string code)
		{
			string result = null;
			Common.BLL.Logic.GasStation.Base__PlateCity		lPlateCity		= new Common.BLL.Logic.GasStation.Base__PlateCity (Common.Enum.EDatabase.GasStation);
			DataTable	resultPlateCity		= lPlateCity.allData("","", false).model as DataTable;
			
			var resultItem = (from myRow in resultPlateCity.AsEnumerable()
							where myRow.Field<string>("code") == code
							select myRow).FirstOrDefault();
			if (null != resultItem)
			{
				plateModel.plateCityId = (int)resultItem.ItemArray[0];
				result = resultItem.ItemArray[3].ToString();
			}			

			return  result;		
		}		
		#endregion
	}
}
