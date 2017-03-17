namespace VishnuMain
{
    partial class ArmControl
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
            this.components = new System.ComponentModel.Container();
            this.riseUp = new System.Windows.Forms.Button();
            this.lowerDown = new System.Windows.Forms.Button();
            this.rotateRight = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.offButton = new System.Windows.Forms.Button();
            this.onButton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.portListBox = new System.Windows.Forms.RichTextBox();
            this.findPorts = new System.Windows.Forms.Button();
            this.openPort = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // riseUp
            // 
            this.riseUp.Location = new System.Drawing.Point(184, 80);
            this.riseUp.Name = "riseUp";
            this.riseUp.Size = new System.Drawing.Size(134, 114);
            this.riseUp.TabIndex = 0;
            this.riseUp.Text = "Rise UP";
            this.riseUp.UseVisualStyleBackColor = true;
            // 
            // lowerDown
            // 
            this.lowerDown.Location = new System.Drawing.Point(184, 308);
            this.lowerDown.Name = "lowerDown";
            this.lowerDown.Size = new System.Drawing.Size(134, 117);
            this.lowerDown.TabIndex = 1;
            this.lowerDown.Text = "Lower Down";
            this.lowerDown.UseVisualStyleBackColor = true;
            // 
            // rotateRight
            // 
            this.rotateRight.Location = new System.Drawing.Point(315, 194);
            this.rotateRight.Name = "rotateRight";
            this.rotateRight.Size = new System.Drawing.Size(138, 117);
            this.rotateRight.TabIndex = 2;
            this.rotateRight.Text = "Rotate Right";
            this.rotateRight.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(54, 194);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 117);
            this.button4.TabIndex = 3;
            this.button4.Text = "Rotate Left";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.lowerDown);
            this.groupBox1.Controls.Add(this.rotateRight);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.riseUp);
            this.groupBox1.Location = new System.Drawing.Point(663, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 923);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(45, 456);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(113, 24);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(45, 426);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Maroon;
            this.groupBox2.Controls.Add(this.openPort);
            this.groupBox2.Controls.Add(this.findPorts);
            this.groupBox2.Controls.Add(this.portListBox);
            this.groupBox2.Controls.Add(this.offButton);
            this.groupBox2.Controls.Add(this.onButton);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(4, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(653, 923);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arduino Control";
            // 
            // offButton
            // 
            this.offButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.offButton.Location = new System.Drawing.Point(390, 106);
            this.offButton.Name = "offButton";
            this.offButton.Size = new System.Drawing.Size(128, 117);
            this.offButton.TabIndex = 1;
            this.offButton.Text = "OFF";
            this.offButton.UseVisualStyleBackColor = true;
            this.offButton.Click += new System.EventHandler(this.offButton_Click);
            // 
            // onButton
            // 
            this.onButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.onButton.Location = new System.Drawing.Point(140, 106);
            this.onButton.Name = "onButton";
            this.onButton.Size = new System.Drawing.Size(128, 117);
            this.onButton.TabIndex = 0;
            this.onButton.Text = "ON";
            this.onButton.UseVisualStyleBackColor = true;
            this.onButton.Click += new System.EventHandler(this.onButton_Click);
            // 
            // portListBox
            // 
            this.portListBox.Location = new System.Drawing.Point(57, 308);
            this.portListBox.Name = "portListBox";
            this.portListBox.Size = new System.Drawing.Size(529, 262);
            this.portListBox.TabIndex = 2;
            this.portListBox.Text = "";
            // 
            // findPorts
            // 
            this.findPorts.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.findPorts.Location = new System.Drawing.Point(57, 588);
            this.findPorts.Name = "findPorts";
            this.findPorts.Size = new System.Drawing.Size(119, 53);
            this.findPorts.TabIndex = 3;
            this.findPorts.Text = "Find Ports";
            this.findPorts.UseVisualStyleBackColor = true;
            this.findPorts.Click += new System.EventHandler(this.findPorts_Click);
            // 
            // openPort
            // 
            this.openPort.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.openPort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openPort.Location = new System.Drawing.Point(207, 588);
            this.openPort.Name = "openPort";
            this.openPort.Size = new System.Drawing.Size(114, 52);
            this.openPort.TabIndex = 4;
            this.openPort.Text = "Open Port";
            this.openPort.UseVisualStyleBackColor = true;
            this.openPort.Click += new System.EventHandler(this.openPort_Click);
            // 
            // ArmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ArmControl";
            this.Size = new System.Drawing.Size(1203, 942);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button riseUp;
        private System.Windows.Forms.Button lowerDown;
        private System.Windows.Forms.Button rotateRight;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button offButton;
        private System.Windows.Forms.Button onButton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button findPorts;
        private System.Windows.Forms.RichTextBox portListBox;
        private System.Windows.Forms.Button openPort;
    }
}
