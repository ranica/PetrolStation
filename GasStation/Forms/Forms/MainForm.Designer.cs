namespace GasStation.Forms.Forms
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoffMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدلخودروToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carSystemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carTypeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carLevelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carFuelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.رنگخودروToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plateCityMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plateTypeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.customerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerShowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerSerachMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportCustomerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportCarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportTrafficMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lotteryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lotteryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اطلاعاتکاربریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تنظیماتبرنامهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تنظیماتآنتنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تنظیماتپیامکToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.versionToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.nameTtoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dateToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenu.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Font = new System.Drawing.Font("B Yekan", 12F);
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.baseInfoMenuItem,
            this.toolStripMenuItem1,
            this.ReportMenuItem,
            this.lotteryMenuItem,
            this.settingMenuItem,
            this.helpMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(864, 32);
            this.mainMenu.TabIndex = 0;
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoffMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(49, 28);
            this.fileMenuItem.Text = "فایل";
            // 
            // logoffMenuItem
            // 
            this.logoffMenuItem.Name = "logoffMenuItem";
            this.logoffMenuItem.Size = new System.Drawing.Size(144, 28);
            this.logoffMenuItem.Text = "تغییر کاربر";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(144, 28);
            this.exitMenuItem.Text = "خروج";
            // 
            // baseInfoMenuItem
            // 
            this.baseInfoMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مدلخودروToolStripMenuItem,
            this.رنگخودروToolStripMenuItem});
            this.baseInfoMenuItem.Name = "baseInfoMenuItem";
            this.baseInfoMenuItem.Size = new System.Drawing.Size(92, 28);
            this.baseInfoMenuItem.Text = "اطلاعات پایه";
            // 
            // مدلخودروToolStripMenuItem
            // 
            this.مدلخودروToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carSystemMenuItem,
            this.carColorMenuItem,
            this.carTypeMenuItem,
            this.carLevelMenuItem,
            this.carFuelMenuItem});
            this.مدلخودروToolStripMenuItem.Name = "مدلخودروToolStripMenuItem";
            this.مدلخودروToolStripMenuItem.Size = new System.Drawing.Size(117, 28);
            this.مدلخودروToolStripMenuItem.Text = "خودرو";
            // 
            // carSystemMenuItem
            // 
            this.carSystemMenuItem.Name = "carSystemMenuItem";
            this.carSystemMenuItem.Size = new System.Drawing.Size(125, 28);
            this.carSystemMenuItem.Text = "سیستم";
            // 
            // carColorMenuItem
            // 
            this.carColorMenuItem.Name = "carColorMenuItem";
            this.carColorMenuItem.Size = new System.Drawing.Size(125, 28);
            this.carColorMenuItem.Text = "رنگ";
            // 
            // carTypeMenuItem
            // 
            this.carTypeMenuItem.Name = "carTypeMenuItem";
            this.carTypeMenuItem.Size = new System.Drawing.Size(125, 28);
            this.carTypeMenuItem.Text = "نوع";
            // 
            // carLevelMenuItem
            // 
            this.carLevelMenuItem.Name = "carLevelMenuItem";
            this.carLevelMenuItem.Size = new System.Drawing.Size(125, 28);
            this.carLevelMenuItem.Text = "تیپ";
            // 
            // carFuelMenuItem
            // 
            this.carFuelMenuItem.Name = "carFuelMenuItem";
            this.carFuelMenuItem.Size = new System.Drawing.Size(125, 28);
            this.carFuelMenuItem.Text = "سوخت";
            // 
            // رنگخودروToolStripMenuItem
            // 
            this.رنگخودروToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plateCityMenuItem,
            this.plateTypeMenuItem});
            this.رنگخودروToolStripMenuItem.Name = "رنگخودروToolStripMenuItem";
            this.رنگخودروToolStripMenuItem.Size = new System.Drawing.Size(117, 28);
            this.رنگخودروToolStripMenuItem.Text = "پلاک";
            // 
            // plateCityMenuItem
            // 
            this.plateCityMenuItem.Name = "plateCityMenuItem";
            this.plateCityMenuItem.Size = new System.Drawing.Size(104, 28);
            this.plateCityMenuItem.Text = "شهر";
            // 
            // plateTypeMenuItem
            // 
            this.plateTypeMenuItem.Name = "plateTypeMenuItem";
            this.plateTypeMenuItem.Size = new System.Drawing.Size(104, 28);
            this.plateTypeMenuItem.Text = "نوع";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerMenuItem,
            this.customerShowMenuItem,
            this.customerSerachMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(73, 28);
            this.toolStripMenuItem1.Text = "مشتریان";
            // 
            // customerMenuItem
            // 
            this.customerMenuItem.Name = "customerMenuItem";
            this.customerMenuItem.Size = new System.Drawing.Size(230, 28);
            this.customerMenuItem.Text = "ثبت مشتری جدید";
            // 
            // customerShowMenuItem
            // 
            this.customerShowMenuItem.Name = "customerShowMenuItem";
            this.customerShowMenuItem.Size = new System.Drawing.Size(230, 28);
            this.customerShowMenuItem.Text = "مشاهده اطلاعات مشتریان";
            // 
            // customerSerachMenuItem
            // 
            this.customerSerachMenuItem.Name = "customerSerachMenuItem";
            this.customerSerachMenuItem.Size = new System.Drawing.Size(230, 28);
            this.customerSerachMenuItem.Text = "جستجوی مشتریان";
            // 
            // ReportMenuItem
            // 
            this.ReportMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportCustomerMenuItem,
            this.reportCarMenuItem,
            this.reportTrafficMenuItem});
            this.ReportMenuItem.Name = "ReportMenuItem";
            this.ReportMenuItem.Size = new System.Drawing.Size(75, 28);
            this.ReportMenuItem.Text = "گزارشات";
            // 
            // reportCustomerMenuItem
            // 
            this.reportCustomerMenuItem.Name = "reportCustomerMenuItem";
            this.reportCustomerMenuItem.Size = new System.Drawing.Size(131, 28);
            this.reportCustomerMenuItem.Text = "مشتریان";
            // 
            // reportCarMenuItem
            // 
            this.reportCarMenuItem.Name = "reportCarMenuItem";
            this.reportCarMenuItem.Size = new System.Drawing.Size(131, 28);
            this.reportCarMenuItem.Text = "خودروها";
            // 
            // reportTrafficMenuItem
            // 
            this.reportTrafficMenuItem.Name = "reportTrafficMenuItem";
            this.reportTrafficMenuItem.Size = new System.Drawing.Size(131, 28);
            this.reportTrafficMenuItem.Text = "تردد ها";
            // 
            // lotteryMenuItem
            // 
            this.lotteryMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lotteryToolStripMenuItem});
            this.lotteryMenuItem.Name = "lotteryMenuItem";
            this.lotteryMenuItem.Size = new System.Drawing.Size(84, 28);
            this.lotteryMenuItem.Text = "قرعه کشی";
            // 
            // lotteryToolStripMenuItem
            // 
            this.lotteryToolStripMenuItem.Name = "lotteryToolStripMenuItem";
            this.lotteryToolStripMenuItem.Size = new System.Drawing.Size(117, 28);
            this.lotteryToolStripMenuItem.Text = "ماهانه";
            // 
            // settingMenuItem
            // 
            this.settingMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اطلاعاتکاربریToolStripMenuItem,
            this.تنظیماتبرنامهToolStripMenuItem});
            this.settingMenuItem.Name = "settingMenuItem";
            this.settingMenuItem.Size = new System.Drawing.Size(69, 28);
            this.settingMenuItem.Text = "تنظیمات";
            // 
            // اطلاعاتکاربریToolStripMenuItem
            // 
            this.اطلاعاتکاربریToolStripMenuItem.Name = "اطلاعاتکاربریToolStripMenuItem";
            this.اطلاعاتکاربریToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.اطلاعاتکاربریToolStripMenuItem.Text = "اطلاعات کاربری";
            // 
            // تنظیماتبرنامهToolStripMenuItem
            // 
            this.تنظیماتبرنامهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تنظیماتآنتنToolStripMenuItem,
            this.تنظیماتپیامکToolStripMenuItem});
            this.تنظیماتبرنامهToolStripMenuItem.Name = "تنظیماتبرنامهToolStripMenuItem";
            this.تنظیماتبرنامهToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.تنظیماتبرنامهToolStripMenuItem.Text = "تنظیمات برنامه";
            // 
            // تنظیماتآنتنToolStripMenuItem
            // 
            this.تنظیماتآنتنToolStripMenuItem.Name = "تنظیماتآنتنToolStripMenuItem";
            this.تنظیماتآنتنToolStripMenuItem.Size = new System.Drawing.Size(167, 28);
            this.تنظیماتآنتنToolStripMenuItem.Text = "تنظیمات آنتن";
            // 
            // تنظیماتپیامکToolStripMenuItem
            // 
            this.تنظیماتپیامکToolStripMenuItem.Name = "تنظیماتپیامکToolStripMenuItem";
            this.تنظیماتپیامکToolStripMenuItem.Size = new System.Drawing.Size(167, 28);
            this.تنظیماتپیامکToolStripMenuItem.Text = "تنظیمات پیامک";
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(58, 28);
            this.helpMenuItem.Text = "راهنما";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 28);
            this.aboutToolStripMenuItem.Text = "درباره ...";
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Font = new System.Drawing.Font("B Yekan", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mainStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripStatusLabel,
            this.nameTtoolStripStatusLabel,
            this.dateToolStripStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 461);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(864, 26);
            this.mainStatusStrip.TabIndex = 1;
            // 
            // versionToolStripStatusLabel
            // 
            this.versionToolStripStatusLabel.Name = "versionToolStripStatusLabel";
            this.versionToolStripStatusLabel.Size = new System.Drawing.Size(150, 21);
            this.versionToolStripStatusLabel.Text = "اطلاعات برنامه(نسخه و . .. )";
            // 
            // nameTtoolStripStatusLabel
            // 
            this.nameTtoolStripStatusLabel.Name = "nameTtoolStripStatusLabel";
            this.nameTtoolStripStatusLabel.Size = new System.Drawing.Size(42, 21);
            this.nameTtoolStripStatusLabel.Text = "امروز:";
            // 
            // dateToolStripStatusLabel
            // 
            this.dateToolStripStatusLabel.Name = "dateToolStripStatusLabel";
            this.dateToolStripStatusLabel.Size = new System.Drawing.Size(68, 21);
            this.dateToolStripStatusLabel.Text = "تاریخ امروز";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(864, 487);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ورود به سامانه";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logoffMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
		private System.Windows.Forms.ToolStripMenuItem baseInfoMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem customerMenuItem;
		private System.Windows.Forms.ToolStripMenuItem customerShowMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingMenuItem;
		private System.Windows.Forms.ToolStripMenuItem اطلاعاتکاربریToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem تنظیماتبرنامهToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ReportMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportCustomerMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportCarMenuItem;
		private System.Windows.Forms.StatusStrip mainStatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel versionToolStripStatusLabel;
		private System.Windows.Forms.ToolStripMenuItem مدلخودروToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem رنگخودروToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem carSystemMenuItem;
		private System.Windows.Forms.ToolStripMenuItem carColorMenuItem;
		private System.Windows.Forms.ToolStripMenuItem carTypeMenuItem;
		private System.Windows.Forms.ToolStripMenuItem carLevelMenuItem;
		private System.Windows.Forms.ToolStripMenuItem carFuelMenuItem;
		private System.Windows.Forms.ToolStripMenuItem plateCityMenuItem;
		private System.Windows.Forms.ToolStripMenuItem plateTypeMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportTrafficMenuItem;
		private System.Windows.Forms.ToolStripMenuItem تنظیماتآنتنToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem تنظیماتپیامکToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel nameTtoolStripStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel dateToolStripStatusLabel;
		private System.Windows.Forms.ToolStripMenuItem customerSerachMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lotteryMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lotteryToolStripMenuItem;
	}
}