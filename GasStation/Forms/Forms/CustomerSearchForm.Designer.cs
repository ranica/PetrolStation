namespace GasStation.Forms.Forms
{
	partial class CustomerSearchForm
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
			this.dataGroupBox = new System.Windows.Forms.GroupBox();
			this.plateDataGroupBox = new System.Windows.Forms.GroupBox();
			this.mainPlatePanel = new System.Windows.Forms.Panel();
			this.code1Numeric = new System.Windows.Forms.DomainUpDown();
			this.part2MainTextBox = new System.Windows.Forms.TextBox();
			this.characterDomainUpDown = new System.Windows.Forms.DomainUpDown();
			this.part1MainTextBox = new System.Windows.Forms.TextBox();
			this.plateTypeComboBox = new System.Windows.Forms.ComboBox();
			this.motorPlatePanel = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.part2MotorTextBox = new System.Windows.Forms.TextBox();
			this.part1MotorTextBox = new System.Windows.Forms.TextBox();
			this.malulinPlatePanel = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.code2Numeric = new System.Windows.Forms.DomainUpDown();
			this.part2MaluinTextBox = new System.Windows.Forms.TextBox();
			this.part1MalulinTextBox = new System.Windows.Forms.TextBox();
			this.plateRadioButton = new System.Windows.Forms.RadioButton();
			this.serachButton = new System.Windows.Forms.Button();
			this.nationalCodeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.nationalCodeRadioButton = new System.Windows.Forms.RadioButton();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.ownerTabPage = new System.Windows.Forms.TabPage();
			this.carTabPage = new System.Windows.Forms.TabPage();
			this.trafficTabPage = new System.Windows.Forms.TabPage();
			this.dataGroupBox.SuspendLayout();
			this.plateDataGroupBox.SuspendLayout();
			this.mainPlatePanel.SuspendLayout();
			this.motorPlatePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.malulinPlatePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGroupBox
			// 
			this.dataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGroupBox.Controls.Add(this.plateDataGroupBox);
			this.dataGroupBox.Controls.Add(this.plateRadioButton);
			this.dataGroupBox.Controls.Add(this.serachButton);
			this.dataGroupBox.Controls.Add(this.nationalCodeMaskedTextBox);
			this.dataGroupBox.Controls.Add(this.nationalCodeRadioButton);
			this.dataGroupBox.Location = new System.Drawing.Point(12, 12);
			this.dataGroupBox.Name = "dataGroupBox";
			this.dataGroupBox.Size = new System.Drawing.Size(752, 220);
			this.dataGroupBox.TabIndex = 1;
			this.dataGroupBox.TabStop = false;
			this.dataGroupBox.Text = "جستجو براساس";
			// 
			// plateDataGroupBox
			// 
			this.plateDataGroupBox.Controls.Add(this.mainPlatePanel);
			this.plateDataGroupBox.Controls.Add(this.plateTypeComboBox);
			this.plateDataGroupBox.Controls.Add(this.motorPlatePanel);
			this.plateDataGroupBox.Controls.Add(this.malulinPlatePanel);
			this.plateDataGroupBox.Location = new System.Drawing.Point(280, 82);
			this.plateDataGroupBox.Name = "plateDataGroupBox";
			this.plateDataGroupBox.Size = new System.Drawing.Size(326, 117);
			this.plateDataGroupBox.TabIndex = 4;
			this.plateDataGroupBox.TabStop = false;
			this.plateDataGroupBox.Visible = false;
			// 
			// mainPlatePanel
			// 
			this.mainPlatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mainPlatePanel.Controls.Add(this.code1Numeric);
			this.mainPlatePanel.Controls.Add(this.part2MainTextBox);
			this.mainPlatePanel.Controls.Add(this.characterDomainUpDown);
			this.mainPlatePanel.Controls.Add(this.part1MainTextBox);
			this.mainPlatePanel.Location = new System.Drawing.Point(18, 61);
			this.mainPlatePanel.Name = "mainPlatePanel";
			this.mainPlatePanel.Size = new System.Drawing.Size(295, 47);
			this.mainPlatePanel.TabIndex = 4;
			// 
			// code1Numeric
			// 
			this.code1Numeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.code1Numeric.Location = new System.Drawing.Point(243, 7);
			this.code1Numeric.Name = "code1Numeric";
			this.code1Numeric.Size = new System.Drawing.Size(49, 26);
			this.code1Numeric.TabIndex = 3;
			this.code1Numeric.Tag = "plateCityId";
			this.code1Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// part2MainTextBox
			// 
			this.part2MainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.part2MainTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.part2MainTextBox.Location = new System.Drawing.Point(171, 7);
			this.part2MainTextBox.MaxLength = 3;
			this.part2MainTextBox.Name = "part2MainTextBox";
			this.part2MainTextBox.Size = new System.Drawing.Size(67, 26);
			this.part2MainTextBox.TabIndex = 2;
			this.part2MainTextBox.Tag = "";
			this.part2MainTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// characterDomainUpDown
			// 
			this.characterDomainUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.characterDomainUpDown.Items.Add("الف");
			this.characterDomainUpDown.Items.Add("ب");
			this.characterDomainUpDown.Items.Add("پ");
			this.characterDomainUpDown.Items.Add("ی");
			this.characterDomainUpDown.Location = new System.Drawing.Point(108, 7);
			this.characterDomainUpDown.Name = "characterDomainUpDown";
			this.characterDomainUpDown.Size = new System.Drawing.Size(58, 26);
			this.characterDomainUpDown.TabIndex = 1;
			this.characterDomainUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// part1MainTextBox
			// 
			this.part1MainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.part1MainTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.part1MainTextBox.Location = new System.Drawing.Point(36, 7);
			this.part1MainTextBox.MaxLength = 2;
			this.part1MainTextBox.Name = "part1MainTextBox";
			this.part1MainTextBox.Size = new System.Drawing.Size(67, 26);
			this.part1MainTextBox.TabIndex = 0;
			this.part1MainTextBox.Tag = "";
			this.part1MainTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// plateTypeComboBox
			// 
			this.plateTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.plateTypeComboBox.FormattingEnabled = true;
			this.plateTypeComboBox.Location = new System.Drawing.Point(18, 24);
			this.plateTypeComboBox.Name = "plateTypeComboBox";
			this.plateTypeComboBox.Size = new System.Drawing.Size(295, 26);
			this.plateTypeComboBox.TabIndex = 5;
			this.plateTypeComboBox.Tag = "plateTypeId";
			// 
			// motorPlatePanel
			// 
			this.motorPlatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.motorPlatePanel.Controls.Add(this.pictureBox2);
			this.motorPlatePanel.Controls.Add(this.part2MotorTextBox);
			this.motorPlatePanel.Controls.Add(this.part1MotorTextBox);
			this.motorPlatePanel.Location = new System.Drawing.Point(18, 64);
			this.motorPlatePanel.Name = "motorPlatePanel";
			this.motorPlatePanel.Size = new System.Drawing.Size(295, 42);
			this.motorPlatePanel.TabIndex = 2;
			this.motorPlatePanel.Visible = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = global::GasStation.Properties.Resources.motor;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Location = new System.Drawing.Point(114, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(49, 32);
			this.pictureBox2.TabIndex = 12;
			this.pictureBox2.TabStop = false;
			// 
			// part2MotorTextBox
			// 
			this.part2MotorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.part2MotorTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.part2MotorTextBox.Location = new System.Drawing.Point(169, 6);
			this.part2MotorTextBox.MaxLength = 6;
			this.part2MotorTextBox.Name = "part2MotorTextBox";
			this.part2MotorTextBox.Size = new System.Drawing.Size(67, 26);
			this.part2MotorTextBox.TabIndex = 1;
			this.part2MotorTextBox.Tag = "";
			this.part2MotorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// part1MotorTextBox
			// 
			this.part1MotorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.part1MotorTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.part1MotorTextBox.Location = new System.Drawing.Point(34, 6);
			this.part1MotorTextBox.MaxLength = 6;
			this.part1MotorTextBox.Name = "part1MotorTextBox";
			this.part1MotorTextBox.Size = new System.Drawing.Size(67, 26);
			this.part1MotorTextBox.TabIndex = 0;
			this.part1MotorTextBox.Tag = "";
			this.part1MotorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// malulinPlatePanel
			// 
			this.malulinPlatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.malulinPlatePanel.Controls.Add(this.pictureBox1);
			this.malulinPlatePanel.Controls.Add(this.code2Numeric);
			this.malulinPlatePanel.Controls.Add(this.part2MaluinTextBox);
			this.malulinPlatePanel.Controls.Add(this.part1MalulinTextBox);
			this.malulinPlatePanel.Location = new System.Drawing.Point(18, 62);
			this.malulinPlatePanel.Name = "malulinPlatePanel";
			this.malulinPlatePanel.Size = new System.Drawing.Size(295, 46);
			this.malulinPlatePanel.TabIndex = 3;
			this.malulinPlatePanel.Visible = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackgroundImage = global::GasStation.Properties.Resources.malulin_;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(114, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(45, 35);
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			// 
			// code2Numeric
			// 
			this.code2Numeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.code2Numeric.Items.Add("79");
			this.code2Numeric.Location = new System.Drawing.Point(241, 5);
			this.code2Numeric.Name = "code2Numeric";
			this.code2Numeric.Size = new System.Drawing.Size(49, 26);
			this.code2Numeric.TabIndex = 2;
			this.code2Numeric.Tag = "plateCityId";
			this.code2Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// part2MaluinTextBox
			// 
			this.part2MaluinTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.part2MaluinTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.part2MaluinTextBox.Location = new System.Drawing.Point(169, 5);
			this.part2MaluinTextBox.MaxLength = 3;
			this.part2MaluinTextBox.Name = "part2MaluinTextBox";
			this.part2MaluinTextBox.Size = new System.Drawing.Size(67, 26);
			this.part2MaluinTextBox.TabIndex = 1;
			this.part2MaluinTextBox.Tag = "";
			this.part2MaluinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// part1MalulinTextBox
			// 
			this.part1MalulinTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.part1MalulinTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.part1MalulinTextBox.Location = new System.Drawing.Point(34, 5);
			this.part1MalulinTextBox.MaxLength = 2;
			this.part1MalulinTextBox.Name = "part1MalulinTextBox";
			this.part1MalulinTextBox.Size = new System.Drawing.Size(67, 26);
			this.part1MalulinTextBox.TabIndex = 0;
			this.part1MalulinTextBox.Tag = "";
			this.part1MalulinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// plateRadioButton
			// 
			this.plateRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.plateRadioButton.AutoSize = true;
			this.plateRadioButton.Location = new System.Drawing.Point(623, 96);
			this.plateRadioButton.Name = "plateRadioButton";
			this.plateRadioButton.Size = new System.Drawing.Size(103, 22);
			this.plateRadioButton.TabIndex = 3;
			this.plateRadioButton.Text = "شماره پلاک";
			this.plateRadioButton.UseVisualStyleBackColor = true;
			// 
			// serachButton
			// 
			this.serachButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.serachButton.Location = new System.Drawing.Point(16, 160);
			this.serachButton.Name = "serachButton";
			this.serachButton.Size = new System.Drawing.Size(157, 39);
			this.serachButton.TabIndex = 2;
			this.serachButton.Text = "جستجو";
			this.serachButton.UseVisualStyleBackColor = true;
			// 
			// nationalCodeMaskedTextBox
			// 
			this.nationalCodeMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nationalCodeMaskedTextBox.Location = new System.Drawing.Point(403, 44);
			this.nationalCodeMaskedTextBox.Mask = "0000000000";
			this.nationalCodeMaskedTextBox.Name = "nationalCodeMaskedTextBox";
			this.nationalCodeMaskedTextBox.Size = new System.Drawing.Size(203, 26);
			this.nationalCodeMaskedTextBox.TabIndex = 1;
			this.nationalCodeMaskedTextBox.Tag = "nationalCode";
			this.nationalCodeMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nationalCodeRadioButton
			// 
			this.nationalCodeRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nationalCodeRadioButton.AutoSize = true;
			this.nationalCodeRadioButton.Checked = true;
			this.nationalCodeRadioButton.Location = new System.Drawing.Point(649, 45);
			this.nationalCodeRadioButton.Name = "nationalCodeRadioButton";
			this.nationalCodeRadioButton.Size = new System.Drawing.Size(77, 22);
			this.nationalCodeRadioButton.TabIndex = 0;
			this.nationalCodeRadioButton.TabStop = true;
			this.nationalCodeRadioButton.Text = "کد ملی";
			this.nationalCodeRadioButton.UseVisualStyleBackColor = true;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.ownerTabPage);
			this.tabControl1.Controls.Add(this.carTabPage);
			this.tabControl1.Controls.Add(this.trafficTabPage);
			this.tabControl1.Location = new System.Drawing.Point(12, 238);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.RightToLeftLayout = true;
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(752, 300);
			this.tabControl1.TabIndex = 3;
			// 
			// ownerTabPage
			// 
			this.ownerTabPage.Location = new System.Drawing.Point(4, 27);
			this.ownerTabPage.Name = "ownerTabPage";
			this.ownerTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.ownerTabPage.Size = new System.Drawing.Size(744, 269);
			this.ownerTabPage.TabIndex = 0;
			this.ownerTabPage.Text = "مشخصات شخصی";
			this.ownerTabPage.UseVisualStyleBackColor = true;
			// 
			// carTabPage
			// 
			this.carTabPage.Location = new System.Drawing.Point(4, 27);
			this.carTabPage.Name = "carTabPage";
			this.carTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.carTabPage.Size = new System.Drawing.Size(744, 269);
			this.carTabPage.TabIndex = 1;
			this.carTabPage.Text = "مشخصات ماشین";
			this.carTabPage.UseVisualStyleBackColor = true;
			// 
			// trafficTabPage
			// 
			this.trafficTabPage.Location = new System.Drawing.Point(4, 27);
			this.trafficTabPage.Name = "trafficTabPage";
			this.trafficTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.trafficTabPage.Size = new System.Drawing.Size(744, 269);
			this.trafficTabPage.TabIndex = 2;
			this.trafficTabPage.Text = "تردد ها";
			this.trafficTabPage.UseVisualStyleBackColor = true;
			// 
			// CustomerSearchForm
			// 
			this.AcceptButton = this.serachButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(776, 550);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.dataGroupBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CustomerSearchForm";
			this.Text = "جستجوی مشتری";
			this.dataGroupBox.ResumeLayout(false);
			this.dataGroupBox.PerformLayout();
			this.plateDataGroupBox.ResumeLayout(false);
			this.mainPlatePanel.ResumeLayout(false);
			this.mainPlatePanel.PerformLayout();
			this.motorPlatePanel.ResumeLayout(false);
			this.motorPlatePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.malulinPlatePanel.ResumeLayout(false);
			this.malulinPlatePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox dataGroupBox;
		private System.Windows.Forms.Button serachButton;
		private System.Windows.Forms.MaskedTextBox nationalCodeMaskedTextBox;
		private System.Windows.Forms.RadioButton nationalCodeRadioButton;
		private System.Windows.Forms.RadioButton plateRadioButton;
		private System.Windows.Forms.GroupBox plateDataGroupBox;
		private System.Windows.Forms.Panel mainPlatePanel;
		private System.Windows.Forms.DomainUpDown code1Numeric;
		private System.Windows.Forms.TextBox part2MainTextBox;
		private System.Windows.Forms.DomainUpDown characterDomainUpDown;
		private System.Windows.Forms.TextBox part1MainTextBox;
		private System.Windows.Forms.ComboBox plateTypeComboBox;
		private System.Windows.Forms.Panel motorPlatePanel;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TextBox part2MotorTextBox;
		private System.Windows.Forms.TextBox part1MotorTextBox;
		private System.Windows.Forms.Panel malulinPlatePanel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DomainUpDown code2Numeric;
		private System.Windows.Forms.TextBox part2MaluinTextBox;
		private System.Windows.Forms.TextBox part1MalulinTextBox;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage ownerTabPage;
		private System.Windows.Forms.TabPage carTabPage;
		private System.Windows.Forms.TabPage trafficTabPage;
	}
}