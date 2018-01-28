using System;
using System.Data;
using BaseDAL.Model;

namespace Common.BLL.Entity.GasStation
{
	[Serializable]
	public class Plate : BaseBLL.Entity.BaseByViewId
	{		
		
//
	// Genereted Property of Car
	//
	#region Relation - Car (Has-Many relation)
		private System.Data.DataTable _get_Car_plateId;
		public System.Data.DataTable getCar_plateId
		{
			get
			{
				if ((_get_Car_plateId == null) && (AutoLoadForeignKeys))
					loadCar_plateId ();

				return _get_Car_plateId;
			}
			set
			{
				_get_Car_plateId	= value;
			}
		}

		public void loadCar_plateId (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Car	logic	= new BLL.Logic.GasStation.Car ("GasStation");
			if (pageIndex == -1)
				opResult	= logic.allData ("plateId = @plateId", "", false, true, new KeyValuePair ("@plateId", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "plateId = @plateId", "", false, true, new KeyValuePair ("@plateId", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Car_plateId	= opResult.model as System.Data.DataTable;
		}
	#endregion

		
		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.Base__PlateType),foreignField="id")]
		public System.Int32 plateTypeId
		{
			get;
			set;
		}
//
	// Genereted Property of plateTypeId
	//
	#region Referenced Property - Base__PlateType
		BLL.Entity.GasStation.Base__PlateType _Base__PlateType_plateTypeId;
		public BLL.Entity.GasStation.Base__PlateType Base__PlateType_plateTypeId
		{
			get
			{
				if ((null == _Base__PlateType_plateTypeId) && (AutoLoadForeignKeys))
					load_Base__PlateType_plateTypeId ();
				return _Base__PlateType_plateTypeId;
			}
			set
			{
				_Base__PlateType_plateTypeId	= value;
			}
		}

		public void load_Base__PlateType_plateTypeId ()
		{ 
			BLL.Entity.GasStation.Base__PlateType	entity;
			BLL.Logic.GasStation.Base__PlateType	logic;

			entity	= new BLL.Entity.GasStation.Base__PlateType () { id = plateTypeId };
			logic	= new BLL.Logic.GasStation.Base__PlateType ("GasStation");
			logic.read (entity);

			_Base__PlateType_plateTypeId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.Base__PlateCity),foreignField="id")]
		public System.Int32 plateCityId
		{
			get;
			set;
		}
//
	// Genereted Property of plateCityId
	//
	#region Referenced Property - Base__PlateCity
		BLL.Entity.GasStation.Base__PlateCity _Base__PlateCity_plateCityId;
		public BLL.Entity.GasStation.Base__PlateCity Base__PlateCity_plateCityId
		{
			get
			{
				if ((null == _Base__PlateCity_plateCityId) && (AutoLoadForeignKeys))
					load_Base__PlateCity_plateCityId ();
				return _Base__PlateCity_plateCityId;
			}
			set
			{
				_Base__PlateCity_plateCityId	= value;
			}
		}

		public void load_Base__PlateCity_plateCityId ()
		{ 
			BLL.Entity.GasStation.Base__PlateCity	entity;
			BLL.Logic.GasStation.Base__PlateCity	logic;

			entity	= new BLL.Entity.GasStation.Base__PlateCity () { id = plateCityId };
			logic	= new BLL.Logic.GasStation.Base__PlateCity ("GasStation");
			logic.read (entity);

			_Base__PlateCity_plateCityId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.VarChar,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,size=50)]
		public System.String plate
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