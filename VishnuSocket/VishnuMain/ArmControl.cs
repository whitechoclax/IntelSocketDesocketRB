﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;


namespace VishnuMain
{
    public partial class ArmControl : UserControl
    {
        delegate void SetTextCallback(string text);
        int portID = 0;
        int ZcoordinateValue;
        int RotationVal;
        int XcoordinateValue;
        int YcoordinateValue;
        int TrayChoiceValue;
        public int LocationChoiceValue = 0;
        public Capture _capture;
        public bool _captureInProgress;
        private double xShift, yShift = 0.0;
        private double NewCameraX, NewCameraY = 0.0;
        private bool gripperPresented = true;
        
        public ArmControl()
        {
            InitializeComponent();
            BootMessages();
            findPorts.Enabled = true;
            calibrationSelectorBox.SelectedIndex = 0;
            //set unicode vlaues for the buttons
            DownLeftButton.Text = char.ConvertFromUtf32(0x2199);
            DownRightButton.Text = char.ConvertFromUtf32(0x2198);
            UpLeftButton.Text = char.ConvertFromUtf32(0x2196);
            UpRightButton.Text = char.ConvertFromUtf32(0x2197);
        }

        //arduino messages/connections
        private void BootMessages()
        {
            if (ArduinoMotionLibrary.Arduinos[0] != 2)
            {
                portListBox.AppendText("Main Robot Arm Connected" + Environment.NewLine);
                coordControl.Enabled = true;
                groupBox3.Enabled = true;
            }
            else if (ArduinoMotionLibrary.Arduinos[0] == 2)
            {
                portListBox.AppendText("Main Robot Arm is Disconnected" + Environment.NewLine);
                coordControl.Enabled = false;
                groupBox3.Enabled = false;
            }
            //default 2 means not connected. 
            if (ArduinoMotionLibrary.Arduinos[1] != 2)
            {
                portListBox.AppendText("Tray Handler Connected" + Environment.NewLine);
                trayGroupBox.Enabled = true;
            }
            else if (ArduinoMotionLibrary.Arduinos[1] == 2)
            {
                portListBox.AppendText("Tray Handler Arm is Disconnected" + Environment.NewLine);
                trayGroupBox.Enabled = false;
            }

        }

        private void openPort_Click(object sender, EventArgs e)
        {
            portListBox.AppendText(portID + " opened.");
            MessageBox.Show("COM PORT not found, Arduino Connected?" + Environment.NewLine);
        }

        //ALL coordinate values assignment functions
        private void moveXval_ValueChanged(object sender, EventArgs e)
        {
            XcoordinateValue = (int)moveXval.Value;
        }

        private void moveZval_ValueChanged(object sender, EventArgs e)
        {
            ZcoordinateValue = (int)moveZval.Value;
        }

        private void moveYval_ValueChanged(object sender, EventArgs e)
        {
            YcoordinateValue = (int)moveYval.Value;
        }

        private void RotationDegrees_ValueChanged(object sender, EventArgs e)
        {
            RotationVal = (int)RotationDegrees.Value;
        }


        //Run motor functions
        private void stopButton_Click(object sender, EventArgs e)
        {
            var BWS = new BackgroundWorker();
            BWS.DoWork += delegate
            {
                ArduinoMotionLibrary.StopMotor();
            };
            BWS.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("EMERGENCY STOP ASYNC" + Environment.NewLine);
            };
            BWS.RunWorkerAsync();

        }


        //ASYNC TASKS


