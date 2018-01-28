using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.GlobalData
{
	/// <summary>
	/// User Manager
	/// </summary>
	public class UserManager
	{
		#region Properties
		/// <summary>
		/// Current User data
		/// </summary>
		public static Common.BLL.Entity.GasStation.User currentUser
		{
			get;
			set;
		}
		#endregion
	}
}
