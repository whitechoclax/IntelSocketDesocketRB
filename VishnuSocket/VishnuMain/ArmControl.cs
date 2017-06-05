using System;
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
        public Capture _capture;
        public bool _captureInProgress;
        private double xShift, yShift = 0.0;
        private double NewCameraX, NewCameraY = 0.0;
        
        public ArmControl()
        {
            InitializeComponent();
            BootMessages();
            findPorts.Enabled = true;
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
            }
            else if (ArduinoMotionLibrary.Arduinos[0] == 2)
            {
                portListBox.AppendText("Main Robot Arm is disconnected." + Environment.NewLine
                    + "Arduino connected?" + Environment.NewLine);
                coordControl.Enabled = false;
            }
            //default 2 means not connected. 
            if (ArduinoMotionLibrary.Arduinos[1] != 2)
            {
                portListBox.AppendText("Tray Handler Connected");
                trayGroupBox.Enabled = true;
            }
            else if (ArduinoMotionLibrary.Arduinos[1] == 2)
            {
                portListBox.AppendText("Tray Handler Arm is disconnected." + Environment.NewLine
                    + "Arduino connected?" + Environment.NewLine);
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
                portListBox.AppendText("EMERGENCY STOP ASYNC");
            };
            BWS.RunWorkerAsync();

        }



        //ASYNC TASKS


        private void redefineButton_Click(object sender, EventArgs e)
        {
            var BWR = new BackgroundWorker();
            BWR.DoWork += delegate
            {
                ArduinoMotionLibrary.ArdPosition("REDEF", portID, XcoordinateValue, YcoordinateValue, ZcoordinateValue, RotationVal);
            };
            BWR.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("REDEF" + XcoordinateValue.ToString() + YcoordinateValue.ToString() + ZcoordinateValue.ToString() + RotationVal.ToString() + Environment.NewLine);
            };
            BWR.RunWorkerAsync();

        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            var BWM = new BackgroundWorker();
            BWM.DoWork += delegate
            {
                ArduinoMotionLibrary.ArdPosition("MOVE", portID, XcoordinateValue, YcoordinateValue, ZcoordinateValue, RotationVal);
            };
            BWM.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("MOVE" + XcoordinateValue.ToString() + YcoordinateValue.ToString() + ZcoordinateValue.ToString() + RotationVal.ToString() + Environment.NewLine);
            };
            BWM.RunWorkerAsync();

        }

        private void ShiftButton_Click(object sender, EventArgs e)
        {
            var BWR = new BackgroundWorker();
            BWR.DoWork += delegate
            {
                ArduinoMotionLibrary.ArdPosition("SHIFT", portID, XcoordinateValue, YcoordinateValue, ZcoordinateValue, RotationVal);
            };
            BWR.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("SHIFT" + XcoordinateValue.ToString() + YcoordinateValue.ToString() + ZcoordinateValue.ToString() + RotationVal.ToString() + Environment.NewLine);
                portListBox.AppendText("X: " + ArduinoMotionLibrary.ArmCoordinates[0]
                    + " Y: " + ArduinoMotionLibrary.ArmCoordinates[1] + " "
                    + " Z: " + ArduinoMotionLibrary.ArmCoordinates[2] + " "
                    + " theta: " + ArduinoMotionLibrary.ArmCoordinates[3] + " " + Environment.NewLine);
                portListBox.ScrollToCaret();  // enables autoscrolling
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
                ArduinoMotionLibrary.ArdPosition("GRAB", portID, 0, 0, 0, 0);
            };
            BWG.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("GRABBED" + Environment.NewLine);
            };
            BWG.RunWorkerAsync();
        }

        private void releaseButton_Click(object sender, EventArgs e)
        {
            var BWRE = new BackgroundWorker();
            BWRE.DoWork += delegate
            {
                ArduinoMotionLibrary.ArdPosition("RELEASE", portID, 0, 0, 0, 0);
            };
            BWRE.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("RELEASED" + Environment.NewLine);
            };
            BWRE.RunWorkerAsync();
        }


        //raise and lower
        private void raiseZButton_Click(object sender, EventArgs e)
        {
            var BWR = new BackgroundWorker();
            BWR.DoWork += delegate
            {
                ArduinoMotionLibrary.ArdPosition("SHIFT", portID, 0, 0, ZcoordinateValue, 0);
            };
            BWR.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("PAD Z RAISE" + XcoordinateValue.ToString() + YcoordinateValue.ToString() + Environment.NewLine);
            };
            BWR.RunWorkerAsync();
        }

        private void lowerZButton_Click(object sender, EventArgs e)
        {
            var BWR = new BackgroundWorker();
            BWR.DoWork += delegate
            {
                ArduinoMotionLibrary.ArdPosition("SHIFT", portID, 0, 0, (-1* ZcoordinateValue), 0);
            };
            BWR.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("PAD Z LOWER" + XcoordinateValue.ToString() + YcoordinateValue.ToString() + Environment.NewLine);
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
                ArduinoMotionLibrary.ArdPosition("SHIFT", portID, NewCameraX, NewCameraY, 0, 0);
            };
            BWR.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("PAD Y INCREMENT" + XcoordinateValue.ToString() + YcoordinateValue.ToString() + Environment.NewLine);
            };
            BWR.RunWorkerAsync();
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            var BWR = new BackgroundWorker();
            NewCameraX = ShifttoCameraX(0);
            NewCameraY = ShifttoCameraY(YcoordinateValue);
            BWR.DoWork += delegate
            {
                ArduinoMotionLibrary.ArdPosition("SHIFT", portID, NewCameraX, NewCameraY, 0, 0);
            };
            BWR.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("PAD Y DECREMENT" + XcoordinateValue.ToString() + YcoordinateValue.ToString() + Environment.NewLine);
            };
            BWR.RunWorkerAsync();
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            var BWR = new BackgroundWorker();

            NewCameraX = ShifttoCameraX((XcoordinateValue));
            NewCameraY = ShifttoCameraY(0);
            BWR.DoWork += delegate
            {
                ArduinoMotionLibrary.ArdPosition("SHIFT", portID, NewCameraX, NewCameraY, 0, 0);
            };
            BWR.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("PAD X INCREMENT" + XcoordinateValue.ToString() + YcoordinateValue.ToString() + Environment.NewLine);
            };
            BWR.RunWorkerAsync();
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            var BWR = new BackgroundWorker();
            NewCameraX = ShifttoCameraX((-1 * XcoordinateValue));
            NewCameraY = ShifttoCameraY(0);
            BWR.DoWork += delegate
            {
                
                ArduinoMotionLibrary.ArdPosition("SHIFT", portID, NewCameraX, NewCameraY, 0, 0);
            };
            BWR.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("PAD X DECREMENT" + XcoordinateValue.ToString() + YcoordinateValue.ToString() + Environment.NewLine);
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
                
                ArduinoMotionLibrary.ArdPosition("SHIFT", portID, NewCameraX, NewCameraY, 0, 0);
            };
            BWR.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("PAD (+X)(-Y)" + XcoordinateValue.ToString() + YcoordinateValue.ToString() + Environment.NewLine);
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
                
                ArduinoMotionLibrary.ArdPosition("SHIFT", portID, NewCameraX, NewCameraY, 0, 0);
            };
            BWR.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("PAD (-)XY" + XcoordinateValue.ToString() + YcoordinateValue.ToString() + Environment.NewLine);
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
              
                ArduinoMotionLibrary.ArdPosition("SHIFT", portID, NewCameraX, NewCameraY, 0, 0);
            };
            BWR.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("PAD XY" + XcoordinateValue.ToString() + YcoordinateValue.ToString() + Environment.NewLine);
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
                
                ArduinoMotionLibrary.ArdPosition("SHIFT", portID, NewCameraX, NewCameraY, 0, 0);
            };
            BWR.RunWorkerCompleted += delegate
            {
                portListBox.AppendText("PAD (-x)(+Y)" + XcoordinateValue.ToString() + YcoordinateValue.ToString() + Environment.NewLine);
            };
            BWR.RunWorkerAsync();
        }

        private void CameraViewer_Click(object sender, EventArgs e)
        {
            ArduinoMotionLibrary.ArdPosition("CAM", 0, 0, 0, 0, 0);
        }

        private void EffectorViewer_Click(object sender, EventArgs e)
        {
            ArduinoMotionLibrary.ArdPosition("GRIP", 0, 0, 0, 0, 0);
        }

        private void RestPos_Click(object sender, EventArgs e)
        {
            ArduinoMotionLibrary.ArdPosition("MOVE", 0, ArmHandlerLibrary.RestLocation[0],
                ArmHandlerLibrary.RestLocation[1], ArmHandlerLibrary.RestLocation[2], ArmHandlerLibrary.RestLocation[3]);
        }

        private void buttonCLR_Click(object sender, EventArgs e)
        {
            moveXval.Value = 0;
            moveYval.Value = 0;
            moveZval.Value = 0;
            RotationDegrees.Value = 0;

        }

        private void cameraFeedBox_Enter(object sender, EventArgs e) {

        }

        private void ArmFeedBox_Click(object sender, EventArgs e) {

        }

    }
}
