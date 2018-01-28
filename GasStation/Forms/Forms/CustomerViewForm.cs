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
	public partial class CustomerViewForm : General.SuperForm
	{
		#region Variables
		
		#endregion

		#region Properties
		
		#endregion

		#region Methods	
		
		public CustomerViewForm ()
		{
			InitializeComponent ();

			init();
		}

		/// <summary>
		/// Initilize 
		/// </summary>
		private void init ()
		{
			bindEvents();
			prepare();
		}

		/// <summary>
		/// Prepare
		/// </summary>
		private void prepare ()
		{
			reload();
			nationalCodeRadioButton.Checked = true;
		}

		/// <summary>
		/// Reload
		/// </summary>
		private void reload ()
		{			
			Common.BLL.Logic.GasStation.Owner		lOwner = new Common.BLL.Logic.GasStation.Owner (Common.Enum.EDatabase.GasStation);
			CommandResult opResult = lOwner.loadViewOwner();
			resultGrid.DataSource = opResult.model;
			resultGrid.loadHeader(this.GetType().Name);		
		}
		/// <summary>
		/// Bind Events
		/// </summary>
		private void bindEvents ()
		{
			reloadMenu.Click    += ReloadMenu_Click;
			insertMenu.Click	+= InsertMenu_Click;
			deleteMenu.Click	+= DeleteMenu_Click;
			modifyMenu.Click	+= ModifyMenu_Click;
			exitMenu.Click		+= ExitMenu_Click;
			nationalCodeRadioButton.CheckedChanged += NationalCodeRadioButton_CheckedChanged;			
			serachButton.Click	+= SerachButton_Click;			
		}		
		/// <summary>
		/// NationalCode Radio Button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NationalCodeRadioButton_CheckedChanged (object sender, EventArgs e)
		{
			if (nationalCodeRadioButton.Checked)
			{
				nationalCodeMaskedTextBox.Visible = true;
				nationalCodeMaskedTextBox.Focus();
				nationalCodeMaskedTextBox.Clear();
			}
			else 
				nationalCodeMaskedTextBox.Visible = false;
		}

		/// <summary>
		/// National Code KeyDown
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NationalCodeMaskedTextBox_KeyDown (object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (nationalCodeMaskedTextBox.Text.isNullOrEmptyOrWhiteSpaceOrLen(10))
					reloadData();
			}
		}
		/// <summary>
		/// Exit Menu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ExitMenu_Click (object sender, EventArgs e)
		{
			Close();
		}
		/// <summary>
		/// Modify Menu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ModifyMenu_Click (object sender, EventArgs e)
		{
			if (null != resultGrid.CurrentRow)
			{ 
				int	id;

				// Get id
				id	= Convert.ToInt32 (resultGrid.CurrentRow.Cells["idCar"].Value);

				Common.BLL.Entity.GasStation.CarOwner  model	= new Common.BLL.Entity.GasStation.CarOwner ()
				{
					carId = id
				};						

				CustomerForm	form	= new CustomerForm (model);
				if (form.ShowDialog () == System.Windows.Forms.DialogResult.OK)
					reload ();
			}
			else
				MessageBox.Show ("رکوردی انتخاب نشده است", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		/// <summary>
		/// Delete Menu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DeleteMenu_Click (object sender, EventArgs e)
		{
			if ((null != resultGrid.CurrentRow) && 
				(MessageBox.Show (this, "آیا برای حذف اطمینان دارید؟", "حذف رکورد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes))
			{ 
				int	id;

				// Get id
				id	= Convert.ToInt32 (resultGrid.CurrentRow.Cells["id"].Value);

				Common.BLL.Entity.GasStation.CarOwner	model	= new Common.BLL.Entity.GasStation.CarOwner ()
				{
					ownerId	= id
				};

				Common.BLL.Logic.GasStation.CarOwner	lCarOwner	= new Common.BLL.Logic.GasStation.CarOwner (Common.Enum.EDatabase.GasStation);
				CommandResult	opResult	= lCarOwner.read(model, "ownerId");
				
				if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				{
					if (deleteLegalOwner(model.id))
					{
						if (deleteCarOwner(model))
						{
							if (deleteCarTag_Tag(model.carId))
							{
								if (deleteCar_Plate(model.carId))
								{
									if (deleteOwner(model.ownerId))
										reload();
								}
							}
						}
					}		
					
				}
					
			}
			else				
				MessageBox.Show ("رکوردی انتخاب نشده است", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private bool deleteOwner (int ownerId)
		{
			bool result = false;

		
			Common.BLL.Entity.GasStation.Owner		model	= new Common.BLL.Entity.GasStation.Owner ()
			{
				id =  ownerId
			};

			Common.BLL.Logic.GasStation.Owner	lOwner	= new Common.BLL.Logic.GasStation.Owner (Common.Enum.EDatabase.GasStation);
			CommandResult	opResult	= lOwner.delete(model);
			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				result = true;

			return result;
		}

		private bool deleteCar_Plate (int carId)
		{
			bool result = false;

			int id, plateId;
			id = carId;
			Common.BLL.Entity.GasStation.Car		model	= new Common.BLL.Entity.GasStation.Car ()
			{
				id = carId
			};

			Common.BLL.Logic.GasStation.Car 	lCar	= new Common.BLL.Logic.GasStation.Car (Common.Enum.EDatabase.GasStation);
			CommandResult	resultCar	= lCar.read(model,"id");
			if (resultCar.status == BaseDAL.Base.EnumCommandStatus.success)
			{
				plateId = model.plateId;
				CommandResult	opResult	= lCar.delete(model);
				if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				{
					Common.BLL.Entity.GasStation.Plate		modelPlate	= new Common.BLL.Entity.GasStation.Plate ()
					{
						id 	= plateId
					};

					Common.BLL.Logic.GasStation.Plate	lPlate	= new Common.BLL.Logic.GasStation.Plate (Common.Enum.EDatabase.GasStation);
					CommandResult	resultPlate	= lPlate.delete(modelPlate);
					if (resultPlate.status == BaseDAL.Base.EnumCommandStatus.success)
						result = true;				
				}				
			}		

			return result;
		}

		private bool deleteCarTag_Tag (int carId)
		{
			bool result = false;

			int id;
			id = carId;
			Common.BLL.Entity.GasStation.CarTag		model	= new Common.BLL.Entity.GasStation.CarTag ()
			{
				carId	= id
			};

			Common.BLL.Logic.GasStation.CarTag	lCarTag	= new Common.BLL.Logic.GasStation.CarTag (Common.Enum.EDatabase.GasStation);
			CommandResult	resultCarTag	= lCarTag.read(model, "carId");			
			
			if (resultCarTag.status == BaseDAL.Base.EnumCommandStatus.success)
			{
				// Delete CarTag
				int tagId = model.tagId;
				CommandResult	opResult	= lCarTag.delete(model);
				if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				{				
					//Delete Tag from tabel Tarffic
					Common.BLL.Logic.GasStation.Traffic		lTraffic	= new Common.BLL.Logic.GasStation.Traffic (Common.Enum.EDatabase.GasStation);
					Common.BLL.Entity.GasStation.Traffic		modelTraffic	= new Common.BLL.Entity.GasStation.Traffic ()
					{
						 tagId = tagId	
					};
					CommandResult	result1 = lTraffic.deleteTraffic(modelTraffic);			
					
					if (result1.status == BaseDAL.Base.EnumCommandStatus.success)
					{						
						//	// Delete Tag from table Tag
							Common.BLL.Entity.GasStation.Tag		modelTag	= new Common.BLL.Entity.GasStation.Tag ()
							{
								id = tagId	
							};
							Common.BLL.Logic.GasStation.Tag		lTag	= new Common.BLL.Logic.GasStation.Tag (Common.Enum.EDatabase.GasStation);
							CommandResult	result2	= lTag.read(modelTag, "tagId");
							if (result2.status == BaseDAL.Base.EnumCommandStatus.success)
							{
								CommandResult	resultTag	= lTag.delete(modelTag);
								if (resultTag.status == BaseDAL.Base.EnumCommandStatus.success)
									result= true;
							}
					}
					
				}
			}				

			return result;
		}
		

		private bool deleteCarOwner (Common.BLL.Entity.GasStation.CarOwner model)
		{
			bool result = false;			

			Common.BLL.Logic.GasStation.CarOwner	lCarOwner	= new Common.BLL.Logic.GasStation.CarOwner (Common.Enum.EDatabase.GasStation);
			CommandResult	opResult	= lCarOwner.delete(model);
			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				result = true;

			return result;
		}

		/// <summary>
		/// Delete Legal Owner
		/// </summary>
		/// <param name="p"></param>
		/// <returns></returns>
		private bool deleteLegalOwner (int id)
		{
			bool result = false;
			
			Common.BLL.Entity.GasStation.LegalOwner		model	= new Common.BLL.Entity.GasStation.LegalOwner ()
			{
				carOwnerId = id						 
			};

			Common.BLL.Logic.GasStation.LegalOwner	lLegalOwner	= new Common.BLL.Logic.GasStation.LegalOwner (Common.Enum.EDatabase.GasStation);
			CommandResult	resultLegal	= lLegalOwner.read(model, "carOwnerId");
			if (resultLegal.status == BaseDAL.Base.EnumCommandStatus.success)
			{
				CommandResult	opResult	= lLegalOwner.delete(model);
				if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
					result = true;
			}			

			return result;
		}

		/// <summary>
		/// Insert Menu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void InsertMenu_Click (object sender, EventArgs e)
		{
			CustomerForm form = new CustomerForm();
			if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				reload();
		}

		/// <summary>
		/// Reload Menu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ReloadMenu_Click (object sender, EventArgs e)
		{
			reload();
		}
		/// <summary>
		/// Search Button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SerachButton_Click (object sender, EventArgs e)
		{
			reloadData ();
		}

		private void reloadData ()
		{
			Common.BLL.Entity.GasStation.Owner model = new Common.BLL.Entity.GasStation.Owner ()
			{
				nationalCode = nationalCodeMaskedTextBox.Text.Trim ()
			};

			Common.BLL.Logic.GasStation.Owner		lOwner = new Common.BLL.Logic.GasStation.Owner (Common.Enum.EDatabase.GasStation);
			CommandResult opResult = lOwner.loadDataOwner(model);

			//Common.BLL.Logic.GasStation.Owner lOwner = new Common.BLL.Logic.GasStation.Owner (Common.Enum.EDatabase.GasStation);
			//CommandResult opResult = lOwner.read (model, "nationalCode");
			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
			{
				resultGrid.DataSource = opResult.model;
				resultGrid.loadHeader(this.GetType().Name);				
			}
		}

        #endregion
       
    }
}
