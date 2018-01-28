namespace GasStation.Forms.Base
{
	partial class CarFuelEntryForm
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
			this.saveButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.dataGroupBox = new System.Windows.Forms.GroupBox();
			this.fuelTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.saveButton.Location = new System.Drawing.Point(133, 131);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(114, 33);
			this.saveButton.TabIndex = 1;
			this.saveButton.Text = "ثبت";
			this.saveButton.UseVisualStyleBackColor = true;
			// 
			// exitButton
			// 
			this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.exitButton.Location = new System.Drawing.Point(13, 131);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(114, 33);
			this.exitButton.TabIndex = 2;
			this.exitButton.Text = "خروج";
			this.exitButton.UseVisualStyleBackColor = true;
			// 
			// dataGroupBox
			// 
			this.dataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGroupBox.Controls.Add(this.fuelTextBox);
			this.dataGroupBox.Controls.Add(this.label1);
			this.dataGroupBox.Location = new System.Drawing.Point(12, 9);
			this.dataGroupBox.Name = "dataGroupBox";
			this.dataGroupBox.Size = new System.Drawing.Size(352, 116);
			this.dataGroupBox.TabIndex = 0;
			this.dataGroupBox.TabStop = false;
			this.dataGroupBox.Text = "اطلاعات پایه";
			// 
			// fuelTextBox
			// 
			this.fuelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.fuelTextBox.Location = new System.Drawing.Point(20, 59);
			this.fuelTextBox.MaxLength = 50;
			this.fuelTextBox.Name = "fuelTextBox";
			this.fuelTextBox.Size = new System.Drawing.Size(298, 26);
			this.fuelTextBox.TabIndex = 0;
			this.fuelTextBox.Tag = "fuel";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(227, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "سوخت خودرو";
			// 
			// CarFuelEntryForm
			// 
			this.AcceptButton = this.saveButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.CancelButton = this.exitButton;
			this.ClientSize = new System.Drawing.Size(376, 176);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.dataGroupBox);
			this.Font = new System.Drawing.Font("Tahoma", 9F);
			this.Name = "CarFuelEntryForm";
			this.Text = "ثبت اطلاعات / سوخت خودرو ";
			this.dataGroupBox.ResumeLayout(false);
			this.dataGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox dataGroupBox;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.TextBox fuelTextBox;
		private System.Windows.Forms.Label label1;
	}
}