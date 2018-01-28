using BaseDAL.Model;
using Common.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace System
{
	/// <summary>
	/// JsonExtension
	/// </summary>
	public static class GridExtension
	{
		/// <summary>
		/// To Json
		/// </summary>
		/// <param name="grid"></param>
		/// <returns></returns>
		public static void loadHeader (this DataGridView grid, string name)
		{
			CommandResult	opResult;

			if (null != grid)
			{
				#region Load data
				Common.BLL.Logic.GasStation.Base__GridHeader	lGridHeader	= new Common.BLL.Logic.GasStation.Base__GridHeader (Common.Enum.EDatabase.GasStation);
				Common.BLL.Entity.GasStation.Base__GridHeader	gridHeader	= new Common.BLL.Entity.GasStation.Base__GridHeader ()
				{
					name	= name
				};

				opResult	= lGridHeader.read (gridHeader, "name");
				#endregion

				#region Apply changes on grid
				if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				{
					GridColumnCollectionModel cols = gridHeader.data.toModel<GridColumnCollectionModel> (typeof (GridColumnCollectionModel)) as GridColumnCollectionModel;

					if (cols is GridColumnCollectionModel)
						foreach (GridColumnModel col in cols.columns)
							if (grid.Columns.Contains (col.field))
							{
								DataGridViewColumn gridCol = grid.Columns[col.field];

								gridCol.HeaderText      = col.caption;
								gridCol.Visible         = col.visible;
								gridCol.ReadOnly        = col.readOnly;
								gridCol.DisplayIndex    = col.position;
								gridCol.Width			= col.width;
							}
				} 
				#endregion
			}
		}

        /// <summary>
        /// Add columns of DataRowView to grid view
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        public static bool addColumns(this DataGridView grid, DataRowView row)
        {
            bool result = false;

            if ((row != null) && (row.Row.Table.Columns.Count > 0))
            {
                if (grid.ColumnCount == 0)
                {
                    foreach (DataColumn column in row.Row.Table.Columns)
                        grid.Columns.Add(column.ColumnName, column.ColumnName);
                    result = true;
                }
            }

            return result;
        }
    }
}
