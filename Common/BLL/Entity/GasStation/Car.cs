using System;
using System.Data;
using BaseDAL.Model;

namespace Common.BLL.Entity.GasStation
{
	[Serializable]
	public class Car : BaseBLL.Entity.BaseByViewId
	{		
//
	// Genereted Property of CarTag
	//
	#region Relation - CarTag (Has-Many relation)
		private System.Data.DataTable _get_CarTag_carId;
		public System.Data.DataTable getCarTag_carId
		{
			get
			{
				if ((_get_CarTag_carId == null) && (AutoLoadForeignKeys))
					loadCarTag_carId ();

				return _get_CarTag_carId;
			}
			set
			{
				_get_CarTag_carId	= value;
			}
		}

		public void loadCarTag_carId (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.CarTag	logic	= new BLL.Logic.GasStation.CarTag ("GasStation");
			if (pageIndex == -1)
				opResult	= logic.allData ("carId = @carId", "", false, true, new KeyValuePair ("@carId", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "carId = @carId", "", false, true, new KeyValuePair ("@carId", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_CarTag_carId	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of CarOwner
	//
	#region Relation - CarOwner (Has-Many relation)
		private System.Data.DataTable _get_CarOwner_carId;
		public System.Data.DataTable getCarOwner_carId
		{
			get
			{
				if ((_get_CarOwner_carId == null) && (AutoLoadForeignKeys))
					loadCarOwner_carId ();

				return _get_CarOwner_carId;
			}
			set
			{
				_get_CarOwner_carId	= value;
			}
		}

		public void loadCarOwner_carId (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.CarOwner	logic	= new BLL.Logic.GasStation.CarOwner ("GasStation");
			if (pageIndex == -1)
				opResult	= logic.allData ("carId = @carId", "", false, true, new KeyValuePair ("@carId", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "carId = @carId", "", false, true, new KeyValuePair ("@carId", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_CarOwner_carId	= opResult.model as System.Data.DataTable;
		}
	#endregion

		

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.Base__CarType),foreignField="id")]
		public System.Int32 carTypeId
		{
			get;
			set;
		}
//
	// Genereted Property of carTypeId
	//
	#region Referenced Property - Base__CarType
		BLL.Entity.GasStation.Base__CarType _Base__CarType_carTypeId;
		public BLL.Entity.GasStation.Base__CarType Base__CarType_carTypeId
		{
			get
			{
				if ((null == _Base__CarType_carTypeId) && (AutoLoadForeignKeys))
					load_Base__CarType_carTypeId ();
				return _Base__CarType_carTypeId;
			}
			set
			{
				_Base__CarType_carTypeId	= value;
			}
		}

		public void load_Base__CarType_carTypeId ()
		{ 
			BLL.Entity.GasStation.Base__CarType	entity;
			BLL.Logic.GasStation.Base__CarType	logic;

			entity	= new BLL.Entity.GasStation.Base__CarType () { id = carTypeId };
			logic	= new BLL.Logic.GasStation.Base__CarType ("GasStation");
			logic.read (entity);

			_Base__CarType_carTypeId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.Base__CarColor),foreignField="id")]
		public System.Int32 carColorId
		{
			get;
			set;
		}
//
	// Genereted Property of carColorId
	//
	#region Referenced Property - Base__CarColor
		BLL.Entity.GasStation.Base__CarColor _Base__CarColor_carColorId;
		public BLL.Entity.GasStation.Base__CarColor Base__CarColor_carColorId
		{
			get
			{
				if ((null == _Base__CarColor_carColorId) && (AutoLoadForeignKeys))
					load_Base__CarColor_carColorId ();
				return _Base__CarColor_carColorId;
			}
			set
			{
				_Base__CarColor_carColorId	= value;
			}
		}

		public void load_Base__CarColor_carColorId ()
		{ 
			BLL.Entity.GasStation.Base__CarColor	entity;
			BLL.Logic.GasStation.Base__CarColor	logic;

			entity	= new BLL.Entity.GasStation.Base__CarColor () { id = carColorId };
			logic	= new BLL.Logic.GasStation.Base__CarColor ("GasStation");
			logic.read (entity);

			_Base__CarColor_carColorId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.Base__CarSystem),foreignField="id")]
		public System.Int32 carSystemId
		{
			get;
			set;
		}
//
	// Genereted Property of carSystemId
	//
	#region Referenced Property - Base__CarSystem
		BLL.Entity.GasStation.Base__CarSystem _Base__CarSystem_carSystemId;
		public BLL.Entity.GasStation.Base__CarSystem Base__CarSystem_carSystemId
		{
			get
			{
				if ((null == _Base__CarSystem_carSystemId) && (AutoLoadForeignKeys))
					load_Base__CarSystem_carSystemId ();
				return _Base__CarSystem_carSystemId;
			}
			set
			{
				_Base__CarSystem_carSystemId	= value;
			}
		}

