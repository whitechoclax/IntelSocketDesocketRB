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

namespace VishnuMain
{
    public partial class LoginMain : Form
    {
        public LoginMain()
        {
            InitializeComponent();
            
          
           
        }
       

        private void armControlButton_Click(object sender, EventArgs e)
        {
            if (!centralPanel.Controls.Contains(ArmControl.Instance))
            {
                centralPanel.Controls.Add(ArmControl.Instance);
                ArmControl.Instance.Dock = DockStyle.Fill;
                ArmControl.Instance.BringToFront();

            }
            else
            {
                ArmControl.Instance.BringToFront();
            }
        }

        private void templateViewButton_Click(object sender, EventArgs e)
        {
            if (!centralPanel.Controls.Contains(TemplateMatchView.Instance))
            {
                centralPanel.Controls.Add(TemplateMatchView.Instance);
                TemplateMatchView.Instance.Dock = DockStyle.Fill;
                TemplateMatchView.Instance.BringToFront();

            }
            else
            {
                TemplateMatchView.Instance.BringToFront();
            }
        }

        private void userModeButton_Click(object sender, EventArgs e)
        {
            if (!centralPanel.Controls.Contains(CameraFeed.Instance))
            {
                centralPanel.Controls.Add(CameraFeed.Instance);
                CameraFeed.Instance.Dock = DockStyle.Fill;
                CameraFeed.Instance.BringToFront();
            }
            else
            {
                CameraFeed.Instance.BringToFront();
            }
        }
    }
}
