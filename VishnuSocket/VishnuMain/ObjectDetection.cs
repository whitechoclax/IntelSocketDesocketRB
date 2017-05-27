using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;

namespace VishnuMain {

    public partial class ComputerVision_Tab : UserControl {

        /* Variabless  */
        double[] xy = { 0, 0 };
        String[] templateList;
        Capture _capture = null;
        Mat frame = new Mat();
        Mat source_img = new Mat();
        List<Rectangle> cpuDetected = new List<Rectangle>();
        CvFunctions _Template = new CvFunctions();


        public ComputerVision_Tab(Capture capture) {
            /* Initilize winforms */
            InitializeComponent();
            _capture = capture;
        }


        void captureImg_Click(object sender, EventArgs e) {

            captured_imgbox.Image = _Template.SnapPicture(3, _capture);
        }


        void loadImg_Click(object sender, EventArgs e) {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes) {
                sourceimg_textbox.Text = openFileDialog1.FileName;
            }
        }


        void loadTemplate_Click(object sender, EventArgs e) {
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes) {
                templateList = openFileDialog2.FileNames;
                template_textbox.Text = String.Join(Environment.NewLine, templateList);
            }
            using (Mat templateImg = CvInvoke.Imread(templateList[0], LoadImageType.Grayscale)) {
                template_imgbox.Image = templateImg;
            }
        
        }


        void findMatch_Click(object sender, EventArgs e) {
            tracked_imgbox.Image = _Template.TemplateDetection(templateList, _Template.SnapPicture(3, _capture), xy);
        }


        void savePicture_Click(object sender, EventArgs e) {
            _Template.SaveImg(_Template.SnapPicture(3, _capture), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + "EMGU.jpg");
        }


        void harr__find_Click(object sender, EventArgs e) {
            Mat Img = _Template.SnapPicture(0, _capture);
            _Template.haar_cascade(Img, cpuDetected);
            _Template.displayHar(Img, cpuDetected, tracked_imgbox);
            cpuDetected.Clear();

        }

    }
}

