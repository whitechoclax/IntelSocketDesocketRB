namespace VishnuMain
{
    partial class LoginMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginMain));
            this.button1 = new System.Windows.Forms.Button();
            this.main_camera_feed = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.main_camera_feed)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1274, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start Cameras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // main_camera_feed
            // 
            this.main_camera_feed.Location = new System.Drawing.Point(835, 181);
            this.main_camera_feed.Name = "main_camera_feed";
            this.main_camera_feed.Size = new System.Drawing.Size(480, 270);
            this.main_camera_feed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.main_camera_feed.TabIndex = 2;
            this.main_camera_feed.TabStop = false;
            // 
            // LoginMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1404, 729);
            this.Controls.Add(this.main_camera_feed);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1388, 403);
            this.Name = "LoginMain";
            this.Text = "Vishnu 2017 0.4a";
            this.Load += new System.EventHandler(this.LoginMain_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.main_camera_feed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private Emgu.CV.UI.ImageBox main_camera_feed;
    }
}

