using System;
using System.Data;
using BaseDAL.Model;

namespace Common.BLL.Entity.GasStation
{
	[Serializable]
	public class Tag : BaseBLL.Entity.BaseByViewId
	{
		
//
	// Genereted Property of CarTag
	//
	#region Relation - CarTag (Has-Many relation)
		private System.Data.DataTable _get_CarTag_tagId;
		public System.Data.DataTable getCarTag_tagId
		{
			get
			{
				if ((_get_CarTag_tagId == null) && (AutoLoadForeignKeys))
					loadCarTag_tagId ();

				return _get_CarTag_tagId;
			}
			set
			{
				_get_CarTag_tagId	= value;
			}
		}

		public void loadCarTag_tagId (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.CarTag	logic	= new BLL.Logic.GasStation.CarTag (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("tagId = @tagId", "", false, true, new KeyValuePair ("@tagId", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "tagId = @tagId", "", false, true, new KeyValuePair ("@tagId", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_CarTag_tagId	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Traffic
	//
	#region Relation - Traffic (Has-Many relation)
		private System.Data.DataTable _get_Traffic_tagId;
		public System.Data.DataTable getTraffic_tagId
		{
			get
			{
				if ((_get_Traffic_tagId == null) && (AutoLoadForeignKeys))
					loadTraffic_tagId ();

				return _get_Traffic_tagId;
			}
			set
			{
				_get_Traffic_tagId	= value;
			}
		}

		public void loadTraffic_tagId (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Traffic	logic	= new BLL.Logic.GasStation.Traffic (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("tagId = @tagId", "", false, true, new KeyValuePair ("@tagId", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "tagId = @tagId", "", false, true, new KeyValuePair ("@tagId", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Traffic_tagId	= opResult.model as System.Data.DataTable;
		}
	#endregion

		

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.VarChar,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,size=50)]
		public System.String tag
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