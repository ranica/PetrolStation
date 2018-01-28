using BaseDAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GasStation.Forms
{
    public partial class testForm : Form
    {

        Common.BLL.Entity.GasStation.UHF uhfModel;
        Common.BLL.Logic.GasStation.UHF lUHF;
        Common.BLL.Entity.GasStation.User serviceUser;
        Common.BLL.Logic.GasStation.User lUser;
        public testForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {      


             lUser = new Common.BLL.Logic.GasStation.User(
               Common.Enum.EDatabase.GasStation);
            CommandResult opResult = lUser.getServiceUser();

            serviceUser = opResult.model as Common.BLL.Entity.GasStation.User;
            MessageBox.Show(serviceUser.name + " " + serviceUser.lastname);


            #region Get UHF
            lUHF = new Common.BLL.Logic.GasStation.UHF(Common.Enum.EDatabase.GasStation);

            uhfModel = new Common.BLL.Entity.GasStation.UHF
            {
                IP = "127.0.0.1"
            };
            CommandResult result = lUHF.read(uhfModel, "IP");
            if ((result.status != BaseDAL.Base.EnumCommandStatus.success) && (uhfModel.id <= 0))
            {
                //writeLog("Error Load Info UHF");
            }
            MessageBox.Show(uhfModel.IP + " , " + uhfModel.netStatus + " , " + uhfModel.Port);


            Common.BLL.Entity.GasStation.Owner model = new Common.BLL.Entity.GasStation.Owner()
            {
                nationalCode = "4324260869"
            };
            Common.BLL.Logic.GasStation.Owner lOwner = new Common.BLL.Logic.GasStation.Owner(Common.Enum.EDatabase.GasStation);
            CommandResult opResult1 = lOwner.read(model, "nationalCode");

            if (opResult1.status == BaseDAL.Base.EnumCommandStatus.success)
            {
                MessageBox.Show(model.name);
            }

              
            #endregion
        }
    }
}
