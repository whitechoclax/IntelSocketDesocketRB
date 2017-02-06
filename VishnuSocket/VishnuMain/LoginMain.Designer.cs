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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginMain));
            this.centralPanel = new System.Windows.Forms.Panel();
            this.DebugMode = new System.Windows.Forms.Button();
            this.UserMode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // centralPanel
            // 
            this.centralPanel.Location = new System.Drawing.Point(13, 13);
            this.centralPanel.Name = "centralPanel";
            this.centralPanel.Size = new System.Drawing.Size(1280, 1479);
            this.centralPanel.TabIndex = 0;
            // 
            // DebugMode
            // 
            this.DebugMode.Location = new System.Drawing.Point(1318, 13);
            this.DebugMode.Name = "DebugMode";
            this.DebugMode.Size = new System.Drawing.Size(230, 139);
            this.DebugMode.TabIndex = 1;
            this.DebugMode.Text = "Debug Mode";
            this.DebugMode.UseVisualStyleBackColor = true;
            this.DebugMode.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserMode
            // 
            this.UserMode.Location = new System.Drawing.Point(1318, 177);
            this.UserMode.Name = "UserMode";
            this.UserMode.Size = new System.Drawing.Size(230, 139);
            this.UserMode.TabIndex = 2;
            this.UserMode.Text = "User Mode";
            this.UserMode.UseVisualStyleBackColor = true;
            this.UserMode.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoginMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1691, 1504);
            this.Controls.Add(this.UserMode);
            this.Controls.Add(this.DebugMode);
            this.Controls.Add(this.centralPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginMain";
            this.Text = "Vishnu 2017";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel centralPanel;
        private System.Windows.Forms.Button DebugMode;
        private System.Windows.Forms.Button UserMode;
    }
}