        private void redefineButton_Click(object sender, EventArgs e)
        {
            var BWR = new BackgroundWorker();
            BWR.DoWork += delegate
            {
                if( ArduinoMotionLibrary.ArdPosition("REDEF", portID, XcoordinateValue, YcoordinateValue, ZcoordinateValue, RotationVal) == 2)
                { MessageBox.Show("Movement either encountered an error or Must wait until movement has finished" + Environment.NewLine); }
            };
            BWR.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("REDEF " + XcoordinateValue.ToString() + YcoordinateValue.ToString() + ZcoordinateValue.ToString() + RotationVal.ToString() + Environment.NewLine);
                portListBox.ScrollToCaret();
            };
            BWR.RunWorkerAsync();

        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            var BWM = new BackgroundWorker();
            BWM.DoWork += delegate
            {
                if(ArduinoMotionLibrary.ArdPosition("MOVE", portID, XcoordinateValue, YcoordinateValue, ZcoordinateValue, RotationVal) == -2)
                { MessageBox.Show("Movement either encountered an error or Must wait until movement has finished"); }
            };
            BWM.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("MOVE " + XcoordinateValue.ToString() + YcoordinateValue.ToString() + ZcoordinateValue.ToString() + RotationVal.ToString() + Environment.NewLine);
                portListBox.ScrollToCaret();
            };
            BWM.RunWorkerAsync();

        }

        private void ShiftButton_Click(object sender, EventArgs e)
        {
            var BWR = new BackgroundWorker();
            BWR.DoWork += delegate
            {
                if(ArduinoMotionLibrary.ArdPosition("SHIFT", portID, XcoordinateValue, YcoordinateValue, ZcoordinateValue, RotationVal) == -2)
                { MessageBox.Show("Movement either encountered an error or Must wait until movement has finished" + Environment.NewLine); }
            };
            BWR.RunWorkerCompleted += delegate
            {
              portListBox.AppendText("SHIFT" + XcoordinateValue.ToString() + YcoordinateValue.ToString() + ZcoordinateValue.ToString() + RotationVal.ToString() + Environment.NewLine);
            };

            BWR.RunWorkerAsync();
        }

        private void traySelectorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TrayChoiceValue = traySelectorBox.SelectedIndex;
        }

        private void findPorts_Click(object sender, EventArgs e)
        {
            ArduinoMotionLibrary.ArduinoMotionLibraryBoot();
            BootMessages();
        }

        private void grabButton_Click(object sender, EventArgs e)
        {
            var BWG = new BackgroundWorker();
            BWG.DoWork += delegate
            {
                if(ArduinoMotionLibrary.ArdPosition("GRAB", portID, 0, 0, 0, 0) == 2)
                { MessageBox.Show("Movement either encountered an error or Must wait until movement has finished" + Environment.NewLine); }
            };
            BWG.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("GRABBED" + Environment.NewLine);
                portListBox.ScrollToCaret();
            };
            BWG.RunWorkerAsync();
        }

        private void releaseButton_Click(object sender, EventArgs e)
        {
            var BWRE = new BackgroundWorker();
            BWRE.DoWork += delegate
            {
                if (ArduinoMotionLibrary.ArdPosition("RELEASE", portID, 0, 0, 0, 0) == 2)
                { MessageBox.Show("Movement either encountered an error or Must wait until movement has finished" + Environment.NewLine); }
            };
            BWRE.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("RELEASED" + Environment.NewLine);
                portListBox.ScrollToCaret();
            };
            BWRE.RunWorkerAsync();
        }


        //raise and lower
        private void raiseZButton_Click(object sender, EventArgs e)
        {
            var BWR = new BackgroundWorker();
            BWR.DoWork += delegate
            {
                if(ArduinoMotionLibrary.ArdPosition("SHIFT", portID, 0, 0, ZcoordinateValue, 0) == 2)
                { MessageBox.Show("Movement either encountered an error or Must wait until movement has finished" + Environment.NewLine); }
            };
            BWR.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("PAD Z RAISE " + XcoordinateValue.ToString() + YcoordinateValue.ToString() + Environment.NewLine);
                portListBox.ScrollToCaret();
            };
            BWR.RunWorkerAsync();
        }

        private void lowerZButton_Click(object sender, EventArgs e)
        {
            var BWR = new BackgroundWorker();
            BWR.DoWork += delegate
            {
                if(ArduinoMotionLibrary.ArdPosition("SHIFT", portID, 0, 0, (-1* ZcoordinateValue), 0) == 2)
                { MessageBox.Show("Movement either encountered an error or Must wait until movement has finished" + Environment.NewLine); }
            };
            BWR.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("PAD Z LOWER " + XcoordinateValue.ToString() + YcoordinateValue.ToString() + Environment.NewLine);
                portListBox.ScrollToCaret();
            };
            BWR.RunWorkerAsync();
        }

        //directional arrow button pad

        private double ShifttoCameraX(double XcoordtoShift)
        {
             xShift = -1 * XcoordtoShift * Math.Cos(ArduinoMotionLibrary.ArmCoordinates[4] * 0.0174533)
                          + XcoordtoShift * Math.Sin(ArduinoMotionLibrary.ArmCoordinates[4] * 0.0174533);
            xShift = Math.Round(xShift);
            return xShift;
        }

        private double ShifttoCameraY(double YcoordtoShift)
        {
            yShift = YcoordtoShift * Math.Sin(ArduinoMotionLibrary.ArmCoordinates[4] * 0.0174533)
                   - YcoordtoShift * Math.Cos(ArduinoMotionLibrary.ArmCoordinates[4] * 0.0174533);
            yShift = Math.Round(yShift);
            return yShift;
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            var BWR = new BackgroundWorker();

            NewCameraX = ShifttoCameraX(0);
            NewCameraY = ShifttoCameraY((-1 * YcoordinateValue));
            BWR.DoWork += delegate
            {
                if(ArduinoMotionLibrary.ArdPosition("SHIFT", portID, NewCameraX, NewCameraY, 0, 0) == 2)
                { MessageBox.Show("Movement either encountered an error or Must wait until movement has finished" + Environment.NewLine); }
            };
            BWR.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("PAD +Y " + XcoordinateValue.ToString() + YcoordinateValue.ToString() + Environment.NewLine);
                portListBox.ScrollToCaret();
            };
            BWR.RunWorkerAsync();
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            var BWR = new BackgroundWorker();
            NewCameraX = ShifttoCameraX(0);
            NewCameraY = ShifttoCameraY( YcoordinateValue);
            BWR.DoWork += delegate
            {
                if (ArduinoMotionLibrary.ArdPosition("SHIFT", portID, NewCameraX, NewCameraY, 0, 0) == 2)
                { MessageBox.Show("Movement either encountered an error or Must wait until movement has finished" + Environment.NewLine); }
            };
            BWR.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("PAD -Y " + XcoordinateValue.ToString() + YcoordinateValue.ToString() + Environment.NewLine);
                portListBox.ScrollToCaret();
            };
            BWR.RunWorkerAsync();
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            var BWR = new BackgroundWorker();

            NewCameraX = ShifttoCameraX(XcoordinateValue);
            NewCameraY = ShifttoCameraY(0);
            BWR.DoWork += delegate
            {
                if(ArduinoMotionLibrary.ArdPosition("SHIFT", portID, NewCameraX, NewCameraY, 0, 0) == 2)
                { MessageBox.Show("Movement either encountered an error or Must wait until movement has finished" + Environment.NewLine); }
            };
            BWR.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("PAD -X " + XcoordinateValue.ToString() + YcoordinateValue.ToString() + Environment.NewLine);
                portListBox.ScrollToCaret();
            };
            BWR.RunWorkerAsync();
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            var BWR = new BackgroundWorker();
            NewCameraX = ShifttoCameraX(-1 * XcoordinateValue);
            NewCameraY = ShifttoCameraY(0);
            BWR.DoWork += delegate
            {
                
                if(ArduinoMotionLibrary.ArdPosition("SHIFT", portID, NewCameraX, NewCameraY, 0, 0) == 2)
                { MessageBox.Show("Movement either encountered an error or Must wait until movement has finished" + Environment.NewLine); }
            };
            BWR.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("PAD +X " + XcoordinateValue.ToString() + YcoordinateValue.ToString() + Environment.NewLine);
                portListBox.ScrollToCaret();
            };
            BWR.RunWorkerAsync();
        }

        private void UpLeftButton_Click(object sender, EventArgs e)
        {
            var BWR = new BackgroundWorker();
            NewCameraX = ShifttoCameraX(XcoordinateValue);
            NewCameraY = ShifttoCameraY((-1* YcoordinateValue));
            BWR.DoWork += delegate
            {
                
                if(ArduinoMotionLibrary.ArdPosition("SHIFT", portID, NewCameraX, NewCameraY, 0, 0) == 2)
                { MessageBox.Show("Movement either encountered an error or Must wait until movement has finished" + Environment.NewLine); }
            };
            BWR.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("PAD (+X)(-Y) " + XcoordinateValue.ToString() + YcoordinateValue.ToString() + Environment.NewLine);
                portListBox.ScrollToCaret();
            };
            BWR.RunWorkerAsync();
        }

        private void UpRightButton_Click(object sender, EventArgs e)
        {
            var BWR = new BackgroundWorker();
            NewCameraX = ShifttoCameraX((-1 * XcoordinateValue));
            NewCameraY = ShifttoCameraY((-1 * YcoordinateValue));
            BWR.DoWork += delegate
            {
                
                if(ArduinoMotionLibrary.ArdPosition("SHIFT", portID, NewCameraX, NewCameraY, 0, 0) == 2)
                { MessageBox.Show("Movement either encountered an error or Must wait until movement has finished" + Environment.NewLine); }
            };
            BWR.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("PAD (+)XY " + XcoordinateValue.ToString() + YcoordinateValue.ToString() + Environment.NewLine);
                portListBox.ScrollToCaret();
            };
            BWR.RunWorkerAsync();
        }

        private void DownLeftButton_Click(object sender, EventArgs e)
        {
            var BWR = new BackgroundWorker();
            NewCameraX = ShifttoCameraX(XcoordinateValue);
            NewCameraY = ShifttoCameraY(YcoordinateValue);
            BWR.DoWork += delegate
            {
              
                if(ArduinoMotionLibrary.ArdPosition("SHIFT", portID, NewCameraX, NewCameraY, 0, 0) == 2)
                { MessageBox.Show("Movement either encountered an error or Must wait until movement has finished" + Environment.NewLine); }
            };
            BWR.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("PAD (-)XY " + XcoordinateValue.ToString() + YcoordinateValue.ToString() + Environment.NewLine);
                portListBox.ScrollToCaret();
            };
            BWR.RunWorkerAsync();
        }

        private void DownRightButton_Click(object sender, EventArgs e)
        {
            var BWR = new BackgroundWorker();
            NewCameraX = ShifttoCameraX((-1 * XcoordinateValue));
            NewCameraY = ShifttoCameraY(YcoordinateValue);
            BWR.DoWork += delegate
            {
                
                if(ArduinoMotionLibrary.ArdPosition("SHIFT", portID, NewCameraX, NewCameraY, 0, 0) == 2)
                { MessageBox.Show("Movement either encountered an error or Must wait until movement has finished" + Environment.NewLine); }
            };
            BWR.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("PAD (+X)(-Y) " + XcoordinateValue.ToString() + YcoordinateValue.ToString() + Environment.NewLine);
                portListBox.ScrollToCaret();
            };
            BWR.RunWorkerAsync();
        }

        private void EffectorViewer_Click(object sender, EventArgs e)
        {
            if (gripperPresented)
            {
                ArduinoMotionLibrary.ArdPosition("CAM", 0, 0, 0, 0, 0);
                EffectorViewer.Text = "Switch to Effector Position";
                gripperPresented = false;
            }
            else
            {
                ArduinoMotionLibrary.ArdPosition("GRIP", 0, 0, 0, 0, 0);
                EffectorViewer.Text = "Switch to Camera Position";
                gripperPresented = true;
            }
        }

        private void RestPos_Click(object sender, EventArgs e)
        {
            if(ArduinoMotionLibrary.ArdPosition("MOVE", 0, ArmHandlerLibrary.RestLocation[0],
                ArmHandlerLibrary.RestLocation[1], ArmHandlerLibrary.RestLocation[2], ArmHandlerLibrary.RestLocation[3]) == 2)
            { MessageBox.Show("Movement either encountered an error or Must wait until movement has finished" + Environment.NewLine); }
        }

        private void buttonCLR_Click(object sender, EventArgs e)
        {
            moveXval.Value = 0;
            moveYval.Value = 0;
            moveZval.Value = 0;
            RotationDegrees.Value = 0;

        }

        private void trayMove_Click(object sender, EventArgs e)
        {
            if(ArduinoMotionLibrary.ArdPosition("MOVE", 1, traySelectorBox.SelectedIndex, (double) trayZaxis.Value, 0, 0) == 2)
            { MessageBox.Show("Movement either encountered an error or Must wait until movement has finished" + Environment.NewLine); }
        }

        private void saveCalibrationButton_Click(object sender, EventArgs e)
        {
            switch (LocationChoiceValue)
            {
                case 0:
                    for (int i=0 ; i < 4; i++)
                        SettingsLibrary.RestLocationCoords[i] = ArduinoMotionLibrary.ArmCoordinates[i];

                    break; 
                case 1:
                    for (int i = 0; i < 4; i++)
                        SettingsLibrary.SocketLocationCoords[i] = ArduinoMotionLibrary.ArmCoordinates[i];
                    
                    break;
                case 2:
                    for (int i = 0; i < 4; i++)
                        SettingsLibrary.OriginLocationCoords[i] = ArduinoMotionLibrary.ArmCoordinates[i];
                    break;
                default:
                    break;


            }
        }

        private void calibrationSelectorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocationChoiceValue = calibrationSelectorBox.SelectedIndex;
        }

        private void CurrPosition_Click(object sender, EventArgs e)
        {
            var BWR = new BackgroundWorker();
            BWR.DoWork += delegate
            {
                if(ArduinoMotionLibrary.ArdPosition("RELAY", portID, 0, 0, 0, 0) == 2)
                { MessageBox.Show("Movement either encountered an error or Must wait until movement has finished" + Environment.NewLine); }
            };
            BWR.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("X: " + ArduinoMotionLibrary.ArmCoordinates[0]
                    + " Y: " + ArduinoMotionLibrary.ArmCoordinates[1] + " "
                    + " Z: " + ArduinoMotionLibrary.ArmCoordinates[2] + " "
                    + " effector: " + ArduinoMotionLibrary.ArmCoordinates[3] + " " + Environment.NewLine);
                portListBox.ScrollToCaret();  // enables autoscrolling
            };

            BWR.RunWorkerAsync();
        }


        private void trayZaxis_ValueChanged(object sender, EventArgs e)
        {

        }

        private void trayRedefine_Click(object sender, EventArgs e)
        {
            if (ArduinoMotionLibrary.ArdPosition("REDEF", 1, traySelectorBox.SelectedIndex, (double)trayZaxis.Value, 0, 0) == 2)
            { MessageBox.Show("Movement either encountered an error or Must wait until movement has finished" + Environment.NewLine); }
        }

    }
}
