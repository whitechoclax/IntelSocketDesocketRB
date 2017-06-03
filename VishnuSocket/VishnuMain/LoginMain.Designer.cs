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
            this.centralTab = new System.Windows.Forms.TabControl();
            this.main_camera_feed = new Emgu.CV.UI.ImageBox();
            this.start_camera = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Camera_Selection = new System.Windows.Forms.ComboBox();
            this.save_camera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.main_camera_feed)).BeginInit();
            this.SuspendLayout();
            // 
            // centralTab
            // 
            this.centralTab.Location = new System.Drawing.Point(14, 14);
            this.centralTab.Margin = new System.Windows.Forms.Padding(2);
            this.centralTab.Name = "centralTab";
            this.centralTab.SelectedIndex = 0;
            this.centralTab.Size = new System.Drawing.Size(875, 800);
            this.centralTab.TabIndex = 0;
            // 
            // main_camera_feed
            // 
            this.main_camera_feed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_camera_feed.Location = new System.Drawing.Point(965, 59);
            this.main_camera_feed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.main_camera_feed.Name = "main_camera_feed";
            this.main_camera_feed.Size = new System.Drawing.Size(600, 337);
            this.main_camera_feed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.main_camera_feed.TabIndex = 2;
            this.main_camera_feed.TabStop = false;
            // 
            // start_camera
            // 
            this.start_camera.Location = new System.Drawing.Point(1107, 512);
            this.start_camera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.start_camera.Name = "start_camera";
            this.start_camera.Size = new System.Drawing.Size(125, 42);
            this.start_camera.TabIndex = 3;
            this.start_camera.Text = "Start Video";
            this.start_camera.UseVisualStyleBackColor = true;
            this.start_camera.Click += new System.EventHandler(this.start_camera_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(962, 447);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Camera Selection";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(962, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Camera Feed";
            // 
            // Camera_Selection
            // 
            this.Camera_Selection.FormattingEnabled = true;
            this.Camera_Selection.Location = new System.Drawing.Point(963, 467);
            this.Camera_Selection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Camera_Selection.Name = "Camera_Selection";
            this.Camera_Selection.Size = new System.Drawing.Size(268, 24);
            this.Camera_Selection.TabIndex = 37;
            // 
            // save_camera
            // 
            this.save_camera.Location = new System.Drawing.Point(963, 512);
            this.save_camera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save_camera.Name = "save_camera";
            this.save_camera.Size = new System.Drawing.Size(125, 42);
            this.save_camera.TabIndex = 38;
            this.save_camera.Text = "Save Selection";
            this.save_camera.UseVisualStyleBackColor = true;
            this.save_camera.Click += new System.EventHandler(this.save_camera_Click);
            // 
            // LoginMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1494, 828);
            this.Controls.Add(this.save_camera);
            this.Controls.Add(this.Camera_Selection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.start_camera);
            this.Controls.Add(this.main_camera_feed);
            this.Controls.Add(this.centralTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(800, 496);
            this.Name = "LoginMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vishnu 2017 0.4a";
            this.Load += new System.EventHandler(this.LoginMain_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.main_camera_feed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl centralTab;
        private Emgu.CV.UI.ImageBox main_camera_feed;
        private System.Windows.Forms.Button start_camera;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save_camera;
        public System.Windows.Forms.ComboBox Camera_Selection;
    }
}

