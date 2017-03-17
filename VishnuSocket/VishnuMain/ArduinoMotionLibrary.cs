using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace VishnuMain
{
    class ArduinoMotionLibrary
    {
        //SerialPort object declaration
        public SerialPort ArdPort = new SerialPort();
        

        public ArduinoMotionLibrary()
        {
            ArdPort.BaudRate = 115200;
        }

        public void RotateLeft()
        {
            ArdPort.Open();
            ArdPort.Close();
        }

        public void RotateRight()
        {
            ArdPort.Open();
            ArdPort.Close();
        }


        public void RaisePlatform()
        {
            ArdPort.Open();
            ArdPort.Close();
        }

        public void LowerPlatform()
        {
            ArdPort.Open();
            ArdPort.Close();

        }

        //Dummy functions used for testing
        public void LEDon(string portID)
        {
            ArdPort.PortName = portID;
            ArdPort.Open();
            ArdPort.WriteLine("c");
            ArdPort.Close();
        }

        public void LEDoff(string portID)
        {
            ArdPort.PortName = portID;
            ArdPort.Open();
            ArdPort.WriteLine("f");
            ArdPort.Close();
        }

        public string [] FindPortsAvailable()
        {
            string[] ports = SerialPort.GetPortNames();
            return ports;
        }

    }
}
