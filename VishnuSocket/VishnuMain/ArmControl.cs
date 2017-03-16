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
        public String portName = "COM6";
       
        public ArmControl()
        {
            InitializeComponent();
            if (!myPort.IsOpen)
            {
                myPort.DataReceived += MyPort_DataReceived;
            }
            myPort.BaudRate = 115200;
            myPort.PortName = portName;
            myPort.Open();
        }

        private void MyPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = myPort.ReadTo("\r");
            MessageBox.Show(data);
        }

        private void onButton_Click(object sender, EventArgs e)
        {
            
            myPort.WriteLine("c");
            //myPort.Close();
        }

        private void offButton_Click(object sender, EventArgs e)
        {
            myPort.WriteLine("f");
            //myPort.Close();

           
        }
    }
}
