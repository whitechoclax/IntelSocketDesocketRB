using System;
using Emgu.CV;
using System.Windows.Forms;

namespace VishnuMain
{
    static class ArmHandlerLibrary
    {
        public static bool Running = false;
        public static double[] RestLocation = { -82, 170.0, 100.0, 84 }; //Change to calibration image
        // Calibrate image at: "COOR:176.00:339.00:60.00:84.0:27.50"
        public static double[] OriginLocation = { -82, 375.0, 100.0, 84.0 }; //CPU0 location
        public static double[] TestImgLocation = { 60, 273, 100, 84 }; //Img location
        //"COOR:0.00:183.00:38.00:0.0:0.00\r" , z = 52 for last one,
        public static double[] SocketLocation = { 40.0, -250.0, 200.0, 0.0 }; //Socket center point 
        private static double centerToCenterL = 0.0; //Distance between left and right CPU
        private static double centerToCenterW = 0.0; //Distance between top and bottom CPU
        private static double centerToCenterZ = 0.0; //Distance between trays
        public static int CPUindex = 0; //Which CPU we're on
        public static bool Error = false;  //This indicates if there was a failed operation somewhere

        
        
        public static void ArmHandlerLibraryMainSequence(Capture camera_feed)
        {   //Start at Origin, find next CPU, Take picture
            //Pick Up requested CPU, Move to Calibration Image
            //Find Socket, put CPU in socket, wait until done
            //Once done, tell tray if good or bad, wait for position
            //Place CPU in position, wait for next either next CPU or done signal

            double[] Loc = { 0.0, 0.0, 0.0, 0.0 };
            FetchInformation();
            TrayManagerLibrary trayHandler = new TrayManagerLibrary();
            bool done = false;
            int CPU;

            //Test procedure:
            //Move to rest position
            //Redifine arduino position on test img coordinates
            //Move to CPU
            //Pick up CPU
            //Calibrate again
            //Move CPU to wherever (watch end effector)
            //Go back and pick up next CPU (account for z change, 14mm / 10)

            while (!done)
            { //Main Loop
                if(ArduinoMotionLibrary.ArdPosition("MOVE", 0, RestLocation[0], RestLocation[1], RestLocation[2], RestLocation[3]) == -2)
                { FatalCrash(); return; }//Move to rest location if we didn't start there
                if (ArduinoMotionLibrary.ArdPosition("MOVE", 0, OriginLocation[0], OriginLocation[1], OriginLocation[2], OriginLocation[3]) == -2)
                { FatalCrash(); return; }//Move to CPU0
                if (ArduinoMotionLibrary.ArdPosition("SHIFT", 0, 0, 0, -10, 0) == -2)
                { FatalCrash(); return; }//Move down to grab CPU
                if (ArduinoMotionLibrary.ArdPosition("GRAB", 0, 0, 0, 0, 0) == -2)
                { FatalCrash(); return; }
                if (ArduinoMotionLibrary.ArdPosition("SHIFT", 0, 0, 0, 10, 0) == -2)
                { FatalCrash(); return; }//Raise back up
                if (ArduinoMotionLibrary.ArdPosition("MOVE", 0, TestImgLocation[0], TestImgLocation[1], TestImgLocation[2], TestImgLocation[3]) == -2)
                { FatalCrash(); return; }//Go calibrate
                CameraTestImg(camera_feed);
                if (ArduinoMotionLibrary.ArdPosition("MOVE", 0, OriginLocation[0], OriginLocation[1] - centerToCenterL, OriginLocation[2], OriginLocation[3]) == -2)
                { FatalCrash(); return; }//Move to next spot
                if (ArduinoMotionLibrary.ArdPosition("SHIFT", 0, 0, 0, -10, 0) == -2)
                { FatalCrash(); return; }//Put it down
                if (ArduinoMotionLibrary.ArdPosition("RELEASE", 0, 0, 0, 0, 0) == -2)
                { FatalCrash(); return; }
                if (ArduinoMotionLibrary.ArdPosition("SHIFT", 0, 0, 0, 10, 0) == -2)
                { FatalCrash(); return; }//Go back
                if (ArduinoMotionLibrary.ArdPosition("MOVE", 0, RestLocation[0], RestLocation[1], RestLocation[2], RestLocation[3]) == -2)
                { FatalCrash(); return; }//Move to rest location to finish
                Running = false;
                done = true;
            }
                /*
                CPU = trayHandler.GetCPUPosition();
                if (CPU == -1)
                {
                    Running = false;
                    done = true;
                }
                if (!Running)
                {
                    //Return to Origin
                    return;
                }
                Loc[0] = ((CPU % trayHandler.trayDimensions[0]) * centerToCenterL) + OriginLocation[0]; //Move x CPU's over
                if (CPU >= trayHandler.trayDimensions[0])
                {
                    Loc[1] = centerToCenterW + OriginLocation[1];
                } //Adding the y offset to the tray
                else
                {
                    Loc[1] = OriginLocation[1];
                }
                Loc[2] = ((trayHandler.emptyTrayCount - 1 + trayHandler.goodTrayCount + trayHandler.badTrayCount) * centerToCenterZ) + OriginLocation[2];
                ArduinoMotionLibrary.ArdPosition("MOVE", 0, OriginLocation[0], OriginLocation[1]-60, OriginLocation[2], OriginLocation[3]);
                CameraTestImg(camera_feed);
                ArduinoMotionLibrary.ArdPosition("REDEF", 0, OriginLocation[0], OriginLocation[1] - 60, OriginLocation[2], OriginLocation[3]);
                ArduinoMotionLibrary.ArdPosition("MOVE", 0, Loc[0], Loc[1], Loc[2], Loc[3]); //Move to CPU
                //Verify we're above a CPU
                while(!CameraTestCPU())  
                {
                    //Keep Navigating to next CPU and testing
                }
                //ArduinoMotionLibrary.ArdPosition("SHIFT", 0, 0, 0, -20, 0); //Descend Z
                ArduinoMotionLibrary.ArdPosition("GRAB", 0, 0, 0, 0, 0); //Grab CPU
                //ArduinoMotionLibrary.ArdPosition("SHIFT", 0, 0, 0, 20, 0); //Raise back up
                //Move to Calibration image, verify it's there in the right spot
                ArduinoMotionLibrary.ArdPosition("MOVE", 0, SocketLocation[0], SocketLocation[1]+60, SocketLocation[2], SocketLocation[3]); //Calibration spot
                //CameraTestImg(); //Calibrate Socket
                ArduinoMotionLibrary.ArdPosition("REDEF", 0, SocketLocation[0], SocketLocation[1] + 60, SocketLocation[2], SocketLocation[3]); //Calibration 
                ArduinoMotionLibrary.ArdPosition("MOVE", 0, SocketLocation[0], SocketLocation[1], SocketLocation[2], SocketLocation[3]);
                ArduinoMotionLibrary.ArdPosition("SHIFT", 0, 0, 0, 0, 0); //Descend into socket
                ArduinoMotionLibrary.ArdPosition("RELEASE", 0, 0, 0, 0, 0); //Release CPU
                //Release CPU
                //Wait for test
                //Tell Tray to present good or bad

                //Runing Template detection code

                ArduinoMotionLibrary.ArdPosition("MOVE", 0, OriginLocation[0], OriginLocation[1], OriginLocation[2], OriginLocation[3]); //Demo done, return to origin
            }*/
            return;
        }

