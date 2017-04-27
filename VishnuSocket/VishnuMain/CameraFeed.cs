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
        private Capture _capture = null;
        private bool _captureInProgress = false;
        Mat frame = new Mat();
        Mat grayFrame = new Mat();
        int CameraDevice = 0; //Variable to track camera device selected
        CameraStructures[] WebCams; //List containing all the camera available

        int Brightness_Store = 0;
        int Contrast_Store = 0;
        int Sharpness_Store = 0;
        #endregion

        public CameraFeed()
        {
            InitializeComponent();
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
            
                _capture.Retrieve(frame);
                DisplayImage(frame.Bitmap);
                //_capture.Dispose();     if we have dispose this shit never works lol
                //CvInvoke.CvtColor(frame, grayFrame, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
        }

        private delegate void DisplayImageDelegate(Bitmap Image);

        private void DisplayImage(Bitmap Image)
        {
            if (CaptureBox.InvokeRequired)
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
                
                CaptureBox.Image = Image;
            }
        }


      

        private void captureButton_Click(object sender, EventArgs e)
        {
            if (_capture != null)
            {
                if (_captureInProgress)
                {
                    //stop the capture
                    captureButton.Text = "Start Capture"; //Change text on button
                   
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
                _capture = new Capture(CameraDevice);
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


        protected void OnFormClosing(CancelEventArgs e)
        {
            if (Capture != null)
            {
                Reset_Cam_Settings_Click(null, null);
                _capture.Dispose();
            }

        }
        
       
        private void MainSequenceButton_Click(object sender, EventArgs e)
        {
            if (ArmHandlerLibrary.Running == false)
            {
                //stop the capture
                MainSequenceButton.Text = "Stop Test"; //Change text on button
                MainSequenceButton.BackColor = System.Drawing.Color.Red;
                ArmHandlerLibrary.Running = true;
                ArmHandlerLibrary.ArmHandlerLibraryMainSequence(); //Should be background worker
            }
            else
            {
                MainSequenceButton.Text = "Start Test Sequence"; //Change text on button
                MainSequenceButton.BackColor = System.Drawing.Color.Blue;
                ArmHandlerLibrary.Running = false;
            }
        }

        //dummy placeholder to demonstrate use of settingslibrary
        private void showStats_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(SettingsLibrary.InvPathString + Environment.NewLine);
            richTextBox1.AppendText(SettingsLibrary.TrayCenter2Center.ToString() + Environment.NewLine);
            richTextBox1.AppendText(SettingsLibrary.TrayOrigin2Center.ToString() + Environment.NewLine);
            richTextBox1.AppendText(SettingsLibrary.TrayStack.ToString() + Environment.NewLine);
            richTextBox1.AppendText(SettingsLibrary.TrayWidth.ToString() + Environment.NewLine);
            richTextBox1.AppendText(SettingsLibrary.TrayLength.ToString() + Environment.NewLine);

        }
    }
}
