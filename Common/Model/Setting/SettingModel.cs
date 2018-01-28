using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Model.Setting
{
	/// <summary>
	/// Setting Model
	/// </summary>
	public class SettingModel
	{
		#region Properties
		/// <summary>
		/// Antenna IP
		/// </summary>
		public string antennaIp
		{
			get;
			set;
		}

		/// <summary>
		/// Antenna Port
		/// </summary>
		public int antennaPort
		{
			get;
			set;
		}

		/// <summary>
		/// ConnectionString
		/// </summary>
		public string connectionString
		{
			get;
			set;
		}
		#endregion
	}
}
