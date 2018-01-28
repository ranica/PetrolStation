using System;
using System.Data;
using BaseDAL.Model;

namespace Common.BLL.Entity.PetrolStation
{
	[Serializable]
	public class Traffic : BaseBLL.Entity.BaseByViewId
	{
		
		//[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
		//public System.Int32 id
		//{
		//	get;
		//	set;
		//}

		//[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.UniqueIdentifier,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
		//public System.Guid viewId
		//{
		//	get;
		//	set;
		//}

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
			logic	= new BLL.Logic.PetrolStation.Tag (Common.Enum.EDatabase.PetrolStation);
			logic.read (entity);

			_Tag_tagId	= entity;
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