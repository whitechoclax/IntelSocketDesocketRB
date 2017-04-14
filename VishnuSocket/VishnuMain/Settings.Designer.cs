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
            this.trayStackValue = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trayWidthValue = new System.Windows.Forms.NumericUpDown();
            this.trayLengthValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.invManagerBox = new System.Windows.Forms.GroupBox();
            this.xmlPathTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.invPathTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inventorySaveFileButton = new System.Windows.Forms.Button();
            this.xmlSaveFileButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trayStackValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trayWidthValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trayLengthValue)).BeginInit();
            this.invManagerBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trayStackValue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.trayWidthValue);
            this.groupBox1.Controls.Add(this.trayLengthValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 485);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tray Properties";
            // 
            // trayStackValue
            // 
            this.trayStackValue.Location = new System.Drawing.Point(228, 177);
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
            this.trayStackValue.Size = new System.Drawing.Size(120, 26);
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
            this.label4.Location = new System.Drawing.Point(20, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tray Height (Stack of trays)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tray Width (in # of chips)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tray Length (in # of chips)";
            // 
            // trayWidthValue
            // 
            this.trayWidthValue.Location = new System.Drawing.Point(229, 137);
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
            this.trayWidthValue.Size = new System.Drawing.Size(120, 26);
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
            this.trayLengthValue.Location = new System.Drawing.Point(229, 94);
            this.trayLengthValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.trayLengthValue.Name = "trayLengthValue";
            this.trayLengthValue.Size = new System.Drawing.Size(120, 26);
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
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tray Dimensions";
            // 
            // invManagerBox
            // 
            this.invManagerBox.Controls.Add(this.xmlSaveFileButton);
            this.invManagerBox.Controls.Add(this.inventorySaveFileButton);
            this.invManagerBox.Controls.Add(this.xmlPathTextBox);
            this.invManagerBox.Controls.Add(this.label6);
            this.invManagerBox.Controls.Add(this.invPathTextBox);
            this.invManagerBox.Controls.Add(this.label5);
            this.invManagerBox.Location = new System.Drawing.Point(396, 39);
            this.invManagerBox.Name = "invManagerBox";
            this.invManagerBox.Size = new System.Drawing.Size(673, 485);
            this.invManagerBox.TabIndex = 1;
            this.invManagerBox.TabStop = false;
            this.invManagerBox.Text = "Inventory Management";
            // 
            // xmlPathTextBox
            // 
            this.xmlPathTextBox.Location = new System.Drawing.Point(24, 177);
            this.xmlPathTextBox.Name = "xmlPathTextBox";
            this.xmlPathTextBox.Size = new System.Drawing.Size(407, 26);
            this.xmlPathTextBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Settings Save file location";
            // 
            // invPathTextBox
            // 
            this.invPathTextBox.Location = new System.Drawing.Point(24, 87);
            this.invPathTextBox.Name = "invPathTextBox";
            this.invPathTextBox.Size = new System.Drawing.Size(407, 26);
            this.invPathTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Inventory Folder location";
            // 
            // inventorySaveFileButton
            // 
            this.inventorySaveFileButton.Location = new System.Drawing.Point(474, 81);
            this.inventorySaveFileButton.Name = "inventorySaveFileButton";
            this.inventorySaveFileButton.Size = new System.Drawing.Size(152, 38);
            this.inventorySaveFileButton.TabIndex = 4;
            this.inventorySaveFileButton.Text = "Browse";
            this.inventorySaveFileButton.UseVisualStyleBackColor = true;
            this.inventorySaveFileButton.Click += new System.EventHandler(this.inventorySaveFileButton_Click);
            // 
            // xmlSaveFileButton
            // 
            this.xmlSaveFileButton.Location = new System.Drawing.Point(474, 171);
            this.xmlSaveFileButton.Name = "xmlSaveFileButton";
            this.xmlSaveFileButton.Size = new System.Drawing.Size(152, 38);
            this.xmlSaveFileButton.TabIndex = 5;
            this.xmlSaveFileButton.Text = "Browse";
            this.xmlSaveFileButton.UseVisualStyleBackColor = true;
            this.xmlSaveFileButton.Click += new System.EventHandler(this.xmlSaveFileButton_Click);
            // 
            // SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.invManagerBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "SettingsMenu";
            this.Size = new System.Drawing.Size(1739, 1042);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trayStackValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trayWidthValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trayLengthValue)).EndInit();
            this.invManagerBox.ResumeLayout(false);
            this.invManagerBox.PerformLayout();
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
    }
}
