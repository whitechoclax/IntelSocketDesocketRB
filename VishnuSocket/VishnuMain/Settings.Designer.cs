namespace VishnuMain
{
    partial class SettingsMenu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.trayCenter2CenterValueCol = new System.Windows.Forms.NumericUpDown();
            this.trayOr2CenterValueY = new System.Windows.Forms.NumericUpDown();
            this.trayHeightValue = new System.Windows.Forms.NumericUpDown();
            this.trayCenter2CenterValueRow = new System.Windows.Forms.NumericUpDown();
            this.trayOr2CenterValueX = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trayStackValue = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trayWidthValue = new System.Windows.Forms.NumericUpDown();
            this.trayLengthValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.invManagerBox = new System.Windows.Forms.GroupBox();
            this.isCompressedFile = new System.Windows.Forms.CheckBox();
            this.xmlSaveFileButton = new System.Windows.Forms.Button();
            this.inventorySaveFileButton = new System.Windows.Forms.Button();
            this.xmlPathTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.invPathTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.xmlSaveButton = new System.Windows.Forms.Button();
            this.loadxmlButton = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.componentBox = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trayCenter2CenterValueCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trayOr2CenterValueY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trayHeightValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trayCenter2CenterValueRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trayOr2CenterValueX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trayStackValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trayWidthValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trayLengthValue)).BeginInit();
            this.invManagerBox.SuspendLayout();
            this.componentBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.trayCenter2CenterValueCol);
            this.groupBox1.Controls.Add(this.trayOr2CenterValueY);
            this.groupBox1.Controls.Add(this.trayHeightValue);
            this.groupBox1.Controls.Add(this.trayCenter2CenterValueRow);
            this.groupBox1.Controls.Add(this.trayOr2CenterValueX);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.trayStackValue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.trayWidthValue);
            this.groupBox1.Controls.Add(this.trayLengthValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(249, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tray Properties";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Tray Center-Center Col (mm)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Tray Origin to center Y (mm)";
            // 
            // trayCenter2CenterValueCol
            // 
            this.trayCenter2CenterValueCol.DecimalPlaces = 3;
            this.trayCenter2CenterValueCol.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.trayCenter2CenterValueCol.Location = new System.Drawing.Point(153, 243);
            this.trayCenter2CenterValueCol.Name = "trayCenter2CenterValueCol";
            this.trayCenter2CenterValueCol.Size = new System.Drawing.Size(80, 20);
            this.trayCenter2CenterValueCol.TabIndex = 14;
            this.trayCenter2CenterValueCol.ValueChanged += new System.EventHandler(this.trayCenter2CenterValueCol_ValueChanged);
            // 
            // trayOr2CenterValueY
            // 
            this.trayOr2CenterValueY.DecimalPlaces = 3;
            this.trayOr2CenterValueY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.trayOr2CenterValueY.Location = new System.Drawing.Point(153, 193);
            this.trayOr2CenterValueY.Name = "trayOr2CenterValueY";
            this.trayOr2CenterValueY.Size = new System.Drawing.Size(80, 20);
            this.trayOr2CenterValueY.TabIndex = 13;
            this.trayOr2CenterValueY.ValueChanged += new System.EventHandler(this.trayOr2CenterValueY_ValueChanged);
            // 
            // trayHeightValue
            // 
            this.trayHeightValue.DecimalPlaces = 3;
            this.trayHeightValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.trayHeightValue.Location = new System.Drawing.Point(152, 268);
            this.trayHeightValue.Margin = new System.Windows.Forms.Padding(2);
            this.trayHeightValue.Name = "trayHeightValue";
            this.trayHeightValue.Size = new System.Drawing.Size(80, 20);
            this.trayHeightValue.TabIndex = 12;
            this.trayHeightValue.ValueChanged += new System.EventHandler(this.trayHeightValue_ValueChanged);
            // 
            // trayCenter2CenterValueRow
            // 
            this.trayCenter2CenterValueRow.DecimalPlaces = 3;
            this.trayCenter2CenterValueRow.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.trayCenter2CenterValueRow.Location = new System.Drawing.Point(152, 218);
            this.trayCenter2CenterValueRow.Margin = new System.Windows.Forms.Padding(2);
            this.trayCenter2CenterValueRow.Name = "trayCenter2CenterValueRow";
            this.trayCenter2CenterValueRow.Size = new System.Drawing.Size(80, 20);
            this.trayCenter2CenterValueRow.TabIndex = 11;
            this.trayCenter2CenterValueRow.ValueChanged += new System.EventHandler(this.trayCenter2CenterValue_ValueChanged);
            // 
            // trayOr2CenterValueX
            // 
            this.trayOr2CenterValueX.DecimalPlaces = 3;
            this.trayOr2CenterValueX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.trayOr2CenterValueX.Location = new System.Drawing.Point(153, 168);
            this.trayOr2CenterValueX.Margin = new System.Windows.Forms.Padding(2);
            this.trayOr2CenterValueX.Name = "trayOr2CenterValueX";
            this.trayOr2CenterValueX.Size = new System.Drawing.Size(80, 20);
            this.trayOr2CenterValueX.TabIndex = 10;
            this.trayOr2CenterValueX.ValueChanged += new System.EventHandler(this.trayOr2CenterValue_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 270);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tray Height (mm)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 220);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tray Center-Center Row (mm)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 170);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tray Origin to center X (mm)";
            // 
            // trayStackValue
            // 
            this.trayStackValue.Location = new System.Drawing.Point(152, 115);
            this.trayStackValue.Margin = new System.Windows.Forms.Padding(2);
            this.trayStackValue.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.trayStackValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.trayStackValue.Name = "trayStackValue";
            this.trayStackValue.Size = new System.Drawing.Size(80, 20);
            this.trayStackValue.TabIndex = 6;
            this.trayStackValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.trayStackValue.ValueChanged += new System.EventHandler(this.trayStackValue_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tray Height (Stack of trays)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tray Width (in # of chips)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tray Length (in # of chips)";
            // 
            // trayWidthValue
            // 
            this.trayWidthValue.Location = new System.Drawing.Point(152, 89);
            this.trayWidthValue.Margin = new System.Windows.Forms.Padding(2);
            this.trayWidthValue.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.trayWidthValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.trayWidthValue.Name = "trayWidthValue";
            this.trayWidthValue.Size = new System.Drawing.Size(80, 20);
            this.trayWidthValue.TabIndex = 2;
            this.trayWidthValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.trayWidthValue.ValueChanged += new System.EventHandler(this.trayWidthValue_ValueChanged);
            // 
            // trayLengthValue
            // 
            this.trayLengthValue.Location = new System.Drawing.Point(152, 60);
            this.trayLengthValue.Margin = new System.Windows.Forms.Padding(2);
            this.trayLengthValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.trayLengthValue.Name = "trayLengthValue";
            this.trayLengthValue.Size = new System.Drawing.Size(80, 20);
            this.trayLengthValue.TabIndex = 1;
            this.trayLengthValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.trayLengthValue.ValueChanged += new System.EventHandler(this.trayLengthValue_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tray Dimensions";
            // 
            // invManagerBox
            // 
            this.invManagerBox.Controls.Add(this.isCompressedFile);
            this.invManagerBox.Controls.Add(this.xmlSaveFileButton);
            this.invManagerBox.Controls.Add(this.inventorySaveFileButton);
            this.invManagerBox.Controls.Add(this.xmlPathTextBox);
            this.invManagerBox.Controls.Add(this.label6);
            this.invManagerBox.Controls.Add(this.invPathTextBox);
            this.invManagerBox.Controls.Add(this.label5);
            this.invManagerBox.Location = new System.Drawing.Point(264, 25);
            this.invManagerBox.Margin = new System.Windows.Forms.Padding(2);
            this.invManagerBox.Name = "invManagerBox";
            this.invManagerBox.Padding = new System.Windows.Forms.Padding(2);
            this.invManagerBox.Size = new System.Drawing.Size(429, 315);
            this.invManagerBox.TabIndex = 1;
            this.invManagerBox.TabStop = false;
            this.invManagerBox.Text = "Inventory Management";
            // 
            // isCompressedFile
            // 
            this.isCompressedFile.AutoSize = true;
            this.isCompressedFile.Location = new System.Drawing.Point(16, 159);
            this.isCompressedFile.Margin = new System.Windows.Forms.Padding(2);
            this.isCompressedFile.Name = "isCompressedFile";
            this.isCompressedFile.Size = new System.Drawing.Size(169, 17);
            this.isCompressedFile.TabIndex = 6;
            this.isCompressedFile.Text = "Use High image quality (>1mb)";
            this.isCompressedFile.UseVisualStyleBackColor = true;
            // 
            // xmlSaveFileButton
            // 
            this.xmlSaveFileButton.Location = new System.Drawing.Point(316, 111);
            this.xmlSaveFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.xmlSaveFileButton.Name = "xmlSaveFileButton";
            this.xmlSaveFileButton.Size = new System.Drawing.Size(101, 25);
            this.xmlSaveFileButton.TabIndex = 5;
            this.xmlSaveFileButton.Text = "Browse";
            this.xmlSaveFileButton.UseVisualStyleBackColor = true;
            this.xmlSaveFileButton.Click += new System.EventHandler(this.xmlSaveFileButton_Click);
            // 
            // inventorySaveFileButton
            // 
            this.inventorySaveFileButton.Location = new System.Drawing.Point(316, 53);
            this.inventorySaveFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.inventorySaveFileButton.Name = "inventorySaveFileButton";
            this.inventorySaveFileButton.Size = new System.Drawing.Size(101, 25);
            this.inventorySaveFileButton.TabIndex = 4;
            this.inventorySaveFileButton.Text = "Browse";
            this.inventorySaveFileButton.UseVisualStyleBackColor = true;
            this.inventorySaveFileButton.Click += new System.EventHandler(this.inventorySaveFileButton_Click);
            // 
            // xmlPathTextBox
            // 
            this.xmlPathTextBox.Location = new System.Drawing.Point(16, 115);
            this.xmlPathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.xmlPathTextBox.Name = "xmlPathTextBox";
            this.xmlPathTextBox.Size = new System.Drawing.Size(273, 20);
            this.xmlPathTextBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Settings Save file location";
            // 
            // invPathTextBox
            // 
            this.invPathTextBox.Location = new System.Drawing.Point(16, 57);
            this.invPathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.invPathTextBox.Name = "invPathTextBox";
            this.invPathTextBox.Size = new System.Drawing.Size(273, 20);
            this.invPathTextBox.TabIndex = 1;
            this.invPathTextBox.TextChanged += new System.EventHandler(this.invPathTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Inventory Folder location";
            // 
            // xmlSaveButton
            // 
            this.xmlSaveButton.Location = new System.Drawing.Point(11, 429);
            this.xmlSaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.xmlSaveButton.Name = "xmlSaveButton";
            this.xmlSaveButton.Size = new System.Drawing.Size(116, 48);
            this.xmlSaveButton.TabIndex = 2;
            this.xmlSaveButton.Text = "SAVE TO FILE";
            this.xmlSaveButton.UseVisualStyleBackColor = true;
            this.xmlSaveButton.Click += new System.EventHandler(this.xmlSaveButton_Click);
            // 
            // loadxmlButton
            // 
            this.loadxmlButton.Location = new System.Drawing.Point(143, 429);
            this.loadxmlButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadxmlButton.Name = "loadxmlButton";
            this.loadxmlButton.Size = new System.Drawing.Size(116, 48);
            this.loadxmlButton.TabIndex = 3;
            this.loadxmlButton.Text = "LOAD FROM FILE";
            this.loadxmlButton.UseVisualStyleBackColor = true;
            this.loadxmlButton.Click += new System.EventHandler(this.loadxmlButton_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "ARDUINO: MAINROBOTARM ",
            "ARDUINO: TRAYHANDLER"});
            this.checkedListBox1.Location = new System.Drawing.Point(4, 16);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(217, 19);
            this.checkedListBox1.TabIndex = 4;
            // 
            // componentBox
            // 
            this.componentBox.Controls.Add(this.checkedListBox1);
            this.componentBox.Location = new System.Drawing.Point(11, 352);
            this.componentBox.Margin = new System.Windows.Forms.Padding(2);
            this.componentBox.Name = "componentBox";
            this.componentBox.Padding = new System.Windows.Forms.Padding(2);
            this.componentBox.Size = new System.Drawing.Size(249, 64);
            this.componentBox.TabIndex = 5;
            this.componentBox.TabStop = false;
            this.componentBox.Text = "System Peripherals";
            // 
            // SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.loadxmlButton);
            this.Controls.Add(this.xmlSaveButton);
            this.Controls.Add(this.invManagerBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.componentBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SettingsMenu";
            this.Size = new System.Drawing.Size(1159, 677);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trayCenter2CenterValueCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trayOr2CenterValueY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trayHeightValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trayCenter2CenterValueRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trayOr2CenterValueX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trayStackValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trayWidthValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trayLengthValue)).EndInit();
            this.invManagerBox.ResumeLayout(false);
            this.invManagerBox.PerformLayout();
            this.componentBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown trayStackValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown trayWidthValue;
        private System.Windows.Forms.NumericUpDown trayLengthValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox invManagerBox;
        private System.Windows.Forms.TextBox xmlPathTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox invPathTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button xmlSaveFileButton;
        private System.Windows.Forms.Button inventorySaveFileButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button xmlSaveButton;
        private System.Windows.Forms.Button loadxmlButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown trayHeightValue;
        private System.Windows.Forms.NumericUpDown trayCenter2CenterValueRow;
        private System.Windows.Forms.NumericUpDown trayOr2CenterValueX;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox componentBox;
        private System.Windows.Forms.CheckBox isCompressedFile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown trayCenter2CenterValueCol;
        private System.Windows.Forms.NumericUpDown trayOr2CenterValueY;
    }
}
