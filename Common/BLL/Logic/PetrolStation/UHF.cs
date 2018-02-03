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


        /// <summary>
        /// Get info Antenna
        /// </summary>
        /// <param name="AntennaHost"></param>
        /// <returns></returns>
		public CommandResult getAntenna(string AntennaHost)
        {
            CommandResult result;

            Common.BLL.Entity.PetrolStation.UHF antenna = new Entity.PetrolStation.UHF()
            {
                IP = AntennaHost
            };
            result = read(antenna, "IP");

            if (antenna.id > 0)
            {
                result.model = antenna;
            }

            return result;
        }

        /// <summary>
        /// Update Satatus Service
        /// </summary>
        /// <param name="uhf"></param>
        /// <param name="user"></param>
        /// <param name="modifyDate"></param>
        /// <returns></returns>

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