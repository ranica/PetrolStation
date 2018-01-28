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
using GasStation.Forms.Base;
using System.Reflection;
using Stimulsoft.Report;
using GasStation.Forms.Reports;

namespace GasStation.Forms.Forms
{
	public partial class MainForm : General.SuperForm
	{
		#region Properties
		#endregion

		#region Variable
		//Common.BLL.Logic.GasStation.User	lUser;
		//Common.BLL.Entity.GasStation.User	user;
		Common.BLL.Entity.GasStation.System__Data	model;

		#endregion

		#region Methods
		/// <summary>
		/// Constructor
		/// </summary>
		public MainForm ()
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
		}

		/// <summary>
		/// Prepare
		/// </summary>
		private void prepare ()
		{
			__Program.hasLogin	= 0;		// Default exit menu (Logoff)
		
			model = new Common.BLL.Entity.GasStation.System__Data()
			{ 
				name = "DB-Version"
			};
			Common.BLL.Logic.GasStation.System__Data	lSystemData = new Common.BLL.Logic.GasStation.System__Data(Common.Enum.EDatabase.GasStation);
			CommandResult	opResult	= lSystemData.read(model, "name");
			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				versionToolStripStatusLabel.Text = model.value;

			// Get Version
			string version = Assembly.GetExecutingAssembly ().GetName ().Version.ToString ();
			versionToolStripStatusLabel.Text= version;
			dateToolStripStatusLabel.Text = ExtensionsDateTime.getWeekDay(DateTime.Now) + "  " +  ExtensionsDateTime.toPersianDate(DateTime.Now); 

		}		
		/// <summary>
		/// Bind Events
		/// </summary>
		private void bindEvents ()
		{
			// Menus	
			logoffMenuItem.Click			+= LogoffMenuItem_Click;
			exitMenuItem.Click				+= ExitMenuItem_Click;

			//Customer
			customerMenuItem.Click			+= CustomerMenuItem_Click;
			customerShowMenuItem.Click		+= CustomerShowMenuItem_Click;
			customerSerachMenuItem.Click	+= CustomerSerachMenuItem_Click;

			//Car
			carTypeMenuItem.Click			+= CarTypeMenuItem_Click;
			carSystemMenuItem.Click			+= CarSystemMenuItem_Click;
			carFuelMenuItem.Click			+= CarFuelMenuItem_Click;
			carLevelMenuItem.Click			+= CarLevelMenuItem_Click;
			carColorMenuItem.Click			+= CarColorMenuItem_Click;

			//Plate
			plateCityMenuItem.Click			+= PlateCityMenuItem_Click;
			plateTypeMenuItem.Click			+= PlateTypeMenuItem_Click;	

			//Lottery
			lotteryToolStripMenuItem.Click += LotteryToolStripMenuItem_Click;
	
			//Report
			reportCustomerMenuItem.Click	+= ReportCustomerMenuItem_Click;
			reportCarMenuItem.Click			+= ReportCarMenuItem_Click;
			reportTrafficMenuItem.Click		+=ReportTrafficMenuItem_Click;

			aboutToolStripMenuItem.Click	+= AboutToolStripMenuItem_Click;
		}

		private void LotteryToolStripMenuItem_Click (object sender, EventArgs e)
		{
			LotteryForm lotteryform = new LotteryForm ();
			lotteryform.ShowDialog();
		}

		private void CustomerSerachMenuItem_Click (object sender, EventArgs e)
		{
			CustomerSearchForm customerSerach = new CustomerSearchForm ();
			customerSerach.ShowDialog();
		}

		private void AboutToolStripMenuItem_Click (object sender, EventArgs e)
		{
			//writeToDB("E20041374718024919904493");
		}

		private void writeToDB (string tagId)
		{
			int					interval		= 1;
			Common.BLL.Entity.GasStation.User	serviceUser;

			Common.BLL.Logic.GasStation.Traffic	lTraffic	= new Common.BLL.Logic.GasStation.Traffic (Common.Enum.EDatabase.GasStation);
			Common.BLL.Entity.GasStation.Tag	tag			= new Common.BLL.Entity.GasStation.Tag ()
			{
				tag	= tagId
			};

			Common.BLL.Logic.GasStation.User	lUser	= new Common.BLL.Logic.GasStation.User (Common.Enum.EDatabase.GasStation);
			CommandResult						opResult	= lUser.getServiceUser ();

			serviceUser	= opResult.model as Common.BLL.Entity.GasStation.User;

		
			lTraffic.insertTagByService (tag, serviceUser, DateTime.Now, interval);
		}
		
