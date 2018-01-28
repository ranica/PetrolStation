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

namespace PetrolStation.Forms.Forms
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
			Common.BLL.Logic.PetrolStation.Owner		lOwner = new Common.BLL.Logic.PetrolStation.Owner (Common.Enum.EDatabase.PetrolStation);
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

				Common.BLL.Entity.PetrolStation.CarOwner  model	= new Common.BLL.Entity.PetrolStation.CarOwner ()
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

				Common.BLL.Entity.PetrolStation.CarOwner	model	= new Common.BLL.Entity.PetrolStation.CarOwner ()
				{
					ownerId	= id
				};

				Common.BLL.Logic.PetrolStation.CarOwner	lCarOwner	= new Common.BLL.Logic.PetrolStation.CarOwner (Common.Enum.EDatabase.PetrolStation);
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

		
			Common.BLL.Entity.PetrolStation.Owner		model	= new Common.BLL.Entity.PetrolStation.Owner ()
			{
				id =  ownerId
			};

			Common.BLL.Logic.PetrolStation.Owner	lOwner	= new Common.BLL.Logic.PetrolStation.Owner (Common.Enum.EDatabase.PetrolStation);
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
			Common.BLL.Entity.PetrolStation.Car		model	= new Common.BLL.Entity.PetrolStation.Car ()
			{
				id = carId
			};

			Common.BLL.Logic.PetrolStation.Car 	lCar	= new Common.BLL.Logic.PetrolStation.Car (Common.Enum.EDatabase.PetrolStation);
			CommandResult	resultCar	= lCar.read(model,"id");
			if (resultCar.status == BaseDAL.Base.EnumCommandStatus.success)
			{
				plateId = model.plateId;
				CommandResult	opResult	= lCar.delete(model);
				if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				{
					Common.BLL.Entity.PetrolStation.Plate		modelPlate	= new Common.BLL.Entity.PetrolStation.Plate ()
					{
						id 	= plateId
					};

					Common.BLL.Logic.PetrolStation.Plate	lPlate	= new Common.BLL.Logic.PetrolStation.Plate (Common.Enum.EDatabase.PetrolStation);
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
			Common.BLL.Entity.PetrolStation.CarTag		model	= new Common.BLL.Entity.PetrolStation.CarTag ()
			{
				carId	= id
			};

			Common.BLL.Logic.PetrolStation.CarTag	lCarTag	= new Common.BLL.Logic.PetrolStation.CarTag (Common.Enum.EDatabase.PetrolStation);
			CommandResult	resultCarTag	= lCarTag.read(model, "carId");			
			
			if (resultCarTag.status == BaseDAL.Base.EnumCommandStatus.success)
			{
				// Delete CarTag
				int tagId = model.tagId;
				CommandResult	opResult	= lCarTag.delete(model);
				if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				{				
					//Delete Tag from tabel Tarffic
					Common.BLL.Logic.PetrolStation.Traffic		lTraffic	= new Common.BLL.Logic.PetrolStation.Traffic (Common.Enum.EDatabase.PetrolStation);
					Common.BLL.Entity.PetrolStation.Traffic		modelTraffic	= new Common.BLL.Entity.PetrolStation.Traffic ()
					{
						 tagId = tagId	
					};
					CommandResult	result1 = lTraffic.deleteTraffic(modelTraffic);			
					
					if (result1.status == BaseDAL.Base.EnumCommandStatus.success)
					{						
						//	// Delete Tag from table Tag
							Common.BLL.Entity.PetrolStation.Tag		modelTag	= new Common.BLL.Entity.PetrolStation.Tag ()
							{
								id = tagId	
							};
							Common.BLL.Logic.PetrolStation.Tag		lTag	= new Common.BLL.Logic.PetrolStation.Tag (Common.Enum.EDatabase.PetrolStation);
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
		

		private bool deleteCarOwner (Common.BLL.Entity.PetrolStation.CarOwner model)
		{
			bool result = false;			

			Common.BLL.Logic.PetrolStation.CarOwner	lCarOwner	= new Common.BLL.Logic.PetrolStation.CarOwner (Common.Enum.EDatabase.PetrolStation);
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
			
			Common.BLL.Entity.PetrolStation.LegalOwner		model	= new Common.BLL.Entity.PetrolStation.LegalOwner ()
			{
				carOwnerId = id						 
			};

			Common.BLL.Logic.PetrolStation.LegalOwner	lLegalOwner	= new Common.BLL.Logic.PetrolStation.LegalOwner (Common.Enum.EDatabase.PetrolStation);
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
			Common.BLL.Entity.PetrolStation.Owner model = new Common.BLL.Entity.PetrolStation.Owner ()
			{
				nationalCode = nationalCodeMaskedTextBox.Text.Trim ()
			};

			Common.BLL.Logic.PetrolStation.Owner		lOwner = new Common.BLL.Logic.PetrolStation.Owner (Common.Enum.EDatabase.PetrolStation);
			CommandResult opResult = lOwner.loadDataOwner(model);

			//Common.BLL.Logic.PetrolStation.Owner lOwner = new Common.BLL.Logic.PetrolStation.Owner (Common.Enum.EDatabase.PetrolStation);
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
