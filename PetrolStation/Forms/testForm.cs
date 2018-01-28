using BaseDAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PetrolStation.Forms
{
    public partial class testForm : Form
    {

        Common.BLL.Entity.PetrolStation.UHF uhfModel;
        Common.BLL.Logic.PetrolStation.UHF lUHF;
        Common.BLL.Entity.PetrolStation.User serviceUser;
        Common.BLL.Logic.PetrolStation.User lUser;
        public testForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {      


             lUser = new Common.BLL.Logic.PetrolStation.User(
               Common.Enum.EDatabase.PetrolStation);
            CommandResult opResult = lUser.getServiceUser();

            serviceUser = opResult.model as Common.BLL.Entity.PetrolStation.User;
            MessageBox.Show(serviceUser.name + " " + serviceUser.lastname);


            #region Get UHF
            lUHF = new Common.BLL.Logic.PetrolStation.UHF(Common.Enum.EDatabase.PetrolStation);

            uhfModel = new Common.BLL.Entity.PetrolStation.UHF
            {
                IP = "127.0.0.1"
            };
            CommandResult result = lUHF.read(uhfModel, "IP");
            if ((result.status != BaseDAL.Base.EnumCommandStatus.success) && (uhfModel.id <= 0))
            {
                //writeLog("Error Load Info UHF");
            }
            MessageBox.Show(uhfModel.IP + " , " + uhfModel.netStatus + " , " + uhfModel.Port);


            Common.BLL.Entity.PetrolStation.Owner model = new Common.BLL.Entity.PetrolStation.Owner()
            {
                nationalCode = "4324260869"
            };
            Common.BLL.Logic.PetrolStation.Owner lOwner = new Common.BLL.Logic.PetrolStation.Owner(Common.Enum.EDatabase.PetrolStation);
            CommandResult opResult1 = lOwner.read(model, "nationalCode");

            if (opResult1.status == BaseDAL.Base.EnumCommandStatus.success)
            {
                MessageBox.Show(model.name);
            }

              
            #endregion
        }
    }
}
