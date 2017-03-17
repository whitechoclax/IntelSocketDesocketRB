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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.offButton = new System.Windows.Forms.Button();
            this.onButton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.portListBox = new System.Windows.Forms.RichTextBox();
            this.findPorts = new System.Windows.Forms.Button();
            this.openPort = new System.Windows.Forms.Button();
            this.RotationDegrees = new System.Windows.Forms.NumericUpDown();
            this.raiseValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotationDegrees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raiseValue)).BeginInit();
            this.SuspendLayout();
            // 
            // riseUp
            // 
            this.riseUp.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.riseUp.Location = new System.Drawing.Point(27, 370);
            this.riseUp.Name = "riseUp";
            this.riseUp.Size = new System.Drawing.Size(134, 114);
            this.riseUp.TabIndex = 0;
            this.riseUp.Text = "Rise UP";
            this.riseUp.UseVisualStyleBackColor = true;
            // 
            // lowerDown
            // 
            this.lowerDown.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerDown.Location = new System.Drawing.Point(27, 505);
            this.lowerDown.Name = "lowerDown";
            this.lowerDown.Size = new System.Drawing.Size(134, 117);
            this.lowerDown.TabIndex = 1;
            this.lowerDown.Text = "Lower Down";
            this.lowerDown.UseVisualStyleBackColor = true;
            // 
            // rotateRight
            // 
            this.rotateRight.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotateRight.Location = new System.Drawing.Point(27, 189);
            this.rotateRight.Name = "rotateRight";
            this.rotateRight.Size = new System.Drawing.Size(133, 117);
            this.rotateRight.TabIndex = 2;
            this.rotateRight.Text = "Rotate Right";
            this.rotateRight.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(27, 66);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 117);
            this.button4.TabIndex = 3;
            this.button4.Text = "Rotate Left";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.raiseValue);
            this.groupBox1.Controls.Add(this.RotationDegrees);
            this.groupBox1.Controls.Add(this.lowerDown);
            this.groupBox1.Controls.Add(this.rotateRight);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.riseUp);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(663, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 923);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motor Control Panel";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Goldenrod;
            this.groupBox2.Controls.Add(this.openPort);
            this.groupBox2.Controls.Add(this.findPorts);
            this.groupBox2.Controls.Add(this.portListBox);
            this.groupBox2.Controls.Add(this.offButton);
            this.groupBox2.Controls.Add(this.onButton);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.offButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.onButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.portListBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portListBox.Location = new System.Drawing.Point(47, 357);
            this.portListBox.Name = "portListBox";
            this.portListBox.Size = new System.Drawing.Size(283, 182);
            this.portListBox.TabIndex = 2;
            this.portListBox.Text = "";
            // 
            // findPorts
            // 
            this.findPorts.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.findPorts.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findPorts.Location = new System.Drawing.Point(47, 576);
            this.findPorts.Name = "findPorts";
            this.findPorts.Size = new System.Drawing.Size(141, 76);
            this.findPorts.TabIndex = 3;
            this.findPorts.Text = "Find Ports";
            this.findPorts.UseVisualStyleBackColor = true;
            this.findPorts.Click += new System.EventHandler(this.findPorts_Click);
            // 
            // openPort
            // 
            this.openPort.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.openPort.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openPort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openPort.Location = new System.Drawing.Point(47, 658);
            this.openPort.Name = "openPort";
            this.openPort.Size = new System.Drawing.Size(141, 76);
            this.openPort.TabIndex = 4;
            this.openPort.Text = "Open Port";
            this.openPort.UseVisualStyleBackColor = true;
            this.openPort.Click += new System.EventHandler(this.openPort_Click);
            // 
            // RotationDegrees
            // 
            this.RotationDegrees.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotationDegrees.Location = new System.Drawing.Point(231, 189);
            this.RotationDegrees.Name = "RotationDegrees";
            this.RotationDegrees.Size = new System.Drawing.Size(91, 29);
            this.RotationDegrees.TabIndex = 4;
            // 
            // raiseValue
            // 
            this.raiseValue.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raiseValue.Location = new System.Drawing.Point(231, 415);
            this.raiseValue.Name = "raiseValue";
            this.raiseValue.Size = new System.Drawing.Size(91, 29);
            this.raiseValue.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Increment (cm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rotation (Degrees)";
            // 
            // ArmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ArmControl";
            this.Size = new System.Drawing.Size(1249, 942);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RotationDegrees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raiseValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button riseUp;
        private System.Windows.Forms.Button lowerDown;
        private System.Windows.Forms.Button rotateRight;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button offButton;
        private System.Windows.Forms.Button onButton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button findPorts;
        private System.Windows.Forms.RichTextBox portListBox;
        private System.Windows.Forms.Button openPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown raiseValue;
        private System.Windows.Forms.NumericUpDown RotationDegrees;
    }
}
