using System;
using System.Data;
using BaseDAL.Model;

namespace Common.BLL.Entity.GasStation
{
	[Serializable]
	public class CarOwner : BaseBLL.Entity.BaseByViewId
	{
		
		//[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
		//public System.Int32 id
		//{
		//	get;
		//	set;
		//}
//
	// Genereted Property of LegalOwner
	//
	#region Relation - LegalOwner (Has-Many relation)
		private System.Data.DataTable _get_LegalOwner_carOwnerId;
		public System.Data.DataTable getLegalOwner_carOwnerId
		{
			get
			{
				if ((_get_LegalOwner_carOwnerId == null) && (AutoLoadForeignKeys))
					loadLegalOwner_carOwnerId ();

				return _get_LegalOwner_carOwnerId;
			}
			set
			{
				_get_LegalOwner_carOwnerId	= value;
			}
		}

		public void loadLegalOwner_carOwnerId (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.LegalOwner	logic	= new BLL.Logic.GasStation.LegalOwner (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("carOwnerId = @carOwnerId", "", false, true, new KeyValuePair ("@carOwnerId", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "carOwnerId = @carOwnerId", "", false, true, new KeyValuePair ("@carOwnerId", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_LegalOwner_carOwnerId	= opResult.model as System.Data.DataTable;
		}
	#endregion

		//[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.UniqueIdentifier,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
		//public System.Guid viewId
		//{
		//	get;
		//	set;
		//}

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.Car),foreignField="id")]
		public System.Int32 carId
		{
			get;
			set;
		}
//
	// Genereted Property of carId
	//
	#region Referenced Property - Car
		BLL.Entity.GasStation.Car _Car_carId;
		public BLL.Entity.GasStation.Car Car_carId
		{
			get
			{
				if ((null == _Car_carId) && (AutoLoadForeignKeys))
					load_Car_carId ();
				return _Car_carId;
			}
			set
			{
				_Car_carId	= value;
			}
		}

		public void load_Car_carId ()
		{ 
			BLL.Entity.GasStation.Car	entity;
			BLL.Logic.GasStation.Car	logic;

			entity	= new BLL.Entity.GasStation.Car () { id = carId };
			logic	= new BLL.Logic.GasStation.Car (Common.Enum.EDatabase.GasStation);
			logic.read (entity);

			_Car_carId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.Owner),foreignField="id")]
		public System.Int32 ownerId
		{
			get;
			set;
		}
//
	// Genereted Property of ownerId
	//
	#region Referenced Property - Owner
		BLL.Entity.GasStation.Owner _Owner_ownerId;
		public BLL.Entity.GasStation.Owner Owner_ownerId
		{
			get
			{
				if ((null == _Owner_ownerId) && (AutoLoadForeignKeys))
					load_Owner_ownerId ();
				return _Owner_ownerId;
			}
			set
			{
				_Owner_ownerId	= value;
			}
		}

		public void load_Owner_ownerId ()
		{ 
			BLL.Entity.GasStation.Owner	entity;
			BLL.Logic.GasStation.Owner	logic;

			entity	= new BLL.Entity.GasStation.Owner () { id = ownerId };
			logic	= new BLL.Logic.GasStation.Owner (Common.Enum.EDatabase.GasStation);
			logic.read (entity);

			_Owner_ownerId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Bit,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
		public System.Boolean type
		{
			get;
			set;
		}

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.User),foreignField="id")]
		public System.Int32 insertedById
		{
			get;
			set;
		}
//
	// Genereted Property of insertedById
	//
	#region Referenced Property - User
		BLL.Entity.GasStation.User _User_insertedById;
		public BLL.Entity.GasStation.User User_insertedById
		{
			get
			{
				if ((null == _User_insertedById) && (AutoLoadForeignKeys))
					load_User_insertedById ();
				return _User_insertedById;
			}
			set
			{
				_User_insertedById	= value;
			}
		}

		public void load_User_insertedById ()
		{ 
			BLL.Entity.GasStation.User	entity;
			BLL.Logic.GasStation.User	logic;

			entity	= new BLL.Entity.GasStation.User () { id = insertedById };
			logic	= new BLL.Logic.GasStation.User (Common.Enum.EDatabase.GasStation);
			logic.read (entity);

			_User_insertedById	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.DateTime,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
		public System.DateTime insertDate
		{
			get;
			set;
		}

		[BaseBLL.Base.Field(nullable=true,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.User),foreignField="id")]
		public Nullable<System.Int32> updatedById
		{
			get;
			set;
		}
//
	// Genereted Property of updatedById
	//
	#region Referenced Property - User
		BLL.Entity.GasStation.User _User_updatedById;
		public BLL.Entity.GasStation.User User_updatedById
		{
			get
			{
				if ((null == _User_updatedById) && (updatedById.HasValue) && (AutoLoadForeignKeys))
					load_User_updatedById ();
				return _User_updatedById;
			}
			set
			{
				_User_updatedById	= value;
			}
		}

		public void load_User_updatedById ()
		{ 
			BLL.Entity.GasStation.User	entity;
			BLL.Logic.GasStation.User	logic;

			entity	= new BLL.Entity.GasStation.User () { id = updatedById.Value };
			logic	= new BLL.Logic.GasStation.User (Common.Enum.EDatabase.GasStation);
			logic.read (entity);

			_User_updatedById	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=true,sqlDBType=System.Data.SqlDbType.DateTime,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
		public Nullable<System.DateTime> updateDate
		{
			get;
			set;
		}
	}
}