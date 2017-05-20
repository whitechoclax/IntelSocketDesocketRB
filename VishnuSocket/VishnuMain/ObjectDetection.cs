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
using DirectShowLib;

namespace VishnuMain
{

    public partial class ComputerVision_Tab : UserControl
    {

        /* Variabless  */
        private Capture _capture = null;
        private bool videoFeed;
        public bool userImgLoaded;
        Mat frame = new Mat();
        String[] templateList;
        Mat source_img = new Mat();
        int CameraDevice = 0; //Variable to track camera device selected
        CameraStructures[] WebCams; //List containing all the camera available


        /* Calling Object CvFunctions */
        CvFunctions _Template = new CvFunctions();


        /* Initialziation for camera feed */

        public ComputerVision_Tab()
        {
            /* Initilize winforms */
            InitializeComponent();
            DsDevice[] _SystemCameras = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            WebCams = new CameraStructures[_SystemCameras.Length];
            for (int i = 0; i < _SystemCameras.Length; i++)
            {
                WebCams[i] = new CameraStructures(i, _SystemCameras[i].Name, _SystemCameras[i].ClassID); //fill web cam array
                Camera_Selection.Items.Add(WebCams[i].ToString());
            }
            if (Camera_Selection.Items.Count > 0)
            {
                Camera_Selection.SelectedIndex = 0; //Set the selected device the default
                startCaptureButton.Enabled = true; //Enable the start
            }
            
        }


        /*public Capture StartCapture()
        {
            try
            {
                //Camera_frame = new Capture();
                //Camera_frame.SetCaptureProperty(CapProp.FrameHeight, 1080);
                //Camera_frame.SetCaptureProperty(CapProp.FrameWidth, 1920);
                //Camera_frame.ImageGrabbed += videoFeed_refresher; //live stream image cap
                return _capture;         //return the capture value parameter, 
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.StackTrace);
                return _capture = null;
            }
        }*/

        private delegate void DisplayImageDelegate(Mat Image);

        private void DisplayImage(Mat Image)
        {

            if (video_imgbox.InvokeRequired)
            {
                try
                {
                    DisplayImageDelegate DI = new DisplayImageDelegate(DisplayImage);
                    this.BeginInvoke(DI, new object[] { Image });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thread Unsafe operation" + ex.ToString());
                }

            }
            else
            {
                //where the camera feed is displayed to UI
                video_imgbox.Image = Image;
            }
        }
        /* Clicking functions on windows form */
        void startCameraFeed_Click(object sender, EventArgs e)
        {

            if (_capture != null)
            {
                if (videoFeed)
                {
                    startCaptureButton.Text = "Start Capture";
                    _capture.Pause();
                    _capture.Dispose();
                    _capture = null;
                    video_imgbox.Image = null;
                    video_imgbox.Refresh();

                }
                else
                {
                    //Check to see if the selected device has changed
                    if (Camera_Selection.SelectedIndex != CameraDevice)
                    {
                        SetupCapture(Camera_Selection.SelectedIndex); //Setup capture with the new device
                    }

                    SetupCapture(Camera_Selection.SelectedIndex);
                    startCaptureButton.Text = "Stop";
                    _capture.Start();
                }
                videoFeed = !videoFeed;
            }

            else
            {
                SetupCapture(Camera_Selection.SelectedIndex);
                startCameraFeed_Click(null, null);
            }
        }

        private void SetupCapture(int Camera_Identifier)
        {
            //update the selected device
            CameraDevice = Camera_Identifier;
            
            //Dispose of Capture if it was created before
            if (_capture != null) _capture.Dispose();
            try
            {
                //Set up capture device
                _capture = new Capture(CameraDevice);
                
                _capture.SetCaptureProperty(CapProp.Fps, 30);
                _capture.ImageGrabbed += _capture_ImageGrabbed;
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }

        private void _capture_ImageGrabbed(object sender, EventArgs e)
        {
            Mat Frame = new Mat();
            _capture.Retrieve(Frame);
            DisplayImage(Frame);
        }

        void captureImg_Click(object sender, EventArgs e)
        {
            //SnapPicture has various modes
            captured_imgbox.Image = _Template.SnapPicture(3, _capture);
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
            res = _Template.TemplateDetection(templateList, _Template.SnapPicture(3, _capture), xy);
            tracked_imgbox.Image = res;
        }

        void savePicture_Click(object sender, EventArgs e)
        {
            _Template.SaveImg(_Template.SnapPicture(3, _capture), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + "EMGU.jpg");
        }

    }
}
