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
        public ArduinoMotionLibrary()
        {

        }

        public void RotateLeft()
        {

        }

        public void RotateRight()
        {

        }


        public void RaisePlatform()
        {
            
        }

        public void LowerPlatform()
        {


        }


        public string [] FindPortsAvailible()
        {
            string[] ports = SerialPort.GetPortNames();
            return ports;
        }

    }
}
