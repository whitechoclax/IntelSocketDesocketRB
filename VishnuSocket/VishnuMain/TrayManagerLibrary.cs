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
        public int emptyTrayCount = 0;
        public int goodTrayCount = 0;
        public int badTrayCount = 0;

        //Dimensions are length, width, and stack height in # of trays
        public int[] trayDimensions = new int[3];

        //count of cpus in each good and bad trays
        private int cpuFilledGood = 0;
        private int cpuFilledBad = 0;
        public int CPUpos = 0;
        //public int trayGrabberPosition;
        //public int WhichTrayPresented; 

        //constructor
        public TrayManagerLibrary()
        {
            //Fetch settings
            trayDimensions[0] = SettingsLibrary.TrayLength;
            trayDimensions[1] = SettingsLibrary.TrayWidth;
            trayDimensions[2] = SettingsLibrary.TrayStack;
        }


        public int GetCPUPosition()
        {
            if(CPUpos >= 0 && CPUpos < trayDimensions[0] * trayDimensions[1])
            {
                CPUpos = CPUpos + 1;
                return CPUpos - 1;
            }
            else
                return -1;
        }

        //A function that takes a good/bad result from the OSV
        public void TrayFull(bool isPassed)
        {

        }

        public int TestedGood()
        {
            cpuFilledGood++;
            //Move to good trays
            return cpuFilledGood - 1;
        }

        public int TestedBad()
        {
            cpuFilledBad++;
            //Move to bad trays
            return cpuFilledBad - 1;
        }

        //keeps track of how many untested trays we have, so what to do when it
        //becomes empty
        public void UntestedCount(int traySource, int stackDestination)
        {

        }

        public void PresentTray()
        {
            return;
        }
    }
}
