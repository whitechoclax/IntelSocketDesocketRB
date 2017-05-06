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
            this.redefineButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.moveButton = new System.Windows.Forms.Button();
            this.ShiftButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trayGroupBox = new System.Windows.Forms.GroupBox();
            this.traySelectorBox = new System.Windows.Forms.ComboBox();
            this.trayRedefine = new System.Windows.Forms.Button();
            this.trayMove = new System.Windows.Forms.Button();
            this.trayStop = new System.Windows.Forms.Button();
            this.trayShift = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trayZaxis = new System.Windows.Forms.NumericUpDown();
            this.coordControl = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.moveXval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.moveYval = new System.Windows.Forms.NumericUpDown();
            this.moveZval = new System.Windows.Forms.NumericUpDown();
            this.RotationDegrees = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.findPorts = new System.Windows.Forms.Button();
            this.portListBox = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.captureButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cameraBox = new Emgu.CV.UI.ImageBox();
            this.groupBox1.SuspendLayout();
            this.trayGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trayZaxis)).BeginInit();
            this.coordControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveXval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveYval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveZval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotationDegrees)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).BeginInit();
            this.SuspendLayout();
            // 
            // redefineButton
            // 
            this.redefineButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redefineButton.Location = new System.Drawing.Point(273, 271);
            this.redefineButton.Margin = new System.Windows.Forms.Padding(2);
            this.redefineButton.Name = "redefineButton";
            this.redefineButton.Size = new System.Drawing.Size(107, 49);
            this.redefineButton.TabIndex = 0;
            this.redefineButton.Text = "REDEFINE";
            this.redefineButton.UseVisualStyleBackColor = true;
            this.redefineButton.Click += new System.EventHandler(this.redefineButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(27, 337);
            this.stopButton.Margin = new System.Windows.Forms.Padding(2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(353, 44);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // moveButton
            // 
            this.moveButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveButton.Location = new System.Drawing.Point(152, 271);
            this.moveButton.Margin = new System.Windows.Forms.Padding(2);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(92, 49);
            this.moveButton.TabIndex = 2;
            this.moveButton.Text = "MOVE";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // ShiftButton
            // 
            this.ShiftButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftButton.Location = new System.Drawing.Point(27, 271);
            this.ShiftButton.Margin = new System.Windows.Forms.Padding(2);
            this.ShiftButton.Name = "ShiftButton";
            this.ShiftButton.Size = new System.Drawing.Size(90, 49);
            this.ShiftButton.TabIndex = 3;
            this.ShiftButton.Text = "SHIFT";
            this.ShiftButton.UseVisualStyleBackColor = true;
            this.ShiftButton.Click += new System.EventHandler(this.ShiftButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trayGroupBox);
            this.groupBox1.Controls.Add(this.coordControl);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(662, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(454, 923);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motor Control Panel";
            // 
            // trayGroupBox
            // 
            this.trayGroupBox.Controls.Add(this.traySelectorBox);
            this.trayGroupBox.Controls.Add(this.trayRedefine);
            this.trayGroupBox.Controls.Add(this.trayMove);
            this.trayGroupBox.Controls.Add(this.trayStop);
            this.trayGroupBox.Controls.Add(this.trayShift);
            this.trayGroupBox.Controls.Add(this.label7);
            this.trayGroupBox.Controls.Add(this.label8);
            this.trayGroupBox.Controls.Add(this.trayZaxis);
            this.trayGroupBox.Location = new System.Drawing.Point(34, 463);
            this.trayGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.trayGroupBox.Name = "trayGroupBox";
            this.trayGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.trayGroupBox.Size = new System.Drawing.Size(405, 283);
            this.trayGroupBox.TabIndex = 16;
            this.trayGroupBox.TabStop = false;
            this.trayGroupBox.Text = "Tray Arm Coordinate";
            // 
            // traySelectorBox
            // 
            this.traySelectorBox.FormattingEnabled = true;
            this.traySelectorBox.Items.AddRange(new object[] {
            "Untested Tray",
            "Good Tray",
            "Empty Tray",
            "Bad Tray"});
            this.traySelectorBox.Location = new System.Drawing.Point(27, 42);
            this.traySelectorBox.Margin = new System.Windows.Forms.Padding(2);
            this.traySelectorBox.Name = "traySelectorBox";
            this.traySelectorBox.Size = new System.Drawing.Size(125, 29);
            this.traySelectorBox.TabIndex = 16;
            this.traySelectorBox.SelectedIndexChanged += new System.EventHandler(this.traySelectorBox_SelectedIndexChanged);
            // 
            // trayRedefine
            // 
            this.trayRedefine.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayRedefine.Location = new System.Drawing.Point(273, 154);
            this.trayRedefine.Margin = new System.Windows.Forms.Padding(2);
            this.trayRedefine.Name = "trayRedefine";
            this.trayRedefine.Size = new System.Drawing.Size(107, 49);
            this.trayRedefine.TabIndex = 13;
            this.trayRedefine.Text = "REDEFINE";
            this.trayRedefine.UseVisualStyleBackColor = true;
            // 
            // trayMove
            // 
            this.trayMove.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayMove.Location = new System.Drawing.Point(152, 154);
            this.trayMove.Margin = new System.Windows.Forms.Padding(2);
            this.trayMove.Name = "trayMove";
            this.trayMove.Size = new System.Drawing.Size(92, 49);
            this.trayMove.TabIndex = 14;
            this.trayMove.Text = "MOVE";
            this.trayMove.UseVisualStyleBackColor = true;
            // 
            // trayStop
            // 
            this.trayStop.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayStop.Location = new System.Drawing.Point(27, 218);
            this.trayStop.Margin = new System.Windows.Forms.Padding(2);
            this.trayStop.Name = "trayStop";
            this.trayStop.Size = new System.Drawing.Size(353, 44);
            this.trayStop.TabIndex = 1;
            this.trayStop.Text = "STOP";
            this.trayStop.UseVisualStyleBackColor = true;
            // 
            // trayShift
            // 
            this.trayShift.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayShift.Location = new System.Drawing.Point(27, 154);
            this.trayShift.Margin = new System.Windows.Forms.Padding(2);
            this.trayShift.Name = "trayShift";
            this.trayShift.Size = new System.Drawing.Size(90, 49);
            this.trayShift.TabIndex = 15;
            this.trayShift.Text = "SHIFT";
            this.trayShift.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(172, 96);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Increment Z (cm)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(172, 42);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tray Choice 0..3";
            // 
            // trayZaxis
            // 
            this.trayZaxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayZaxis.Location = new System.Drawing.Point(27, 90);
            this.trayZaxis.Margin = new System.Windows.Forms.Padding(2);
            this.trayZaxis.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.trayZaxis.Name = "trayZaxis";
            this.trayZaxis.Size = new System.Drawing.Size(125, 29);
            this.trayZaxis.TabIndex = 5;
            // 
            // coordControl
            // 
            this.coordControl.Controls.Add(this.stopButton);
            this.coordControl.Controls.Add(this.ShiftButton);
            this.coordControl.Controls.Add(this.moveButton);
            this.coordControl.Controls.Add(this.label2);
            this.coordControl.Controls.Add(this.label4);
            this.coordControl.Controls.Add(this.redefineButton);
            this.coordControl.Controls.Add(this.label1);
            this.coordControl.Controls.Add(this.moveXval);
            this.coordControl.Controls.Add(this.label3);
            this.coordControl.Controls.Add(this.moveYval);
            this.coordControl.Controls.Add(this.moveZval);
            this.coordControl.Controls.Add(this.RotationDegrees);
            this.coordControl.Location = new System.Drawing.Point(34, 36);
            this.coordControl.Margin = new System.Windows.Forms.Padding(2);
            this.coordControl.Name = "coordControl";
            this.coordControl.Padding = new System.Windows.Forms.Padding(2);
            this.coordControl.Size = new System.Drawing.Size(405, 401);
            this.coordControl.TabIndex = 12;
            this.coordControl.TabStop = false;
            this.coordControl.Text = "Main Arm Coordinate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rotation (Degrees)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Increment Y (mm)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Increment Z (cm)";
            // 
            // moveXval
            // 
            this.moveXval.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveXval.Location = new System.Drawing.Point(52, 38);
            this.moveXval.Margin = new System.Windows.Forms.Padding(2);
            this.moveXval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.moveXval.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.moveXval.Name = "moveXval";
            this.moveXval.Size = new System.Drawing.Size(91, 26);
            this.moveXval.TabIndex = 8;
            this.moveXval.ValueChanged += new System.EventHandler(this.moveXval_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Increment X (mm)";
            // 
            // moveYval
            // 
            this.moveYval.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveYval.Location = new System.Drawing.Point(52, 98);
            this.moveYval.Margin = new System.Windows.Forms.Padding(2);
            this.moveYval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.moveYval.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.moveYval.Name = "moveYval";
            this.moveYval.Size = new System.Drawing.Size(91, 26);
            this.moveYval.TabIndex = 9;
            this.moveYval.ValueChanged += new System.EventHandler(this.moveYval_ValueChanged);
            // 
            // moveZval
            // 
            this.moveZval.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveZval.Location = new System.Drawing.Point(52, 157);
            this.moveZval.Margin = new System.Windows.Forms.Padding(2);
            this.moveZval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.moveZval.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.moveZval.Name = "moveZval";
            this.moveZval.Size = new System.Drawing.Size(91, 29);
            this.moveZval.TabIndex = 5;
            this.moveZval.ValueChanged += new System.EventHandler(this.moveZval_ValueChanged);
            // 
            // RotationDegrees
            // 
            this.RotationDegrees.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotationDegrees.Location = new System.Drawing.Point(52, 210);
            this.RotationDegrees.Margin = new System.Windows.Forms.Padding(2);
            this.RotationDegrees.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.RotationDegrees.Minimum = new decimal(new int[] {
            359,
            0,
            0,
            -2147483648});
            this.RotationDegrees.Name = "RotationDegrees";
            this.RotationDegrees.Size = new System.Drawing.Size(91, 29);
            this.RotationDegrees.TabIndex = 4;
            this.RotationDegrees.ValueChanged += new System.EventHandler(this.RotationDegrees_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Orange;
            this.groupBox2.Controls.Add(this.findPorts);
            this.groupBox2.Controls.Add(this.portListBox);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(4, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(653, 923);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arduino Control";
            // 
            // findPorts
            // 
            this.findPorts.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.findPorts.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findPorts.Location = new System.Drawing.Point(47, 430);
            this.findPorts.Margin = new System.Windows.Forms.Padding(2);
            this.findPorts.Name = "findPorts";
            this.findPorts.Size = new System.Drawing.Size(140, 76);
            this.findPorts.TabIndex = 3;
            this.findPorts.Text = "Find Ports";
            this.findPorts.UseVisualStyleBackColor = true;
            this.findPorts.Click += new System.EventHandler(this.findPorts_Click);
            // 
            // portListBox
            // 
            this.portListBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.portListBox.Location = new System.Drawing.Point(47, 66);
            this.portListBox.Margin = new System.Windows.Forms.Padding(2);
            this.portListBox.Name = "portListBox";
            this.portListBox.ReadOnly = true;
            this.portListBox.Size = new System.Drawing.Size(575, 316);
            this.portListBox.TabIndex = 2;
            this.portListBox.Text = "";
            // 
            // captureButton
            // 
            this.captureButton.Location = new System.Drawing.Point(1121, 561);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(133, 43);
            this.captureButton.TabIndex = 6;
            this.captureButton.Text = "Start Capture";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1122, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Camera Feed";
            // 
            // cameraBox
            // 
            this.cameraBox.Location = new System.Drawing.Point(1127, 58);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(640, 480);
            this.cameraBox.TabIndex = 2;
            this.cameraBox.TabStop = false;
            this.cameraBox.Paint += new System.Windows.Forms.PaintEventHandler(this.cameraBox_Paint_1);
            // 
            // ArmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.cameraBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ArmControl";
            this.Size = new System.Drawing.Size(1783, 942);
            this.groupBox1.ResumeLayout(false);
            this.trayGroupBox.ResumeLayout(false);
            this.trayGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trayZaxis)).EndInit();
            this.coordControl.ResumeLayout(false);
            this.coordControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveXval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveYval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveZval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotationDegrees)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button redefineButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Button ShiftButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button findPorts;
        private System.Windows.Forms.RichTextBox portListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown moveZval;
        private System.Windows.Forms.NumericUpDown RotationDegrees;
        private System.Windows.Forms.GroupBox coordControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown moveXval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown moveYval;
        private System.Windows.Forms.Button trayRedefine;
        private System.Windows.Forms.Button trayMove;
        private System.Windows.Forms.Button trayStop;
        private System.Windows.Forms.Button trayShift;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown trayZaxis;
        private System.Windows.Forms.ComboBox traySelectorBox;
        public System.Windows.Forms.GroupBox trayGroupBox;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.Label label5;
        private Emgu.CV.UI.ImageBox cameraBox;
    }
}
