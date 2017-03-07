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
        private Capture snap = null;
        Mat grayframe2 = new Mat();
        private bool snap_on;

        public TemplateMatchView()
        {
            InitializeComponent();
            try
            {
                snap = new Capture();
                snap.ImageGrabbed += Live; //live stream image cap
            }
            catch (NullReferenceException except)
            {
                MessageBox.Show(except.Message);
            }
        }

        private void Live(object sender, EventArgs arg)
        {
            Mat frame = new Mat();
            snap.Retrieve(frame, 0);
            imageBox4.Image = frame;
        }

        private void fileNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void takepicture_Click(object sender, EventArgs e)
        {
            SnapPicture(); //declare object matchtemplatecontroller so we can use it
        }

        private void startCaptureButton_Click(object sender, EventArgs e)
        {
                if (snap != null)
                {
                    if (snap_on)
                    {
                        startCaptureButton.Text = "Start Capture";
                        snap.Pause();
                    }
                    else
                    {
                        startCaptureButton.Text = "Stop";
                        snap.Start();
                    }
                    snap_on = !snap_on;
                }
            
        }
    }
}
