using System;
using BaseDAL.Model;
using System.Data;

namespace Common.BLL.Logic.PetrolStation
{
    public class UHFPermit : BaseBLL.Logic.Base<BLL.Entity.PetrolStation.UHFPermit>
    {
        public const string C_spChart = "spChart";

        public UHFPermit(object type) : base(type)
        {
        }

        /// <summary>
        /// Get UHF By User Id
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public DataTable getUHF(int UserId)
        {
            DataTable result;

            UHFPermit c = new UHFPermit(Common.Enum.EDatabase.PetrolStation);
            CommandResult res = c.allData("userId = @userId", "", false, true, new KeyValuePair("@userId", UserId));
            result = res.model as DataTable;

            return result;
        }


        /// <summary>
        /// Fill Chart by UHF_Id
        /// </summary>
        /// <returns></returns>
        public CommandResult fillChart(int UHFId)
        {
            CommandResult result;
            result = BaseDAL.DBaseHelper.executeCommand(BaseDAL.Base.EnumExecuteType.procedureReader, 
                                                        connection, 
                                                        C_spChart,
                                                        true,
                  new KeyValuePair("@uhfId", UHFId)
                );

            return result;
        }


        public DataTable DrawChart(int uhfID)
        {
            Common.BLL.Logic.PetrolStation.UHFPermit lUHFPermit =
                                       new Common.BLL.Logic.PetrolStation.UHFPermit(Common.Enum.EDatabase.PetrolStation);

            CommandResult opResult = lUHFPermit.fillChart(uhfID);
            DataTable resultData = ExtensionsDateTable.makeWeekDay(opResult.model as DataTable, "_WeekDay", true);

            return resultData;
        }
    }
}