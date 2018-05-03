namespace PetrolStation.Forms.Forms
{
	partial class CumulativeForm
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
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.begindateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.endDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.yearRadioButton = new System.Windows.Forms.RadioButton();
            this.monthRadioButton = new System.Windows.Forms.RadioButton();
            this.printButton = new System.Windows.Forms.Button();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.resultGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.antennaComboBox = new System.Windows.Forms.ComboBox();
            this.dataGroupBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGroupBox.Controls.Add(this.antennaComboBox);
            this.dataGroupBox.Controls.Add(this.label4);
            this.dataGroupBox.Controls.Add(this.flowLayoutPanel1);
            this.dataGroupBox.Controls.Add(this.yearTextBox);
            this.dataGroupBox.Controls.Add(this.yearRadioButton);
            this.dataGroupBox.Controls.Add(this.monthRadioButton);
            this.dataGroupBox.Controls.Add(this.printButton);
            this.dataGroupBox.Controls.Add(this.monthComboBox);
            this.dataGroupBox.Controls.Add(this.numberTextBox);
            this.dataGroupBox.Controls.Add(this.label3);
            this.dataGroupBox.Controls.Add(this.startButton);
            this.dataGroupBox.Location = new System.Drawing.Point(12, 12);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Size = new System.Drawing.Size(756, 147);
            this.dataGroupBox.TabIndex = 0;
            this.dataGroupBox.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.begindateTextBox);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.endDateTextBox);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(218, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(223, 60);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // begindateTextBox
            // 
            this.begindateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.begindateTextBox.Location = new System.Drawing.Point(3, 3);
            this.begindateTextBox.Mask = "0000/00/00";
            this.begindateTextBox.Name = "begindateTextBox";
            this.begindateTextBox.Size = new System.Drawing.Size(137, 22);
            this.begindateTextBox.TabIndex = 16;
            this.begindateTextBox.Text = "13960101";
            this.begindateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.begindateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 14);
            this.label1.TabIndex = 18;
            this.label1.Text = "از تاریخ:";
            // 
            // endDateTextBox
            // 
            this.endDateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endDateTextBox.Location = new System.Drawing.Point(3, 31);
            this.endDateTextBox.Mask = "0000/00/00";
            this.endDateTextBox.Name = "endDateTextBox";
            this.endDateTextBox.Size = new System.Drawing.Size(137, 22);
            this.endDateTextBox.TabIndex = 17;
            this.endDateTextBox.Text = "13960101";
            this.endDateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.endDateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 14);
            this.label2.TabIndex = 19;
            this.label2.Text = "تا تاریخ:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yearTextBox.Location = new System.Drawing.Point(447, 75);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(140, 22);
            this.yearTextBox.TabIndex = 15;
            this.yearTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yearRadioButton
            // 
            this.yearRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yearRadioButton.AutoSize = true;
            this.yearRadioButton.Location = new System.Drawing.Point(593, 75);
            this.yearRadioButton.Name = "yearRadioButton";
            this.yearRadioButton.Size = new System.Drawing.Size(126, 18);
            this.yearRadioButton.TabIndex = 14;
            this.yearRadioButton.Text = "قرعه کشی در سال";
            this.yearRadioButton.UseVisualStyleBackColor = true;
            // 
            // monthRadioButton
            // 
            this.monthRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthRadioButton.AutoSize = true;
            this.monthRadioButton.Checked = true;
            this.monthRadioButton.Location = new System.Drawing.Point(601, 50);
            this.monthRadioButton.Name = "monthRadioButton";
            this.monthRadioButton.Size = new System.Drawing.Size(118, 18);
            this.monthRadioButton.TabIndex = 13;
            this.monthRadioButton.TabStop = true;
            this.monthRadioButton.Text = "قرعه کشی در ماه";
            this.monthRadioButton.UseVisualStyleBackColor = true;
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.White;
            this.printButton.Location = new System.Drawing.Point(22, 62);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(170, 35);
            this.printButton.TabIndex = 12;
            this.printButton.Text = "چاپ";
            this.printButton.UseVisualStyleBackColor = false;
            // 
            // monthComboBox
            // 
            this.monthComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "فروردین",
            "اردیبهشت"});
            this.monthComboBox.Location = new System.Drawing.Point(447, 49);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(140, 22);
            this.monthComboBox.TabIndex = 11;
            this.monthComboBox.Tag = "code";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numberTextBox.Location = new System.Drawing.Point(447, 21);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(140, 22);
            this.numberTextBox.TabIndex = 10;
            this.numberTextBox.Text = "10";
            this.numberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "تعداد افراد:";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.startButton.Location = new System.Drawing.Point(22, 21);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(170, 35);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "شروع";
            this.startButton.UseVisualStyleBackColor = false;
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
            this.resultGrid.Location = new System.Drawing.Point(8, 178);
            this.resultGrid.MultiSelect = false;
            this.resultGrid.Name = "resultGrid";
            this.resultGrid.ReadOnly = true;
            this.resultGrid.RowTemplate.Height = 24;
            this.resultGrid.Size = new System.Drawing.Size(760, 404);
            this.resultGrid.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 14);
            this.label4.TabIndex = 19;
            this.label4.Text = "نام آنتن";
            // 
            // antennaComboBox
            // 
            this.antennaComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.antennaComboBox.FormattingEnabled = true;
            this.antennaComboBox.Location = new System.Drawing.Point(218, 18);
            this.antennaComboBox.Name = "antennaComboBox";
            this.antennaComboBox.Size = new System.Drawing.Size(140, 22);
            this.antennaComboBox.TabIndex = 20;
            this.antennaComboBox.Tag = "";
            // 
            // CumulativeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 587);
            this.Controls.Add(this.dataGroupBox);
            this.Controls.Add(this.resultGrid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CumulativeForm";
            this.Text = "قرعه کشی";
            this.dataGroupBox.ResumeLayout(false);
            this.dataGroupBox.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox dataGroupBox;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.TextBox numberTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.DataGridView resultGrid;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.RadioButton yearRadioButton;
        private System.Windows.Forms.RadioButton monthRadioButton;
        private System.Windows.Forms.MaskedTextBox begindateTextBox;
        private System.Windows.Forms.MaskedTextBox endDateTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox antennaComboBox;
        private System.Windows.Forms.Label label4;
    }
}