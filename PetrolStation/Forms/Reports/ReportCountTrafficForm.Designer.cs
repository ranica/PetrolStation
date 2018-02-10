namespace PetrolStation.Forms.Reports
{
    partial class ReportCountTrafficForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.nationalCodeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.pageSizeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.pageIndexComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.dateEndMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dateStartMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.countTabPage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.plateDataGroupBox.SuspendLayout();
            this.mainPlatePanel.SuspendLayout();
            this.motorPlatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.malulinPlatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.pageSizeComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.typeComboBox);
            this.groupBox1.Controls.Add(this.pageIndexComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.showButton);
            this.groupBox1.Controls.Add(this.dateEndMaskedTextBox);
            this.groupBox1.Controls.Add(this.dateStartMaskedTextBox);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(843, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "گزارش گیری براساس";
            // 
            // plateDataGroupBox
            // 
            this.plateDataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plateDataGroupBox.Controls.Add(this.mainPlatePanel);
            this.plateDataGroupBox.Controls.Add(this.plateTypeComboBox);
            this.plateDataGroupBox.Controls.Add(this.malulinPlatePanel);
            this.plateDataGroupBox.Controls.Add(this.motorPlatePanel);
            this.plateDataGroupBox.Location = new System.Drawing.Point(9, 3);
            this.plateDataGroupBox.Name = "plateDataGroupBox";
            this.plateDataGroupBox.Size = new System.Drawing.Size(256, 80);
            this.plateDataGroupBox.TabIndex = 0;
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
            this.mainPlatePanel.Location = new System.Drawing.Point(5, 41);
            this.mainPlatePanel.Name = "mainPlatePanel";
            this.mainPlatePanel.Size = new System.Drawing.Size(246, 37);
            this.mainPlatePanel.TabIndex = 0;
            // 
            // code1Numeric
            // 
            this.code1Numeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.code1Numeric.Location = new System.Drawing.Point(194, 7);
            this.code1Numeric.Name = "code1Numeric";
            this.code1Numeric.Size = new System.Drawing.Size(49, 22);
            this.code1Numeric.TabIndex = 3;
            this.code1Numeric.Tag = "plateCityId";
            this.code1Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // part2MainTextBox
            // 
            this.part2MainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.part2MainTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.part2MainTextBox.Location = new System.Drawing.Point(133, 7);
            this.part2MainTextBox.MaxLength = 3;
            this.part2MainTextBox.Name = "part2MainTextBox";
            this.part2MainTextBox.Size = new System.Drawing.Size(56, 22);
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
            this.characterDomainUpDown.Location = new System.Drawing.Point(72, 7);
            this.characterDomainUpDown.Name = "characterDomainUpDown";
            this.characterDomainUpDown.Size = new System.Drawing.Size(57, 22);
            this.characterDomainUpDown.TabIndex = 1;
            this.characterDomainUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // part1MainTextBox
            // 
            this.part1MainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.part1MainTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.part1MainTextBox.Location = new System.Drawing.Point(5, 7);
            this.part1MainTextBox.MaxLength = 2;
            this.part1MainTextBox.Name = "part1MainTextBox";
            this.part1MainTextBox.Size = new System.Drawing.Size(61, 22);
            this.part1MainTextBox.TabIndex = 0;
            this.part1MainTextBox.Tag = "";
            this.part1MainTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // plateTypeComboBox
            // 
            this.plateTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plateTypeComboBox.FormattingEnabled = true;
            this.plateTypeComboBox.Location = new System.Drawing.Point(64, 12);
            this.plateTypeComboBox.Name = "plateTypeComboBox";
            this.plateTypeComboBox.Size = new System.Drawing.Size(186, 22);
            this.plateTypeComboBox.TabIndex = 0;
            this.plateTypeComboBox.Tag = "plateTypeId";
            // 
            // motorPlatePanel
            // 
            this.motorPlatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.motorPlatePanel.Controls.Add(this.pictureBox2);
            this.motorPlatePanel.Controls.Add(this.part2MotorTextBox);
            this.motorPlatePanel.Controls.Add(this.part1MotorTextBox);
            this.motorPlatePanel.Location = new System.Drawing.Point(10, 40);
            this.motorPlatePanel.Name = "motorPlatePanel";
            this.motorPlatePanel.Size = new System.Drawing.Size(240, 35);
            this.motorPlatePanel.TabIndex = 0;
            this.motorPlatePanel.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = global::PetrolStation.Properties.Resources.motor;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(100, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 32);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // part2MotorTextBox
            // 
            this.part2MotorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.part2MotorTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.part2MotorTextBox.Location = new System.Drawing.Point(155, 6);
            this.part2MotorTextBox.MaxLength = 6;
            this.part2MotorTextBox.Name = "part2MotorTextBox";
            this.part2MotorTextBox.Size = new System.Drawing.Size(67, 22);
            this.part2MotorTextBox.TabIndex = 1;
            this.part2MotorTextBox.Tag = "";
            this.part2MotorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // part1MotorTextBox
            // 
            this.part1MotorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.part1MotorTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.part1MotorTextBox.Location = new System.Drawing.Point(17, 6);
            this.part1MotorTextBox.MaxLength = 6;
            this.part1MotorTextBox.Name = "part1MotorTextBox";
            this.part1MotorTextBox.Size = new System.Drawing.Size(67, 22);
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
            this.malulinPlatePanel.Location = new System.Drawing.Point(6, 41);
            this.malulinPlatePanel.Name = "malulinPlatePanel";
            this.malulinPlatePanel.Size = new System.Drawing.Size(245, 37);
            this.malulinPlatePanel.TabIndex = 0;
            this.malulinPlatePanel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::PetrolStation.Properties.Resources.malulin_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(71, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 35);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // code2Numeric
            // 
            this.code2Numeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.code2Numeric.Items.Add("79");
            this.code2Numeric.Location = new System.Drawing.Point(191, 5);
            this.code2Numeric.Name = "code2Numeric";
            this.code2Numeric.Size = new System.Drawing.Size(49, 22);
            this.code2Numeric.TabIndex = 2;
            this.code2Numeric.Tag = "plateCityId";
            this.code2Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // part2MaluinTextBox
            // 
            this.part2MaluinTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.part2MaluinTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.part2MaluinTextBox.Location = new System.Drawing.Point(121, 5);
            this.part2MaluinTextBox.MaxLength = 3;
            this.part2MaluinTextBox.Name = "part2MaluinTextBox";
            this.part2MaluinTextBox.Size = new System.Drawing.Size(67, 22);
            this.part2MaluinTextBox.TabIndex = 1;
            this.part2MaluinTextBox.Tag = "";
            this.part2MaluinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // part1MalulinTextBox
            // 
            this.part1MalulinTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.part1MalulinTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.part1MalulinTextBox.Location = new System.Drawing.Point(6, 5);
            this.part1MalulinTextBox.MaxLength = 2;
            this.part1MalulinTextBox.Name = "part1MalulinTextBox";
            this.part1MalulinTextBox.Size = new System.Drawing.Size(60, 22);
            this.part1MalulinTextBox.TabIndex = 0;
            this.part1MalulinTextBox.Tag = "";
            this.part1MalulinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.plateDataGroupBox);
            this.flowLayoutPanel1.Controls.Add(this.nationalCodeMaskedTextBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(254, 53);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(268, 111);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // nationalCodeMaskedTextBox
            // 
            this.nationalCodeMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nationalCodeMaskedTextBox.Location = new System.Drawing.Point(79, 89);
            this.nationalCodeMaskedTextBox.Mask = "0000000000";
            this.nationalCodeMaskedTextBox.Name = "nationalCodeMaskedTextBox";
            this.nationalCodeMaskedTextBox.Size = new System.Drawing.Size(186, 22);
            this.nationalCodeMaskedTextBox.TabIndex = 0;
            this.nationalCodeMaskedTextBox.Tag = "nationalCode";
            this.nationalCodeMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nationalCodeMaskedTextBox.Visible = false;
            // 
            // pageSizeComboBox
            // 
            this.pageSizeComboBox.FormattingEnabled = true;
            this.pageSizeComboBox.Items.AddRange(new object[] {
            "10",
            "20",
            "50"});
            this.pageSizeComboBox.Location = new System.Drawing.Point(6, 94);
            this.pageSizeComboBox.Name = "pageSizeComboBox";
            this.pageSizeComboBox.Size = new System.Drawing.Size(56, 22);
            this.pageSizeComboBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "تعداد سطرهای قابل نمایش";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "براساس:";
            // 
            // typeComboBox
            // 
            this.typeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "انتخاب کنید...",
            "کد ملی",
            "پلاک خودرو"});
            this.typeComboBox.Location = new System.Drawing.Point(333, 25);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(186, 22);
            this.typeComboBox.TabIndex = 2;
            // 
            // pageIndexComboBox
            // 
            this.pageIndexComboBox.FormattingEnabled = true;
            this.pageIndexComboBox.Items.AddRange(new object[] {
            "1"});
            this.pageIndexComboBox.Location = new System.Drawing.Point(6, 66);
            this.pageIndexComboBox.Name = "pageIndexComboBox";
            this.pageIndexComboBox.Size = new System.Drawing.Size(56, 22);
            this.pageIndexComboBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "شماره صفحه";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(773, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "تا تاریخ:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(773, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "از تاریخ:";
            // 
            // showButton
            // 
            this.showButton.ForeColor = System.Drawing.Color.Black;
            this.showButton.Location = new System.Drawing.Point(6, 19);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(129, 34);
            this.showButton.TabIndex = 3;
            this.showButton.Text = "نمایش";
            this.showButton.UseVisualStyleBackColor = true;
            // 
            // dateEndMaskedTextBox
            // 
            this.dateEndMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEndMaskedTextBox.Location = new System.Drawing.Point(640, 55);
            this.dateEndMaskedTextBox.Mask = "0000/00/00";
            this.dateEndMaskedTextBox.Name = "dateEndMaskedTextBox";
            this.dateEndMaskedTextBox.Size = new System.Drawing.Size(127, 22);
            this.dateEndMaskedTextBox.TabIndex = 1;
            this.dateEndMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateStartMaskedTextBox
            // 
            this.dateStartMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateStartMaskedTextBox.Location = new System.Drawing.Point(640, 27);
            this.dateStartMaskedTextBox.Mask = "0000/00/00";
            this.dateStartMaskedTextBox.Name = "dateStartMaskedTextBox";
            this.dateStartMaskedTextBox.Size = new System.Drawing.Size(127, 22);
            this.dateStartMaskedTextBox.TabIndex = 0;
            this.dateStartMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.countTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(10, 195);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.RightToLeftLayout = true;
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(837, 346);
            this.mainTabControl.TabIndex = 7;
            // 
            // countTabPage
            // 
            this.countTabPage.Location = new System.Drawing.Point(4, 23);
            this.countTabPage.Name = "countTabPage";
            this.countTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.countTabPage.Size = new System.Drawing.Size(829, 319);
            this.countTabPage.TabIndex = 1;
            this.countTabPage.Text = "تعداد تردد";
            this.countTabPage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel2.Controls.Add(this.nextButton);
            this.flowLayoutPanel2.Controls.Add(this.previousButton);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 545);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(128, 44);
            this.flowLayoutPanel2.TabIndex = 20;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(3, 3);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(57, 37);
            this.nextButton.TabIndex = 16;
            this.nextButton.Text = "بعدی";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(66, 3);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(56, 37);
            this.previousButton.TabIndex = 17;
            this.previousButton.Text = "قبلی";
            this.previousButton.UseVisualStyleBackColor = true;
            // 
            // ReportCountTrafficForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(856, 595);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "ReportCountTrafficForm";
            this.Text = "گزارش تعداد تردد ها";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportTrafficForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.plateDataGroupBox.ResumeLayout(false);
            this.mainPlatePanel.ResumeLayout(false);
            this.mainPlatePanel.PerformLayout();
            this.motorPlatePanel.ResumeLayout(false);
            this.motorPlatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.malulinPlatePanel.ResumeLayout(false);
            this.malulinPlatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage countTabPage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MaskedTextBox nationalCodeMaskedTextBox;
        private System.Windows.Forms.ComboBox pageSizeComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ComboBox pageIndexComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.MaskedTextBox dateEndMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox dateStartMaskedTextBox;
    }
}