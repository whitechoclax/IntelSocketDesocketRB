using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VishnuMain
{
    struct ArduinoPort
    {
        public int Baud_Rate;
        public string COM_PORT;


        public ArduinoPort(int rate, string COM)
        {
            Baud_Rate = rate;
            COM_PORT = COM;
        }


    }
}
