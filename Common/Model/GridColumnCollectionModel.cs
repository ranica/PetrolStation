using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Model
{
	/// <summary>
	/// Grid column model
	/// </summary>
	[Serializable]
	public class GridColumnCollectionModel
	{
		#region Properties
		/// <summary>
		/// Columns
		/// </summary>
		public List<GridColumnModel> columns
		{
			get;
			set;
		}
		#endregion

		#region Methods
		/// <summary>
		/// Constructor
		/// </summary>
		public GridColumnCollectionModel ()
		{
			columns	= new List<Model.GridColumnModel> ();
		}
		#endregion
	}
}
