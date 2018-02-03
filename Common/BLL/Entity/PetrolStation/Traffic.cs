using System;
using System.Data;
using BaseDAL.Model;

namespace Common.BLL.Entity.PetrolStation
{
	[Serializable]
	public class Traffic : BaseBLL.Entity.BaseByViewId
	{
				
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
			logic	= new BLL.Logic.PetrolStation.Tag ("GasStation");
			logic.read (entity);

			_Tag_tagId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=true,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.PetrolStation.UHF),foreignField="id")]
		public Nullable<System.Int32> uhfId
		{
			get;
			set;
		}
//
	// Genereted Property of uhfId
	//
	#region Referenced Property - UHF
		BLL.Entity.PetrolStation.UHF _UHF_uhfId;
		public BLL.Entity.PetrolStation.UHF UHF_uhfId
		{
			get
			{
				if ((null == _UHF_uhfId) && (uhfId.HasValue) && (AutoLoadForeignKeys))
					load_UHF_uhfId ();
				return _UHF_uhfId;
			}
			set
			{
				_UHF_uhfId	= value;
			}
		}

		public void load_UHF_uhfId ()
		{ 
			BLL.Entity.PetrolStation.UHF	entity;
			BLL.Logic.PetrolStation.UHF	logic;

			entity	= new BLL.Entity.PetrolStation.UHF () { id = uhfId.Value };
			logic	= new BLL.Logic.PetrolStation.UHF ("GasStation");
			logic.read (entity);

			_UHF_uhfId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.DateTime,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
		public System.DateTime trafficDate
		{
			get;
			set;
		}
	}
}