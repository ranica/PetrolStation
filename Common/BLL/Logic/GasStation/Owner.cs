using System;
using BaseDAL.Model;

namespace Common.BLL.Logic.GasStation
{
	public class Owner : BaseBLL.Logic.Base<BLL.Entity.GasStation.Owner>
	{
		
		#region Constants
		private const string	C_spShowCustomer	= "spShowCustomer";
		private const string	C_spShowCustomerTag	= "spShowCustomerTag";
		public const string		C_spGetOwnerSearchByPlate = "spGetOwnerSearchByPlate";

		
		#endregion

		#region Methods
		public Owner (object type) : base (type)
		{
		}
		#endregion

		#region Custom Methods
		/// <summary>
		/// Load View Owner
		/// </summary>
		/// <returns></returns>
		public CommandResult loadViewOwner()
		{
			CommandResult result;
			string commandString	=	 "SELECT * FROM viewCustomer";
			result = BaseDAL.DBaseHelper.executeCommand(BaseDAL.Base.EnumExecuteType.reader, connection, commandString);

			return result;

			//CommandResult result;
			//result	= BaseDAL.DBaseHelper.executeCommand (BaseDAL.Base.EnumExecuteType.procedureReader, connection,C_spShowCustomer, true);
			//return result;
		}		

		public CommandResult loadDataOwner(Entity.GasStation.Owner owner)
		{
			CommandResult result;
			string commandString	=	 "SELECT * FROM viewCustomer where  nationalCode =" + owner.nationalCode;
			if (null != owner)
				result = BaseDAL.DBaseHelper.executeCommand(BaseDAL.Base.EnumExecuteType.reader, connection, commandString);
					
			else
				result = CommandResult.makeNullDataResult ();

			return result;
		}

		/// <summary>
		/// Load Report Owner
		/// </summary>
		/// <returns></returns>
		public CommandResult loadReportOwner()
		{
			CommandResult result;
			string commandString	=	 "SELECT nationalCode, name, lastname, mobile FROM Owner";
			result = BaseDAL.DBaseHelper.executeCommand(BaseDAL.Base.EnumExecuteType.reader, connection, commandString);

			return result;			
		}

		/// <summary>
		/// Load Car and Tag and Customer
		/// </summary>
		/// <returns></returns>
		public CommandResult loadTag()
		{
			CommandResult result;
			result	= BaseDAL.DBaseHelper.executeCommand (BaseDAL.Base.EnumExecuteType.procedureReader, connection,C_spShowCustomerTag, true);
			return result;			
		}

		/// <summary>
		/// Search Owner By Plate
		/// </summary>
		/// <returns></returns>
		public CommandResult	searchOwnerByPlate(string plate)
		{
			CommandResult result;
			
			result	= BaseDAL.DBaseHelper.executeCommand(BaseDAL.Base.EnumExecuteType.procedureReader,connection, C_spGetOwnerSearchByPlate, true,
				new KeyValuePair ("@plate",	plate)
				);
			
	
			return result;
		}

		#endregion
	}
}