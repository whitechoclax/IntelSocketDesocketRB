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
            this.ArmFeedBox = new Emgu.CV.UI.ImageBox();
            this.upButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.grabButton = new System.Windows.Forms.Button();
            this.releaseButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.captureButton = new System.Windows.Forms.Button();
            this.UpRightButton = new System.Windows.Forms.Button();
            this.UpLeftButton = new System.Windows.Forms.Button();
            this.DownLeftButton = new System.Windows.Forms.Button();
            this.DownRightButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.trayGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trayZaxis)).BeginInit();
            this.coordControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveXval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveYval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveZval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotationDegrees)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArmFeedBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // redefineButton
            // 
            this.redefineButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redefineButton.Location = new System.Drawing.Point(260, 272);
            this.redefineButton.Name = "redefineButton";
            this.redefineButton.Size = new System.Drawing.Size(106, 50);
            this.redefineButton.TabIndex = 0;
            this.redefineButton.Text = "REDEFINE";
            this.redefineButton.UseVisualStyleBackColor = true;
            this.redefineButton.Click += new System.EventHandler(this.redefineButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(14, 338);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(352, 45);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // moveButton
            // 
            this.moveButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveButton.Location = new System.Drawing.Point(141, 272);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(93, 50);
            this.moveButton.TabIndex = 2;
            this.moveButton.Text = "MOVE";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // ShiftButton
            // 
            this.ShiftButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftButton.Location = new System.Drawing.Point(14, 272);
            this.ShiftButton.Name = "ShiftButton";
            this.ShiftButton.Size = new System.Drawing.Size(90, 50);
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
            this.groupBox1.Location = new System.Drawing.Point(603, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 766);
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
            this.trayGroupBox.Location = new System.Drawing.Point(33, 464);
            this.trayGroupBox.Name = "trayGroupBox";
            this.trayGroupBox.Size = new System.Drawing.Size(381, 284);
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
            this.traySelectorBox.Location = new System.Drawing.Point(33, 42);
            this.traySelectorBox.Name = "traySelectorBox";
            this.traySelectorBox.Size = new System.Drawing.Size(121, 29);
            this.traySelectorBox.TabIndex = 16;
            this.traySelectorBox.SelectedIndexChanged += new System.EventHandler(this.traySelectorBox_SelectedIndexChanged);
            // 
            // trayRedefine
            // 
            this.trayRedefine.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayRedefine.Location = new System.Drawing.Point(260, 153);
            this.trayRedefine.Name = "trayRedefine";
            this.trayRedefine.Size = new System.Drawing.Size(106, 50);
            this.trayRedefine.TabIndex = 13;
            this.trayRedefine.Text = "REDEFINE";
            this.trayRedefine.UseVisualStyleBackColor = true;
            // 
            // trayMove
            // 
            this.trayMove.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayMove.Location = new System.Drawing.Point(141, 153);
            this.trayMove.Name = "trayMove";
            this.trayMove.Size = new System.Drawing.Size(93, 50);
            this.trayMove.TabIndex = 14;
            this.trayMove.Text = "MOVE";
            this.trayMove.UseVisualStyleBackColor = true;
            // 
            // trayStop
            // 
            this.trayStop.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayStop.Location = new System.Drawing.Point(14, 220);
            this.trayStop.Name = "trayStop";
            this.trayStop.Size = new System.Drawing.Size(352, 45);
            this.trayStop.TabIndex = 1;
            this.trayStop.Text = "STOP";
            this.trayStop.UseVisualStyleBackColor = true;
            // 
            // trayShift
            // 
            this.trayShift.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayShift.Location = new System.Drawing.Point(14, 153);
            this.trayShift.Name = "trayShift";
            this.trayShift.Size = new System.Drawing.Size(90, 50);
            this.trayShift.TabIndex = 15;
            this.trayShift.Text = "SHIFT";
            this.trayShift.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(171, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Increment Z (cm)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(171, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tray Choice 0..3";
            // 
            // trayZaxis
            // 
            this.trayZaxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayZaxis.Location = new System.Drawing.Point(51, 90);
            this.trayZaxis.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.trayZaxis.Name = "trayZaxis";
            this.trayZaxis.Size = new System.Drawing.Size(92, 29);
            this.trayZaxis.TabIndex = 5;
            // 
            // coordControl
            // 
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
            this.coordControl.Location = new System.Drawing.Point(33, 36);
            this.coordControl.Name = "coordControl";
            this.coordControl.Size = new System.Drawing.Size(381, 400);
            this.coordControl.TabIndex = 12;
            this.coordControl.TabStop = false;
            this.coordControl.Text = "Main Arm Coordinate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rotation (Degrees)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Increment Y (mm)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Increment Z (cm)";
            // 
            // moveXval
            // 
            this.moveXval.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveXval.Location = new System.Drawing.Point(51, 39);
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
            this.moveXval.Size = new System.Drawing.Size(92, 26);
            this.moveXval.TabIndex = 8;
            this.moveXval.ValueChanged += new System.EventHandler(this.moveXval_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Increment X (mm)";
            // 
            // moveYval
            // 
            this.moveYval.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveYval.Location = new System.Drawing.Point(51, 99);
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
            this.moveYval.Size = new System.Drawing.Size(92, 26);
            this.moveYval.TabIndex = 9;
            this.moveYval.ValueChanged += new System.EventHandler(this.moveYval_ValueChanged);
            // 
            // moveZval
            // 
            this.moveZval.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveZval.Location = new System.Drawing.Point(51, 158);
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
            this.moveZval.Size = new System.Drawing.Size(92, 29);
            this.moveZval.TabIndex = 5;
            this.moveZval.ValueChanged += new System.EventHandler(this.moveZval_ValueChanged);
            // 
            // RotationDegrees
            // 
            this.RotationDegrees.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotationDegrees.Location = new System.Drawing.Point(51, 210);
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
            this.RotationDegrees.Size = new System.Drawing.Size(92, 29);
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
            this.groupBox2.Location = new System.Drawing.Point(3, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 768);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arduino Control";
            // 
            // findPorts
            // 
            this.findPorts.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.findPorts.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findPorts.Location = new System.Drawing.Point(15, 441);
            this.findPorts.Name = "findPorts";
            this.findPorts.Size = new System.Drawing.Size(141, 75);
            this.findPorts.TabIndex = 3;
            this.findPorts.Text = "Find Ports";
            this.toolTip1.SetToolTip(this.findPorts, "Click to discover connected Arduinos if not connected already");
            this.findPorts.UseVisualStyleBackColor = true;
            this.findPorts.Click += new System.EventHandler(this.findPorts_Click);
            // 
            // portListBox
            // 
            this.portListBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.portListBox.Location = new System.Drawing.Point(15, 42);
            this.portListBox.Name = "portListBox";
            this.portListBox.ReadOnly = true;
            this.portListBox.Size = new System.Drawing.Size(564, 381);
            this.portListBox.TabIndex = 2;
            this.portListBox.Text = "";
            // 
            // ArmFeedBox
            // 
            this.ArmFeedBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ArmFeedBox.Location = new System.Drawing.Point(1044, 26);
            this.ArmFeedBox.Name = "ArmFeedBox";
            this.ArmFeedBox.Size = new System.Drawing.Size(640, 458);
            this.ArmFeedBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ArmFeedBox.TabIndex = 2;
            this.ArmFeedBox.TabStop = false;
            // 
            // upButton
            // 
            this.upButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upButton.Location = new System.Drawing.Point(1320, 548);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(75, 75);
            this.upButton.TabIndex = 6;
            this.upButton.UseVisualStyleBackColor = true;
            // 
            // leftButton
            // 
            this.leftButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftButton.Location = new System.Drawing.Point(1210, 649);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(75, 75);
            this.leftButton.TabIndex = 7;
            this.leftButton.UseVisualStyleBackColor = true;
            // 
            // rightButton
            // 
            this.rightButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightButton.Location = new System.Drawing.Point(1430, 649);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(75, 75);
            this.rightButton.TabIndex = 8;
            this.rightButton.UseVisualStyleBackColor = true;
            // 
            // downButton
            // 
            this.downButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downButton.Location = new System.Drawing.Point(1320, 760);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(75, 75);
            this.downButton.TabIndex = 9;
            this.downButton.UseVisualStyleBackColor = true;
            // 
            // grabButton
            // 
            this.grabButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grabButton.Location = new System.Drawing.Point(1566, 566);
            this.grabButton.Name = "grabButton";
            this.grabButton.Size = new System.Drawing.Size(95, 55);
            this.grabButton.TabIndex = 10;
            this.grabButton.Text = "GRAB";
            this.grabButton.UseVisualStyleBackColor = true;
            this.grabButton.Click += new System.EventHandler(this.grabButton_Click);
            // 
            // releaseButton
            // 
            this.releaseButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseButton.Location = new System.Drawing.Point(1566, 634);
            this.releaseButton.Name = "releaseButton";
            this.releaseButton.Size = new System.Drawing.Size(95, 55);
            this.releaseButton.TabIndex = 11;
            this.releaseButton.Text = "RELEASE";
            this.releaseButton.UseVisualStyleBackColor = true;
            this.releaseButton.Click += new System.EventHandler(this.releaseButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // captureButton
            // 
            this.captureButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captureButton.Location = new System.Drawing.Point(1049, 507);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(126, 39);
            this.captureButton.TabIndex = 12;
            this.captureButton.Text = "Start Capture";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // UpRightButton
            // 
            this.UpRightButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpRightButton.Location = new System.Drawing.Point(1430, 548);
            this.UpRightButton.Name = "UpRightButton";
            this.UpRightButton.Size = new System.Drawing.Size(75, 75);
            this.UpRightButton.TabIndex = 13;
            this.UpRightButton.UseVisualStyleBackColor = true;
            // 
            // UpLeftButton
            // 
            this.UpLeftButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpLeftButton.Location = new System.Drawing.Point(1210, 548);
            this.UpLeftButton.Name = "UpLeftButton";
            this.UpLeftButton.Size = new System.Drawing.Size(75, 75);
            this.UpLeftButton.TabIndex = 14;
            this.UpLeftButton.UseVisualStyleBackColor = true;
            // 
            // DownLeftButton
            // 
            this.DownLeftButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownLeftButton.Location = new System.Drawing.Point(1210, 760);
            this.DownLeftButton.Name = "DownLeftButton";
            this.DownLeftButton.Size = new System.Drawing.Size(75, 75);
            this.DownLeftButton.TabIndex = 15;
            this.DownLeftButton.UseVisualStyleBackColor = true;
            // 
            // DownRightButton
            // 
            this.DownRightButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownRightButton.Location = new System.Drawing.Point(1430, 760);
            this.DownRightButton.Name = "DownRightButton";
            this.DownRightButton.Size = new System.Drawing.Size(75, 75);
            this.DownRightButton.TabIndex = 16;
            this.DownRightButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(1195, 490);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 365);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Main arm Manual Control Pad";
            this.toolTip1.SetToolTip(this.groupBox3, resources.GetString("groupBox3.ToolTip"));
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(125, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "RAISE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(125, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "LOWER";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ArmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.DownRightButton);
            this.Controls.Add(this.DownLeftButton);
            this.Controls.Add(this.UpLeftButton);
            this.Controls.Add(this.UpRightButton);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.releaseButton);
            this.Controls.Add(this.grabButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.ArmFeedBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "ArmControl";
            this.Size = new System.Drawing.Size(1696, 876);
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
            ((System.ComponentModel.ISupportInitialize)(this.ArmFeedBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
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
        private Emgu.CV.UI.ImageBox ArmFeedBox;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button grabButton;
        private System.Windows.Forms.Button releaseButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.Button UpRightButton;
        private System.Windows.Forms.Button UpLeftButton;
        private System.Windows.Forms.Button DownLeftButton;
        private System.Windows.Forms.Button DownRightButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
