namespace GasStation.UserControls
{
	partial class CarUserControl
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.carGrid = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.carGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// carGrid
			// 
			this.carGrid.AllowUserToAddRows = false;
			this.carGrid.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
			this.carGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.carGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.carGrid.BackgroundColor = System.Drawing.Color.White;
			this.carGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.carGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.carGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.carGrid.Location = new System.Drawing.Point(5, 4);
			this.carGrid.MultiSelect = false;
			this.carGrid.Name = "carGrid";
			this.carGrid.ReadOnly = true;
			this.carGrid.RowTemplate.Height = 24;
			this.carGrid.Size = new System.Drawing.Size(839, 295);
			this.carGrid.TabIndex = 1;
			// 
			// CarUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.carGrid);
			this.Name = "CarUserControl";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Size = new System.Drawing.Size(854, 308);
			((System.ComponentModel.ISupportInitialize)(this.carGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView carGrid;

	}
}
