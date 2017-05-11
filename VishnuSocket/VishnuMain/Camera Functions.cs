using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using DataMatrix.net;


namespace VishnuMain
{
    public class CvFunctions {

        Mat color_frame = new Mat();
        Mat gray_frame = new Mat();
        Mat binary_frame = new Mat();
        Mat[] rgb_frame;

        /*CAMERA CAPTURE CLASS*/
        private Capture camera_feed;

        /*CONSTURCTOR: INTIALIZE CAMERA CAPTURE*/
        public CvFunctions() {

            /*CAMERA SETTINGS*/
            camera_feed = new Capture(); 
            camera_feed.SetCaptureProperty(CapProp.FrameHeight, 1080);
            camera_feed.SetCaptureProperty(CapProp.FrameWidth, 1920);
        }

        ~CvFunctions () {
            camera_feed.Dispose();
        }

        /*METHODS BELOW*/

        ///<summary>
        /// Returns image, various modes: 1.grayscale 2.redbinary 3.binary
        ///</summary>
        public Mat SnapPicture(int mode) { 

            camera_feed.Retrieve(color_frame);

            switch (mode) {

                case 1: //case for just grayscale img
                    CvInvoke.CvtColor(color_frame, gray_frame, ColorConversion.Bgr2Gray);
                    return gray_frame;

                case 2://case for barcode scanning
                    rgb_frame = color_frame.Split();
                    CvInvoke.Threshold(rgb_frame[2], binary_frame, 150, 255, ThresholdType.Binary);
                    return binary_frame;

                case 3: //case for calibration x.y
                    CvInvoke.CvtColor(color_frame, gray_frame, ColorConversion.Bgr2Gray);
                    CvInvoke.Threshold(gray_frame, binary_frame, 100, 255, ThresholdType.Binary);
                    return binary_frame;

                default:
                    return color_frame;
            }
        }

        ///<summary>
        ///Return coordinate offset for correcton
        ///</summary>
        public Mat TemplateDetection(string[] templatelist, Mat sourceImg, double[] xy_Coord ) { //takes in list of template images, source img

            Mat ResultMat = new Mat(); //mat data holds template matches coordinates
            Mat result_img = sourceImg.Clone(); //image with rectangles
            int template_length = templatelist.Length;

            //requirement for template detection
            double minValues = 0;
            double maxValues = 0;
            Point minLocations = new Point { X = 0, Y = 0 };
            Point maxLocations = new Point { X = 0, Y = 0 };

            for (int i = 0; i < template_length; ++i) { //loop used to go through all template images

                while (true) { //loop to mark all matches

                    Mat templateImg = CvInvoke.Imread(templatelist[i], LoadImageType.Grayscale); //creates image from list
                    CvInvoke.MatchTemplate(sourceImg, templateImg, ResultMat, TemplateMatchingType.CcoeffNormed); //does template matching
                    //UNHANDLED EXCEPTION HERE!! ^^
                    //finds best matching location
                    CvInvoke.MinMaxLoc(ResultMat, ref minValues, ref maxValues, ref minLocations, ref maxLocations);

                    //accpetance check
                    if (maxValues > 0.8) {

                        //creates rectangle 
                        Rectangle match = new Rectangle(maxLocations, templateImg.Size);

                        double offset_x;
                        double offset_y;
                        double x_cm = 1920 / 23;
                        double y_cm = 1080 / 13;
                        //23x13 @ 16.5 cm
                        //20x10 @ 12.5 cm
                        //12.1x6.8 @ 8.3 cm 
                        //30 x 15.5 @ 21 cm


                        offset_x = Math.Round((960 - (match.X + (match.Width / 2))) / x_cm, 2) * 10;
                        offset_y = Math.Round((540 - (match.Y + (match.Height / 2))) / y_cm, 2) * 10;

                        xy_Coord[0] = offset_x;
                        xy_Coord[1] = offset_y;

                        //MessageBox.Show("Left/Right:" + offset_x + "\n" + "Up/Down:" + offset_y, "Coordinates");

                        //draws rectangle match onto source img
                        CvInvoke.Rectangle(sourceImg, match, new Bgr(Color.Black).MCvScalar, 20);

                        //section to compelte floodfill function
                        //Rectangle outRect;

                        Mat mask = new Mat(sourceImg.Height + 2, sourceImg.Width + 2, DepthType.Cv8U, 1);

                        MCvScalar lo = new MCvScalar(0);
                        MCvScalar up = new MCvScalar(255);

                        //method to fill in all rectagles so there will be no redundant detection
                        //CvInvoke.FloodFill(sourceImg,
                        //    mask, maxLocations,
                        //    new MCvScalar(0), out outRect,
                        //    lo, up,
                        //    Connectivity.FourConnected,
                        //    FloodFillType.Default);

                    }
                    else
                        break;
                } //loops template matching
            }
            return sourceImg;
        }

        ///<summary>
        ///Scans 2D-DataMatrix Barcode and returns value
        ///</summary>
        public string BarcodeScanner(Mat barcode_img) {

            //creates decorder object
            DmtxImageDecoder decoder = new DmtxImageDecoder();

            //decode barcode img
            List<string> codes = decoder.DecodeImage(barcode_img.Bitmap, 1, new TimeSpan(0, 0, 2));

            //return barcode string
            if (codes.Count > 0)
                return codes[0];
            else {
                return "Nothing found";
            }

        }

        public void SaveImg(Mat Img, string filename) {
            Img.Save(filename);
        }

    }
}
