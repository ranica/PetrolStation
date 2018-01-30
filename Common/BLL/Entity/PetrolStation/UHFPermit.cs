using System;
using System.Data;
using BaseDAL.Model;

namespace Common.BLL.Entity.PetrolStation
{
	[Serializable]
	public class UHFPermit : BaseBLL.Entity.BaseByViewId
	{
		
		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.PetrolStation.User),foreignField="id")]
		public System.Int32 userId
		{
			get;
			set;
		}
//
	// Genereted Property of userId
	//
	#region Referenced Property - User
		BLL.Entity.PetrolStation.User _User_userId;
		public BLL.Entity.PetrolStation.User User_userId
		{
			get
			{
				if ((null == _User_userId) && (AutoLoadForeignKeys))
					load_User_userId ();
				return _User_userId;
			}
			set
			{
				_User_userId	= value;
			}
		}

		public void load_User_userId ()
		{ 
			BLL.Entity.PetrolStation.User	entity;
			BLL.Logic.PetrolStation.User	logic;

			entity	= new BLL.Entity.PetrolStation.User () { id = userId };
			logic	= new BLL.Logic.PetrolStation.User ("GasStation");
			logic.read (entity);

			_User_userId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.PetrolStation.UHF),foreignField="id")]
		public System.Int32 uhfId
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
				if ((null == _UHF_uhfId) && (AutoLoadForeignKeys))
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

			entity	= new BLL.Entity.PetrolStation.UHF () { id = uhfId };
			logic	= new BLL.Logic.PetrolStation.UHF ("GasStation");
			logic.read (entity);

			_UHF_uhfId	= entity;
		}
	#endregion
	}
}