namespace VishnuMain
{
    partial class CameraFeed
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
            this.flipVerticalButton = new System.Windows.Forms.Button();
            this.flipHorizontalButton = new System.Windows.Forms.Button();
            this.captureButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Setting_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Sharpness_SLD = new System.Windows.Forms.TrackBar();
            this.Sharpness_LBL = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Brightness_SLD = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.Brigthness_LBL = new System.Windows.Forms.Label();
            this.Contrast_LBL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Contrast_SLD = new System.Windows.Forms.TrackBar();
            this.Reset_Cam_Settings = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Refresh_BTN = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RetrieveGrayFrame = new System.Windows.Forms.CheckBox();
            this.RetrieveBgrFrame = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Camera_Selection = new System.Windows.Forms.ComboBox();
            this.Cam_lbl = new System.Windows.Forms.Label();
            this.CaptureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sharpness_SLD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brightness_SLD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contrast_SLD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // flipVerticalButton
            // 
            this.flipVerticalButton.Location = new System.Drawing.Point(27, 202);
            this.flipVerticalButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flipVerticalButton.Name = "flipVerticalButton";
            this.flipVerticalButton.Size = new System.Drawing.Size(153, 35);
            this.flipVerticalButton.TabIndex = 2;
            this.flipVerticalButton.Text = "Flip Vertical";
            this.flipVerticalButton.UseVisualStyleBackColor = true;
            this.flipVerticalButton.Click += new System.EventHandler(this.flipVerticalButton_Click);
            // 
            // flipHorizontalButton
            // 
            this.flipHorizontalButton.Location = new System.Drawing.Point(189, 202);
            this.flipHorizontalButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flipHorizontalButton.Name = "flipHorizontalButton";
            this.flipHorizontalButton.Size = new System.Drawing.Size(153, 35);
            this.flipHorizontalButton.TabIndex = 1;
            this.flipHorizontalButton.Text = "Flip Horizontal";
            this.flipHorizontalButton.UseVisualStyleBackColor = true;
            this.flipHorizontalButton.Click += new System.EventHandler(this.flipHorizontalButton_Click);
            // 
            // captureButton
            // 
            this.captureButton.Enabled = false;
            this.captureButton.Location = new System.Drawing.Point(27, 97);
            this.captureButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(153, 35);
            this.captureButton.TabIndex = 0;
            this.captureButton.Text = "Start Capture";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Setting_lbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Cam_lbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CaptureBox, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 18);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1227, 1157);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Setting_lbl
            // 
            this.Setting_lbl.AutoSize = true;
            this.Setting_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Setting_lbl.Location = new System.Drawing.Point(617, 0);
            this.Setting_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Setting_lbl.Name = "Setting_lbl";
            this.Setting_lbl.Size = new System.Drawing.Size(91, 25);
            this.Setting_lbl.TabIndex = 2;
            this.Setting_lbl.Text = "Settings";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Reset_Cam_Settings);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Refresh_BTN);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.RetrieveGrayFrame);
            this.panel1.Controls.Add(this.RetrieveBgrFrame);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Camera_Selection);
            this.panel1.Controls.Add(this.captureButton);
            this.panel1.Controls.Add(this.flipHorizontalButton);
            this.panel1.Controls.Add(this.flipVerticalButton);
            this.panel1.Location = new System.Drawing.Point(617, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 1116);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.Sharpness_SLD);
            this.panel2.Controls.Add(this.Sharpness_LBL);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.Brightness_SLD);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Brigthness_LBL);
            this.panel2.Controls.Add(this.Contrast_LBL);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Contrast_SLD);
            this.panel2.Location = new System.Drawing.Point(4, 386);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 438);
            this.panel2.TabIndex = 24;
            // 
            // Sharpness_SLD
            // 
            this.Sharpness_SLD.Location = new System.Drawing.Point(153, 162);
            this.Sharpness_SLD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sharpness_SLD.Maximum = 250;
            this.Sharpness_SLD.Name = "Sharpness_SLD";
            this.Sharpness_SLD.Size = new System.Drawing.Size(357, 69);
            this.Sharpness_SLD.TabIndex = 21;
            this.Sharpness_SLD.TickFrequency = 5;
            this.Sharpness_SLD.Scroll += new System.EventHandler(this.Sharpness_SLD_Scroll);
            // 
            // Sharpness_LBL
            // 
            this.Sharpness_LBL.AutoSize = true;
            this.Sharpness_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sharpness_LBL.Location = new System.Drawing.Point(519, 162);
            this.Sharpness_LBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sharpness_LBL.Name = "Sharpness_LBL";
            this.Sharpness_LBL.Size = new System.Drawing.Size(24, 25);
            this.Sharpness_LBL.TabIndex = 22;
            this.Sharpness_LBL.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 162);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Sharpness:";
            // 
            // Brightness_SLD
            // 
            this.Brightness_SLD.Location = new System.Drawing.Point(154, 5);
            this.Brightness_SLD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Brightness_SLD.Maximum = 250;
            this.Brightness_SLD.Name = "Brightness_SLD";
            this.Brightness_SLD.Size = new System.Drawing.Size(357, 69);
            this.Brightness_SLD.TabIndex = 14;
            this.Brightness_SLD.TickFrequency = 5;
            this.Brightness_SLD.Scroll += new System.EventHandler(this.Brigtness_SLD_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Contrast:";
            // 
            // Brigthness_LBL
            // 
            this.Brigthness_LBL.AutoSize = true;
            this.Brigthness_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brigthness_LBL.Location = new System.Drawing.Point(519, 5);
            this.Brigthness_LBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Brigthness_LBL.Name = "Brigthness_LBL";
            this.Brigthness_LBL.Size = new System.Drawing.Size(24, 25);
            this.Brigthness_LBL.TabIndex = 15;
            this.Brigthness_LBL.Text = "0";
            // 
            // Contrast_LBL
            // 
            this.Contrast_LBL.AutoSize = true;
            this.Contrast_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contrast_LBL.Location = new System.Drawing.Point(519, 83);
            this.Contrast_LBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Contrast_LBL.Name = "Contrast_LBL";
            this.Contrast_LBL.Size = new System.Drawing.Size(24, 25);
            this.Contrast_LBL.TabIndex = 19;
            this.Contrast_LBL.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Brightness:";
            // 
            // Contrast_SLD
            // 
            this.Contrast_SLD.Location = new System.Drawing.Point(153, 83);
            this.Contrast_SLD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Contrast_SLD.Maximum = 250;
            this.Contrast_SLD.Name = "Contrast_SLD";
            this.Contrast_SLD.Size = new System.Drawing.Size(357, 69);
            this.Contrast_SLD.TabIndex = 18;
            this.Contrast_SLD.TickFrequency = 5;
            this.Contrast_SLD.Scroll += new System.EventHandler(this.Contrast_SLD_Scroll);
            // 
            // Reset_Cam_Settings
            // 
            this.Reset_Cam_Settings.Location = new System.Drawing.Point(447, 834);
            this.Reset_Cam_Settings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Reset_Cam_Settings.Name = "Reset_Cam_Settings";
            this.Reset_Cam_Settings.Size = new System.Drawing.Size(153, 35);
            this.Reset_Cam_Settings.TabIndex = 17;
            this.Reset_Cam_Settings.Text = "Reset";
            this.Reset_Cam_Settings.UseVisualStyleBackColor = true;
            this.Reset_Cam_Settings.Click += new System.EventHandler(this.Reset_Cam_Settings_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 357);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Settings";
            // 
            // Refresh_BTN
            // 
            this.Refresh_BTN.Location = new System.Drawing.Point(447, 1072);
            this.Refresh_BTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Refresh_BTN.Name = "Refresh_BTN";
            this.Refresh_BTN.Size = new System.Drawing.Size(153, 35);
            this.Refresh_BTN.TabIndex = 12;
            this.Refresh_BTN.Text = "Refresh";
            this.Refresh_BTN.UseVisualStyleBackColor = true;
            this.Refresh_BTN.Click += new System.EventHandler(this.Refresh_BTN_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(27, 909);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(571, 152);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 880);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Info";
            // 
            // RetrieveGrayFrame
            // 
            this.RetrieveGrayFrame.AutoSize = true;
            this.RetrieveGrayFrame.Location = new System.Drawing.Point(60, 303);
            this.RetrieveGrayFrame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RetrieveGrayFrame.Name = "RetrieveGrayFrame";
            this.RetrieveGrayFrame.Size = new System.Drawing.Size(182, 24);
            this.RetrieveGrayFrame.TabIndex = 9;
            this.RetrieveGrayFrame.Text = "Retrieve Gray Frame";
            this.RetrieveGrayFrame.UseVisualStyleBackColor = true;
            this.RetrieveGrayFrame.CheckedChanged += new System.EventHandler(this.RetrieveGrayFrame_CheckedChanged);
            // 
            // RetrieveBgrFrame
            // 
            this.RetrieveBgrFrame.AutoSize = true;
            this.RetrieveBgrFrame.Checked = true;
            this.RetrieveBgrFrame.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RetrieveBgrFrame.Location = new System.Drawing.Point(60, 268);
            this.RetrieveBgrFrame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RetrieveBgrFrame.Name = "RetrieveBgrFrame";
            this.RetrieveBgrFrame.Size = new System.Drawing.Size(173, 24);
            this.RetrieveBgrFrame.TabIndex = 8;
            this.RetrieveBgrFrame.Text = "Retrieve Bgr Frame";
            this.RetrieveBgrFrame.UseVisualStyleBackColor = true;
            this.RetrieveBgrFrame.CheckedChanged += new System.EventHandler(this.RetrieveBgrFrame_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "View";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Camera";
            // 
            // Camera_Selection
            // 
            this.Camera_Selection.FormattingEnabled = true;
            this.Camera_Selection.Location = new System.Drawing.Point(27, 55);
            this.Camera_Selection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Camera_Selection.Name = "Camera_Selection";
            this.Camera_Selection.Size = new System.Drawing.Size(343, 28);
            this.Camera_Selection.TabIndex = 3;
            // 
            // Cam_lbl
            // 
            this.Cam_lbl.AutoSize = true;
            this.Cam_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cam_lbl.Location = new System.Drawing.Point(4, 0);
            this.Cam_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cam_lbl.Name = "Cam_lbl";
            this.Cam_lbl.Size = new System.Drawing.Size(141, 25);
            this.Cam_lbl.TabIndex = 1;
            this.Cam_lbl.Text = "Camera View";
            // 
            // CaptureBox
            // 
            this.CaptureBox.Location = new System.Drawing.Point(3, 34);
            this.CaptureBox.Name = "CaptureBox";
            this.CaptureBox.Size = new System.Drawing.Size(607, 540);
            this.CaptureBox.TabIndex = 3;
            this.CaptureBox.TabStop = false;
            // 
            // CameraFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CameraFeed";
            this.Size = new System.Drawing.Size(1263, 1194);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sharpness_SLD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brightness_SLD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contrast_SLD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.Button flipHorizontalButton;
        private System.Windows.Forms.Button flipVerticalButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Setting_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Cam_lbl;
        private System.Windows.Forms.ComboBox Camera_Selection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox RetrieveBgrFrame;
        private System.Windows.Forms.CheckBox RetrieveGrayFrame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Refresh_BTN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Brigthness_LBL;
        private System.Windows.Forms.TrackBar Brightness_SLD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Reset_Cam_Settings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Contrast_LBL;
        private System.Windows.Forms.TrackBar Contrast_SLD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar Sharpness_SLD;
        private System.Windows.Forms.Label Sharpness_LBL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox CaptureBox;
    }
}
 
