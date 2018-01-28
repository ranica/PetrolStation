using BaseDAL.Model;
using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace System
{
	/// <summary>
	/// JsonExtension
	/// </summary>
	public static class GridColumnCollectionExtension
	{
		/// <summary>
		/// Save to db
		/// </summary>
		/// <param name="model"></param>
		/// <returns></returns>
		public static CommandResult saveToDB (this GridColumnCollectionModel model, string name)
		{
			CommandResult result;
			CommandResult opResult;

			// Check for empty model
			model	= model??new GridColumnCollectionModel ();

			#region Load data
			Common.BLL.Logic.GasStation.Base__GridHeader	lGridHeader	= new Common.BLL.Logic.GasStation.Base__GridHeader (Common.Enum.EDatabase.GasStation);
			Common.BLL.Entity.GasStation.Base__GridHeader	gridHeader	= new Common.BLL.Entity.GasStation.Base__GridHeader ()
			{
				name	= name
			};

			opResult	= lGridHeader.read (gridHeader, "name");

			if (gridHeader.id > 0)
			{
				gridHeader.data	= model.toJson ();
				result	= lGridHeader.update (gridHeader);
			}
			else
			{
				gridHeader.name	= name;
				gridHeader.data	= model.toJson ();
				result	= lGridHeader.create (gridHeader);
			}
			#endregion

			return result;
		}
	}
}
