using System;
using System.Data;
using BaseDAL.Model;

namespace Common.BLL.Entity.PetrolStation
{
	[Serializable]
	public class UHF : BaseBLL.Entity.BaseByViewId
	{
		
//
	// Genereted Property of UHFPermit
	//
	#region Relation - UHFPermit (Has-Many relation)
		private System.Data.DataTable _get_UHFPermit_uhfId;
		public System.Data.DataTable getUHFPermit_uhfId
		{
			get
			{
				if ((_get_UHFPermit_uhfId == null) && (AutoLoadForeignKeys))
					loadUHFPermit_uhfId ();

				return _get_UHFPermit_uhfId;
			}
			set
			{
				_get_UHFPermit_uhfId	= value;
			}
		}

		public void loadUHFPermit_uhfId (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.PetrolStation.UHFPermit	logic	= new BLL.Logic.PetrolStation.UHFPermit ("PetrolStation");
			if (pageIndex == -1)
				opResult	= logic.allData ("uhfId = @uhfId", "", false, true, new KeyValuePair ("@uhfId", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "uhfId = @uhfId", "", false, true, new KeyValuePair ("@uhfId", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_UHFPermit_uhfId	= opResult.model as System.Data.DataTable;
		}
	#endregion
//
	// Genereted Property of Traffic
	//
	#region Relation - Traffic (Has-Many relation)
		private System.Data.DataTable _get_Traffic_uhfId;
		public System.Data.DataTable getTraffic_uhfId
		{
			get
			{
				if ((_get_Traffic_uhfId == null) && (AutoLoadForeignKeys))
					loadTraffic_uhfId ();

				return _get_Traffic_uhfId;
			}
			set
			{
				_get_Traffic_uhfId	= value;
			}
		}

		public void loadTraffic_uhfId (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.PetrolStation.Traffic	logic	= new BLL.Logic.PetrolStation.Traffic ("PetrolStation");
			if (pageIndex == -1)
				opResult	= logic.allData ("uhfId = @uhfId", "", false, true, new KeyValuePair ("@uhfId", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "uhfId = @uhfId", "", false, true, new KeyValuePair ("@uhfId", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Traffic_uhfId	= opResult.model as System.Data.DataTable;
		}
	#endregion
        		

		[BaseBLL.Base.Field(nullable=true,sqlDBType=System.Data.SqlDbType.VarChar,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,size=50)]
		public System.String name
		{
			get;
			set;
		}

		[BaseBLL.Base.Field(nullable=true,sqlDBType=System.Data.SqlDbType.VarChar,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,size=50)]
		public System.String antennaName
		{
			get;
			set;
		}

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.VarChar,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,size=15)]
		public System.String IP
		{
			get;
			set;
		}

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
		public System.Int32 Port
		{
			get;
			set;
		}

		[BaseBLL.Base.Field(nullable=true,sqlDBType=System.Data.SqlDbType.Bit,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
		public Nullable<System.Boolean> netStatus
		{
			get;
			set;
		}

		[BaseBLL.Base.Field(nullable=true,sqlDBType=System.Data.SqlDbType.VarChar,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,size=50)]
		public System.String serviceStatus
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
			logic	= new BLL.Logic.PetrolStation.User ("PetrolStation");
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
			logic	= new BLL.Logic.PetrolStation.User ("PetrolStation");
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