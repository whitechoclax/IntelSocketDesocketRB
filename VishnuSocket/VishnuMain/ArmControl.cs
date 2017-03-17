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

        public SerialPort myPort = new SerialPort();
        ArduinoMotionLibrary Arduino = new ArduinoMotionLibrary();
        public String portName;
       
        public ArmControl()
        {
            InitializeComponent();
            findPorts.Enabled = true;
            openPort.Enabled = false;
             
            if (!myPort.IsOpen)
            {
                myPort.DataReceived += MyPort_DataReceived;
            }
            
        }

        private void MyPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = myPort.ReadTo("\r");
            MessageBox.Show(data);
        }

        private void onButton_Click(object sender, EventArgs e)
        {
            Arduino.LEDon(portName);
            //myPort.WriteLine("c");
        }

        private void offButton_Click(object sender, EventArgs e)
        {
            Arduino.LEDoff(portName);
            //myPort.WriteLine("f");

           
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
            myPort.BaudRate = 115200;
            myPort.PortName = portName;
            try
            {
                myPort.Open();
            }
            catch
            {
                MessageBox.Show("COM PORT not found, Have you checked Arduino Connection?");
            }

        }
    }
}
