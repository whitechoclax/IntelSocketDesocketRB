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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArmControl));
            this.redefineButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.moveButton = new System.Windows.Forms.Button();
            this.ShiftButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.findPorts = new System.Windows.Forms.Button();
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
            this.buttonCLR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.moveXval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.moveYval = new System.Windows.Forms.NumericUpDown();
            this.moveZval = new System.Windows.Forms.NumericUpDown();
            this.RotationDegrees = new System.Windows.Forms.NumericUpDown();
            this.releaseButton = new System.Windows.Forms.Button();
            this.grabButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DownRightButton = new System.Windows.Forms.Button();
            this.DownLeftButton = new System.Windows.Forms.Button();
            this.UpLeftButton = new System.Windows.Forms.Button();
            this.UpRightButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.lowerZButton = new System.Windows.Forms.Button();
            this.raiseZButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.portListBox = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.CameraViewer = new System.Windows.Forms.Button();
            this.EffectorViewer = new System.Windows.Forms.Button();
            this.RestPos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.trayGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trayZaxis)).BeginInit();
            this.coordControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveXval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveYval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveZval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotationDegrees)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // redefineButton
            // 
            this.redefineButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redefineButton.Location = new System.Drawing.Point(232, 219);
            this.redefineButton.Margin = new System.Windows.Forms.Padding(2);
            this.redefineButton.Name = "redefineButton";
            this.redefineButton.Size = new System.Drawing.Size(88, 42);
            this.redefineButton.TabIndex = 7;
            this.redefineButton.Text = "REDEFINE";
            this.redefineButton.UseVisualStyleBackColor = true;
            this.redefineButton.Click += new System.EventHandler(this.redefineButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(28, 274);
            this.stopButton.Margin = new System.Windows.Forms.Padding(2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(292, 38);
            this.stopButton.TabIndex = 8;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // moveButton
            // 
            this.moveButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveButton.Location = new System.Drawing.Point(132, 219);
            this.moveButton.Margin = new System.Windows.Forms.Padding(2);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(78, 42);
            this.moveButton.TabIndex = 6;
            this.moveButton.Text = "MOVE";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // ShiftButton
            // 
            this.ShiftButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftButton.Location = new System.Drawing.Point(28, 219);
            this.ShiftButton.Margin = new System.Windows.Forms.Padding(2);
            this.ShiftButton.Name = "ShiftButton";
            this.ShiftButton.Size = new System.Drawing.Size(75, 42);
            this.ShiftButton.TabIndex = 5;
            this.ShiftButton.Text = "SHIFT";
            this.ShiftButton.UseVisualStyleBackColor = true;
            this.ShiftButton.Click += new System.EventHandler(this.ShiftButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.findPorts);
            this.groupBox1.Controls.Add(this.trayGroupBox);
            this.groupBox1.Controls.Add(this.coordControl);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(395, 744);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motor Control Panel";
            // 
            // findPorts
            // 
            this.findPorts.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.findPorts.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findPorts.Location = new System.Drawing.Point(15, 638);
            this.findPorts.Margin = new System.Windows.Forms.Padding(2);
            this.findPorts.Name = "findPorts";
            this.findPorts.Size = new System.Drawing.Size(118, 62);
            this.findPorts.TabIndex = 3;
            this.findPorts.Text = "Find Ports";
            this.toolTip1.SetToolTip(this.findPorts, "Click to discover connected Arduinos if not connected already");
            this.findPorts.UseVisualStyleBackColor = true;
            this.findPorts.Click += new System.EventHandler(this.findPorts_Click);
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
            this.trayGroupBox.Location = new System.Drawing.Point(15, 372);
            this.trayGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.trayGroupBox.Name = "trayGroupBox";
            this.trayGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.trayGroupBox.Size = new System.Drawing.Size(360, 238);
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
            this.traySelectorBox.Location = new System.Drawing.Point(42, 36);
            this.traySelectorBox.Margin = new System.Windows.Forms.Padding(2);
            this.traySelectorBox.Name = "traySelectorBox";
            this.traySelectorBox.Size = new System.Drawing.Size(102, 25);
            this.traySelectorBox.TabIndex = 16;
            this.traySelectorBox.SelectedIndexChanged += new System.EventHandler(this.traySelectorBox_SelectedIndexChanged);
            // 
            // trayRedefine
            // 
            this.trayRedefine.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayRedefine.Location = new System.Drawing.Point(232, 129);
            this.trayRedefine.Margin = new System.Windows.Forms.Padding(2);
            this.trayRedefine.Name = "trayRedefine";
            this.trayRedefine.Size = new System.Drawing.Size(88, 42);
            this.trayRedefine.TabIndex = 13;
            this.trayRedefine.Text = "REDEFINE";
            this.trayRedefine.UseVisualStyleBackColor = true;
            // 
            // trayMove
            // 
            this.trayMove.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayMove.Location = new System.Drawing.Point(132, 129);
            this.trayMove.Margin = new System.Windows.Forms.Padding(2);
            this.trayMove.Name = "trayMove";
            this.trayMove.Size = new System.Drawing.Size(78, 42);
            this.trayMove.TabIndex = 14;
            this.trayMove.Text = "MOVE";
            this.trayMove.UseVisualStyleBackColor = true;
            // 
            // trayStop
            // 
            this.trayStop.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayStop.Location = new System.Drawing.Point(28, 184);
            this.trayStop.Margin = new System.Windows.Forms.Padding(2);
            this.trayStop.Name = "trayStop";
            this.trayStop.Size = new System.Drawing.Size(292, 38);
            this.trayStop.TabIndex = 1;
            this.trayStop.Text = "STOP";
            this.trayStop.UseVisualStyleBackColor = true;
            // 
            // trayShift
            // 
            this.trayShift.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayShift.Location = new System.Drawing.Point(28, 129);
            this.trayShift.Margin = new System.Windows.Forms.Padding(2);
            this.trayShift.Name = "trayShift";
            this.trayShift.Size = new System.Drawing.Size(75, 42);
            this.trayShift.TabIndex = 15;
            this.trayShift.Text = "SHIFT";
            this.trayShift.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(158, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Increment Z (mm)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(158, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tray Choice 0..3";
            // 
            // trayZaxis
            // 
            this.trayZaxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayZaxis.Location = new System.Drawing.Point(58, 76);
            this.trayZaxis.Margin = new System.Windows.Forms.Padding(2);
            this.trayZaxis.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.trayZaxis.Name = "trayZaxis";
            this.trayZaxis.Size = new System.Drawing.Size(78, 25);
            this.trayZaxis.TabIndex = 17;
            // 
            // coordControl
            // 
            this.coordControl.Controls.Add(this.buttonCLR);
            this.coordControl.Controls.Add(this.stopButton);
            this.coordControl.Controls.Add(this.ShiftButton);
            this.coordControl.Controls.Add(this.label2);
            this.coordControl.Controls.Add(this.redefineButton);
            this.coordControl.Controls.Add(this.label4);
            this.coordControl.Controls.Add(this.label1);
            this.coordControl.Controls.Add(this.moveXval);
            this.coordControl.Controls.Add(this.label3);
            this.coordControl.Controls.Add(this.moveYval);
            this.coordControl.Controls.Add(this.moveZval);
            this.coordControl.Controls.Add(this.RotationDegrees);
            this.coordControl.Controls.Add(this.moveButton);
            this.coordControl.Location = new System.Drawing.Point(15, 26);
            this.coordControl.Margin = new System.Windows.Forms.Padding(2);
            this.coordControl.Name = "coordControl";
            this.coordControl.Padding = new System.Windows.Forms.Padding(2);
            this.coordControl.Size = new System.Drawing.Size(360, 332);
            this.coordControl.TabIndex = 12;
            this.coordControl.TabStop = false;
            this.coordControl.Text = "Main Arm Coordinate";
            // 
            // buttonCLR
            // 
            this.buttonCLR.Location = new System.Drawing.Point(265, 6);
            this.buttonCLR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCLR.Name = "buttonCLR";
            this.buttonCLR.Size = new System.Drawing.Size(95, 29);
            this.buttonCLR.TabIndex = 9;
            this.buttonCLR.Text = "Clear";
            this.buttonCLR.UseVisualStyleBackColor = true;
            this.buttonCLR.Click += new System.EventHandler(this.buttonCLR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "End Effector (Degrees)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Increment Y (mm)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Increment Z (cm)";
            // 
            // moveXval
            // 
            this.moveXval.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveXval.Location = new System.Drawing.Point(30, 40);
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
            this.moveXval.Size = new System.Drawing.Size(78, 23);
            this.moveXval.TabIndex = 1;
            this.moveXval.ValueChanged += new System.EventHandler(this.moveXval_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Increment X (mm)";
            // 
            // moveYval
            // 
            this.moveYval.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveYval.Location = new System.Drawing.Point(30, 85);
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
            this.moveYval.Size = new System.Drawing.Size(78, 23);
            this.moveYval.TabIndex = 2;
            this.moveYval.ValueChanged += new System.EventHandler(this.moveYval_ValueChanged);
            // 
            // moveZval
            // 
            this.moveZval.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveZval.Location = new System.Drawing.Point(30, 129);
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
            this.moveZval.Size = new System.Drawing.Size(78, 25);
            this.moveZval.TabIndex = 3;
            this.moveZval.ValueChanged += new System.EventHandler(this.moveZval_ValueChanged);
            // 
            // RotationDegrees
            // 
            this.RotationDegrees.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotationDegrees.Location = new System.Drawing.Point(30, 171);
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
            this.RotationDegrees.Size = new System.Drawing.Size(78, 25);
            this.RotationDegrees.TabIndex = 4;
            this.RotationDegrees.ValueChanged += new System.EventHandler(this.RotationDegrees_ValueChanged);
            // 
            // releaseButton
            // 
            this.releaseButton.AutoSize = true;
            this.releaseButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseButton.Location = new System.Drawing.Point(319, 161);
            this.releaseButton.Margin = new System.Windows.Forms.Padding(2);
            this.releaseButton.Name = "releaseButton";
            this.releaseButton.Size = new System.Drawing.Size(92, 46);
            this.releaseButton.TabIndex = 11;
            this.releaseButton.Text = "RELEASE";
            this.releaseButton.UseVisualStyleBackColor = true;
            this.releaseButton.Click += new System.EventHandler(this.releaseButton_Click);
            // 
            // grabButton
            // 
            this.grabButton.AutoSize = true;
            this.grabButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grabButton.Location = new System.Drawing.Point(319, 102);
            this.grabButton.Margin = new System.Windows.Forms.Padding(2);
            this.grabButton.Name = "grabButton";
            this.grabButton.Size = new System.Drawing.Size(91, 46);
            this.grabButton.TabIndex = 10;
            this.grabButton.Text = "GRAB";
            this.grabButton.UseVisualStyleBackColor = true;
            this.grabButton.Click += new System.EventHandler(this.grabButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CameraViewer);
            this.groupBox3.Controls.Add(this.EffectorViewer);
            this.groupBox3.Controls.Add(this.RestPos);
            this.groupBox3.Controls.Add(this.releaseButton);
            this.groupBox3.Controls.Add(this.DownRightButton);
            this.groupBox3.Controls.Add(this.DownLeftButton);
            this.groupBox3.Controls.Add(this.UpLeftButton);
            this.groupBox3.Controls.Add(this.grabButton);
            this.groupBox3.Controls.Add(this.UpRightButton);
            this.groupBox3.Controls.Add(this.downButton);
            this.groupBox3.Controls.Add(this.rightButton);
            this.groupBox3.Controls.Add(this.leftButton);
            this.groupBox3.Controls.Add(this.upButton);
            this.groupBox3.Controls.Add(this.lowerZButton);
            this.groupBox3.Controls.Add(this.raiseZButton);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Black", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(431, 412);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(424, 350);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Main Arm Manual Control Pad";
            this.toolTip1.SetToolTip(this.groupBox3, resources.GetString("groupBox3.ToolTip"));
            // 
            // DownRightButton
            // 
            this.DownRightButton.AutoSize = true;
            this.DownRightButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownRightButton.Location = new System.Drawing.Point(226, 214);
            this.DownRightButton.Margin = new System.Windows.Forms.Padding(2);
            this.DownRightButton.Name = "DownRightButton";
            this.DownRightButton.Size = new System.Drawing.Size(74, 62);
            this.DownRightButton.TabIndex = 24;
            this.toolTip1.SetToolTip(this.DownRightButton, "Shift +X-Y Direction");
            this.DownRightButton.UseVisualStyleBackColor = true;
            this.DownRightButton.Click += new System.EventHandler(this.DownRightButton_Click);
            // 
            // DownLeftButton
            // 
            this.DownLeftButton.AutoSize = true;
            this.DownLeftButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownLeftButton.Location = new System.Drawing.Point(42, 215);
            this.DownLeftButton.Margin = new System.Windows.Forms.Padding(2);
            this.DownLeftButton.Name = "DownLeftButton";
            this.DownLeftButton.Size = new System.Drawing.Size(74, 62);
            this.DownLeftButton.TabIndex = 23;
            this.toolTip1.SetToolTip(this.DownLeftButton, "Shift -XY Direction");
            this.DownLeftButton.UseVisualStyleBackColor = true;
            this.DownLeftButton.Click += new System.EventHandler(this.DownLeftButton_Click);
            // 
            // UpLeftButton
            // 
            this.UpLeftButton.AutoSize = true;
            this.UpLeftButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpLeftButton.Location = new System.Drawing.Point(42, 38);
            this.UpLeftButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpLeftButton.Name = "UpLeftButton";
            this.UpLeftButton.Size = new System.Drawing.Size(74, 62);
            this.UpLeftButton.TabIndex = 22;
            this.toolTip1.SetToolTip(this.UpLeftButton, "Shift -X+Y Direction");
            this.UpLeftButton.UseVisualStyleBackColor = true;
            this.UpLeftButton.Click += new System.EventHandler(this.UpLeftButton_Click);
            // 
            // UpRightButton
            // 
            this.UpRightButton.AutoSize = true;
            this.UpRightButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpRightButton.Location = new System.Drawing.Point(226, 38);
            this.UpRightButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpRightButton.Name = "UpRightButton";
            this.UpRightButton.Size = new System.Drawing.Size(74, 62);
            this.UpRightButton.TabIndex = 21;
            this.toolTip1.SetToolTip(this.UpRightButton, "Shift +XY Direction");
            this.UpRightButton.UseVisualStyleBackColor = true;
            this.UpRightButton.Click += new System.EventHandler(this.UpRightButton_Click);
            // 
            // downButton
            // 
            this.downButton.AutoSize = true;
            this.downButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downButton.Location = new System.Drawing.Point(136, 214);
            this.downButton.Margin = new System.Windows.Forms.Padding(2);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(74, 65);
            this.downButton.TabIndex = 20;
            this.downButton.Text = "↓";
            this.toolTip1.SetToolTip(this.downButton, "Shift -Y Direction");
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.AutoSize = true;
            this.rightButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightButton.Location = new System.Drawing.Point(226, 122);
            this.rightButton.Margin = new System.Windows.Forms.Padding(2);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(74, 69);
            this.rightButton.TabIndex = 19;
            this.rightButton.Text = "→";
            this.toolTip1.SetToolTip(this.rightButton, "Shift +X Direction");
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.AutoSize = true;
            this.leftButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftButton.Location = new System.Drawing.Point(42, 122);
            this.leftButton.Margin = new System.Windows.Forms.Padding(2);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(74, 69);
            this.leftButton.TabIndex = 18;
            this.leftButton.Text = "←";
            this.toolTip1.SetToolTip(this.leftButton, "Shift -X Direction");
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // upButton
            // 
            this.upButton.AutoSize = true;
            this.upButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upButton.Location = new System.Drawing.Point(136, 38);
            this.upButton.Margin = new System.Windows.Forms.Padding(2);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(74, 62);
            this.upButton.TabIndex = 17;
            this.upButton.Text = "↑";
            this.toolTip1.SetToolTip(this.upButton, "Shift +Y Direction");
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // lowerZButton
            // 
            this.lowerZButton.AutoSize = true;
            this.lowerZButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerZButton.Location = new System.Drawing.Point(136, 162);
            this.lowerZButton.Margin = new System.Windows.Forms.Padding(2);
            this.lowerZButton.Name = "lowerZButton";
            this.lowerZButton.Size = new System.Drawing.Size(74, 46);
            this.lowerZButton.TabIndex = 1;
            this.lowerZButton.Text = "LOWER";
            this.toolTip1.SetToolTip(this.lowerZButton, "Shift -Z direction");
            this.lowerZButton.UseVisualStyleBackColor = true;
            this.lowerZButton.Click += new System.EventHandler(this.lowerZButton_Click);
            // 
            // raiseZButton
            // 
            this.raiseZButton.AutoSize = true;
            this.raiseZButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raiseZButton.Location = new System.Drawing.Point(136, 109);
            this.raiseZButton.Margin = new System.Windows.Forms.Padding(2);
            this.raiseZButton.Name = "raiseZButton";
            this.raiseZButton.Size = new System.Drawing.Size(74, 49);
            this.raiseZButton.TabIndex = 0;
            this.raiseZButton.Text = "RAISE";
            this.toolTip1.SetToolTip(this.raiseZButton, "Shift +Z Direction");
            this.raiseZButton.UseVisualStyleBackColor = true;
            this.raiseZButton.Click += new System.EventHandler(this.raiseZButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.portListBox);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(431, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(410, 368);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arduino Control";
            // 
            // portListBox
            // 
            this.portListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.portListBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.portListBox.Location = new System.Drawing.Point(2, 30);
            this.portListBox.Margin = new System.Windows.Forms.Padding(2);
            this.portListBox.Name = "portListBox";
            this.portListBox.ReadOnly = true;
            this.portListBox.Size = new System.Drawing.Size(406, 336);
            this.portListBox.TabIndex = 2;
            this.portListBox.Text = "";
            // 
            // CameraViewer
            // 
            this.CameraViewer.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CameraViewer.Location = new System.Drawing.Point(6, 285);
            this.CameraViewer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CameraViewer.Name = "CameraViewer";
            this.CameraViewer.Size = new System.Drawing.Size(136, 56);
            this.CameraViewer.TabIndex = 18;
            this.CameraViewer.Text = "Switch to Camera Position";
            this.CameraViewer.UseVisualStyleBackColor = true;
            this.CameraViewer.Click += new System.EventHandler(this.CameraViewer_Click);
            // 
            // EffectorViewer
            // 
            this.EffectorViewer.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EffectorViewer.Location = new System.Drawing.Point(143, 285);
            this.EffectorViewer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EffectorViewer.Name = "EffectorViewer";
            this.EffectorViewer.Size = new System.Drawing.Size(135, 55);
            this.EffectorViewer.TabIndex = 19;
            this.EffectorViewer.Text = "Switch to Effector Position";
            this.EffectorViewer.UseVisualStyleBackColor = true;
            this.EffectorViewer.Click += new System.EventHandler(this.EffectorViewer_Click);
            // 
            // RestPos
            // 
            this.RestPos.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestPos.Location = new System.Drawing.Point(280, 285);
            this.RestPos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RestPos.Name = "RestPos";
            this.RestPos.Size = new System.Drawing.Size(138, 55);
            this.RestPos.TabIndex = 20;
            this.RestPos.Text = "Return To Home Position";
            this.RestPos.UseVisualStyleBackColor = true;
            this.RestPos.Click += new System.EventHandler(this.RestPos_Click);
            // 
            // ArmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ArmControl";
            this.Size = new System.Drawing.Size(905, 782);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button grabButton;
        private System.Windows.Forms.Button releaseButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button lowerZButton;
        private System.Windows.Forms.Button raiseZButton;
        private System.Windows.Forms.Button DownRightButton;
        private System.Windows.Forms.Button DownLeftButton;
        private System.Windows.Forms.Button UpLeftButton;
        private System.Windows.Forms.Button UpRightButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button CameraViewer;
        private System.Windows.Forms.Button EffectorViewer;
        private System.Windows.Forms.Button RestPos;
        private System.Windows.Forms.Button buttonCLR;
    }
}
