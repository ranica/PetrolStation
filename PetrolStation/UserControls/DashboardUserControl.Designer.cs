namespace PetrolStation.UserControls
{
    partial class DashboardUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.countTrafficGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.countTrafficGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // countTrafficGrid
            // 
            this.countTrafficGrid.AllowUserToAddRows = false;
            this.countTrafficGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            this.countTrafficGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.countTrafficGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countTrafficGrid.BackgroundColor = System.Drawing.Color.White;
            this.countTrafficGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.countTrafficGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.countTrafficGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countTrafficGrid.Location = new System.Drawing.Point(10, 10);
            this.countTrafficGrid.Margin = new System.Windows.Forms.Padding(2);
            this.countTrafficGrid.MultiSelect = false;
            this.countTrafficGrid.Name = "countTrafficGrid";
            this.countTrafficGrid.ReadOnly = true;
            this.countTrafficGrid.RowHeadersWidth = 20;
            this.countTrafficGrid.RowTemplate.Height = 24;
            this.countTrafficGrid.Size = new System.Drawing.Size(373, 489);
            this.countTrafficGrid.TabIndex = 5;
            // 
            // DashboardUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.countTrafficGrid);
            this.Name = "DashboardUserControl";
            this.Size = new System.Drawing.Size(398, 509);
            ((System.ComponentModel.ISupportInitialize)(this.countTrafficGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView countTrafficGrid;
    }
}
