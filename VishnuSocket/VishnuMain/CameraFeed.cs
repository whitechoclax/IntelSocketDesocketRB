using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
 
using DirectShowLib;

namespace VishnuMain
{
    public partial class CameraFeed : UserControl
    {
        //singletons
        private static CameraFeed _instance;
        public static CameraFeed Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CameraFeed();
                return _instance;
            }
        }


        #region Variables
        private VideoCapture _capture = null;
        private bool _captureInProgress = false;

        int CameraDevice = 0; //Variable to track camera device selected
        CameraStructures[] WebCams; //List containing all the camera available

        int Brightness_Store = 0;
        int Contrast_Store = 0;
        int Sharpness_Store = 0;
        #endregion

        public CameraFeed()
        {
            InitializeComponent();
            Slider_Enable(false);
            //find cameras on system using DirectShow.net dll
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
                captureButton.Enabled = true; //Enable the start
            }
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            //***If you want to access the image data the use the following method call***/
            //Image<Bgr, Byte> frame = new Image<Bgr,byte>(_capture.RetrieveBgrFrame().ToBitmap());

            if (RetrieveBgrFrame.Checked)
            {
                Image<Bgr, byte> frame = _capture.QueryFrame().ToImage<Bgr, byte>();
                //because we are using an autosize picturebox we need to do a thread safe update
               DisplayImage(frame.ToBitmap());
            }
            else if (RetrieveGrayFrame.Checked)
            {
                Image<Bgr, byte> frame = _capture.QueryFrame().ToImage<Bgr, byte>();
                Image<Gray, byte> grayframe = frame.Convert<Gray, Byte>();
                //because we are using an autosize picturebox we need to do a thread safe update
                DisplayImage(grayframe.ToBitmap());
            }
        }

        private delegate void DisplayImageDelegate(Bitmap Image);

        private void DisplayImage(Bitmap Image)
        {
            if (captureBox.InvokeRequired)
            {
                try
                {
                    DisplayImageDelegate DI = new DisplayImageDelegate(DisplayImage);
                    this.BeginInvoke(DI, new object[] { Image });
                }
                catch (Exception ex)
                {
                }
            }
            else
            {
                captureBox.Image = Image;
            }
        }


        private void Slider_Enable(bool State)
        {
            Brigtness_SLD.Enabled = State;
            Contrast_SLD.Enabled = State;
            Sharpness_SLD.Enabled = State;
        }

        private void flipVerticalButton_Click(object sender, EventArgs e)
        {
            if (_capture != null) _capture.FlipVertical = !_capture.FlipVertical;
        }

        private void flipHorizontalButton_Click(object sender, EventArgs e)
        {
            if (_capture != null) _capture.FlipHorizontal = !_capture.FlipHorizontal;
        }

        private void captureButton_Click(object sender, EventArgs e)
        {
            if (_capture != null)
            {
                if (_captureInProgress)
                {
                    //stop the capture
                    captureButton.Text = "Start Capture"; //Change text on button
                    Slider_Enable(false);
                    _capture.Pause(); //Pause the capture
                    _captureInProgress = false; //Flag the state of the camera
                }
                else
                {
                    //Check to see if the selected device has changed
                    if (Camera_Selection.SelectedIndex != CameraDevice)
                    {
                        SetupCapture(Camera_Selection.SelectedIndex); //Setup capture with the new device
                    }

                    RetrieveCaptureInformation(); //Get Camera information
                    captureButton.Text = "Stop"; //Change text on button
                    StoreCameraSettings(); //Save Camera Settings
                    Slider_Enable(true);  //Enable User Controls
                    _capture.Start(); //Start the capture
                    _captureInProgress = true; //Flag the state of the camera
                }

            }
            else
            {
                //set up capture with selected device
                SetupCapture(Camera_Selection.SelectedIndex);
                //Be lazy and Recall this method to start camera
                captureButton_Click(null, null);
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
                _capture = new VideoCapture(CameraDevice);
                _capture.ImageGrabbed += ProcessFrame;
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }

        private void RetrieveCaptureInformation()
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("Camera: " + WebCams[CameraDevice].Device_Name + " (-1 = Unknown)\n\n");

            //Brightness
            richTextBox1.AppendText("Brightness: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Brightness).ToString() + "\n"); //get the value and add it to richtextbox
            Brigtness_SLD.Value = (int)_capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Brightness);  //Set the slider value
            Brigthness_LBL.Text = Brigtness_SLD.Value.ToString(); //set the slider text

            //Contrast
            richTextBox1.AppendText("Contrast: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Contrast).ToString() + "\n");//get the value and add it to richtextbox
            Contrast_SLD.Value = (int)_capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Contrast);  //Set the slider value
            Contrast_LBL.Text = Contrast_SLD.Value.ToString(); //set the slider text

            //Sharpness
            richTextBox1.AppendText("Sharpness: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Sharpness).ToString() + "\n");
            Sharpness_SLD.Value = (int)_capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Sharpness);  //Set the slider value
            Sharpness_LBL.Text = Sharpness_SLD.Value.ToString(); //set the slider text

            //TODO: ALL These need sliders setting up on main form
            richTextBox1.AppendText("Convert RGB : " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.ConvertRgb).ToString() + "\n");
            richTextBox1.AppendText("Exposure control done by camera: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.AutoExposure).ToString() + "\n");
            richTextBox1.AppendText("Exposure: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Exposure).ToString() + "\n");
            richTextBox1.AppendText("Frame Height: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight).ToString() + "\n");
            richTextBox1.AppendText("Frame Width: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth).ToString() + "\n");
            richTextBox1.AppendText("Gain: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Gain).ToString() + "\n");
            richTextBox1.AppendText("Gamma: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Gamma).ToString() + "\n");
            richTextBox1.AppendText("Hue: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Hue).ToString() + "\n");
            richTextBox1.AppendText("Saturation: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Staturation).ToString() + "\n");
            richTextBox1.AppendText("Sharpness: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Sharpness).ToString() + "\n");
            richTextBox1.AppendText("Trigger: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Trigger).ToString() + "\n");
            richTextBox1.AppendText("Trigger Delay: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.TriggerDelay).ToString() + "\n");
            richTextBox1.AppendText("White balance blue u : " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.WhiteBalanceBlueU).ToString() + "\n");
            richTextBox1.AppendText("White balance red v : " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.WhiteBalanceRedV).ToString() + "\n");
            richTextBox1.AppendText("Max DC1394: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.MaxDC1394).ToString() + "\n");
            richTextBox1.AppendText("Current Capture Mode: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Mode).ToString() + "\n");
            richTextBox1.AppendText("Monocrome : " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Monochrome).ToString() + "\n");
            richTextBox1.AppendText("Rectification : " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Rectification).ToString() + "\n");
            richTextBox1.AppendText("Preview (tricky property, returns cpnst char* indeed ): " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.SupportedPreviewSizesString).ToString() + "\n");

            #region Unused
            /*
            //OpenNI
            richTextBox1.AppendText("\nOpen NI specific devices: \n");
            richTextBox1.AppendText("OpenNI map generators : " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_OPENNI_DEPTH_GENERATOR).ToString() + "\n");
            richTextBox1.AppendText("Depth generator baseline, in mm: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_OPENNI_DEPTH_GENERATOR_BASELINE).ToString() + "\n");
            richTextBox1.AppendText("Depth generator focal length, in pixels: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_OPENNI_DEPTH_GENERATOR_FOCAL_LENGTH).ToString() + "\n");
            richTextBox1.AppendText("OpenNI map generators: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_OPENNI_GENERATORS_MASK).ToString() + "\n");
            richTextBox1.AppendText("CV_CAP_OPENNI_IMAGE_GENERATOR: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_OPENNI_IMAGE_GENERATOR).ToString() + "\n");
            richTextBox1.AppendText("Image generator output mode : " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_OPENNI_IMAGE_GENERATOR_OUTPUT_MODE).ToString() + "\n");
            richTextBox1.AppendText("OpenNI Baseline mm: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_OPENNI_BASELINE).ToString() + "\n");
            richTextBox1.AppendText("OpenNI Focal Length, pixels: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_OPENNI_FOCAL_LENGTH).ToString() + "\n");
            richTextBox1.AppendText("OpenNI Max Depth mm: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_OPENNI_FRAME_MAX_DEPTH).ToString() + "\n");
            richTextBox1.AppendText("OpenNI Oputput Mode: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_OPENNI_OUTPUT_MODE).ToString() + "\n");
             
            //Android
            richTextBox1.AppendText("\nAndroid Only: \n");
            richTextBox1.AppendText("property for highgui class: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_AUTOGRAB).ToString() + "\n");
             
            //Video File
            richTextBox1.AppendText("\nVideo Files: \n");
            richTextBox1.AppendText("Format: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FORMAT).ToString() + "\n");
            richTextBox1.AppendText("4-character code of codec : " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FOURCC).ToString() + "\n");
            richTextBox1.AppendText("Frame rate : " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FPS).ToString() + "\n");
            richTextBox1.AppendText("Number of frames in video file : " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_COUNT).ToString() + "\n");
            richTextBox1.AppendText(" Relative position of the video file (0 - start of the film, 1 - end of the film): " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_POS_AVI_RATIO).ToString() + "\n");
            richTextBox1.AppendText("0-based index of the frame to be decoded/captured next: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_POS_FRAMES).ToString() + "\n");
            richTextBox1.AppendText("Film current position in milliseconds or video capture timestamp: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_POS_MSEC).ToString() + "\n");

            //GStreamer Device
            richTextBox1.AppendText("\nGStreamer: \n");
            richTextBox1.AppendText("Properties of cameras available through GStreamer interface: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_GSTREAMER_QUEUE_LENGTH).ToString() + "\n");*/
            #endregion

        }

        private void StoreCameraSettings()
        {
            Brightness_Store = Brigtness_SLD.Value;
            Contrast_Store = Contrast_SLD.Value;
            Sharpness_Store = Sharpness_SLD.Value;
        }

        private void Refresh_BTN_Click(object sender, EventArgs e)
        {
            if (_capture != null)
            {
                RetrieveCaptureInformation();
            }
        }

        private void Reset_Cam_Settings_Click(object sender, EventArgs e)
        {

            if (_capture != null)
            {
                _capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.Brightness, Brightness_Store);
                _capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.Contrast, Contrast_Store);
                _capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.Sharpness, Sharpness_Store);
                RetrieveCaptureInformation(); // This will refresh the settings
            }
        }

        private void Brigtness_SLD_Scroll(object sender, EventArgs e)
        {
            Brigthness_LBL.Text = Brigtness_SLD.Value.ToString();
            if (_capture != null) _capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.Contrast, Brigtness_SLD.Value);
        }

        private void Contrast_SLD_Scroll(object sender, EventArgs e)
        {
            Contrast_LBL.Text = Contrast_SLD.Value.ToString();
            if (_capture != null) _capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.Contrast, Contrast_SLD.Value);
        }

        private void Sharpness_SLD_Scroll(object sender, EventArgs e)
        {
            Sharpness_LBL.Text = Sharpness_SLD.Value.ToString();
            if (_capture != null) _capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.Sharpness, Sharpness_SLD.Value);
        }

        protected void OnFormClosing(CancelEventArgs e)
        {
            if (Capture != null)
            {
                Reset_Cam_Settings_Click(null, null);
                _capture.Dispose();
            }

        }
        //both boxes cant be checked!
        private void RetrieveBgrFrame_CheckedChanged(object sender, EventArgs e)
        {
            if (RetrieveBgrFrame.Checked)
            {
                RetrieveGrayFrame.Checked = !RetrieveBgrFrame.Checked;
            }
        }

        private void RetrieveGrayFrame_CheckedChanged(object sender, EventArgs e)
        {
            if (RetrieveGrayFrame.Checked)
            {
                RetrieveBgrFrame.Checked = !RetrieveGrayFrame.Checked;
            }
        }

    
    }
}
