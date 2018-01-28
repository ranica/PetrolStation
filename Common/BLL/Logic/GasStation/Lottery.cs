using System;
using BaseDAL.Model;

namespace Common.BLL.Logic.GasStation
{
	public class Lottery : BaseBLL.Logic.Base<BLL.Entity.GasStation.Lottery>
	{
        #region Constants
        public const string C_spGetLottery = "spGetLottery";
        #endregion

        #region Methods
        public Lottery(object type) : base(type)
        {
        }

        /// <summary>
        /// Load Lottery
        /// </summary>
        /// <returns></returns>
        public CommandResult loadLottery(DateTime startDate, DateTime endDate)
        {
            CommandResult result;
            result = BaseDAL.DBaseHelper.executeCommand(BaseDAL.Base.EnumExecuteType.procedureReader, connection, C_spGetLottery, true,
                new KeyValuePair("@startDate", startDate),
                new KeyValuePair("@endDate", endDate)
                );

            return result;
        }
        #endregion
    }
}