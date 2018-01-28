namespace AntennaService
{
	partial class ProjectInstaller
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

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			this.AntennaProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
			this.AntennaServiceInstaller = new System.ServiceProcess.ServiceInstaller();
			// 
			// AntennaProcessInstaller
			// 
			this.AntennaProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
			this.AntennaProcessInstaller.Password = null;
			this.AntennaProcessInstaller.Username = null;
			// 
			// AntennaServiceInstaller
			// 
			this.AntennaServiceInstaller.Description = "GasStation Antenna Service";
			this.AntennaServiceInstaller.ServiceName = "AntennaService";
			this.AntennaServiceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
			// 
			// ProjectInstaller
			// 
			this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.AntennaProcessInstaller,
            this.AntennaServiceInstaller});

		}

		#endregion

		private System.ServiceProcess.ServiceProcessInstaller AntennaProcessInstaller;
		private System.ServiceProcess.ServiceInstaller AntennaServiceInstaller;
	}
}