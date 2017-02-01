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
            //file is specific to mine.  change it if you wish.
            string fileName = @"C:\Users\Justin Morgan\Documents\CapstoneDevelopment\VishnuSocket\emgucv-windesktop 3.1.0.2504\bin\lena.jpg";
            Image<Bgr, byte> imf = new Image<Bgr, byte>(fileName);
            CvInvoke.Imshow("Image", imf);

            CvInvoke.WaitKey(0);
        }
    }
}
