namespace VishnuMain
{
    partial class TemplateMatchView
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
            this.imageBox4 = new Emgu.CV.UI.ImageBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imageBox3 = new Emgu.CV.UI.ImageBox();
            this.startCaptureButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fileNameTextBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.takepicture = new System.Windows.Forms.Button();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox4
            // 
            this.imageBox4.Location = new System.Drawing.Point(25, 54);
            this.imageBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imageBox4.Name = "imageBox4";
            this.imageBox4.Size = new System.Drawing.Size(640, 480);
            this.imageBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageBox4.TabIndex = 3;
            this.imageBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Video Feed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 588);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Template Image";
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(25, 633);
            this.imageBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(950, 480);
            this.imageBox2.TabIndex = 18;
            this.imageBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(715, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Captured Image";
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(719, 54);
            this.imageBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(640, 480);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageBox1.TabIndex = 20;
            this.imageBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1002, 588);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tracked Objects";
            // 
            // imageBox3
            // 
            this.imageBox3.Location = new System.Drawing.Point(1006, 633);
            this.imageBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(640, 480);
            this.imageBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageBox3.TabIndex = 22;
            this.imageBox3.TabStop = false;
            // 
            // startCaptureButton
            // 
            this.startCaptureButton.Location = new System.Drawing.Point(40, 1249);
            this.startCaptureButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startCaptureButton.Name = "startCaptureButton";
            this.startCaptureButton.Size = new System.Drawing.Size(150, 35);
            this.startCaptureButton.TabIndex = 31;
            this.startCaptureButton.Text = "Start Capture";
            this.startCaptureButton.UseVisualStyleBackColor = true;
            this.startCaptureButton.Click += new System.EventHandler(this.startCaptureButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 1196);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Template";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 1154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Image";
            // 
            // fileNameTextBox2
            // 
            this.fileNameTextBox2.Location = new System.Drawing.Point(138, 1200);
            this.fileNameTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fileNameTextBox2.Name = "fileNameTextBox2";
            this.fileNameTextBox2.Size = new System.Drawing.Size(373, 26);
            this.fileNameTextBox2.TabIndex = 28;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(364, 1249);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 35);
            this.button3.TabIndex = 27;
            this.button3.Text = "Find";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(522, 1192);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 34);
            this.button2.TabIndex = 26;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // takepicture
            // 
            this.takepicture.Location = new System.Drawing.Point(198, 1249);
            this.takepicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.takepicture.Name = "takepicture";
            this.takepicture.Size = new System.Drawing.Size(150, 35);
            this.takepicture.TabIndex = 25;
            this.takepicture.Text = "Capture Picture";
            this.takepicture.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.takepicture.UseVisualStyleBackColor = true;
            this.takepicture.Click += new System.EventHandler(this.takepicture_Click);
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(138, 1151);
            this.fileNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(373, 26);
            this.fileNameTextBox.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 1151);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 31);
            this.button1.TabIndex = 23;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TemplateMatchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.startCaptureButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fileNameTextBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.takepicture);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imageBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.imageBox4);
            this.Name = "TemplateMatchView";
            this.Size = new System.Drawing.Size(1680, 1306);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Label label1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Label label2;
        private Emgu.CV.UI.ImageBox imageBox3;
        private System.Windows.Forms.Button startCaptureButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fileNameTextBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button takepicture;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Button button1;
    }
}