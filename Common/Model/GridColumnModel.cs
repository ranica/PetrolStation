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
	public class GridColumnModel
	{
		#region Properties
		public string field
		{
			get;
			set;
		}
		public string caption
		{
			get;
			set;
		}
		public bool visible
		{
			get;
			set;
		}
		public bool readOnly
		{
			get;
			set;
		}
		public int position
		{
			get;
			set;
		}
		public int width 
		{ 
			get; 
			set; 
		}
		#endregion

		#region Methods
		/// <summary>
		/// Constructor
		/// </summary>
		public GridColumnModel ()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="field"></param>
		/// <param name="caption"></param>
		/// <param name="visible"></param>
		/// <param name="readOnly"></param>
		/// <param name="position"></param>
		public GridColumnModel (string field, string caption, bool visible = true, bool readOnly = true, int position = 0, int width = 150)
		{
			this.field		= field;
			this.caption	= caption;
			this.visible	= visible;
			this.readOnly	= readOnly;
			this.position	= position;
			this.width		= width;
		}
		#endregion

	}
}
