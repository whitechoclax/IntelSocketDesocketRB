using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoLed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.PortName = "COM3";
            serialPort1.BaudRate = 115200;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("c");
            }
            serialPort1.Close();
            panel1.BackColor = Color.Lime;
            panel2.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("f");
            }
            serialPort1.Close();
            panel2.BackColor = Color.Red;
            panel1.BackColor = Color.Transparent;
        }
    }
}
