using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Model.Tag
{
	/// <summary>
	/// Tag Model
	/// </summary>
	[Serializable]
	[System.Runtime.InteropServices.StructLayout (System.Runtime.InteropServices.LayoutKind.Sequential)]
	public class TagModel
	{
		#region Properties
		/// <summary>
		/// Tag Id
		/// </summary>
		public string	tagId
		{
			get;
			set;
		}

		/// <summary>
		/// Date
		/// </summary>
		public DateTime date
		{
			get;
			set;
		}
		#endregion
	}
}