        private static void FatalCrash()
        {
            MessageBox.Show("Arm encountered an error, procedure had to be aborted");
        }

        private static void FetchInformation()
        {//Get information from settings later
            centerToCenterL = Math.Round(SettingsLibrary.TrayCenter2CenterCol,0);
            centerToCenterZ = Math.Round(SettingsLibrary.TrayHeight,0);
            centerToCenterW = Math.Round(SettingsLibrary.TrayCenter2CenterRow, 0);  // rounding added
            return;
        }

        public static bool CameraTestImg(Capture camera_feed)
        {
            //value from templateDetection
            CvFunctions _cameraMethods = new CvFunctions();
            double[] template_xy = { 1000, 1000 };
            string[] fileloc = { "../../../../Common/TempImg/CIRCLE_TEMP.jpg" };
            double xShift = 1000;
            double yShift = 1000;
            CvFunctions imgFx = new CvFunctions();

            
            while (Math.Abs(template_xy[0]) > 3 && Math.Abs(template_xy[1]) > 3)
            {
                
                if (xShift < 100 && yShift < 100)
                {
                
                    ArduinoMotionLibrary.ArdPosition("SHIFT", 0, Math.Round(xShift, 0), Math.Round(yShift, 0), 0, 0);
                    template_xy[0] = 1000;
                    template_xy[1] = 1000;
                }
               
                imgFx.TemplateDetection(fileloc, imgFx.SnapPicture(3, camera_feed ), template_xy);
                    
                xShift = -1 * template_xy[0] * Math.Cos(ArduinoMotionLibrary.ArmCoordinates[4] * 0.0174533)
                    + template_xy[1] * Math.Sin(ArduinoMotionLibrary.ArmCoordinates[4] * 0.0174533);
                yShift = template_xy[0] * Math.Sin(ArduinoMotionLibrary.ArmCoordinates[4] * 0.0174533)
                    - template_xy[1] * Math.Cos(ArduinoMotionLibrary.ArmCoordinates[4] * 0.0174533);
                xShift = xShift * ( ArduinoMotionLibrary.ArmCoordinates[2]/165);
                yShift = yShift * ( ArduinoMotionLibrary.ArmCoordinates[2]/165);
                //Shift by the template_xy 

            }
            ArduinoMotionLibrary.ArdPosition("REDEF", 0, TestImgLocation[0], TestImgLocation[1], TestImgLocation[2], TestImgLocation[3]);
            return true;
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
