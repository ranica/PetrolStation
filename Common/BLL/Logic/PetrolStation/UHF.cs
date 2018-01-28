using System;
using BaseDAL.Model;
using Common.Helper.Logger;

namespace Common.BLL.Logic.PetrolStation
{
    public class UHF : BaseBLL.Logic.Base<BLL.Entity.PetrolStation.UHF>
    {
        public UHF(object type) : base(type)
        {
        }

        public bool updateStatusService(Common.BLL.Entity.PetrolStation.UHF uhf,
            Common.BLL.Entity.PetrolStation.User user, DateTime modifyDate)

        {
            CommandResult opResult = null;
            bool result = false;
            Common.BLL.Logic.PetrolStation.UHF lUHF = new Common.BLL.Logic.PetrolStation.UHF(Common.Enum.EDatabase.PetrolStation);
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