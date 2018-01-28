using BaseDAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PetrolStation.Forms.Base
{
    public partial class CarColorForm : General.SuperForm
    {
        #region Variables

        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// Constructor
        /// </summary>
        public CarColorForm()
        {
            InitializeComponent();

            init();

            button2.Visible = false;
        }

        /// <summary>
        /// Initilize
        /// </summary>
        private void init()
        {
            bindEvents();
            prepare();
        }

        /// <summary>
        /// Prepare
        /// </summary>
        private void prepare()
        {
			reload ();
        }

        /// <summary>
        /// Bind Events
        /// </summary>
        private void bindEvents()
        {
            exitMenu.Click      += exitMenu_Click;
			reloadMenu.Click	+= reloadMenu_Click;
            insertMenu.Click    += insertMenu_Click;
            modifyMenu.Click    += modifyMenu_Click;
			deleteMenu.Click	+= deleteMenu_Click;
        }

		/// <summary>
		/// Reload data
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void reloadMenu_Click (object sender, EventArgs e)
		{
			reload ();
		}

		/// <summary>
		/// Delete menu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void deleteMenu_Click (object sender, EventArgs e)
		{
			if ((null != resultGrid.CurrentRow) && 
				(MessageBox.Show (this, "آیا برای حذف اطمینان دارید؟", "حذف رکورد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes))
			{ 
				int	id;

				// Get id
				id	= Convert.ToInt32 (resultGrid.CurrentRow.Cells["id"].Value);

				Common.BLL.Entity.PetrolStation.Base__CarColor	model	= new Common.BLL.Entity.PetrolStation.Base__CarColor ()
				{
					id	= id
				};

				Common.BLL.Logic.PetrolStation.Base__CarColor	lCarColor	= new Common.BLL.Logic.PetrolStation.Base__CarColor (Common.Enum.EDatabase.PetrolStation);
				CommandResult	opResult	= lCarColor.delete (model);
				
				if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
					reload ();
			}
			else				
				MessageBox.Show ("رکوردی انتخاب نشده است", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

        /// <summary>
        /// Modify menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void modifyMenu_Click(object sender, EventArgs e)
        {
			if (null != resultGrid.CurrentRow)
			{ 
				int	id;

				// Get id
				id	= Convert.ToInt32 (resultGrid.CurrentRow.Cells["id"].Value);

				Common.BLL.Entity.PetrolStation.Base__CarColor	model	= new Common.BLL.Entity.PetrolStation.Base__CarColor ()
				{
					id	= id
				};
						

				CarColorEntryForm	form	= new CarColorEntryForm (model);
				if (form.ShowDialog () == System.Windows.Forms.DialogResult.OK)
					reload ();
			}
			else
				MessageBox.Show ("رکوردی انتخاب نشده است", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Insert Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void insertMenu_Click(object sender, EventArgs e)
        {
			CarColorEntryForm form	= new CarColorEntryForm ();

			if (form.ShowDialog () == System.Windows.Forms.DialogResult.OK)
				reload ();
        }

        /// <summary>
        /// Exit Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void exitMenu_Click(object sender, EventArgs e)
        {
            Close();
        } 

		/// <summary>
		/// Reload data
		/// </summary>
		void reload ()
		{
			Common.BLL.Logic.PetrolStation.Base__CarColor	lCarColor	= new Common.BLL.Logic.PetrolStation.Base__CarColor (Common.Enum.EDatabase.PetrolStation);

			CommandResult opResult	= lCarColor.allData ("", "color", false);
			resultGrid.DataSource	= opResult.model;		
			resultGrid.loadHeader (this.GetType ().Name);
		}
        #endregion

		
    }
}
