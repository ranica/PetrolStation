using System;
using BaseDAL.Model;
using Common.Helper.Logger;

namespace Common.BLL.Logic.GasStation
{
    public class UHF : BaseBLL.Logic.Base<BLL.Entity.GasStation.UHF>
    {
        public UHF(object type) : base(type)
        {
        }

        public bool updateStatusService(Common.BLL.Entity.GasStation.UHF uhf,
            Common.BLL.Entity.GasStation.User user, DateTime modifyDate)

        {
            CommandResult opResult = null;
            bool result = false;
            Common.BLL.Logic.GasStation.UHF lUHF = new Common.BLL.Logic.GasStation.UHF(Common.Enum.EDatabase.GasStation);
            if (uhf.id > 0)
            {
               
                uhf.updatedById = user.id;
                uhf.updateDate = modifyDate;
                opResult = lUHF.update(uhf);
            }

            if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

    }
}