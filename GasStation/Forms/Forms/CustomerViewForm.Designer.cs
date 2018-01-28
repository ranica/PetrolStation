namespace GasStation.Forms.Forms
{
	partial class CustomerViewForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.اطلاعاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.insertMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.customerTabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serachButton = new System.Windows.Forms.Button();
            this.nationalCodeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nationalCodeRadioButton = new System.Windows.Forms.RadioButton();
            this.resultGrid = new System.Windows.Forms.DataGridView();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.mainMenu.SuspendLayout();
            this.customerTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // اطلاعاتToolStripMenuItem
            // 
            this.اطلاعاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadMenu,
            this.toolStripSeparator1,
            this.insertMenu,
            this.modifyMenu,
            this.deleteMenu,
            this.toolStripMenuItem1,
            this.exitMenu});
            this.اطلاعاتToolStripMenuItem.Name = "اطلاعاتToolStripMenuItem";
            this.اطلاعاتToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.اطلاعاتToolStripMenuItem.Text = "اطلاعات";
            // 
            // reloadMenu
            // 
            this.reloadMenu.Name = "reloadMenu";
            this.reloadMenu.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.reloadMenu.Size = new System.Drawing.Size(181, 22);
            this.reloadMenu.Text = "بازخوانی اطلاعات";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // insertMenu
            // 
            this.insertMenu.Name = "insertMenu";
            this.insertMenu.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.insertMenu.Size = new System.Drawing.Size(181, 22);
            this.insertMenu.Text = "ثبت رکورد جدید";
            // 
            // modifyMenu
            // 
            this.modifyMenu.Name = "modifyMenu";
            this.modifyMenu.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.modifyMenu.Size = new System.Drawing.Size(181, 22);
            this.modifyMenu.Text = "ویرایش رکورد ";
            // 
            // deleteMenu
            // 
            this.deleteMenu.Name = "deleteMenu";
            this.deleteMenu.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.deleteMenu.Size = new System.Drawing.Size(181, 22);
            this.deleteMenu.Text = "حذف رکورد";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 6);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.exitMenu.Size = new System.Drawing.Size(181, 22);
            this.exitMenu.Text = "خروج";
            // 
            // mainMenu
            // 
            this.mainMenu.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اطلاعاتToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(782, 24);
            this.mainMenu.TabIndex = 0;
            // 
            // customerTabPage
            // 
            this.customerTabPage.Controls.Add(this.groupBox1);
            this.customerTabPage.Controls.Add(this.resultGrid);
            this.customerTabPage.Location = new System.Drawing.Point(4, 23);
            this.customerTabPage.Name = "customerTabPage";
            this.customerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.customerTabPage.Size = new System.Drawing.Size(750, 465);
            this.customerTabPage.TabIndex = 0;
            this.customerTabPage.Text = "مشتریان ثبت شده";
            this.customerTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.serachButton);
            this.groupBox1.Controls.Add(this.nationalCodeMaskedTextBox);
            this.groupBox1.Controls.Add(this.nationalCodeRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(19, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 68);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو براساس";
            // 
            // serachButton
            // 
            this.serachButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serachButton.Location = new System.Drawing.Point(182, 20);
            this.serachButton.Name = "serachButton";
            this.serachButton.Size = new System.Drawing.Size(95, 39);
            this.serachButton.TabIndex = 2;
            this.serachButton.Text = "جستجو";
            this.serachButton.UseVisualStyleBackColor = true;
            // 
            // nationalCodeMaskedTextBox
            // 
            this.nationalCodeMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nationalCodeMaskedTextBox.Location = new System.Drawing.Point(366, 27);
            this.nationalCodeMaskedTextBox.Mask = "0000000000";
            this.nationalCodeMaskedTextBox.Name = "nationalCodeMaskedTextBox";
            this.nationalCodeMaskedTextBox.Size = new System.Drawing.Size(203, 22);
            this.nationalCodeMaskedTextBox.TabIndex = 1;
            this.nationalCodeMaskedTextBox.Tag = "nationalCode";
            this.nationalCodeMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nationalCodeRadioButton
            // 
            this.nationalCodeRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nationalCodeRadioButton.AutoSize = true;
            this.nationalCodeRadioButton.Location = new System.Drawing.Point(625, 28);
            this.nationalCodeRadioButton.Name = "nationalCodeRadioButton";
            this.nationalCodeRadioButton.Size = new System.Drawing.Size(64, 18);
            this.nationalCodeRadioButton.TabIndex = 0;
            this.nationalCodeRadioButton.TabStop = true;
            this.nationalCodeRadioButton.Text = "کد ملی";
            this.nationalCodeRadioButton.UseVisualStyleBackColor = true;
            // 
            // resultGrid
            // 
            this.resultGrid.AllowUserToAddRows = false;
            this.resultGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.resultGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.resultGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultGrid.BackgroundColor = System.Drawing.Color.White;
            this.resultGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.resultGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.resultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGrid.Location = new System.Drawing.Point(15, 89);
            this.resultGrid.MultiSelect = false;
            this.resultGrid.Name = "resultGrid";
            this.resultGrid.ReadOnly = true;
            this.resultGrid.RowTemplate.Height = 24;
            this.resultGrid.Size = new System.Drawing.Size(721, 359);
            this.resultGrid.TabIndex = 0;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.customerTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(12, 31);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.RightToLeftLayout = true;
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(758, 492);
            this.mainTabControl.TabIndex = 0;
            // 
            // CustomerViewForm
            // 
            this.AcceptButton = this.serachButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 535);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.mainMenu);
            this.Name = "CustomerViewForm";
            this.Text = "مشاهده اطلاعات مشتریان";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.customerTabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.ToolStripMenuItem اطلاعاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem insertMenu;
        private System.Windows.Forms.ToolStripMenuItem modifyMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.TabPage customerTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button serachButton;
        private System.Windows.Forms.MaskedTextBox nationalCodeMaskedTextBox;
        private System.Windows.Forms.RadioButton nationalCodeRadioButton;
        private System.Windows.Forms.DataGridView resultGrid;
        private System.Windows.Forms.TabControl mainTabControl;
    }
}