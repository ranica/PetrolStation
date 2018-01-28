using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace System
{
	/// <summary>
	/// Combobox Extensions
	/// </summary>
	public static class ComboBoxExtension
	{
		/// <summary>
		/// Fill Combobox by datatable
		/// </summary>
		/// <param name="combo"></param>
		/// <param name="table"></param>
		/// <param name="id"></param>
		/// <param name="value"></param>
		public static void fillByTable (this System.Windows.Forms.ComboBox combo, DataTable table, string id, string value)
		{
			if ((combo != null) && (null != table) && !id.isNullOrEmptyOrWhiteSpaceOrLen() && !value.isNullOrEmptyOrWhiteSpaceOrLen())
			{
				combo.DisplayMember	= value;
				combo.ValueMember	= id;
				combo.DataSource	= table;
			}
		}
	}
}
