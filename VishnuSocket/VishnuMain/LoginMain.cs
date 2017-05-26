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
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.Util;

namespace VishnuMain {



    public partial class LoginMain : Form
    {

        
        Capture _capture = new Capture();
        ComputerVision_Tab Match = new ComputerVision_Tab();
        ArmControl Arm = new ArmControl();
        CameraFeed cam = new CameraFeed();

        //Camera Feed

        bool videoFeed;
        Mat frame = new Mat();


        
        

        public LoginMain()
        {
            InitializeComponent();
            
        }

        //set the load order here for all tabs
        public void LoginMain_Load_1(object sender, EventArgs e)
        {
            ArduinoMotionLibrary.ArduinoMotionLibraryBoot();
            LoadMainViewerTab();        //tabindex 0
            LoadArmControlTab();        //tabindex 1
            LoadSettingsTab();          //tabindex 2
            LoadCvDetectionTab();       //tabindex 3
            StartCapture();
            
        }


        //Load main viewer tab
        public void LoadMainViewerTab()
        {
            TabPage page = new TabPage();
            page.Text = "Main Viewer";
            page.Controls.Add(cam);
            centralTab.TabPages.Add(page);
        }

        //load tab page for Arm handler controls
        public void LoadArmControlTab()
        {
            TabPage page = new TabPage();
            page.Text = "Manual Arm Control";            
            page.Controls.Add(Arm);
            centralTab.TabPages.Add(page);
        }

        //load settings tab
        public void LoadSettingsTab()
        {
            TabPage page = new TabPage();
            page.Text = "Settings";
            SettingsMenu Menu = new VishnuMain.SettingsMenu();
            page.Controls.Add(Menu);
            centralTab.TabPages.Add(page);
        }

        //template detection
        public void LoadCvDetectionTab() 
        {
            TabPage page = new TabPage();
            page.Text = "Object Detection";
            page.Controls.Add(Match);
            centralTab.TabPages.Add(page);
        }




        public Capture StartCapture() {
            try {
                
                _capture.SetCaptureProperty(CapProp.FrameHeight, 1080);
                _capture.SetCaptureProperty(CapProp.FrameWidth, 1920);
                _capture.ImageGrabbed += videoFeed_refresher; //live stream image cap
                return _capture;         //return the capture value parameter, 
            }
            catch (System.Exception e) {
                MessageBox.Show(e.StackTrace);
                return _capture = null;
            }
        }

        void videoFeed_refresher(object sender, EventArgs arg) {
            _capture.Retrieve(frame); 
            Match.video_imgbox.Image = frame; 
            Arm.ArmFeedBox.Image = frame;
            cam.CameraFeedBox.Image = frame;
        }



       void button1_Click(object sender, EventArgs e) {
            if (_capture != null) {
                if (videoFeed) {
                    button1.Text = "Start Capture";
                    _capture.Pause();
                }
                else {
                    button1.Text = "Stop";
                    _capture.Start();
                }
                videoFeed = !videoFeed;
            }
        }











    }
}

