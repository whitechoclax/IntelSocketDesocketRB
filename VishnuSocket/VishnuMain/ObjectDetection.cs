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
    
        private Capture _objectFeed = null;
        private bool _captureInprogress;        
        public bool userImgLoaded;      
        String[] templateList;
        Mat source_img = new Mat();
        CvFunctions _cameraMethods = new CvFunctions();

        /* Calling Object CvFunctions */
        //CvFunctions _Template = new CvFunctions();


        /* Initialziation for camera feed */

        public ComputerVision_Tab() {
            /* Initilize winforms */
            InitializeComponent();
            video_imgbox.Paint += new System.Windows.Forms.PaintEventHandler(this.video_imgbox_Paint);
            /* start camera feed loading the UI */
            
        }

        public Capture StartCapture()
        {
            if (CameraFeedUnified.camera_feed == null)
            {
                _objectFeed = CameraFeedUnified.EnableCameraFeed();
            }
                _objectFeed.ImageGrabbed += videoFeed_refresher; //live stream image cap
                return CameraFeedUnified.camera_feed;       //return the capture value parameter, 
        }

        private void videoFeed_refresher(object sender, EventArgs arg)
        {
            Mat frame = new Mat();
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            _objectFeed.Retrieve(frame);
             
            video_imgbox.Image = frame;
=======
            Camera_frame.Retrieve(frame, 0);
            video_imgbox.Image = frame; //<<UNHANDLED EXECEPTION
>>>>>>> parent of deaa424... Made some tweaks to improve the auto calibration accuracy, it's still slow, though
=======
            Camera_frame.Retrieve(frame, 0);
            video_imgbox.Image = frame; //<<UNHANDLED EXECEPTION
>>>>>>> parent of deaa424... Made some tweaks to improve the auto calibration accuracy, it's still slow, though
=======
            Camera_frame.Retrieve(frame, 0);
            video_imgbox.Image = frame; //<<UNHANDLED EXECEPTION
>>>>>>> parent of deaa424... Made some tweaks to improve the auto calibration accuracy, it's still slow, though
        }


        /* Clicking functions on windows form */

        private void captureImg_Click(object sender, EventArgs e) {

            //SnapPicture has various modes
            captured_imgbox.Image = _cameraMethods.SnapPicture(3, _objectFeed);
        }

        private void startCameraFeed_Click(object sender, EventArgs e) {

           
            if (_objectFeed!= null)
            {
                if (_captureInprogress)
                {
                    startCaptureButton.Text = "Start Capture";
                    _objectFeed.Pause();
                }
                else
                {
                    _objectFeed = StartCapture();
                    startCaptureButton.Text = "Stop";
                    _objectFeed.Start();

                }
                _captureInprogress = !_captureInprogress;
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

            //grab images from UI, run templ detection and retrieve images.  
            res = _cameraMethods.TemplateDetection(templateList, _cameraMethods.SnapPicture(3, _objectFeed), xy);
            tracked_imgbox.Image = res;
        }

        private void savePicture_Click(object sender, EventArgs e) {

            _cameraMethods.SaveImg(_cameraMethods.SnapPicture(3, _objectFeed), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + "EMGU.jpg");
        }

        //Paint overlay of crosshair
        private void video_imgbox_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            e.Graphics.DrawLine(new Pen(Color.Red,2), 160, 240, 480, 240);
            e.Graphics.DrawLine(new Pen(Color.Red,2), 320, 120, 320, 360);
            e.Graphics.DrawEllipse(new Pen(Color.Red,2), new RectangleF(280.0F, 200.0F, 80.0F, 80.0F));
            e.Dispose();
        }

        private void video_imgbox_Click(object sender, EventArgs e)
        {

        }
    }
}
