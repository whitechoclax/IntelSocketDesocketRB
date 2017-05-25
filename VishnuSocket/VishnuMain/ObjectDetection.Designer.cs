namespace VishnuMain
{
    partial class ComputerVision_Tab
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
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.template_imgbox = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startCaptureButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.template_textbox = new System.Windows.Forms.TextBox();
            this.findMatch = new System.Windows.Forms.Button();
            this.loadTemplate = new System.Windows.Forms.Button();
            this.capturePicture = new System.Windows.Forms.Button();
            this.sourceimg_textbox = new System.Windows.Forms.TextBox();
            this.loadSource = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SavePicture = new System.Windows.Forms.Button();
            this.Camera_Selection = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tracked_imgbox = new Emgu.CV.UI.ImageBox();
            this.videogroupBox = new System.Windows.Forms.GroupBox();
            this.video_imgbox = new Emgu.CV.UI.ImageBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.captured_imgbox = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.template_imgbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracked_imgbox)).BeginInit();
            this.videogroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.video_imgbox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captured_imgbox)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2, -2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Video Feed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Template Image";
            // 
            // template_imgbox
            // 
            this.template_imgbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.template_imgbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.template_imgbox.Location = new System.Drawing.Point(17, 336);
            this.template_imgbox.Name = "template_imgbox";
            this.template_imgbox.Size = new System.Drawing.Size(480, 270);
            this.template_imgbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.template_imgbox.TabIndex = 18;
            this.template_imgbox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-4, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Captured Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tracked Objects";
            // 
            // startCaptureButton
            // 
            this.startCaptureButton.Location = new System.Drawing.Point(1019, 53);
            this.startCaptureButton.Name = "startCaptureButton";
            this.startCaptureButton.Size = new System.Drawing.Size(100, 34);
            this.startCaptureButton.TabIndex = 31;
            this.startCaptureButton.Text = "Start Camera";
            this.startCaptureButton.UseVisualStyleBackColor = true;
            this.startCaptureButton.Click += new System.EventHandler(this.startCameraFeed_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1019, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Template";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1019, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Image";
            // 
            // template_textbox
            // 
            this.template_textbox.Location = new System.Drawing.Point(1022, 389);
            this.template_textbox.Name = "template_textbox";
            this.template_textbox.Size = new System.Drawing.Size(72, 20);
            this.template_textbox.TabIndex = 28;
            // 
            // findMatch
            // 
            this.findMatch.Location = new System.Drawing.Point(1019, 173);
            this.findMatch.Name = "findMatch";
            this.findMatch.Size = new System.Drawing.Size(100, 34);
            this.findMatch.TabIndex = 27;
            this.findMatch.Text = "Find";
            this.findMatch.UseVisualStyleBackColor = true;
            this.findMatch.Click += new System.EventHandler(this.findMatch_Click);
            // 
            // loadTemplate
            // 
            this.loadTemplate.Location = new System.Drawing.Point(1102, 389);
            this.loadTemplate.Name = "loadTemplate";
            this.loadTemplate.Size = new System.Drawing.Size(24, 20);
            this.loadTemplate.TabIndex = 26;
            this.loadTemplate.Text = "...";
            this.loadTemplate.UseVisualStyleBackColor = true;
            this.loadTemplate.Click += new System.EventHandler(this.loadTemplate_Click);
            // 
            // capturePicture
            // 
            this.capturePicture.Location = new System.Drawing.Point(1019, 93);
            this.capturePicture.Name = "capturePicture";
            this.capturePicture.Size = new System.Drawing.Size(100, 34);
            this.capturePicture.TabIndex = 25;
            this.capturePicture.Text = "Capture Picture";
            this.capturePicture.UseVisualStyleBackColor = true;
            this.capturePicture.Click += new System.EventHandler(this.captureImg_Click);
            // 
            // sourceimg_textbox
            // 
            this.sourceimg_textbox.Location = new System.Drawing.Point(1022, 347);
            this.sourceimg_textbox.Name = "sourceimg_textbox";
            this.sourceimg_textbox.Size = new System.Drawing.Size(72, 20);
            this.sourceimg_textbox.TabIndex = 24;
            // 
            // loadSource
            // 
            this.loadSource.Location = new System.Drawing.Point(1102, 347);
            this.loadSource.Name = "loadSource";
            this.loadSource.Size = new System.Drawing.Size(24, 20);
            this.loadSource.TabIndex = 23;
            this.loadSource.Text = "...";
            this.loadSource.UseVisualStyleBackColor = true;
            this.loadSource.Click += new System.EventHandler(this.loadImg_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // SavePicture
            // 
            this.SavePicture.Location = new System.Drawing.Point(1019, 133);
            this.SavePicture.Name = "SavePicture";
            this.SavePicture.Size = new System.Drawing.Size(100, 34);
            this.SavePicture.TabIndex = 32;
            this.SavePicture.Text = "Save Image";
            this.SavePicture.UseVisualStyleBackColor = true;
            this.SavePicture.Click += new System.EventHandler(this.savePicture_Click);
            // 
            // Camera_Selection
            // 
            this.Camera_Selection.FormattingEnabled = true;
            this.Camera_Selection.Location = new System.Drawing.Point(1014, 25);
            this.Camera_Selection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Camera_Selection.Name = "Camera_Selection";
            this.Camera_Selection.Size = new System.Drawing.Size(127, 21);
            this.Camera_Selection.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1006, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Camera Selection";
            // 
            // tracked_imgbox
            // 
            this.tracked_imgbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tracked_imgbox.Location = new System.Drawing.Point(522, 336);
            this.tracked_imgbox.Name = "tracked_imgbox";
            this.tracked_imgbox.Size = new System.Drawing.Size(480, 270);
            this.tracked_imgbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tracked_imgbox.TabIndex = 22;
            this.tracked_imgbox.TabStop = false;
            // 
            // videogroupBox
            // 
            this.videogroupBox.Controls.Add(this.video_imgbox);
            this.videogroupBox.Controls.Add(this.label6);
            this.videogroupBox.Location = new System.Drawing.Point(16, 9);
            this.videogroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.videogroupBox.Name = "videogroupBox";
            this.videogroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.videogroupBox.Size = new System.Drawing.Size(486, 302);
            this.videogroupBox.TabIndex = 35;
            this.videogroupBox.TabStop = false;
            // 
            // video_imgbox
            // 
            this.video_imgbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.video_imgbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.video_imgbox.Location = new System.Drawing.Point(2, 15);
            this.video_imgbox.Name = "video_imgbox";
            this.video_imgbox.Size = new System.Drawing.Size(482, 285);
            this.video_imgbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.video_imgbox.TabIndex = 4;
            this.video_imgbox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.captured_imgbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(523, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 304);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // captured_imgbox
            // 
            this.captured_imgbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.captured_imgbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.captured_imgbox.Location = new System.Drawing.Point(3, 16);
            this.captured_imgbox.Name = "captured_imgbox";
            this.captured_imgbox.Size = new System.Drawing.Size(473, 285);
            this.captured_imgbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.captured_imgbox.TabIndex = 21;
            this.captured_imgbox.TabStop = false;
            // 
            // ComputerVision_Tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Camera_Selection);
            this.Controls.Add(this.SavePicture);
            this.Controls.Add(this.startCaptureButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.template_textbox);
            this.Controls.Add(this.findMatch);
            this.Controls.Add(this.loadTemplate);
            this.Controls.Add(this.capturePicture);
            this.Controls.Add(this.sourceimg_textbox);
            this.Controls.Add(this.loadSource);
            this.Controls.Add(this.tracked_imgbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.template_imgbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.videogroupBox);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ComputerVision_Tab";
            this.Size = new System.Drawing.Size(1483, 720);
            ((System.ComponentModel.ISupportInitialize)(this.template_imgbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracked_imgbox)).EndInit();
            this.videogroupBox.ResumeLayout(false);
            this.videogroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.video_imgbox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captured_imgbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private Emgu.CV.UI.ImageBox template_imgbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startCaptureButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox template_textbox;
        private System.Windows.Forms.Button findMatch;
        private System.Windows.Forms.Button loadTemplate;
        private System.Windows.Forms.Button capturePicture;
        private System.Windows.Forms.TextBox sourceimg_textbox;
        private System.Windows.Forms.Button loadSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button SavePicture;
        private System.Windows.Forms.ComboBox Camera_Selection;
        private System.Windows.Forms.Label label7;
        private Emgu.CV.UI.ImageBox tracked_imgbox;
        private System.Windows.Forms.GroupBox videogroupBox;
        private Emgu.CV.UI.ImageBox video_imgbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private Emgu.CV.UI.ImageBox captured_imgbox;
    }
}