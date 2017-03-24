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

            //if (!ArdPort.IsOpen)
            //{
            //    ArdPort.DataReceived += ArdPort_DataReceived;
            //}
        }

        /*private void ArdPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = ArdPort.ReadTo("\r");
            //this.Invoke(new EventHandler(processData));
            
        }*/

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

        //shift is " i know where I am, move offset with these coords"
        //move is "i dont care where I am, I am moving to this absolute location
        //format is COMMAND:X:Y:Z:THETA/n
        //REDEF dont move, heres where I am.

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

        //Send STOP command to Arduino.  
        public void StopMotor()
        {
          
            ArdPort.WriteLine("STOP");
            

        }
        //Dummy functions used for testing
        public void LEDon(string portID)
        {
            if (ArdPort.PortName != portID)
                ArdPort.PortName = portID;

            if (ArdPort.IsOpen)
            {
                ArdPort.WriteLine("c");
            }
            else
            {
                OpenPorts(portID);
                ArdPort.WriteLine("c");
            }
        }

        public void LEDoff(string portID)
        {
            if (ArdPort.PortName != portID)
                ArdPort.PortName = portID;

            if (ArdPort.IsOpen)
            {
                ArdPort.WriteLine("f");
            }
            else
            {
                OpenPorts(portID);
                ArdPort.WriteLine("f");
            }
        }

        public string[] FindPortsAvailable()
        {
            string[] ports = SerialPort.GetPortNames();
            return ports;
        }

        public void OpenPorts(string Port)
        {
            ArdPort.PortName = Port;
            ArdPort.Open();
        }

    }
}
