using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

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
       
        public ArmControl()
        {
            InitializeComponent();
            BootMessages();
            findPorts.Enabled = true;
            
        }

        private void BootMessages()
        {
            if(ArduinoMotionLibrary.Arduinos[0] != 2)
            {
                portListBox.AppendText("Main Robot Arm Connected");
                coordControl.Enabled = true;
            }
            else if (ArduinoMotionLibrary.Arduinos[0] == 2)
            {
                portListBox.AppendText("Main Robot Arm is disconnected." + Environment.NewLine
                    + "Have you checked your arduino connection or device manager?");
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
                    + "Have You checked your arduino connection or device manager?");
                trayGroupBox.Enabled = false;
            }

        }

        private void openPort_Click(object sender, EventArgs e)
        { 
            portListBox.AppendText(portID + " opened.");
            MessageBox.Show("COM PORT not found, Have you checked Arduino Connection?");
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
            ArduinoMotionLibrary.StopMotor(portID);
        }

        private void redefineButton_Click(object sender, EventArgs e)
        {
            ArduinoMotionLibrary.ArdPosition("REDEF", portID, XcoordinateValue, YcoordinateValue, ZcoordinateValue, RotationVal);
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            ArduinoMotionLibrary.ArdPosition("MOVE", portID, XcoordinateValue, YcoordinateValue, ZcoordinateValue, RotationVal);
        }

        private void ShiftButton_Click(object sender, EventArgs e)
        {
            ArduinoMotionLibrary.ArdPosition("SHIFT", portID, XcoordinateValue, YcoordinateValue, ZcoordinateValue, RotationVal);
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
    }
}
