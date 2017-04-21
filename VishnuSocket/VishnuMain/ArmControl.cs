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
        //singletons
        private static ArmControl _instance;
        public static ArmControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ArmControl();
                return _instance;
            }
        }

        ArduinoMotionLibrary Arduino = new ArduinoMotionLibrary();
        delegate void SetTextCallback(string text);
        private BackgroundWorker hardworker;
        int portID = 0;
        int ZcoordinateValue;
        int RotationVal;
        int XcoordinateValue;
        int YcoordinateValue;
       
        public ArmControl()
        {
            InitializeComponent();
            hardworker = new BackgroundWorker();
            findPorts.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void findPorts_Click(object sender, EventArgs e)
        {
            if(Arduino.Arduinos[0] != 2)
            {
                MessageBox.Show("Main Robot Arm Connected");
            }
            if(Arduino.Arduinos[1] != 2)
            {
                MessageBox.Show("Tray Handler Connected");
            }
            /*string [] portList = Arduino.FindPortsAvailable();
            foreach (string line in portList)
            {
                portListBox.AppendText(line);
                portListBox.AppendText(Environment.NewLine);
            }

            try
            {
                if (portList[0] != null)
                {
                    portName = portList[0];
                    groupBox1.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("ARDUINO not found! Please connect.");
            }*/

        }

        private void openPort_Click(object sender, EventArgs e)
        { 
            portListBox.AppendText(portID + " opened.");
            MessageBox.Show("COM PORT not found, Have you checked Arduino Connection?");
        }

        private void ArdPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //string data = Arduino.ArdPort.ReadTo("\n");
            //portListBox.AppendText(data);

            this.Invoke((MethodInvoker)delegate
            {
                //portListBox.AppendText(data);
            });
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
            Arduino.StopMotor(portID);
        }

        private void redefineButton_Click(object sender, EventArgs e)
        {
            Arduino.ArdPosition("REDEF", portID, XcoordinateValue, YcoordinateValue, ZcoordinateValue, RotationVal);
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            Arduino.ArdPosition("MOVE", portID, XcoordinateValue, YcoordinateValue, ZcoordinateValue, RotationVal);
        }

        private void ShiftButton_Click(object sender, EventArgs e)
        {
            Arduino.ArdPosition("SHIFT", portID, XcoordinateValue, YcoordinateValue, ZcoordinateValue, RotationVal);
        }
    }
}
