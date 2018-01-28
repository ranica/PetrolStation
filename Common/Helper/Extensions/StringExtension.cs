using Common.Helper.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
	/// <summary>
	/// String Extension
	/// </summary>
	public static class StringExtension
	{
		#region Methods
		/// <summary>
		/// Convert string to integer
		/// </summary>
		/// <param name="num"></param>
		/// <param name="defaultValue"></param>
		/// <returns></returns>
		public static int toInt (this string num, int defaultValue)
		{
			int result;

			if (!int.TryParse (num, out result))
				result	= defaultValue;

			return result;
		}

		/// <summary>
		/// Get String
		/// </summary>
		/// <param name="data"></param>
		/// <param name="encoding">IF NULL => UTF8 Selected as default</param>
		/// <returns></returns>
		public static string getString (this byte[] data, Encoding encoding = null)
		{
			if (null == encoding)
				encoding	= Encoding.UTF8;

			return encoding.GetString (data);
		}

		/// <summary>
		/// Encrypte data
		/// </summary>
		/// <param name="text"></param>
		/// <returns></returns>
		public static string encrypt (this string text, string pass = StringCipher.passPhrase)
		{
			return StringCipher.encrypt (text, pass);
		}

		/// <summary>
		/// Dycrypt data
		/// </summary>
		/// <param name="text"></param>
		/// <returns></returns>
		public static string dycrypt (this string text, string pass = StringCipher.passPhrase)
		{
			return StringCipher.decrypt (text, pass);
		}

		/// <summary>
		/// Get Bytes
		/// </summary>
		/// <param name="data"></param>
		/// <param name="encoding"></param>
		/// <returns></returns>
		public static byte[] getBytes (this string data, Encoding encoding = null)
		{
			byte[] result;

			if (null == encoding)
				encoding    = System.Text.Encoding.UTF8;

			result  = encoding.GetBytes (data);

			return result;
		}

		/// <summary>
		/// Check for empty/null/white spaces string
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		public static bool isNullOrEmptyOrWhiteSpaceOrLen (this string data, int len = 0)
		{
			bool result = false;

			result  = (data != null) && (data.Trim ().Length > 0);
			if (result && (len > 0))
				result  = result && (data.Length <= len);

			result  = !result;
			return result;
		}
		/// <summary>
		/// Check string is empty or null or white spaces
		/// </summary>
		/// <param name="text"></param>
		/// <returns></returns>
		public static bool isEmptyOrNullOrWhiteSpaces (this string text)
		{
			bool result	= false;

			// Check input data
			result	= (text == null) || (text.Trim ().Length == 0);

			return result;
		}

		#endregion
	}
}
