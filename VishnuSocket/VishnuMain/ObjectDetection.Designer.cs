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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.template_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.findMatch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.loadTemplate = new System.Windows.Forms.Button();
            this.SavePicture = new System.Windows.Forms.Button();
            this.capturePicture = new System.Windows.Forms.Button();
            this.sourceimg_textbox = new System.Windows.Forms.TextBox();
            this.captured_imgbox = new Emgu.CV.UI.ImageBox();
            this.loadSource = new System.Windows.Forms.Button();
            this.harr__find = new System.Windows.Forms.Button();
            this.tracked_imgbox = new Emgu.CV.UI.ImageBox();
            this.template_imgbox = new Emgu.CV.UI.ImageBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.barcode_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.captured_imgbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracked_imgbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.template_imgbox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // template_textbox
            // 
            this.template_textbox.Location = new System.Drawing.Point(930, 390);
            this.template_textbox.Margin = new System.Windows.Forms.Padding(6);
            this.template_textbox.Name = "template_textbox";
            this.template_textbox.Size = new System.Drawing.Size(123, 29);
            this.template_textbox.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(925, 466);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Image";
            // 
            // findMatch
            // 
            this.findMatch.Location = new System.Drawing.Point(929, 747);
            this.findMatch.Margin = new System.Windows.Forms.Padding(6);
            this.findMatch.Name = "findMatch";
            this.findMatch.Size = new System.Drawing.Size(175, 59);
            this.findMatch.TabIndex = 27;
            this.findMatch.Text = "Find";
            this.findMatch.UseVisualStyleBackColor = true;
            this.findMatch.Click += new System.EventHandler(this.findMatch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(925, 354);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Template";
            // 
            // loadTemplate
            // 
            this.loadTemplate.Location = new System.Drawing.Point(1063, 389);
            this.loadTemplate.Margin = new System.Windows.Forms.Padding(6);
            this.loadTemplate.Name = "loadTemplate";
            this.loadTemplate.Size = new System.Drawing.Size(42, 35);
            this.loadTemplate.TabIndex = 26;
            this.loadTemplate.Text = "...";
            this.loadTemplate.UseVisualStyleBackColor = true;
            this.loadTemplate.Click += new System.EventHandler(this.loadTemplate_Click);
            // 
            // SavePicture
            // 
            this.SavePicture.Location = new System.Drawing.Point(929, 657);
            this.SavePicture.Margin = new System.Windows.Forms.Padding(6);
            this.SavePicture.Name = "SavePicture";
            this.SavePicture.Size = new System.Drawing.Size(175, 59);
            this.SavePicture.TabIndex = 32;
            this.SavePicture.Text = "Save Image";
            this.SavePicture.UseVisualStyleBackColor = true;
            this.SavePicture.Click += new System.EventHandler(this.savePicture_Click);
            // 
            // capturePicture
            // 
            this.capturePicture.Location = new System.Drawing.Point(929, 571);
            this.capturePicture.Margin = new System.Windows.Forms.Padding(6);
            this.capturePicture.Name = "capturePicture";
            this.capturePicture.Size = new System.Drawing.Size(175, 59);
            this.capturePicture.TabIndex = 25;
            this.capturePicture.Text = "Capture Picture";
            this.capturePicture.UseVisualStyleBackColor = true;
            this.capturePicture.Click += new System.EventHandler(this.captureImg_Click);
            // 
            // sourceimg_textbox
            // 
            this.sourceimg_textbox.Location = new System.Drawing.Point(930, 502);
            this.sourceimg_textbox.Margin = new System.Windows.Forms.Padding(6);
            this.sourceimg_textbox.Name = "sourceimg_textbox";
            this.sourceimg_textbox.Size = new System.Drawing.Size(123, 29);
            this.sourceimg_textbox.TabIndex = 24;
            // 
            // captured_imgbox
            // 
            this.captured_imgbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.captured_imgbox.Location = new System.Drawing.Point(27, 45);
            this.captured_imgbox.Margin = new System.Windows.Forms.Padding(6);
            this.captured_imgbox.Name = "captured_imgbox";
            this.captured_imgbox.Size = new System.Drawing.Size(839, 471);
            this.captured_imgbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.captured_imgbox.TabIndex = 21;
            this.captured_imgbox.TabStop = false;
            // 
            // loadSource
            // 
            this.loadSource.Location = new System.Drawing.Point(1063, 501);
            this.loadSource.Margin = new System.Windows.Forms.Padding(6);
            this.loadSource.Name = "loadSource";
            this.loadSource.Size = new System.Drawing.Size(42, 35);
            this.loadSource.TabIndex = 23;
            this.loadSource.Text = "...";
            this.loadSource.UseVisualStyleBackColor = true;
            this.loadSource.Click += new System.EventHandler(this.loadImg_Click);
            // 
            // harr__find
            // 
            this.harr__find.Location = new System.Drawing.Point(929, 837);
            this.harr__find.Margin = new System.Windows.Forms.Padding(6);
            this.harr__find.Name = "harr__find";
            this.harr__find.Size = new System.Drawing.Size(175, 59);
            this.harr__find.TabIndex = 35;
            this.harr__find.Text = "Haar Cascade";
            this.harr__find.UseVisualStyleBackColor = true;
            this.harr__find.Click += new System.EventHandler(this.harr__find_Click);
            // 
            // tracked_imgbox
            // 
            this.tracked_imgbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tracked_imgbox.Location = new System.Drawing.Point(27, 571);
            this.tracked_imgbox.Margin = new System.Windows.Forms.Padding(6);
            this.tracked_imgbox.Name = "tracked_imgbox";
            this.tracked_imgbox.Size = new System.Drawing.Size(839, 471);
            this.tracked_imgbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tracked_imgbox.TabIndex = 22;
            this.tracked_imgbox.TabStop = false;
            // 
            // template_imgbox
            // 
            this.template_imgbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.template_imgbox.Location = new System.Drawing.Point(930, 134);
            this.template_imgbox.Margin = new System.Windows.Forms.Padding(6);
            this.template_imgbox.MaximumSize = new System.Drawing.Size(262, 192);
            this.template_imgbox.Name = "template_imgbox";
            this.template_imgbox.Size = new System.Drawing.Size(262, 192);
            this.template_imgbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.template_imgbox.TabIndex = 36;
            this.template_imgbox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 543);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tracked Objects";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(924, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Template Image";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Captured Image";
            // 
            // barcode_button
            // 
            this.barcode_button.Location = new System.Drawing.Point(930, 925);
            this.barcode_button.Name = "barcode_button";
            this.barcode_button.Size = new System.Drawing.Size(175, 59);
            this.barcode_button.TabIndex = 38;
            this.barcode_button.Text = "Scan Barcode";
            this.barcode_button.UseVisualStyleBackColor = true;
            this.barcode_button.Click += new System.EventHandler(this.barcode_click);
            // 
            // ComputerVision_Tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.barcode_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.template_textbox);
            this.Controls.Add(this.template_imgbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tracked_imgbox);
            this.Controls.Add(this.findMatch);
            this.Controls.Add(this.harr__find);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.loadSource);
            this.Controls.Add(this.loadTemplate);
            this.Controls.Add(this.captured_imgbox);
            this.Controls.Add(this.SavePicture);
            this.Controls.Add(this.sourceimg_textbox);
            this.Controls.Add(this.capturePicture);
            this.Name = "ComputerVision_Tab";
            this.Size = new System.Drawing.Size(1198, 1048);
            ((System.ComponentModel.ISupportInitialize)(this.captured_imgbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracked_imgbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.template_imgbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox template_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button findMatch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button loadTemplate;
        private System.Windows.Forms.Button SavePicture;
        private System.Windows.Forms.Button capturePicture;
        private System.Windows.Forms.TextBox sourceimg_textbox;
        private Emgu.CV.UI.ImageBox captured_imgbox;
        private System.Windows.Forms.Button loadSource;
        private System.Windows.Forms.Button harr__find;
        private Emgu.CV.UI.ImageBox tracked_imgbox;
        private Emgu.CV.UI.ImageBox template_imgbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button barcode_button;
    }
}