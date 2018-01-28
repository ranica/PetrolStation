using System;
using BaseDAL.Model;

namespace Common.BLL.Logic.GasStation
{
	public class Car : BaseBLL.Logic.Base<BLL.Entity.GasStation.Car>
	{
		#region Constants
		public const string C_spSaveData = "spSaveData";
		
		
		public const string C_spGetCarSearchByNationalcode = "spGetCarSearchByNationalcode";
		public const string C_spGetCarSearchByPlate = "spGetCarSearchByPlate";
		#endregion

		#region Methods
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="type"></param>
		public Car (object type) : base (type)
		{
		}

		#endregion
		#region Custom Methods

		/// <summary>
		/// Load View Car
		/// </summary>
		/// <returns></returns>
		public CommandResult	loadViewCar()
		{
			CommandResult result;
			string  commandString = "SELECT * FROM viewCar";
			result	= BaseDAL.DBaseHelper.executeCommand(BaseDAL.Base.EnumExecuteType.reader,connection,commandString);
	
			return result;
		}

		
		/// <summary>
		/// Search Car By Nationalcode 
		/// </summary>
		/// <returns></returns>
		public CommandResult	searchCar(string nationalcode)
		{
			CommandResult result;
			
			result	= BaseDAL.DBaseHelper.executeCommand(BaseDAL.Base.EnumExecuteType.procedureReader,connection, C_spGetCarSearchByNationalcode, true,
				new KeyValuePair ("@nationalCode",		nationalcode)
				);
			
	
			return result;
		}

		/// <summary>
		/// Search Car By Nationalcode 
		/// </summary>
		/// <returns></returns>
		public CommandResult	searchCarByPlate(string plate)
		{
			CommandResult result;
			
			result	= BaseDAL.DBaseHelper.executeCommand(BaseDAL.Base.EnumExecuteType.procedureReader,connection, C_spGetCarSearchByPlate, true,
				new KeyValuePair ("@plate",		plate)
				);
			
	
			return result;
		}

		
		/// <summary>
		/// save Data
		/// </summary>
		/// <param name="owner"></param>
		/// <param name="plate"></param>
		/// <param name="user"></param>
		/// <returns></returns>
		public CommandResult saveData ( Common.BLL.Entity.GasStation.Owner owner,
										Common.BLL.Entity.GasStation.Plate plate,
										Common.BLL.Entity.GasStation.User user)
										//Common.BLL.Entity.GasStation.Car car,
										
										//Common.BLL.Entity.GasStation.LegalOwner legalOwner)
		{
			CommandResult result;

			if (null != owner && null!= user)

				result = BaseDAL.DBaseHelper.executeCommand (BaseDAL.Base.EnumExecuteType.procedureReader, connection, C_spSaveData, true,
					new KeyValuePair ("@nationalCode",		owner.nationalCode),
					new KeyValuePair ("@name",				owner.name),
					new KeyValuePair ("@lastname",			owner.lastname),
					new KeyValuePair ("@birthdate",			owner.birthdate),
					new KeyValuePair ("@birthdatelocal",	owner.birthdatelocal),
					new KeyValuePair ("@gen", 				owner.gen),
					new KeyValuePair ("@mobile", 			owner.mobile),
					new KeyValuePair ("@address", 			owner.address),
					new KeyValuePair ("@phone", 			owner.phone),


					new KeyValuePair ("@plate", 			plate.plate),
					new KeyValuePair ("@palteCityId", 		plate.plateCityId),
					new KeyValuePair ("@palteTypeId", 		plate.plateTypeId),
				



					new KeyValuePair ("@insertedById",		user.id)
					);
			else
				result = CommandResult.makeNullDataResult ();

			return result;
		}

		#endregion
	}
}