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
            this.userModeButton = new System.Windows.Forms.Button();
            this.templateViewButton = new System.Windows.Forms.Button();
            this.armControlButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // centralPanel
            // 
            this.centralPanel.AutoSize = true;
            this.centralPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.centralPanel.Location = new System.Drawing.Point(13, 56);
            this.centralPanel.Name = "centralPanel";
            this.centralPanel.Size = new System.Drawing.Size(1667, 1436);
            this.centralPanel.TabIndex = 0;
            // 
            // userModeButton
            // 
            this.userModeButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.userModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userModeButton.Location = new System.Drawing.Point(13, 12);
            this.userModeButton.Name = "userModeButton";
            this.userModeButton.Size = new System.Drawing.Size(141, 38);
            this.userModeButton.TabIndex = 1;
            this.userModeButton.Text = "User Mode";
            this.userModeButton.UseVisualStyleBackColor = false;
            this.userModeButton.Click += new System.EventHandler(this.userModeButton_Click);
            // 
            // templateViewButton
            // 
            this.templateViewButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.templateViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.templateViewButton.Location = new System.Drawing.Point(160, 12);
            this.templateViewButton.Name = "templateViewButton";
            this.templateViewButton.Size = new System.Drawing.Size(141, 38);
            this.templateViewButton.TabIndex = 2;
            this.templateViewButton.Text = "Template Viewer";
            this.templateViewButton.UseVisualStyleBackColor = false;
            this.templateViewButton.Click += new System.EventHandler(this.templateViewButton_Click);
            // 
            // armControlButton
            // 
            this.armControlButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.armControlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.armControlButton.Location = new System.Drawing.Point(307, 12);
            this.armControlButton.Name = "armControlButton";
            this.armControlButton.Size = new System.Drawing.Size(141, 38);
            this.armControlButton.TabIndex = 3;
            this.armControlButton.Text = "Arm Control";
            this.armControlButton.UseVisualStyleBackColor = false;
            this.armControlButton.Click += new System.EventHandler(this.armControlButton_Click);
            // 
            // LoginMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1914, 1504);
            this.Controls.Add(this.armControlButton);
            this.Controls.Add(this.templateViewButton);
            this.Controls.Add(this.userModeButton);
            this.Controls.Add(this.centralPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginMain";
            this.Text = "Vishnu 2017";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel centralPanel;
        private System.Windows.Forms.Button userModeButton;
        private System.Windows.Forms.Button templateViewButton;
        private System.Windows.Forms.Button armControlButton;
    }
}

