using System;
using System.Data;
using BaseDAL.Model;

namespace Common.BLL.Entity.PetrolStation
{
	[Serializable]
	public class CarTag : BaseBLL.Entity.BaseByViewId
	{		
		
		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.PetrolStation.Car),foreignField="id")]
		public System.Int32 carId
		{
			get;
			set;
		}
//
	// Genereted Property of carId
	//
	#region Referenced Property - Car
		BLL.Entity.PetrolStation.Car _Car_carId;
		public BLL.Entity.PetrolStation.Car Car_carId
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
			BLL.Entity.PetrolStation.Car	entity;
			BLL.Logic.PetrolStation.Car	logic;

			entity	= new BLL.Entity.PetrolStation.Car () { id = carId };
			logic	= new BLL.Logic.PetrolStation.Car ("PetrolStation");
			logic.read (entity);

			_Car_carId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.PetrolStation.Tag),foreignField="id")]
		public System.Int32 tagId
		{
			get;
			set;
		}
//
	// Genereted Property of tagId
	//
	#region Referenced Property - Tag
		BLL.Entity.PetrolStation.Tag _Tag_tagId;
		public BLL.Entity.PetrolStation.Tag Tag_tagId
		{
			get
			{
				if ((null == _Tag_tagId) && (AutoLoadForeignKeys))
					load_Tag_tagId ();
				return _Tag_tagId;
			}
			set
			{
				_Tag_tagId	= value;
			}
		}

		public void load_Tag_tagId ()
		{ 
			BLL.Entity.PetrolStation.Tag	entity;
			BLL.Logic.PetrolStation.Tag	logic;

			entity	= new BLL.Entity.PetrolStation.Tag () { id = tagId };
			logic	= new BLL.Logic.PetrolStation.Tag ("PetrolStation");
			logic.read (entity);

			_Tag_tagId	= entity;
		}
	#endregion

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
			logic	= new BLL.Logic.PetrolStation.User ("PetrolStation");
			logic.read (entity);

			_User_insertedById	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Date,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
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
			logic	= new BLL.Logic.PetrolStation.User ("PetrolStation");
			logic.read (entity);

			_User_updatedById	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=true,sqlDBType=System.Data.SqlDbType.Date,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
		public Nullable<System.DateTime> updateDate
		{
			get;
			set;
		}
	}
}