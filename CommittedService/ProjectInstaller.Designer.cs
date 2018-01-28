namespace CommittedService
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
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CommittedProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.CommittedInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // CommittedProcessInstaller
            // 
            this.CommittedProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.CommittedProcessInstaller.Password = null;
            this.CommittedProcessInstaller.Username = null;
            // 
            // CommittedInstaller
            // 
            this.CommittedInstaller.Description = "Committed Service";
            this.CommittedInstaller.ServiceName = "CommittedService";
            this.CommittedInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.CommittedProcessInstaller,
            this.CommittedInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller CommittedProcessInstaller;
        private System.ServiceProcess.ServiceInstaller CommittedInstaller;
    }
}