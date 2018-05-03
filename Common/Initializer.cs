using BaseDAL.Model;
using Common.Helper.Logger;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Common
{
	public class Initializer
	{
		/// <summary>
		/// Init
		/// </summary>
		public static void init (string loggerFilename, string exePath)
		{						
			ConnectionModel res = Common.Helper.Setting.SettingHelper.readConfigData(exePath);
            ConnectionModel cm = new ConnectionModel()
            {
                dataSource  = res.dataSource,
				initCatalog	= res.initCatalog,
				userId		= res.userId,
				password	= res.password

                //dataSource = SSTCryptographer.Decrypt(res.dataSource.Trim(), "Petrol@Station$3862018"),
                //initCatalog = SSTCryptographer.Decrypt(res.initCatalog.Trim(), "Petrol@Station$3862018"),
                //userId = SSTCryptographer.Decrypt(res.userId.Trim(), "Petrol@Station$3862018"),
                //password = SSTCryptographer.Decrypt(res.password.Trim(), "Petrol@Station$3862018"),


            };

			Logger.logger	= new Helper.Logger.Logger(loggerFilename);
			BaseDAL.Base.Connection.dataSources.Add (Common.Enum.EDatabase.PetrolStation.ToString (), cm);
		}
	}
}
