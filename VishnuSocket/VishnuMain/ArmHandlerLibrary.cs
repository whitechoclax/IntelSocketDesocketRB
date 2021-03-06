﻿using System;
using Emgu.CV;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace VishnuMain
{
    static class ArmHandlerLibrary
    {
        public static bool Running = false;
        public static double[] RestLocation = SettingsLibrary.RestLocationCoords; //Change to calibration image
        // Calibrate image at: "COOR:176.00:339.00:60.00:84.0:27.50"
        public static double[] OriginLocation = SettingsLibrary.OriginLocationCoords; //CPU0 location + 1cm up on z
        public static double[] TestImgLocation = SettingsLibrary.SocketLocationCoords; //Img location
        //"COOR:0.00:183.00:38.00:0.0:0.00\r" , z = 52 for last one,
        public static double[] SocketLocation = SettingsLibrary.SocketLocationCoords; //Socket center point 
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
              if (ArduinoMotionLibrary.ArdPosition("MOVE", 1, 0, 0, 0, 0) == 2)
              { FatalCrash(); return; }//Move tray to spot 0 in order to get tray 2 under arm
              if (ArduinoMotionLibrary.ArdPosition("MOVE", 0, OriginLocation[0], OriginLocation[1], OriginLocation[2], OriginLocation[3]) == -2)
              { FatalCrash(); return; }//Move to CPU0
              //GrabChip();

                Task.Delay(1000);
                if (ArduinoMotionLibrary.ArdPosition("SHIFT", 0, 0, 0, -10, 0) == -2)
                { FatalCrash(); return; }//Move down to grab CPU 10mm
                if (ArduinoMotionLibrary.ArdPosition("GRAB", 0, 0, 0, 0, 0) == -2)
                { FatalCrash(); return; }
                if (ArduinoMotionLibrary.ArdPosition("SHIFT", 0, 0, 0, 20, 0) == -2)
                { FatalCrash(); return; }//Raise back up 10mm

                //if (ArduinoMotionLibrary.ArdPosition("MOVE", 0, TestImgLocation[0], TestImgLocation[1], TestImgLocation[2], TestImgLocation[3]) == -2)
                //{ FatalCrash(); return; }//Go calibrate
                //CameraTestImg(camera_feed);
                //Task.Delay(1000);
                //if (ArduinoMotionLibrary.ArdPosition("MOVE", 0, OriginLocation[0], OriginLocation[1]-centerToCenterL, OriginLocation[2], OriginLocation[3]) == -2)
                //if (ArduinoMotionLibrary.ArdPosition("MOVE", 0, 195, 323, OriginLocation[2] + (5 * 1), 51) == -2)
                //{ FatalCrash(); return; }//Move to next spot
                if (ArduinoMotionLibrary.ArdPosition("MOVE", 1, 1, 0, 0, 0) == 2)
              { FatalCrash(); return; }//Move tray to spot 1 in order to get tray 3 under arm
              //ReleaseChip();

                Task.Delay(1000);
                if (ArduinoMotionLibrary.ArdPosition("SHIFT", 0, 0, 0, -15, 0) == -2)
                { FatalCrash(); return; }//Put it down
                if (ArduinoMotionLibrary.ArdPosition("RELEASE", 0, 0, 0, 0, 0) == -2)
                { FatalCrash(); return; }
                if (ArduinoMotionLibrary.ArdPosition("SHIFT", 0, 0, 0, 10, 0) == -2)
                { FatalCrash(); return; }//Go back

                Task.Delay(3000);
              if (ArduinoMotionLibrary.ArdPosition("MOVE", 0, RestLocation[0], RestLocation[1], RestLocation[2], RestLocation[3]) == -2)
              { FatalCrash(); return; }//Move to rest location to finish
              
              //}
              //This is a demo of range of motion
              /*
                if (ArduinoMotionLibrary.ArdPosition("MOVE", 1, 0, 0, 0, 0) == 2)
                { FatalCrash(); return; }//Move to next tray spot
                if (ArduinoMotionLibrary.ArdPosition("MOVE", 1, 1, 0, 0, 0) == 2)
                { FatalCrash(); return; }//Move to next tray spot
                if (ArduinoMotionLibrary.ArdPosition("MOVE", 1, 2, 0, 0, 0) == 2)
                { FatalCrash(); return; }//Move to next tray spot
                if (ArduinoMotionLibrary.ArdPosition("MOVE", 1, 3, 0, 0, 0) == 2)
                { FatalCrash(); return; }//Move to next tray spot
                /*if (ArduinoMotionLibrary.ArdPosition("MOVE", 0, RestLocation[0], RestLocation[1], RestLocation[2], RestLocation[3]) == -2)
                { FatalCrash(); return; }//Move to next spot
                if (ArduinoMotionLibrary.ArdPosition("MOVE", 0, 300, 300, 300, 84) == -2)
                { FatalCrash(); return; }//Move to next spot
                if (ArduinoMotionLibrary.ArdPosition("MOVE", 0, 300, 300, 300, 40) == -2)
                { FatalCrash(); return; }//Move to next spot
                if (ArduinoMotionLibrary.ArdPosition("MOVE", 0, 300, 300, 300, 120) == -2)
                { FatalCrash(); return; }//Move to next spot
                if (ArduinoMotionLibrary.ArdPosition("MOVE", 0, 300, 300, 300, 84) == -2)
                { FatalCrash(); return; }//Move to next spot
                if (ArduinoMotionLibrary.ArdPosition("MOVE", 0, 200, 82, 300, 84) == -2)
                { FatalCrash(); return; }//Move to next spot
                if (ArduinoMotionLibrary.ArdPosition("MOVE", 0, 200, 82, 300, 84) == -2)
                { FatalCrash(); return; }//Move to next spot
                if (ArduinoMotionLibrary.ArdPosition("MOVE", 0, RestLocation[0], RestLocation[1], RestLocation[2], RestLocation[3]) == -2)
                { FatalCrash(); return; }//Move to next spot
                */
                Running = false;
                done = true; 
            }
            
            return;
        }

        private static void FatalCrash()
        {
            MessageBox.Show("Arm encountered an error, procedure had to be aborted");
        }
        private static void GrabChip()
        {
            Task.Delay(1000);
            if (ArduinoMotionLibrary.ArdPosition("SHIFT", 0, 0, 0, -10, 0) == -2)
            { FatalCrash(); return; }//Move down to grab CPU 10mm
            if (ArduinoMotionLibrary.ArdPosition("GRAB", 0, 0, 0, 0, 0) == -2)
            { FatalCrash(); return; }
            if (ArduinoMotionLibrary.ArdPosition("SHIFT", 0, 0, 0, 10, 0) == -2)
            { FatalCrash(); return; }//Raise back up 10mm
        }
        private static void ReleaseChip()
        {
            Task.Delay(1000);
            if (ArduinoMotionLibrary.ArdPosition("SHIFT", 0, 0, 0, -10, 0) == -2)
            { FatalCrash(); return; }//Put it down
            if (ArduinoMotionLibrary.ArdPosition("RELEASE", 0, 0, 0, 0, 0) == -2)
            { FatalCrash(); return; }
            if (ArduinoMotionLibrary.ArdPosition("SHIFT", 0, 0, 0, 10, 0) == -2)
            { FatalCrash(); return; }//Go back
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
            string filepath = "../../../../Common/TempImg/";
            CvFunctions _cameraMethods = new CvFunctions();
            double[] template_xy = { 1000, 1000 };
            string[] fileloc = { filepath + "CIRCLE_TEMP_2.jpg" , filepath + "CIRCLE_TEMP_2.jpg" };
            double xShift = 1000;
            double yShift = 1000;
            CvFunctions imgFx = new CvFunctions();

            
            while (xShift > 3 || xShift < -3 || yShift > 3 || yShift < -3)
            {
                
                if (xShift < 100 && xShift > -100 && yShift < 100 && yShift > -100)
                {
                
                    ArduinoMotionLibrary.ArdPosition("SHIFT", 0, Math.Round(xShift, 0), Math.Round(yShift, 0), 0, 0);
                    template_xy[0] = 1000;
                    template_xy[1] = 1000;
                }
               
                imgFx.TemplateDetection(fileloc, imgFx.SnapPicture(3, camera_feed ), template_xy, false);
                    
                xShift = -1 * template_xy[0] * Math.Cos(ArduinoMotionLibrary.ArmCoordinates[4] * 0.0174533)
                    + template_xy[1] * Math.Sin(ArduinoMotionLibrary.ArmCoordinates[4] * 0.0174533);
                yShift = template_xy[0] * Math.Sin(ArduinoMotionLibrary.ArmCoordinates[4] * 0.0174533)
                    - template_xy[1] * Math.Cos(ArduinoMotionLibrary.ArmCoordinates[4] * 0.0174533);
                xShift = xShift * ( ArduinoMotionLibrary.ArmCoordinates[2]/165);
                yShift = -1 * yShift * ( ArduinoMotionLibrary.ArmCoordinates[2]/165);
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
