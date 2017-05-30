using System;
using System.ComponentModel;
using System.Windows.Forms;
using Emgu.CV;

namespace VishnuMain
{
    public partial class CameraFeed : UserControl
    {
        #region Variables
        Capture _capture = null;
        #endregion


        public CameraFeed(Capture capture)
        {
            InitializeComponent();
            
            //grabs capture from parent, main function
            _capture = capture; 

            backWorker.WorkerReportsProgress = true;
            backWorker.WorkerSupportsCancellation = true;
            backWorker.DoWork += new DoWorkEventHandler(backWorker_DoWork);
            backWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backWorker_RunWorkerCompleted);
        }


        //private void RetrieveCaptureInformation()
        //{
        //    richTextBox1.Clear();
        //    richTextBox1.AppendText("Camera: " + WebCams[CameraDevice].Device_Name + " (-1 = Unknown)\n\n");

        //    //TODO: ALL These need sliders setting up on main form
        //    richTextBox1.AppendText("Convert RGB : " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.ConvertRgb).ToString() + "\n");
        //    richTextBox1.AppendText("Exposure control done by camera: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.AutoExposure).ToString() + "\n");
        //    richTextBox1.AppendText("Exposure: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Exposure).ToString() + "\n");
        //    richTextBox1.AppendText("Frame Height: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight).ToString() + "\n");
        //    richTextBox1.AppendText("Frame Width: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth).ToString() + "\n");
        //    richTextBox1.AppendText("Gain: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Gain).ToString() + "\n");
        //    richTextBox1.AppendText("Gamma: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Gamma).ToString() + "\n");
        //    richTextBox1.AppendText("Hue: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Hue).ToString() + "\n");
        //    richTextBox1.AppendText("Saturation: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Staturation).ToString() + "\n");
        //    richTextBox1.AppendText("Sharpness: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Sharpness).ToString() + "\n");
        //    richTextBox1.AppendText("Trigger: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Trigger).ToString() + "\n");
        //    richTextBox1.AppendText("Trigger Delay: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.TriggerDelay).ToString() + "\n");
        //    richTextBox1.AppendText("White balance blue u : " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.WhiteBalanceBlueU).ToString() + "\n");
        //    richTextBox1.AppendText("White balance red v : " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.WhiteBalanceRedV).ToString() + "\n");
        //    richTextBox1.AppendText("Max DC1394: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.MaxDC1394).ToString() + "\n");
        //    richTextBox1.AppendText("Current Capture Mode: " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Mode).ToString() + "\n");
        //    richTextBox1.AppendText("Monocrome : " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Monochrome).ToString() + "\n");
        //    richTextBox1.AppendText("Rectification : " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Rectification).ToString() + "\n");
        //    richTextBox1.AppendText("Preview (tricky property, returns cpnst char* indeed ): " + _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.SupportedPreviewSizesString).ToString() + "\n");
        //}


        private void Refresh_BTN_Click(object sender, EventArgs e)
        {
            //RetrieveCaptureInformation()
        }


        private void backWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            while (ArmHandlerLibrary.Running)
            { 
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                }

                else
                {
                    //peform our time consuming op
                    //IM A FOOOL TO DO YER DIRTY WORK
                    ArmHandlerLibrary.ArmHandlerLibraryMainSequence(_capture);
                }
            }
        }
       

        private void MainSequenceButton_Click(object sender, EventArgs e)
        {
            if (backWorker.IsBusy != true)
            {
                //start async op for our main handler library running var might be redundant
                if (ArmHandlerLibrary.Running == false)
                {
                    //stop the capture
                    MainSequenceButton.Text = "Stop Test"; //Change text on button
                    MainSequenceButton.BackColor = System.Drawing.Color.Red;
                    ArmHandlerLibrary.Running = true;
                    backWorker.RunWorkerAsync();
                    //Should be background worker
                }
            }
            else if (backWorker.IsBusy == true && backWorker.WorkerSupportsCancellation == true)
            {
                backWorker.CancelAsync();
                MainSequenceButton.Text = "Start Test Sequence"; //Change text on button
                MainSequenceButton.BackColor = System.Drawing.Color.Blue;
                ArmHandlerLibrary.Running = false;
            }
        }
       

        private void backWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                richTextBox1.AppendText("Operation was Cancelled");
            }

            else if (e.Error != null)
            {
                richTextBox1.AppendText("Error: " + e.Error.Message);
            }

            else
            {
                richTextBox1.AppendText("All trays completed.  Please unload and reconfigure settings to run another batch");
            }
        }


        //dummy placeholder to demonstrate use of settingslibrary
        private void showStats_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(SettingsLibrary.InvPathString + Environment.NewLine);
            richTextBox1.AppendText(SettingsLibrary.TrayCenter2CenterRow.ToString() + Environment.NewLine);
            richTextBox1.AppendText(SettingsLibrary.TrayOrigin2CenterY.ToString() + Environment.NewLine);
            richTextBox1.AppendText(SettingsLibrary.TrayStack.ToString() + Environment.NewLine);
            richTextBox1.AppendText(SettingsLibrary.TrayWidth.ToString() + Environment.NewLine);
            richTextBox1.AppendText(SettingsLibrary.TrayLength.ToString() + Environment.NewLine);

        }


        /*private void CameraFeedBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            e.Graphics.DrawLine(new Pen(Color.Red), 160, 240, 480, 240);
            e.Graphics.DrawLine(new Pen(Color.Red), 320, 120, 320, 360);
            e.Graphics.DrawEllipse(new Pen(Color.Red, 2), new RectangleF(280.0F, 200.0F, 80.0F, 80.0F));
            e.Dispose();
        }*/
    }
}
