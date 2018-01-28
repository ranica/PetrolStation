using Common.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace System
{
	/// <summary>
	/// JsonExtension
	/// </summary>
	public static class JsonExtension
	{
		/// <summary>
		/// To Model
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		public static T toModel<T> (this string data, Type type)
		{
			T result;

			result	= JsonConvert.DeserializeObject<T>(data??"");

			return result;
		}

		/// <summary>
		/// To Json
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		public static string toJson (this object data)
		{
			string result	= "";

			result	= JsonConvert.SerializeObject (data);

			return result;
		}
	}
}
