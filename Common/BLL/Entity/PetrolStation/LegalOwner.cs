using System;
using System.Data;
using BaseDAL.Model;

namespace Common.BLL.Entity.PetrolStation
{
	[Serializable]
	public class LegalOwner : BaseBLL.Entity.BaseByViewId
	{	

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.PetrolStation.CarOwner),foreignField="id")]
		public System.Int32 carOwnerId
		{
			get;
			set;
		}
//
	// Genereted Property of carOwnerId
	//
	#region Referenced Property - CarOwner
		BLL.Entity.PetrolStation.CarOwner _CarOwner_carOwnerId;
		public BLL.Entity.PetrolStation.CarOwner CarOwner_carOwnerId
		{
			get
			{
				if ((null == _CarOwner_carOwnerId) && (AutoLoadForeignKeys))
					load_CarOwner_carOwnerId ();
				return _CarOwner_carOwnerId;
			}
			set
			{
				_CarOwner_carOwnerId	= value;
			}
		}

		public void load_CarOwner_carOwnerId ()
		{ 
			BLL.Entity.PetrolStation.CarOwner	entity;
			BLL.Logic.PetrolStation.CarOwner	logic;

			entity	= new BLL.Entity.PetrolStation.CarOwner () { id = carOwnerId };
			logic	= new BLL.Logic.PetrolStation.CarOwner (Common.Enum.EDatabase.PetrolStation);
			logic.read (entity);

			_CarOwner_carOwnerId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.VarChar,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,size=50)]
		public System.String OrganizationCode
		{
			get;
			set;
		}

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.VarChar,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,size=50)]
		public System.String name
		{
			get;
			set;
		}

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.PetrolStation.User),foreignField="id")]
		public System.Int32 insertedById
		{
			get;
			set;
		}
//
	// Genereted Property of insertedById
	//
	#region Referenced Property - User
		BLL.Entity.PetrolStation.User _User_insertedById;
		public BLL.Entity.PetrolStation.User User_insertedById
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
			BLL.Entity.PetrolStation.User	entity;
			BLL.Logic.PetrolStation.User	logic;

			entity	= new BLL.Entity.PetrolStation.User () { id = insertedById };
			logic	= new BLL.Logic.PetrolStation.User (Common.Enum.EDatabase.PetrolStation);
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

		[BaseBLL.Base.Field(nullable=true,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.PetrolStation.User),foreignField="id")]
		public Nullable<System.Int32> updatedById
		{
			get;
			set;
		}
//
	// Genereted Property of updatedById
	//
	#region Referenced Property - User
		BLL.Entity.PetrolStation.User _User_updatedById;
		public BLL.Entity.PetrolStation.User User_updatedById
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
			BLL.Entity.PetrolStation.User	entity;
			BLL.Logic.PetrolStation.User	logic;

			entity	= new BLL.Entity.PetrolStation.User () { id = updatedById.Value };
			logic	= new BLL.Logic.PetrolStation.User (Common.Enum.EDatabase.PetrolStation);
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