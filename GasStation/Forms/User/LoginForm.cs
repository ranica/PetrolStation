using BaseDAL.Model;
using GasStation.Forms.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common.BLL.Entity.GasStation;

namespace GasStation.Forms.User
{
	public partial class LoginForm : SuperForm
	{
		#region Properties
		#endregion

		#region Variable
		Common.BLL.Logic.GasStation.User	lUser;
		Common.BLL.Entity.GasStation.User	user;
		#endregion

		#region Methods
		/// <summary>
		/// Constructor
		/// </summary>
		public LoginForm ()
		{
			InitializeComponent ();

			init ();
		}


		/// <summary>
		/// Init
		/// </summary>
		private void init ()
		{
			bindEvents ();
			prepare ();
			
			//Common.DLL.CardReaderHelper	cHelper	= new Common.DLL.CardReaderHelper ();
				
			//// Connect
			//Common.DLL.Public.PublicFunction.onDataRead	+= (x) =>
			//{
			//	object t = x;
			//};
			//cHelper.connect (cHelper.GetComList ()[0]);
			//if (cHelper.connected)
			//{
			//	cHelper.startTagReader (3);
			//}

		}

		/// <summary>
		/// Prepare
		/// </summary>
		private void prepare ()
		{
			__Program.hasLogin	= 2;	// Exit program as default

			lUser	= new Common.BLL.Logic.GasStation.User (Common.Enum.EDatabase.GasStation);
			user	= new Common.BLL.Entity.GasStation.User ();
		}

		/// <summary>
		/// Bind Events
		/// </summary>
		private void bindEvents ()
		{
			loginButton.Click   += LoginButton_Click;
			exitButton.Click    += ExitButton_Click;
		}

		/// <summary>
		/// Exit Button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ExitButton_Click (object sender, EventArgs e)
		{
			__Program.hasLogin	= 2;
			Close ();
		}

		/// <summary>
		/// Login Button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LoginButton_Click (object sender, EventArgs e)
		{
			checkLogin ();
		}

		/// <summary>
		/// Check Login
		/// </summary>
		private void checkLogin ()
		{
			CommandResult	opResult;
			BaseBLL.General.FormModelHelper<Common.BLL.Entity.GasStation.User>.fillModel (userDataGroupBox, user);

			if (isValid (user))
			{
				 opResult	= lUser.read (user, "username,password");

				if ((opResult.status == BaseDAL.Base.EnumCommandStatus.success) && (user.id > 0))
				{
					Common.GlobalData.UserManager.currentUser	= user;
					__Program.hasLogin	= 1;
					Close ();
				}
				else
					MessageBox.Show (this, "اطلاعات کاربری خود را بررسی نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
				MessageBox.Show (this, "اطلاعات کاربری خود را وارد نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

			// Set focus
			usernameTextBox.Focus ();
		}

		/// <summary>
		/// Validate user data
		/// </summary>
		/// <param name="user"></param>
		/// <returns></returns>
		private bool isValid (Common.BLL.Entity.GasStation.User user)
		{
			bool result	= false;

			result	= (user != null) && (user.username.Length > 0) && (user.password.Length > 0);

			return result;
		}
		#endregion
	}
}
