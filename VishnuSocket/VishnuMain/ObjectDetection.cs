using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.Util;

namespace VishnuMain
{

    public partial class ComputerVision_Tab : UserControl
    {

        /* Variabless  */
    
        //private Capture Camera_frame = null;
        private bool videoFeed;        
        public bool userImgLoaded;      
        String[] templateList;
        Mat source_img = new Mat();


        /* Calling Object CvFunctions */
        //CvFunctions _Template = new CvFunctions();


        /* Initialziation for camera feed */

        public ComputerVision_Tab() {
            /* Initilize winforms */
            InitializeComponent();

            /* start camera feed loading the UI */
            
        }

        public Capture StartCapture()
        {
            try
            {
                
                CvFunctions.CvFunctionsCamera();

                CvFunctions.camera_feed.ImageGrabbed += videoFeed_refresher; //live stream image cap
                return CvFunctions.camera_feed;       //return the capture value parameter, 
            }
            catch (System.Exception)
            {
                MessageBox.Show("Camera Feed could not be started - Check camera conections");
                return CvFunctions.camera_feed = null;
                
            }
        }

        private void videoFeed_refresher(object sender, EventArgs arg)
        {
            Mat frame = new Mat();
            CvFunctions.camera_feed.Retrieve(frame);
             
            video_imgbox.Image = frame;
        }


        /* Clicking functions on windows form */

        private void captureImg_Click(object sender, EventArgs e) {

            //SnapPicture has various modes
            captured_imgbox.Image = CvFunctions.SnapPicture(3);
        }

        private void startCameraFeed_Click(object sender, EventArgs e) {

            CvFunctions.camera_feed = StartCapture();
            if (CvFunctions.camera_feed != null) {
                if (videoFeed) {
                    startCaptureButton.Text = "Start Capture";
                    CvFunctions.camera_feed.Pause();
                }
                else {
                    startCaptureButton.Text = "Stop";
                    CvFunctions.camera_feed.Start();
                }
                videoFeed = !videoFeed;
            }
        }

        private void loadImg_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                sourceimg_textbox.Text = openFileDialog1.FileName;
                userImgLoaded = true;
            }
        }

        private void loadTemplate_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                templateList = openFileDialog2.FileNames;
                template_textbox.Text = String.Join(Environment.NewLine, templateList);
                
            }
        }

        private void findMatch_Click(object sender, EventArgs e)
        {
            double[] xy = { 0, 0 };

            //loads image taken from capture and does templatedetection
            Mat res = new Mat();   
            //source_img = new Mat(sourceimg_textbox.Text, LoadImageType.Grayscale);

            //grab images from UI, run templ detection and retrieve images.  
            res = CvFunctions.TemplateDetection(templateList, CvFunctions.SnapPicture(3), xy);
            tracked_imgbox.Image = res;
        }

        private void savePicture_Click(object sender, EventArgs e) {

            CvFunctions.SaveImg(CvFunctions.SnapPicture(3), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + "EMGU.jpg");
        }
            
    }
}
