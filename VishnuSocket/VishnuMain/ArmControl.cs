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
       
        public ArmControl()
        {
            InitializeComponent();
            hardworker = new BackgroundWorker();
            findPorts.Enabled = true;
            openPort.Enabled = false;

            if (!Arduino.ArdPort.IsOpen)
            {
                Arduino.ArdPort.DataReceived += ArdPort_DataReceived; ;
            }


        }

        private void onButton_Click(object sender, EventArgs e)
        {
            Arduino.LEDon(portName);
        }

        private void offButton_Click(object sender, EventArgs e)
        {
            Arduino.LEDoff(portName);
        }

        private void findPorts_Click(object sender, EventArgs e)
        {
            string [] portList = Arduino.FindPortsAvailable();
            foreach (string line in portList)
            {
                portListBox.AppendText(line);
                portListBox.AppendText(Environment.NewLine);
            }

            if (portList[0] != null)
            {
                portName = portList[0];
                openPort.Enabled = true;
            }

        }

        private void openPort_Click(object sender, EventArgs e)
        { 
            portListBox.AppendText(portName + " opened.");
            //MessageBox.Show("COM PORT not found, Have you checked Arduino Connection?");
        }

        private void ArdPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = Arduino.ArdPort.ReadTo("\r");
            //portListBox.AppendText(data);
        }
    }
}
