using System;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using DirectShowLib;


namespace VishnuMain {
    public partial class LoginMain : Form {

        Capture _capture = null;
        Mat frame = new Mat();
        bool videoFeed;
        CameraStructures[] WebCams;
        int CameraDevice = 0;


        public LoginMain() {
            InitializeComponent();
            StartCapture(); //initilize camera
        }


        //set the load order here for all tabs
        private void LoginMain_Load_1(object sender, EventArgs e) {
            ArduinoMotionLibrary.ArduinoMotionLibraryBoot();
            LoadMainViewerTab();        //tabindex 0
            LoadArmControlTab();        //tabindex 1
            LoadSettingsTab();          //tabindex 2
            LoadCvDetectionTab();       //tabindex 3
            


            


        }


        //Load main viewer tab
        private void LoadMainViewerTab() {
            TabPage page = new TabPage();
            page.Text = "Main Viewer";
            CameraFeed cam = new CameraFeed(_capture);
            page.Controls.Add(cam);
            centralTab.TabPages.Add(page);
        }


        //load tab page for Arm handler controls
        private void LoadArmControlTab() {
            TabPage page = new TabPage();
            page.Text = "Manual Arm Control";
            ArmControl Arm = new ArmControl();
            page.Controls.Add(Arm);
            centralTab.TabPages.Add(page);
        }


        //load settings tab
        private void LoadSettingsTab() {
            TabPage page = new TabPage();
            page.Text = "Settings";
            SettingsMenu Menu = new SettingsMenu();
            page.Controls.Add(Menu);
            centralTab.TabPages.Add(page);
        }


        //template detection
        private void LoadCvDetectionTab() {
            TabPage page = new TabPage();
            page.Text = "Object Detection";
            ComputerVision_Tab Match = new ComputerVision_Tab(_capture);
            page.Controls.Add(Match);
            centralTab.TabPages.Add(page);
        }


        public void videoFeed_refresher(object sender, EventArgs arg) {
            _capture.Retrieve(frame);
            main_camera_feed.Image = frame;
        }


        public Capture StartCapture() {
            try {
                _capture = new Capture();
                _capture.SetCaptureProperty(CapProp.FrameHeight, 1080);
                _capture.SetCaptureProperty(CapProp.FrameWidth, 1920);
                _capture.ImageGrabbed += videoFeed_refresher;
                return _capture;       
            }
            catch (System.Exception e) {
                MessageBox.Show(e.StackTrace);
                return _capture = null;
            }
        }


        public void listCamera() {

            DsDevice[] _SystemCameras = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            WebCams = new CameraStructures[_SystemCameras.Length];
            for (int i = 0; i < _SystemCameras.Length; i++) {
                WebCams[i] = new CameraStructures(i, _SystemCameras[i].Name, _SystemCameras[i].ClassID); //fill web cam array
                Camera_Selection.Items.Add(WebCams[i].ToString());
            }
            if (Camera_Selection.Items.Count > 0) {
                Camera_Selection.SelectedIndex = 0; //Set the selected device the default
                start_camera.Enabled = true; //Enable the start
            }
        }


        private void start_camera_Click(object sender, EventArgs e) {
            if (_capture != null) {
                if (videoFeed) {
                    start_camera.Text = "Start Capture";
                    _capture.Pause();
                }
                else {
                    start_camera.Text = "Stop";
                    _capture.Start();
                }
                videoFeed = !videoFeed;
            }

        }


    }
}

