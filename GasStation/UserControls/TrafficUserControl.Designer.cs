namespace GasStation.UserControls
{
	partial class TrafficUserControl
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
			this.trafficGrid = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.trafficGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// trafficGrid
			// 
			this.trafficGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.trafficGrid.BackgroundColor = System.Drawing.Color.White;
			this.trafficGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.trafficGrid.Location = new System.Drawing.Point(13, 9);
			this.trafficGrid.Name = "trafficGrid";
			this.trafficGrid.RowTemplate.Height = 24;
			this.trafficGrid.Size = new System.Drawing.Size(820, 286);
			this.trafficGrid.TabIndex = 0;
			// 
			// TrafficUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.trafficGrid);
			this.Name = "TrafficUserControl";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Size = new System.Drawing.Size(854, 308);
			((System.ComponentModel.ISupportInitialize)(this.trafficGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView trafficGrid;
	}
}
