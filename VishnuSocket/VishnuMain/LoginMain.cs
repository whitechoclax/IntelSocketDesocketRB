using System;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using DirectShowLib;


namespace VishnuMain {
    public partial class LoginMain : Form {

        // object used to control camera
        Capture _capture = null;

        // object used to hold images
        Mat frame = new Mat();
        
        // array to hold list of web cameras
        CameraStructures[] WebCams;


        bool videoFeed;
        int cameraSelect = 0;


        public LoginMain() {
            InitializeComponent();
            list_cameras();
            default_camera();
            StartCapture(); //initilize camera
        }


        // set the load order here for all tabs
        private void LoginMain_Load_1(object sender, EventArgs e) {
            ArduinoMotionLibrary.ArduinoMotionLibraryBoot();
            LoadMainViewerTab();        //tabindex 0
            LoadArmControlTab();        //tabindex 1
            LoadSettingsTab();          //tabindex 2
            LoadCvDetectionTab();       //tabindex 3
        }


        // Load main viewer tab
        private void LoadMainViewerTab() {
            TabPage page = new TabPage();
            page.Text = "Main Viewer";
            CameraFeed cam = new CameraFeed(_capture);
            page.Controls.Add(cam);
            centralTab.TabPages.Add(page);
        }


        // load tab page for Arm handler controls
        private void LoadArmControlTab() {
            TabPage page = new TabPage();
            page.Text = "Manual Arm Control";
            ArmControl Arm = new ArmControl();
            page.Controls.Add(Arm);
            centralTab.TabPages.Add(page);
        }


        // load settings tab
        private void LoadSettingsTab() {
            TabPage page = new TabPage();
            page.Text = "Settings";
            SettingsMenu Menu = new SettingsMenu();
            page.Controls.Add(Menu);
            centralTab.TabPages.Add(page);
        }


        // template detection
        private void LoadCvDetectionTab() {
            TabPage page = new TabPage();
            page.Text = "Object Detection";
            ComputerVision_Tab Match = new ComputerVision_Tab(_capture);
            page.Controls.Add(Match);
            centralTab.TabPages.Add(page);
        }


        // function required to allow for video feed
        public void videoFeed_refresher(object sender, EventArgs arg) {
            _capture.Retrieve(frame);
            main_camera_feed.Image = frame;
        }


        // initialzation for camera feed and object
        public Capture StartCapture() {
            try {
                _capture = new Capture(cameraSelect);
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


        // sets default camera when program opens
        private void default_camera() {
            cameraSelect = Properties.Settings.Default.camera_selection;
            try {
                Camera_Selection.SelectedIndex = cameraSelect;
            } catch {
                try {
                    Camera_Selection.SelectedIndex = 0;
                } catch {
                    MessageBox.Show("No cameras detected!!!");
                }
            }
        }

        
        private void save_camera_Click(object sender, EventArgs e) {
            Properties.Settings.Default.camera_selection = Camera_Selection.SelectedIndex;
            Properties.Settings.Default.Save();
            start_camera.Text = "Resume";
            _capture.Stop();
            _capture.Dispose();
            _capture = null;
            videoFeed = false;
            default_camera();
            StartCapture();
            
        }


        // lists all cameras avaiable on computer
        void list_cameras() {
            //find cameras on system using DirectShow.net dll
            DsDevice[] _SystemCameras = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            WebCams = new CameraStructures[_SystemCameras.Length];
            for (int i = 0; i < _SystemCameras.Length; i++) {
                WebCams[i] = new CameraStructures(i, _SystemCameras[i].Name, _SystemCameras[i].ClassID); //fill web cam array
                Camera_Selection.Items.Add(WebCams[i].ToString());
            }
            if (Camera_Selection.Items.Count > 0) {
                Camera_Selection.SelectedIndex = 0; //Set the selected device the default
                cameraSelect = 0;
                start_camera.Enabled = true; //Enable the start
            }
        }



    }
}

