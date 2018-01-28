namespace GasStation.UserControls
{
	partial class OwnerUserControl
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
			this.ownerGrid = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.ownerGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// ownerGrid
			// 
			this.ownerGrid.AllowUserToAddRows = false;
			this.ownerGrid.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
			this.ownerGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.ownerGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ownerGrid.BackgroundColor = System.Drawing.Color.White;
			this.ownerGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.ownerGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.ownerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ownerGrid.Location = new System.Drawing.Point(11, 6);
			this.ownerGrid.MultiSelect = false;
			this.ownerGrid.Name = "ownerGrid";
			this.ownerGrid.ReadOnly = true;
			this.ownerGrid.RowTemplate.Height = 24;
			this.ownerGrid.Size = new System.Drawing.Size(839, 295);
			this.ownerGrid.TabIndex = 2;
			// 
			// OwnerUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ownerGrid);
			this.Name = "OwnerUserControl";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Size = new System.Drawing.Size(854, 308);
			((System.ComponentModel.ISupportInitialize)(this.ownerGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView ownerGrid;

	}
}
