namespace GasStation.Forms.Forms
{
	partial class ExistenceCustomerForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.lastnameLabel = new System.Windows.Forms.Label();
			this.nationalCodeLabel = new System.Windows.Forms.Label();
			this.getButton = new System.Windows.Forms.Button();
			this.ownerDataGroupBox = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.mobileLabel = new System.Windows.Forms.Label();
			this.birthdateLabel = new System.Windows.Forms.Label();
			this.ownerDataGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(332, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "نام";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(269, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "نام خانوادگی";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(301, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 18);
			this.label3.TabIndex = 0;
			this.label3.Text = "کد ملی";
			// 
			// nameLabel
			// 
			this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nameLabel.AutoSize = true;
			this.nameLabel.BackColor = System.Drawing.Color.Transparent;
			this.nameLabel.Location = new System.Drawing.Point(151, 34);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(13, 18);
			this.nameLabel.TabIndex = 1;
			this.nameLabel.Tag = "name";
			this.nameLabel.Text = "-";
			// 
			// lastnameLabel
			// 
			this.lastnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lastnameLabel.AutoSize = true;
			this.lastnameLabel.BackColor = System.Drawing.Color.Transparent;
			this.lastnameLabel.Location = new System.Drawing.Point(151, 72);
			this.lastnameLabel.Name = "lastnameLabel";
			this.lastnameLabel.Size = new System.Drawing.Size(13, 18);
			this.lastnameLabel.TabIndex = 1;
			this.lastnameLabel.Tag = "lastname";
			this.lastnameLabel.Text = "-";
			// 
			// nationalCodeLabel
			// 
			this.nationalCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nationalCodeLabel.AutoSize = true;
			this.nationalCodeLabel.BackColor = System.Drawing.Color.Transparent;
			this.nationalCodeLabel.Location = new System.Drawing.Point(151, 121);
			this.nationalCodeLabel.Name = "nationalCodeLabel";
			this.nationalCodeLabel.Size = new System.Drawing.Size(13, 18);
			this.nationalCodeLabel.TabIndex = 1;
			this.nationalCodeLabel.Tag = "nationalCode";
			this.nationalCodeLabel.Text = "-";
			// 
			// getButton
			// 
			this.getButton.Location = new System.Drawing.Point(12, 283);
			this.getButton.Name = "getButton";
			this.getButton.Size = new System.Drawing.Size(143, 39);
			this.getButton.TabIndex = 2;
			this.getButton.Text = "دریافت اطلاعات";
			this.getButton.UseVisualStyleBackColor = true;
			// 
			// ownerDataGroupBox
			// 
			this.ownerDataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ownerDataGroupBox.BackColor = System.Drawing.Color.Transparent;
			this.ownerDataGroupBox.Controls.Add(this.label7);
			this.ownerDataGroupBox.Controls.Add(this.label5);
			this.ownerDataGroupBox.Controls.Add(this.label1);
			this.ownerDataGroupBox.Controls.Add(this.label2);
			this.ownerDataGroupBox.Controls.Add(this.mobileLabel);
			this.ownerDataGroupBox.Controls.Add(this.birthdateLabel);
			this.ownerDataGroupBox.Controls.Add(this.nationalCodeLabel);
			this.ownerDataGroupBox.Controls.Add(this.label3);
			this.ownerDataGroupBox.Controls.Add(this.lastnameLabel);
			this.ownerDataGroupBox.Controls.Add(this.nameLabel);
			this.ownerDataGroupBox.Location = new System.Drawing.Point(12, 12);
			this.ownerDataGroupBox.Name = "ownerDataGroupBox";
			this.ownerDataGroupBox.Size = new System.Drawing.Size(374, 263);
			this.ownerDataGroupBox.TabIndex = 3;
			this.ownerDataGroupBox.TabStop = false;
			this.ownerDataGroupBox.Text = "نمایش اطلاعات راننده";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(268, 213);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(89, 18);
			this.label7.TabIndex = 2;
			this.label7.Text = "شماره همراه";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(293, 167);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 18);
			this.label5.TabIndex = 2;
			this.label5.Text = "تاریخ تولد";
			// 
			// mobileLabel
			// 
			this.mobileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mobileLabel.AutoSize = true;
			this.mobileLabel.BackColor = System.Drawing.Color.Transparent;
			this.mobileLabel.Location = new System.Drawing.Point(151, 213);
			this.mobileLabel.Name = "mobileLabel";
			this.mobileLabel.Size = new System.Drawing.Size(13, 18);
			this.mobileLabel.TabIndex = 1;
			this.mobileLabel.Tag = "mobile";
			this.mobileLabel.Text = "-";
			// 
			// birthdateLabel
			// 
			this.birthdateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.birthdateLabel.AutoSize = true;
			this.birthdateLabel.BackColor = System.Drawing.Color.Transparent;
			this.birthdateLabel.Location = new System.Drawing.Point(151, 167);
			this.birthdateLabel.Name = "birthdateLabel";
			this.birthdateLabel.Size = new System.Drawing.Size(13, 18);
			this.birthdateLabel.TabIndex = 1;
			this.birthdateLabel.Tag = "birthdate";
			this.birthdateLabel.Text = "-";
			// 
			// ExistenceCustomerForm
			// 
			this.AcceptButton = this.getButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(398, 335);
			this.Controls.Add(this.ownerDataGroupBox);
			this.Controls.Add(this.getButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ExistenceCustomerForm";
			this.Text = "مشخصات مشتری";
			this.ownerDataGroupBox.ResumeLayout(false);
			this.ownerDataGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label lastnameLabel;
		private System.Windows.Forms.Label nationalCodeLabel;
		private System.Windows.Forms.Button getButton;
		private System.Windows.Forms.GroupBox ownerDataGroupBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label mobileLabel;
		private System.Windows.Forms.Label birthdateLabel;
	}
}