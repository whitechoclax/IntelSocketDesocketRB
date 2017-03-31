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
            ArdPort.BaudRate = 74880;

           
        }



        //shift is " i know where I am, move offset with these coords"
        //move is "i dont care where I am, I am moving to this absolute location
        //format is COMMAND:X:Y:Z:THETA/n
        //REDEF dont move, heres where I am.

        public void ShiftPosition(string portID, int Xval, int Yval, int Zval, int thetaVal)
        {
            if (ArdPort.PortName != portID)
                ArdPort.PortName = portID;

            if (!ArdPort.IsOpen)
            {
                OpenPorts(portID);
            }

            string inputline = "SHIFT:" + Xval + ":" + Yval + ":" + Zval + ":" + thetaVal + "\n";
            ArdPort.WriteLine(inputline);
        
        }

        //Use this is directly move to a certain position.  
        public void MovePosition(string portID, int Xval, int Yval, int Zval, int thetaVal)
        {
            if (ArdPort.PortName != portID)
                ArdPort.PortName = portID;

            if (!ArdPort.IsOpen)
            {
                OpenPorts(portID);
            }

            string inputline = "MOVE:" + Xval + ":" + Yval + ":" + Zval + ":" + thetaVal+"\n";
            ArdPort.WriteLine(inputline);
        }

        //Update the coordinate data if we are off, this is usually some type of command that will be 
        //triggered by the failure/ innacuracy of another in certain cases.
        public void RedefinePosition(string portID, int Xval, int Yval, int Zval, int thetaVal)
        {
            if (ArdPort.PortName != portID)
                ArdPort.PortName = portID;

            if (!ArdPort.IsOpen)
            {
                OpenPorts(portID);
            }

            string inputline = "REDEFINE:" + Xval + ":" + Yval + ":" + Zval + ":" + thetaVal + "\n";
            ArdPort.WriteLine(inputline);
        }


        //Send STOP command to Arduino.  
        public void StopMotor()
        {
            ArdPort.WriteLine("STOP\r");
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
