namespace AntennaServiceInstaller.Forms
{
	partial class ServiceControllerForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.installServiceButton = new System.Windows.Forms.Button();
            this.uninstallServiceButton = new System.Windows.Forms.Button();
            this.startServiceButton = new System.Windows.Forms.Button();
            this.stopServiceButton = new System.Windows.Forms.Button();
            this.pauseServiceButton = new System.Windows.Forms.Button();
            this.serviceStatusLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.resumeServiceButton = new System.Windows.Forms.Button();
            this.restartServiceButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.restartServiceButton);
            this.groupBox1.Controls.Add(this.resumeServiceButton);
            this.groupBox1.Controls.Add(this.installServiceButton);
            this.groupBox1.Controls.Add(this.uninstallServiceButton);
            this.groupBox1.Controls.Add(this.startServiceButton);
            this.groupBox1.Controls.Add(this.stopServiceButton);
            this.groupBox1.Controls.Add(this.pauseServiceButton);
            this.groupBox1.Controls.Add(this.serviceStatusLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // installServiceButton
            // 
            this.installServiceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.installServiceButton.Location = new System.Drawing.Point(420, 93);
            this.installServiceButton.Name = "installServiceButton";
            this.installServiceButton.Size = new System.Drawing.Size(121, 35);
            this.installServiceButton.TabIndex = 0;
            this.installServiceButton.Text = "نصب";
            this.installServiceButton.UseVisualStyleBackColor = true;
            // 
            // uninstallServiceButton
            // 
            this.uninstallServiceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uninstallServiceButton.Location = new System.Drawing.Point(420, 134);
            this.uninstallServiceButton.Name = "uninstallServiceButton";
            this.uninstallServiceButton.Size = new System.Drawing.Size(121, 35);
            this.uninstallServiceButton.TabIndex = 2;
            this.uninstallServiceButton.Text = "حذف";
            this.uninstallServiceButton.UseVisualStyleBackColor = true;
            // 
            // startServiceButton
            // 
            this.startServiceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startServiceButton.Location = new System.Drawing.Point(143, 72);
            this.startServiceButton.Name = "startServiceButton";
            this.startServiceButton.Size = new System.Drawing.Size(121, 35);
            this.startServiceButton.TabIndex = 0;
            this.startServiceButton.Text = "اجرا";
            this.startServiceButton.UseVisualStyleBackColor = true;
            // 
            // stopServiceButton
            // 
            this.stopServiceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stopServiceButton.Location = new System.Drawing.Point(16, 134);
            this.stopServiceButton.Name = "stopServiceButton";
            this.stopServiceButton.Size = new System.Drawing.Size(121, 35);
            this.stopServiceButton.TabIndex = 2;
            this.stopServiceButton.Text = "پایان";
            this.stopServiceButton.UseVisualStyleBackColor = true;
            // 
            // pauseServiceButton
            // 
            this.pauseServiceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pauseServiceButton.Location = new System.Drawing.Point(143, 113);
            this.pauseServiceButton.Name = "pauseServiceButton";
            this.pauseServiceButton.Size = new System.Drawing.Size(121, 35);
            this.pauseServiceButton.TabIndex = 1;
            this.pauseServiceButton.Text = "توقف";
            this.pauseServiceButton.UseVisualStyleBackColor = true;
            // 
            // serviceStatusLabel
            // 
            this.serviceStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceStatusLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceStatusLabel.Location = new System.Drawing.Point(186, 34);
            this.serviceStatusLabel.Name = "serviceStatusLabel";
            this.serviceStatusLabel.Size = new System.Drawing.Size(266, 18);
            this.serviceStatusLabel.TabIndex = 1;
            this.serviceStatusLabel.Text = "Status";
            this.serviceStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "وضعیت سرویس : ";
            // 
            // loadingLabel
            // 
            this.loadingLabel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.loadingLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.loadingLabel.ForeColor = System.Drawing.Color.White;
            this.loadingLabel.Location = new System.Drawing.Point(-1, 14);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(266, 46);
            this.loadingLabel.TabIndex = 1;
            this.loadingLabel.Text = "کمی صبر کنید";
            this.loadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // resumeServiceButton
            // 
            this.resumeServiceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resumeServiceButton.Location = new System.Drawing.Point(143, 154);
            this.resumeServiceButton.Name = "resumeServiceButton";
            this.resumeServiceButton.Size = new System.Drawing.Size(121, 35);
            this.resumeServiceButton.TabIndex = 3;
            this.resumeServiceButton.Text = "ادامه";
            this.resumeServiceButton.UseVisualStyleBackColor = true;
            // 
            // restartServiceButton
            // 
            this.restartServiceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.restartServiceButton.Location = new System.Drawing.Point(16, 93);
            this.restartServiceButton.Name = "restartServiceButton";
            this.restartServiceButton.Size = new System.Drawing.Size(121, 35);
            this.restartServiceButton.TabIndex = 4;
            this.restartServiceButton.Text = "راه اندازی مجدد";
            this.restartServiceButton.UseVisualStyleBackColor = true;
            // 
            // ServiceControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AntennaServiceInstaller.Properties.Resources.formBK;
            this.ClientSize = new System.Drawing.Size(622, 228);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ServiceControllerForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کنترلگر سرویس آنتن";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button startServiceButton;
		private System.Windows.Forms.Button stopServiceButton;
		private System.Windows.Forms.Button pauseServiceButton;
		private System.Windows.Forms.Label serviceStatusLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label loadingLabel;
		private System.Windows.Forms.Button installServiceButton;
		private System.Windows.Forms.Button uninstallServiceButton;
        private System.Windows.Forms.Button resumeServiceButton;
        private System.Windows.Forms.Button restartServiceButton;
    }
}

