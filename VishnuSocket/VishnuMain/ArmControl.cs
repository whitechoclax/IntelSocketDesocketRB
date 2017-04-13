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

        //
        ArduinoMotionLibrary Arduino = new ArduinoMotionLibrary();
        delegate void SetTextCallback(string text);
        private BackgroundWorker hardworker;
        string portName;
        int ZcoodrinateValue;
        int RotationVal;
        int XcoordinateValue;
        int YcoordinateValue;
       
        public ArmControl()
        {
            InitializeComponent();
            hardworker = new BackgroundWorker();
            findPorts.Enabled = true;
            groupBox1.Enabled = false;

            if (!Arduino.ArdPort.IsOpen)
            {
                Arduino.ArdPort.DataReceived += ArdPort_DataReceived; ;
            }


        }

        private void findPorts_Click(object sender, EventArgs e)
        {
            string [] portList = Arduino.FindPortsAvailable();
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
                MessageBox.Show("No serial devices connected");
            }
               
        }

        private void openPort_Click(object sender, EventArgs e)
        { 
            portListBox.AppendText(portName + " opened.");
            //MessageBox.Show("COM PORT not found, Have you checked Arduino Connection?");
        }

        private void ArdPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = Arduino.ArdPort.ReadTo("\n");
            //portListBox.AppendText(data);

            this.Invoke((MethodInvoker)delegate
            {
                portListBox.AppendText(data);
            });
        }

      
        //ALL coordinate values assignment functions
        private void moveXval_ValueChanged(object sender, EventArgs e)
        {
            XcoordinateValue = (int)moveXval.Value;
        }

        private void moveZval_ValueChanged(object sender, EventArgs e)
        {
            ZcoodrinateValue = (int)moveZval.Value;
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
            Arduino.StopMotor();
        }

        private void redefineButton_Click(object sender, EventArgs e)
        {
            Arduino.RedefinePosition(portName, XcoordinateValue, YcoordinateValue, ZcoodrinateValue, RotationVal);
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            Arduino.MovePosition(portName, XcoordinateValue, YcoordinateValue, ZcoodrinateValue, RotationVal);
        }

        private void ShiftButton_Click(object sender, EventArgs e)
        {
            Arduino.ShiftPosition(portName, XcoordinateValue, YcoordinateValue, ZcoodrinateValue, RotationVal);
        }
    }
}
