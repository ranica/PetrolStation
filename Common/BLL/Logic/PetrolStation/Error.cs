using System;
using BaseDAL.Model;

namespace Common.BLL.Logic.PetrolStation
{
	public class Error : BaseBLL.Logic.Base<BLL.Entity.PetrolStation.Error>
	{
		public Error (object type) : base (type)
		{
		}

        /// <summary>
        /// Insert Error
        /// </summary>
        /// <param name="error"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool InsertError(Exception e)
        {
            bool result = false;
            CommandResult opResult = null;

            Common.BLL.Logic.PetrolStation.Error lError = new Common.BLL.Logic.PetrolStation.Error(Common.Enum.EDatabase.PetrolStation);
            Common.BLL.Entity.PetrolStation.Error errorModel = new Common.BLL.Entity.PetrolStation.Error
            {
                error = e.ToString(),
                eSource = e.Source.ToString(),
                eInnerExecption = (e.InnerException != null ? e.InnerException.ToString() : ""),
                eStackTrace = e.StackTrace,
                eTargetSite = e.TargetSite.ToString(),
                eTargetSiteName = e.TargetSite.Name,
                eTargetSiteModule = e.TargetSite.Module.ToString(),
                eDate = DateTime.Now
            };
            opResult =  lError.create(errorModel);

            if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
                result = true;

            return result;
        }
	}
}