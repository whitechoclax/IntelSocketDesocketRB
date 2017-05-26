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

namespace VishnuMain {

    public partial class ComputerVision_Tab : UserControl {
        /* Variabless  */

        Capture _capture = null;
        private bool videoFeed;
        public bool userImgLoaded;
        Mat frame = new Mat();
        String[] templateList;
        double[] xy = { 0, 0 };
        Mat source_img = new Mat();

        int CameraDevice = 0; //Variable to track camera device selected
        CameraStructures[] WebCams; //List containing all the camera available

        List<Rectangle> cpuDetected = new List<Rectangle>();

        /* Calling Object CvFunctions */
        CvFunctions _Template = new CvFunctions();



        public ComputerVision_Tab(Capture capture) {
            /* Initilize winforms */
            InitializeComponent();
            _capture = capture;

            // _capture = capture;
            DsDevice[] _SystemCameras = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            WebCams = new CameraStructures[_SystemCameras.Length];

            for (int i = 0; i < _SystemCameras.Length; i++) {
                WebCams[i] = new CameraStructures(i, _SystemCameras[i].Name, _SystemCameras[i].ClassID); //fill web cam array
                Camera_Selection.Items.Add(WebCams[i].ToString());
            }
            if (Camera_Selection.Items.Count > 0) {
                Camera_Selection.SelectedIndex = 0; //Set the selected device the default
                startCaptureButton.Enabled = true; //Enable the start
            }
        }








        void startCameraFeed_Click(object sender, EventArgs e) {

        }

        void captureImg_Click(object sender, EventArgs e) {
            //SnapPicture has various modes
            captured_imgbox.Image = _Template.SnapPicture(3, _capture);
        }

        void loadImg_Click(object sender, EventArgs e) {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes) {
                sourceimg_textbox.Text = openFileDialog1.FileName;
                userImgLoaded = true;
            }
        }

        void loadTemplate_Click(object sender, EventArgs e) {
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes) {
                templateList = openFileDialog2.FileNames;
                template_textbox.Text = String.Join(Environment.NewLine, templateList);

            }
        }

        void findMatch_Click(object sender, EventArgs e) {
            //loads image taken from capture and does templatedetection
            //source_img = new Mat(sourceimg_textbox.Text, LoadImageType.Grayscale);
            //grab images from UI, run templ detection and retrieve images.  
            tracked_imgbox.Image = _Template.TemplateDetection(templateList, _Template.SnapPicture(3, _capture), xy);
        }

        void savePicture_Click(object sender, EventArgs e) {
            _Template.SaveImg(_Template.SnapPicture(3, _capture), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + "EMGU.jpg");
        }

        private void harr_button_Click(object sender, EventArgs e) {

            Mat Img = _Template.SnapPicture(0, _capture); 
            _Template.haar_cascade(Img, cpuDetected);
            _Template.displayHar(Img, cpuDetected, template_imgbox);
            cpuDetected.Clear();
   
          
        }


    }
}

