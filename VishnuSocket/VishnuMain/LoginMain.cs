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
       

        private void button1_Click(object sender, EventArgs e)
        {
            if (!centralPanel.Controls.Contains(CameraFeed.Instance))
            {
                centralPanel.Controls.Add(CameraFeed.Instance);
                CameraFeed.Instance.Dock = DockStyle.Fill;
                CameraFeed.Instance.BringToFront();
            }
            else
                CameraFeed.Instance.BringToFront();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
