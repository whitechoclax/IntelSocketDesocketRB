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

        public SerialPort myPort;

        public ArmControl()
        {
            InitializeComponent();
        }

        private void onButton_Click(object sender, EventArgs e)
        {
            myPort = new SerialPort();
            myPort.BaudRate = 9600;
            myPort.PortName = "COM5";
            myPort.Open();
            myPort.WriteLine("c");
            myPort.Close();
        }

        private void offButton_Click(object sender, EventArgs e)
        {
            myPort = new SerialPort();
            myPort.BaudRate = 9600;
            myPort.PortName = "COM5";
            myPort.Open();
            myPort.WriteLine("f");
            myPort.Close();

           
        }
    }
}
