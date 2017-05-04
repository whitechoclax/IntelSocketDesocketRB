using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Drawing;


namespace VishnuMain
{
    public class TemplateMatchController
    {
        //local vars to namespace
        Capture camera_feed = null;
        Mat camera_img = new Mat();
        Mat gray_frame = new Mat();
        Mat Overlay = new Mat();
        Mat Load_Img = new Mat();
        Mat Comp_Img = new Mat();
        //public bool isCapturing;


        //take picture with capture button.  Retreive feed data from caller.  NEEDS 
        // a camera stream as an argument
        public Mat SnapPicture(Capture camera_feed)
        { 
            Mat frame = new Mat();
            
            camera_feed.Retrieve(frame, 0);
            CvInvoke.CvtColor(frame, camera_img, ColorConversion.Bgr2Gray);
            return camera_img;
     
        }

        //Main templete detection.  Uses a list of images (choosen by user in this case, 
        public List<Mat> TemplateDetection(String[] templatelist, Mat sourceImg, int template_length)
        {

            Mat ResultMat = new Mat(); //mat data holds template matches coordinates
            Mat result_img = sourceImg.Clone(); //image with rectangles

            //declare new list of Mat objects
            List<Mat> template_imageArray = new List<Mat>();


            for (int i = 0; i < template_length; ++i)
            { //loop used to go through all template images

                Mat templateImg = new Mat(templatelist[i], LoadImageType.Grayscale);
                CvInvoke.MatchTemplate(sourceImg, templateImg, ResultMat, TemplateMatchingType.CcoeffNormed);

                while (true)
                { //loop to mark all matches

                    //requirement for Floodfill
                    double minValues = 0;
                    double maxValues = 0;
                    Point minLocations = new Point { X = 0, Y = 0 };
                    Point maxLocations = new Point { X = 0, Y = 0 };

                    //finds best matching location
                    CvInvoke.MinMaxLoc(ResultMat, ref minValues, ref maxValues, ref minLocations, ref maxLocations);

                    //accpetance check
                    if (maxValues > 0.8)
                    {
                        //draw a rectangle around matched template location
                        Rectangle match = new Rectangle(maxLocations, templateImg.Size);
                        CvInvoke.Rectangle(result_img, match, new MCvScalar(0, 255, 0), 2);

                        //section to compelte floodfill function
                        Rectangle outRect;
                        Mat mask = ResultMat.Clone();
                        int width = mask.Width;
                        int height = mask.Height;
                        Image<Gray, Byte> fillMasks = new Image<Gray, Byte>(width + 2, height + 2);
                        MCvScalar lo = new MCvScalar(0);
                        MCvScalar up = new MCvScalar(255);

                        //method to fill in all rectagles so there will be no redundant detection
                        CvInvoke.FloodFill(ResultMat,
                            fillMasks, maxLocations,
                            new MCvScalar(0), out outRect,
                            lo, up,
                            Connectivity.FourConnected,
                            FloodFillType.Default);
                    }
                    else
                        break;
                }
            }
            

            //Add items to list
            template_imageArray.Add(sourceImg);
            template_imageArray.Add(Comp_Img);
            template_imageArray.Add(result_img);

            return template_imageArray;
        }

       



        //load img and comp img are given by frames from top of this class function, overlay is a clone
        //captured_imgbox.Image = Load_Img;
        //template_imgbox.Image = Comp_Img;
        //tracked_imgbox.Image = Overlay;

    }
}
