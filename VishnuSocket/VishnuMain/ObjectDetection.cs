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
        private Capture Camera_frame = null;
        private bool videoFeed;        
        public bool userImgLoaded;
        Mat frame = new Mat();
        String[] templateList;
        Mat source_img = new Mat();


        /* Calling Object CvFunctions */
        CvFunctions _Template = new CvFunctions();


        /* Initialziation for camera feed */

        public ComputerVision_Tab() {
            /* Initilize winforms */
            InitializeComponent();

            /* start camera feed loading the UI */
            Camera_frame = StartCapture();
        }

        
        public Capture StartCapture()
        {
            try
            {
                Camera_frame = new Capture();
                Camera_frame.SetCaptureProperty(CapProp.FrameHeight, 1080);
                Camera_frame.SetCaptureProperty(CapProp.FrameWidth, 1920);
                Camera_frame.ImageGrabbed += videoFeed_refresher; //live stream image cap
                return Camera_frame;         //return the capture value parameter, 
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.StackTrace);
                return Camera_frame = null;
            }
        }

        void videoFeed_refresher(object sender, EventArgs arg)
        {
            Camera_frame.Retrieve(frame); //<<Memory exception, something about corrupt
            video_imgbox.Image = frame; //<<UNHANDLED EXECEPTION perameter is not valid
        }

        /* Clicking functions on windows form */
        void startCameraFeed_Click(object sender, EventArgs e) {

            if (Camera_frame != null) {
                if (videoFeed) {
                    startCaptureButton.Text = "Start Capture";
                    Camera_frame.Pause();
                }
                else {
                    startCaptureButton.Text = "Stop";
                    Camera_frame.Start();
                }
                videoFeed = !videoFeed;
            }
        }




        void captureImg_Click(object sender, EventArgs e) {

            //SnapPicture has various modes
           captured_imgbox.Image = _Template.SnapPicture(3);
        }

        void loadImg_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                sourceimg_textbox.Text = openFileDialog1.FileName;
                userImgLoaded = true;
            }
        }

        void loadTemplate_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                templateList = openFileDialog2.FileNames;
                template_textbox.Text = String.Join(Environment.NewLine, templateList);
                
            }
        }

        void findMatch_Click(object sender, EventArgs e)
        {
            double[] xy = { 0, 0 };

            //loads image taken from capture and does templatedetection
            Mat res = new Mat();   
            //source_img = new Mat(sourceimg_textbox.Text, LoadImageType.Grayscale);

            //grab images from UI, run templ detection and retrieve images.  
            res =_Template.TemplateDetection(templateList, _Template.SnapPicture(3), xy);
            tracked_imgbox.Image = res;
        }

        void savePicture_Click(object sender, EventArgs e) {
            _Template.SaveImg(_Template.SnapPicture(3), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + "EMGU.jpg");
        }
            
    }
}