		public void load_Base__CarSystem_carSystemId ()
		{ 
			BLL.Entity.GasStation.Base__CarSystem	entity;
			BLL.Logic.GasStation.Base__CarSystem	logic;

			entity	= new BLL.Entity.GasStation.Base__CarSystem () { id = carSystemId };
			logic	= new BLL.Logic.GasStation.Base__CarSystem ("GasStation");
			logic.read (entity);

			_Base__CarSystem_carSystemId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.Base__CarLevel),foreignField="id")]
		public System.Int32 carLevelId
		{
			get;
			set;
		}
//
	// Genereted Property of carLevelId
	//
	#region Referenced Property - Base__CarLevel
		BLL.Entity.GasStation.Base__CarLevel _Base__CarLevel_carLevelId;
		public BLL.Entity.GasStation.Base__CarLevel Base__CarLevel_carLevelId
		{
			get
			{
				if ((null == _Base__CarLevel_carLevelId) && (AutoLoadForeignKeys))
					load_Base__CarLevel_carLevelId ();
				return _Base__CarLevel_carLevelId;
			}
			set
			{
				_Base__CarLevel_carLevelId	= value;
			}
		}

		public void load_Base__CarLevel_carLevelId ()
		{ 
			BLL.Entity.GasStation.Base__CarLevel	entity;
			BLL.Logic.GasStation.Base__CarLevel	logic;

			entity	= new BLL.Entity.GasStation.Base__CarLevel () { id = carLevelId };
			logic	= new BLL.Logic.GasStation.Base__CarLevel ("GasStation");
			logic.read (entity);

			_Base__CarLevel_carLevelId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.Base__CarFuel),foreignField="id")]
		public System.Int32 carFuelId
		{
			get;
			set;
		}
//
	// Genereted Property of carFuelId
	//
	#region Referenced Property - Base__CarFuel
		BLL.Entity.GasStation.Base__CarFuel _Base__CarFuel_carFuelId;
		public BLL.Entity.GasStation.Base__CarFuel Base__CarFuel_carFuelId
		{
			get
			{
				if ((null == _Base__CarFuel_carFuelId) && (AutoLoadForeignKeys))
					load_Base__CarFuel_carFuelId ();
				return _Base__CarFuel_carFuelId;
			}
			set
			{
				_Base__CarFuel_carFuelId	= value;
			}
		}

		public void load_Base__CarFuel_carFuelId ()
		{ 
			BLL.Entity.GasStation.Base__CarFuel	entity;
			BLL.Logic.GasStation.Base__CarFuel	logic;

			entity	= new BLL.Entity.GasStation.Base__CarFuel () { id = carFuelId };
			logic	= new BLL.Logic.GasStation.Base__CarFuel ("GasStation");
			logic.read (entity);

			_Base__CarFuel_carFuelId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.Plate),foreignField="id")]
		public System.Int32 plateId
		{
			get;
			set;
		}
//
	// Genereted Property of plateId
	//
	#region Referenced Property - Plate
		BLL.Entity.GasStation.Plate _Plate_plateId;
		public BLL.Entity.GasStation.Plate Plate_plateId
		{
			get
			{
				if ((null == _Plate_plateId) && (AutoLoadForeignKeys))
					load_Plate_plateId ();
				return _Plate_plateId;
			}
			set
			{
				_Plate_plateId	= value;
			}
		}

		public void load_Plate_plateId ()
		{ 
			BLL.Entity.GasStation.Plate	entity;
			BLL.Logic.GasStation.Plate	logic;

			entity	= new BLL.Entity.GasStation.Plate () { id = plateId };
			logic	= new BLL.Logic.GasStation.Plate ("GasStation");
			logic.read (entity);

			_Plate_plateId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.VarChar,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,size=5)]
		public System.String model
		{
			get;
			set;
		}

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Bit,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
		public System.Boolean status
		{
			get;
			set;
		}

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.SmallInt,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
		public System.Int16 capacity
		{
			get;
			set;
		}

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.VarChar,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,size=50)]
		public System.String chasisCode
		{
			get;
			set;
		}

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.VarChar,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,size=50)]
		public System.String engineCode
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
			logic	= new BLL.Logic.GasStation.User ("GasStation");
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
			logic	= new BLL.Logic.GasStation.User ("GasStation");
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