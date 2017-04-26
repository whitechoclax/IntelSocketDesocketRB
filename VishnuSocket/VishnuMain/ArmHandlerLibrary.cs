using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VishnuMain
{
    static class ArmHandlerLibrary
    {
        public static bool Running = false;
        public static int CPUsWidth = 0;
        public static int CPUsLength = 0;
        public static double centerToCenterW = 0.0; //Distance between left and right CPU
        public static double centerToCenterL = 0.0; //Distance between top and bottom CPU
        public static int CPUindex = 0; //Which CPU we're on

        
        public static void ArmHandlerLibraryMainSequence()
        {   //Start at Origin, find next CPU, Take picture
            //Pick Up requested CPU, Move to Calibration Image
            //Find Socket, put CPU in socket, wait until done
            //Once done, tell tray if good or bad, wait for position
            //Place CPU in position, wait for next either next CPU or done signal
            if(!Running)
            {
                return;
            }


            return;
        }

        public static void NavigateToPosition()
        {

        }

        public static void CameraReadQR()
        {
        }

        //mark tray
        public static void CameraTestCPU()
        {

        }

        //take a pic, bool is true if top, false when bottom
        public static void CameraTakePicture(bool isTop)
        {

        }

        public static bool SendDoneMSG()
        {
            return false;
        }

        private static void PlaceCPUInSocket()
        {

        }

        public static bool CPUPassedTest()
        {
            return false;
        }

    }
}