		private void ReportTrafficMenuItem_Click (object sender, EventArgs e)
		{
			ReportTrafficForm  trafficReportForm = new ReportTrafficForm ();
			trafficReportForm.ShowDialog();			
		}

		/// <summary>
		/// Report Car and Tag 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ReportCarMenuItem_Click (object sender, EventArgs e)
		{				
			Common.BLL.Logic.GasStation.Owner		lOwner = new Common.BLL.Logic.GasStation.Owner (Common.Enum.EDatabase.GasStation);
			CommandResult opResult = lOwner.loadTag();
			DataTable 	result			= opResult.model as DataTable;
			StiReport mainreport = new StiReport ();
			StiOptions.Viewer.RightToLeft = StiRightToLeftType.Yes;
			mainreport.RegBusinessObject("report",result);
			mainreport.Load(Application.StartupPath + "\\Reports\\report.mrt");
			mainreport.Compile();
			mainreport["myDate"]= ExtensionsDateTime.toPersianDate(DateTime.Now);
			mainreport.Render();			
			mainreport.Show();					
		}

		/// <summary>
		/// Report Customer Menu Item
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ReportCustomerMenuItem_Click (object sender, EventArgs e)
		{
			
			Common.BLL.Logic.GasStation.Owner		lOwner = new Common.BLL.Logic.GasStation.Owner (Common.Enum.EDatabase.GasStation);
			CommandResult opResult = lOwner.loadReportOwner();
			DataTable 	result			= opResult.model as DataTable;
			StiReport mainreport = new StiReport ();
			mainreport.RegBusinessObject("owner",result);
			mainreport.Load(Application.StartupPath + "\\Reports\\owner.mrt");
			mainreport.Compile();
			mainreport["myDate"]= ExtensionsDateTime.toPersianDate(DateTime.Now);
			mainreport.Render();
			mainreport.Show();
		}

		/// <summary>
		/// Show Customer Menu Item
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CustomerShowMenuItem_Click (object sender, EventArgs e)
		{
			CustomerViewForm	form	= new CustomerViewForm ();
			form.ShowDialog();
		}		
		/// <summary>
		/// Customer
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CustomerMenuItem_Click (object sender, EventArgs e)
		{
			CustomerForm		form	= new CustomerForm();
			form.ShowDialog();
		}
		
		/// <summary>
		/// Car Level Form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CarLevelMenuItem_Click (object sender, EventArgs e)
		{
			CarLevelForm	form		= new CarLevelForm();
			form.ShowDialog();
		}

		/// <summary>
		/// Car Fuel Form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CarFuelMenuItem_Click (object sender, EventArgs e)
		{
			CarFuelForm		form		= new CarFuelForm();
			form.ShowDialog();
		}

		/// <summary>
		/// Car System Form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>

		private void CarSystemMenuItem_Click (object sender, EventArgs e)
		{
			CarSystemForm	form		= new CarSystemForm();
			form.ShowDialog();
		}

		/// <summary>
		/// Car Type Form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CarTypeMenuItem_Click (object sender, EventArgs e)
		{
			CarTypeForm		form		= new CarTypeForm();
			form.ShowDialog();
		}

		/// <summary>
		/// Car Color Form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CarColorMenuItem_Click (object sender, EventArgs e)
		{
			CarColorForm	form		= new CarColorForm();
			form.ShowDialog();
		}

		/// <summary>
		/// Plate City
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PlateCityMenuItem_Click (object sender, EventArgs e)
		{
			PlateCityForm	 form		= new PlateCityForm ();
			form.ShowDialog();
		}

		/// <summary>
		/// Plate Type Form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PlateTypeMenuItem_Click (object sender, EventArgs e)
		{
			PlateTypeForm	form = new PlateTypeForm();
			form.ShowDialog();
		}

		/// <summary>
		/// Exit
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ExitMenuItem_Click (object sender, EventArgs e)
		{
			__Program.hasLogin	= 2;
			Close ();
		}

		/// <summary>
		/// Logoff Menu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LogoffMenuItem_Click (object sender, EventArgs e)
		{
			__Program.hasLogin	= 0;
			Close ();
		}

		/// <summary>
		/// OnClose
		/// </summary>
		/// <param name="e"></param>
		protected override void OnClosed (EventArgs e)
		{
			base.OnClosed (e);
		}
		#endregion
	}
}
