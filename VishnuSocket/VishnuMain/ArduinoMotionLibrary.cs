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
        //public SerialPort ArdPort = new SerialPort();
        public List<SerialPort> ArdPorts = new List<SerialPort>();
        string[] portName;
        byte[] Arduinos = { 2, 2 };      //0 is Main Arm, 1 is Tray handler

        public ArduinoMotionLibrary()
        {
            ArdPorts.Add(new SerialPort());
            ArdPorts.Add(new SerialPort());

            ArdPorts[0] = new SerialPort();
            ArdPorts[1] = new SerialPort();
            ArdPorts[0].BaudRate = 115200;
            ArdPorts[1].BaudRate = 115200;
            int status = findAvailiblePorts();
            if(status != 2)
            {
                Error(status);
            }
            else
            {
                OpenPorts();
            }

        }

        public int findAvailiblePorts()
        {
            string[] portList = SerialPort.GetPortNames();

            int i = 0;
            foreach (string line in portList)
            {
                ArdPorts[i].PortName = portList[i];
                ++i;
            }
            if (ArdPorts[0].PortName == null)
            {
                return 0; //This is bad!
            }
            else if (ArdPorts[0].PortName == null ^ ArdPorts[1].PortName == null)
            {
                return 1; //This is bad! missing one connector
            }
            else if (ArdPorts[0].PortName != null && ArdPorts[1].PortName != null)
            {
                return 2; //This is good! both connected
            }
            else
                return 0;
        }

        public void OpenPorts()
        {
            try
            {
                ArdPorts[0].Open();
                ArdPorts[1].Open();
            }
            catch (System.IO.IOException e)
            {
                Error(-1);
                return;
            }
            string inputline = "QUERY\r";

            ArdPorts[0].WriteLine(inputline);
            ArdPorts[1].WriteLine(inputline);

            //wait, then send a auto read( dont need event handlers)
            Task.Delay(30);
            string data = ArdPorts[0].ReadLine();

            //if arduino returns trayhandler arm
            if (data == "TRAYHANDLER\r")
            {
                Arduinos[1] = 0;
            }
            else if(data == "MAINROBOTARM\r")
            {
                Arduinos[0] = 0;
            }
            else
            {
                Error(4);
            }
            data = ArdPorts[1].ReadLine();
            if (data == "TRAYHANDLER\r")
            {
                Arduinos[1] = 1;
            }
            else if (data == "MAINROBOTARM\r")
            {
                Arduinos[0] = 1;
            }
            else
            {
                Error(4);
            }



            return;
        }

        //shift is " i know where I am, move offset with these coords"
        //move is "i dont care where I am, I am moving to this absolute location
        //format is COMMAND:X:Y:Z:THETA/n
        //REDEF dont move, heres where I am.

        //public void ShiftPosition(string portID, int Xval, int Yval, int Zval, int thetaVal)
        //{
        //    if (ArdPorts.PortName != portID)
        //        ArdPorts.PortName = portID;

        //    if (!ArdPorts.IsOpen)
        //    {
        //        OpenPorts(portID);
        //    }

        //    string inputline = "SHIFT:" + Xval + ":" + Yval + ":" + Zval + ":" + thetaVal + "\r";
        //    ArdPorts.WriteLine(inputline);
        
        //}

        //Use this is directly move to a certain position.  
        //public void MovePosition(string portID, int Xval, int Yval, int Zval, int thetaVal)
        //{
        //    if (ArdPorts.PortName != portID)
        //        ArdPorts.PortName = portID;

        //    if (!ArdPorts.IsOpen)
        //    {
        //        OpenPorts(portID);
        //    }

        //    string inputline = "MOVE:" + Xval + ":" + Yval + ":" + Zval + ":" + thetaVal+"\r";
        //    ArdPorts.WriteLine(inputline);
        //}

        //Update the coordinate data if we are off, this is usually some type of command that will be 
        //triggered by the failure/ innacuracy of another in certain cases.
        //public void RedefinePosition(string portID, int Xval, int Yval, int Zval, int thetaVal)
        //{
        //    if (ArdPorts.PortName != portID)
        //        ArdPorts.PortName = portID;

        //    if (!ArdPorts.IsOpen)
        //    {
        //        OpenPorts(portID);
        //    }

        //    string inputline = "REDEF:" + Xval + ":" + Yval + ":" + Zval + ":" + thetaVal + "\r";
        //    ArdPorts.WriteLine(inputline);
        //}


        //Send STOP command to Arduino.  
        public void StopMotor()
        {
           // ArdPorts.WriteLine("STOP\r");
        }

        public void Error(int status)
        {
            return;
        }
        
    }
}
