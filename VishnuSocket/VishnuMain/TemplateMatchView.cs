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
    public partial class TemplateMatchView : UserControl
    {
        //UI specific Variables
        private Capture Camera_frame = null;
        List<Mat> UI_images = new List<Mat>();
        private bool snap_on;                       
        public bool isLoaded;                       //is image loaded

        String[] templateList;
        Mat source_img = new Mat();

        //singletons
        private static TemplateMatchView _instance;
        public static TemplateMatchView Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TemplateMatchView();
                return _instance;
            }
        }

        //declare object for class TemplateMatchController
        TemplateMatchController _Template = new TemplateMatchController();
        public TemplateMatchView()
        {
            InitializeComponent();
            Camera_frame = StartCapture();           //start camera feed loading the UI
        }

        public Capture StartCapture()
        {
            try
            {
                Camera_frame = new Capture();
                Camera_frame.ImageGrabbed += CaptureFeed; //live stream image cap
                return Camera_frame;         //return the capture value parameter, 
            }
            catch (System.Exception except)
            {
                MessageBox.Show("Camera Feed could not be started - Check camera conections");
                return Camera_frame = null;
            }
        }
private void takepicture_Click(object sender, EventArgs e)
        {
            //click take a pciture, grab source image from the testbox file, 
            captured_imgbox.Image = _Template.SnapPicture(Camera_frame); //declare object matchtemplatecontroller so we can use it
        }

        private void startCaptureButton_Click(object sender, EventArgs e)
        {
            //start capture of images
            
            if (Camera_frame != null)
                {
                    if (snap_on)
                    {
                        startCaptureButton.Text = "Start Capture";
                        Camera_frame.Pause();
                    }
                    else
                    {
                        startCaptureButton.Text = "Stop";
                        Camera_frame.Start();
                    }
                    snap_on = !snap_on;
                }
            
        }

        //code that handles output to camera feed, 
        private void CaptureFeed(object sender, EventArgs arg)
        {
            Mat frame = new Mat();
            Camera_frame.Retrieve(frame, 0);
            imageBox4.Image = frame;
        }


        private void loadSource_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                sourceimg_textbox.Text = openFileDialog1.FileName;
                isLoaded = true;
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
            source_img = new Mat(sourceimg_textbox.Text, LoadImageType.Grayscale);
            //grab images from UI, run templ detection and retrieve images.  
            UI_images = _Template.TemplateDetection(templateList, source_img, templateList.Length);
            captured_imgbox.Image = UI_images.ElementAt(1);
            template_imgbox.Image = UI_images.ElementAt(2);
            tracked_imgbox.Image = UI_images.ElementAt(3);

        }

        private void ReleaseData()
        {
            if (Camera_frame != null)
                Camera_frame.Dispose();
        }
    }
}
