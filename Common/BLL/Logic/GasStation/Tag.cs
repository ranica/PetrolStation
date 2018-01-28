using System;
using BaseDAL.Model;
using Common.BLL.Entity.GasStation;

namespace Common.BLL.Logic.GasStation
{
	public class Tag : BaseBLL.Logic.Base<BLL.Entity.GasStation.Tag>
	{
		#region Methods
		public Tag (object type) : base (type)
		{
		}

		/// <summary>
		/// Insert or Read tag
		/// </summary>
		/// <param name="tag"></param>
		/// <returns></returns>
		public CommandResult insertOrReadTag (Entity.GasStation.Tag tag, Entity.GasStation.User user)
		{
			CommandResult	result	= null;

			if (null != tag)
			{
				result	= read (tag, "tag");

				if (tag.id == 0)
				{
					tag.insertedById	= user.id;
					tag.insertDate		= DateTime.Now;
					result	= create (tag);
				}
			}
			else
				result	= CommandResult.makeNullDataResult ();

			return result;
		} 
		#endregion
	}
}