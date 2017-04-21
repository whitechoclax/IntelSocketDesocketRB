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
        double[] ArmCoordinates = { 0.0, 0.0, 0.0, 0.0 };
        double TrayZ = 0.0;
        int TrayPresented = 0;
        
        public ArduinoMotionLibrary()
        {
            ArdPorts.Add(new SerialPort());
            ArdPorts.Add(new SerialPort());

            ArdPorts[0] = new SerialPort();
            ArdPorts[1] = new SerialPort();
            ArdPorts[0].BaudRate = 115200;
            ArdPorts[1].BaudRate =115200;
            int status = findAvailiblePorts();
            if(status == 0)
            {
                Error(status);
            }
            else
            {
                OpenPorts();
            }
            ArdPosition("MOVE",0, 50, 10, 10, 0);
            StopMotor(0);

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
            int numArduinos = 2;
            try
            {
                ArdPorts[0].Open();
            }
            catch (System.IO.IOException e)
            {
                Error(0);
                return;
            }
            catch (System.UnauthorizedAccessException e)
            {
                Error(0);
                return;
            }
            try
            {
                ArdPorts[1].Open();
            }
            catch (System.IO.IOException e)
            {
                numArduinos = 1;
            }     
            catch(System.UnauthorizedAccessException e)
            {
                numArduinos = 1;
            }

            string data = null;
            bool checkedYet = false;
            while (checkedYet == false)
            {
                ArdPorts[0].WriteLine("QUERY\r");
                Task.Delay(30);
                data = ArdPorts[0].ReadLine();
                if (data == "TRAYHANDLER\r")
                {
                    Arduinos[1] = 0;
                    checkedYet = true;
                }
                else if (data == "MAINROBOTARM\r")
                {
                    Arduinos[0] = 0;
                    checkedYet = true;
                }
                else if (data != null)
                {
                    checkedYet = true;
                }
                else
                {
                    Error(4);
                    return;
                }
            }
            
            if (numArduinos == 2)
            {
                checkedYet = false;
                data = null;
                while (checkedYet == false)
                {
                    ArdPorts[1].WriteLine("QUERY\r");
                    Task.Delay(30);
                    data = ArdPorts[1].ReadLine();
                    if (data == "TRAYHANDLER\r")
                    {
                        Arduinos[1] = 1;
                        checkedYet = true;
                    }
                    else if (data == "MAINROBOTARM\r")
                    {
                        Arduinos[0] = 1;
                        checkedYet = true;
                    }
                    else if (data != null)
                    {
                        checkedYet = true;
                    }
                    else
                    {
                        Error(4);
                        return;
                    }
                }
            }
            return;
        }

        //shift is " i know where I am, move offset with these coords"
        //move is "i dont care where I am, I am moving to this absolute location
        //format is COMMAND:X:Y:Z:THETA/n
        //REDEF dont move, heres where I am.

        public int ArdPosition(string command, int portID, double Xval, double Yval, double Zval, double thetaVal)
        {
            if (Arduinos[portID] == 2)
            {
                return -1;
            }


            string inputLine = null;
            if (portID == 0) //Going to CPU Main arm
            {
                inputLine = command + ":" + Xval + ":" + Yval + ":" + Zval + ":" + thetaVal + "\r";
            }
            else if (portID == 1) //Going to Tray handler, Yval is tray position
            {
                inputLine = command + ":" + Xval + ":" + Yval + "\r";
            }
            else
            {
                return -1;
            }

            ArdPorts[portID].WriteLine(inputLine);
            Task.Delay(30); //Waiting for navigation message
            string data = ArdPorts[portID].ReadLine();
            if (data != "NAVIGATING\r")
            {

            }
            bool done = false;
            while (!done)
            {
                Task.Delay(50);
                if (ArdPorts[portID].BytesToRead > 0)
                {
                    data = ArdPorts[portID].ReadLine();
                }
                if (data == "DONE\r")
                {
                    Task.Delay(50);
                    if (ArdPorts[portID].BytesToRead > 0)
                    {
                        data = ArdPorts[portID].ReadLine();
                    }
                    //Check COOR
                    if (data.StartsWith("COOR"))
                    {
                        string[] pieces = data.Split(':');
                        if (portID == 0)
                        {
                            ArmCoordinates[0] = double.Parse(pieces[1]);
                            ArmCoordinates[1] = double.Parse(pieces[2]);
                            ArmCoordinates[2] = double.Parse(pieces[3]);
                            ArmCoordinates[3] = double.Parse(pieces[4]);
                        }
                        else if (portID == 1)
                        {
                            TrayZ = double.Parse(pieces[1]);
                            TrayPresented = int.Parse(pieces[2]);
                        }
                    }
                    else
                        return -1;
                    done = true;
                }
            }

            return 0;
        }

        //Send STOP command to Arduino.  
        public int StopMotor(int portID)
        {
            if (Arduinos[portID] == 2)
            {
                return -1;
            }

            string inputLine = "STOP\r";

            ArdPorts[portID].WriteLine(inputLine);
            Task.Delay(30); //Waiting for navigation message
            string data = ArdPorts[portID].ReadLine();
            if (data != "STOPPING\r")
            {

            }
            bool done = false;
            while (!done)
            {
                Task.Delay(50);
                if (ArdPorts[portID].BytesToRead > 0)
                {
                    data = ArdPorts[portID].ReadLine();
                }
                Task.Delay(50);
                if (ArdPorts[portID].BytesToRead > 0)
                {
                    data = ArdPorts[portID].ReadLine();
                }
                //Check COOR
                if (data.StartsWith("COOR"))
                {
                    string[] pieces = data.Split(':');
                    if(portID == 0)
                    {
                        ArmCoordinates[0] = double.Parse(pieces[1]);
                        ArmCoordinates[1] = double.Parse(pieces[2]);
                        ArmCoordinates[2] = double.Parse(pieces[3]);
                        ArmCoordinates[3] = double.Parse(pieces[4]);
                    }
                    else if(portID == 1)
                    {
                        TrayZ = double.Parse(pieces[1]);
                        TrayPresented = int.Parse(pieces[2]);
                    }
                }
                else
                    return -1;
                done = true;
            }

            return 0;
        }

        public void Error(int status)
        { //Error 0, nothing connected, 
            return;
        }
        
    }
}
