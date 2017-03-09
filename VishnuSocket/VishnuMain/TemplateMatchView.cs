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
        private Capture Camera_frame = null;
       
        private bool snap_on;

        //declare object for class TemplateMatchController
        TemplateMatchController _Template = new TemplateMatchController();
        public TemplateMatchView()
        {
            InitializeComponent();
            try
            {
                Camera_frame = new Capture();
                Camera_frame.ImageGrabbed += CaptureFeed; //live stream image cap
            }
            catch (NullReferenceException except)
            {
                MessageBox.Show(except.Message);
            }
        }

        //code for imagebox4 cap feed viewer
        private void CaptureFeed(object sender, EventArgs arg)
        {
            Mat frame = new Mat();
            Camera_frame.Retrieve(frame, 0);
            imageBox4.Image = frame;
        }

        private void fileNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void takepicture_Click(object sender, EventArgs e)
        {
            captured_imgbox.Image = _Template.SnapPicture(); //declare object matchtemplatecontroller so we can use it
        }

        private void startCaptureButton_Click(object sender, EventArgs e)
        {
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


        private void loadSource_Click(object sender, EventArgs e)
        {

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                sourceimg_textbox.Text = openFileDialog1.FileName;
            }
        }

        private void loadTemplate_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                template_textbox.Text = openFileDialog2.FileName;
            }
        }

        private void ReleaseData()
        {
            if (Camera_frame != null)
                Camera_frame.Dispose();
        }
    }
}
