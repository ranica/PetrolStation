namespace GasStation.UserControls
{
	partial class StateTrafficUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.stateTrafficGrid = new System.Windows.Forms.DataGridView();
            this.pageSizeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pageIndexComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.stateTrafficGrid)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stateTrafficGrid
            // 
            this.stateTrafficGrid.AllowUserToAddRows = false;
            this.stateTrafficGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.stateTrafficGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.stateTrafficGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stateTrafficGrid.BackgroundColor = System.Drawing.Color.White;
            this.stateTrafficGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.stateTrafficGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.stateTrafficGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stateTrafficGrid.Location = new System.Drawing.Point(10, 38);
            this.stateTrafficGrid.Margin = new System.Windows.Forms.Padding(2);
            this.stateTrafficGrid.MultiSelect = false;
            this.stateTrafficGrid.Name = "stateTrafficGrid";
            this.stateTrafficGrid.ReadOnly = true;
            this.stateTrafficGrid.RowTemplate.Height = 24;
            this.stateTrafficGrid.Size = new System.Drawing.Size(683, 261);
            this.stateTrafficGrid.TabIndex = 3;
            // 
            // pageSizeComboBox
            // 
            this.pageSizeComboBox.FormattingEnabled = true;
            this.pageSizeComboBox.Items.AddRange(new object[] {
            "10"});
            this.pageSizeComboBox.Location = new System.Drawing.Point(344, 9);
            this.pageSizeComboBox.Name = "pageSizeComboBox";
            this.pageSizeComboBox.Size = new System.Drawing.Size(53, 21);
            this.pageSizeComboBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "تعداد سطرهای قابل نمایش";
            // 
            // pageIndexComboBox
            // 
            this.pageIndexComboBox.FormattingEnabled = true;
            this.pageIndexComboBox.Items.AddRange(new object[] {
            "1"});
            this.pageIndexComboBox.Location = new System.Drawing.Point(562, 9);
            this.pageIndexComboBox.Name = "pageIndexComboBox";
            this.pageIndexComboBox.Size = new System.Drawing.Size(56, 21);
            this.pageIndexComboBox.TabIndex = 15;
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(624, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "شماره صفحه";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(68, 3);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(57, 37);
            this.nextButton.TabIndex = 16;
            this.nextButton.Text = "بعدی";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(6, 3);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(56, 37);
            this.previousButton.TabIndex = 17;
            this.previousButton.Text = "قبلی";
            this.previousButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.nextButton);
            this.flowLayoutPanel1.Controls.Add(this.previousButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 304);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(128, 44);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // StateTrafficUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pageSizeComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pageIndexComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stateTrafficGrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StateTrafficUserControl";
            this.Size = new System.Drawing.Size(699, 354);
            ((System.ComponentModel.ISupportInitialize)(this.stateTrafficGrid)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView stateTrafficGrid;
        private System.Windows.Forms.ComboBox pageSizeComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox pageIndexComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
