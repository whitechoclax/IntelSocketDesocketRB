using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Drawing;

namespace VishnuMain
{
    class TemplateMatchController
    {

        private Capture camera_frame = null;
        Mat gray_frame = new Mat();
        private bool isCapturing;


        public Mat SnapPicture()
        { //take picture with capture button
            Mat frame = new Mat();
            camera_frame.Retrieve(frame, 0);
            CvInvoke.CvtColor(frame, gray_frame, ColorConversion.Bgr2Gray);
            //returns grayframe, so hopefully whenver this is run the imagebox 
            return gray_frame;
        }

        public void templateDetection(String template)
        {
            Mat Load_Img = gray_frame;
            Mat Comp_Img = new Mat(template, LoadImageType.Grayscale);

            Mat Result = new Mat(); //stores results of CvInvoke.MatchTemplate();
            Mat Overlay = gray_frame.Clone();
            Mat Mask = new Mat();
            CvInvoke.MatchTemplate(Load_Img, Comp_Img, Result, TemplateMatchingType.CcoeffNormed);

            while (true)
            {

                double minValues = 0;
                double maxValues = 0;
                Point minLocations = new Point { X = 0, Y = 0 };
                Point maxLocations = new Point { X = 0, Y = 0 };

                //Result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);
                CvInvoke.MinMaxLoc(Result, ref minValues, ref maxValues, ref minLocations, ref maxLocations);

                if (maxValues > 0.7)
                {
                    // This is a match. Do something with it, for example draw a rectangle around it.
                    Rectangle match = new Rectangle(maxLocations, Comp_Img.Size);
                    CvInvoke.Rectangle(Overlay, match, new MCvScalar(0, 255, 0), 2);
                    Rectangle outRect;

                    Mat size = Result.Clone();
                    int width = size.Width;
                    int height = size.Height;

                    Image<Gray, Byte> fillMask = size.ToImage<Gray, Byte>();
                    Image<Gray, Byte> fillMasks = new Image<Gray, Byte>(width + 2, height + 2);

                    MCvScalar lo = new MCvScalar(0);
                    MCvScalar up = new MCvScalar(255);

                    CvInvoke.FloodFill(Result,fillMasks, maxLocations, new MCvScalar(0), out outRect,
                        lo, up, Connectivity.FourConnected, FloodFillType.Default);
                }
                else
                    break;
            }    
        }


        public void DisplayImages()
        {


            //load img and comp img are given by frames from top of this class function, overlay is a clone
            //captured_imgbox.Image = Load_Img;
            //template_imgbox.Image = Comp_Img;
            //tracked_imgbox.Image = Overlay;
        }
    }
}
