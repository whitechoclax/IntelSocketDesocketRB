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
       
        public static double[] OriginLocation = { 50.0, 0.0, 0.0, 0.0 }; //CPU0 location
        public static double[] SocketLocation = { 0.0, 50.0, 0.0, 0.0 };
        private static double centerToCenterL = 0.0; //Distance between left and right CPU
        private static double centerToCenterW = 0.0; //Distance between top and bottom CPU
        private static double centerToCenterZ = 0.0; //Distance between trays
        public static int CPUindex = 0; //Which CPU we're on

        
        public static void ArmHandlerLibraryMainSequence()
        {   //Start at Origin, find next CPU, Take picture
            //Pick Up requested CPU, Move to Calibration Image
            //Find Socket, put CPU in socket, wait until done
            //Once done, tell tray if good or bad, wait for position
            //Place CPU in position, wait for next either next CPU or done signal

            double[] Loc = { 0.0, 0.0, 0.0, 0.0 };
            FetchInformation();
            TrayManagerLibrary trayHandler = new TrayManagerLibrary(); //should be background worker
            bool done = false;
            int CPU;

            while (!done)
            { //Main Loop
                if (!Running)
                {
                    return;
                }
                ArduinoMotionLibrary.ArdPosition("MOVE", 0, OriginLocation[0], OriginLocation[1], OriginLocation[2], OriginLocation[3]);
                CPU = trayHandler.GetCPUPosition();
                Loc[0] = (CPU % trayHandler.trayDimensions[0]) * centerToCenterL; //Move x CPU's over
                if (CPU > trayHandler.trayDimensions[0])
                {
                    Loc[1] += centerToCenterW;
                } //Adding the y offset to the tray
                Loc[2] -= (trayHandler.emptyTrayCount + trayHandler.goodTrayCount + trayHandler.badTrayCount) * centerToCenterZ;
                ArduinoMotionLibrary.ArdPosition("MOVE", 0, Loc[0], Loc[1], Loc[2], Loc[3]); //Move to CPU
                //Verify we're above a CPU
                while(!CameraTestCPU())
                {
                    //Keep Navigating to next CPU and testing
                }
                ArduinoMotionLibrary.ArdPosition("SHIFT", 0, 0, 0, 0, 0); //Descend Z
                //Grab CPU
                ArduinoMotionLibrary.ArdPosition("SHIFT", 0, 0, 0, 0, 0); //Raise back up
                //Move to Socket, calibration image later
                ArduinoMotionLibrary.ArdPosition("MOVE", 0, SocketLocation[0], SocketLocation[1], SocketLocation[2], SocketLocation[3]);
                ArduinoMotionLibrary.ArdPosition("SHIFT", 0, 0, 0, 0, 0); //Descend into socket
                //Release CPU
                //Wait for test
                //Tell Tray to present good or bad

                ArduinoMotionLibrary.ArdPosition("MOVE", 0, 0, 0, 0, 0); //Demo done, return to origin
                done = true;
            }
            return;
        }

        private static void FetchInformation()
        {//Get information from settings later
            centerToCenterL = SettingsLibrary.TrayCenter2CenterCol;
            centerToCenterZ = SettingsLibrary.TrayHeight;
            centerToCenterW = SettingsLibrary.TrayCenter2CenterRow;
            return;
        }

        public static void CameraReadQR()
        {

        }

        //mark tray
        public static bool CameraTestCPU()
        {
            return true;
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
