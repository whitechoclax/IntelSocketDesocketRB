using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VishnuMain
{
    //Part of mainline function, determines what to do when trays are full and empty
    //and how we move those trays around.
    class TrayManagerLibrary
    {
        private int emptyTrayCount;
        private int goodTrayCount;
        private int badTrayCount;

        //Dimensions are length, width, and stack height in # of trays
        public int[] trayDimensions = new int[3];

        //count of cpus in each good and bad trays
        private int cpuFilledGood;
        private int cpuFilledBad;
        private int cpuRemainingUntested;

        public int trayGrabberPosition;
        public int WhichTrayPresented; 

        //constructor
        public TrayManagerLibrary()
        {

        }


        public void SendPosition(bool isPassed)
        {

        }

        //A function that takes a good/bad result from the OSV
        public void TrayFull(bool isPassed)
        {

        }

        //keeps track of how many untested trays we have, so what to do when it
        //becomes empty
        public void UntestedCount(int traySource, int stackDestination)
        {

        }

        public void ParseResult()
        {

        }
    }
}
