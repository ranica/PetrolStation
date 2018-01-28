using System;
using BaseDAL.Model;

namespace Common.BLL.Logic.GasStation
{
	public class User : BaseBLL.Logic.Base<BLL.Entity.GasStation.User>
	{

		#region Constants
		public const string C_spUserDelete = "spUserDelete";
		public const string C_SERVICE_USER = "ServiceUser";
		#endregion

		#region Methods
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="type"></param>
		public User (object type)
			: base (type)
		{
		}
		#endregion

		#region Custom Methods
		/// <summary>
		/// get service user
		/// </summary>
		/// <param name="user">User Model</param>
		/// <returns></returns>
		public CommandResult getServiceUser ()
		{
			CommandResult result;

			Common.BLL.Entity.GasStation.User	user	= new Entity.GasStation.User ()
			{
				username	= C_SERVICE_USER
			};
			result	= read (user, "username");

			if (user.id == 0)
				result	= createServiceUser ();
			else
				result.model	= user;

			return result;
		}

		/// <summary>
		/// Create service user
		/// </summary>
		/// <param name="user">User Model</param>
		/// <returns></returns>
		public CommandResult createServiceUser ()
		{
			CommandResult result;

			Common.BLL.Entity.GasStation.User	user	= new Entity.GasStation.User ()
			{
				name		= "Service",
				lastname	= "",
				username	= C_SERVICE_USER,
				password	= @"$3r\/Ic3U53R",
				inserted	= DateTime.Now,
				enable		= 1
			};
			result	= create (user);
			result.model	= user;

			return result;
		}

		/// <summary>
		/// Delete a user
		/// </summary>
		/// <param name="user">User Model</param>
		/// <returns></returns>
		public CommandResult deleteUser (Entity.GasStation.User user)
		{
			CommandResult result;

			if (null != user)
				result = BaseDAL.DBaseHelper.executeCommand (BaseDAL.Base.EnumExecuteType.procedureReader, connection, C_spUserDelete, true,
					new KeyValuePair ("@userId", user.id)
					);
			else
				result = CommandResult.makeNullDataResult ();

			return result;
		}
		#endregion
	}

}