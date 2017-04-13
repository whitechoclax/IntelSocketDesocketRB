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

        //set the load order here for all tabs
        private void LoginMain_Load_1(object sender, EventArgs e)
        {
            LoadMainViewerTab();        //tabindex 0
            LoadArmControlTab();        //tabindex 1
            LoadSettingsTab();          //tabindex 2
        }

        //load tab pages here

        //Load main viewer tab
        private void LoadMainViewerTab()
        {
            TabPage page = new TabPage();
            page.Text = "Main Viewer";
            CameraFeed cam = new VishnuMain.CameraFeed();
            page.Controls.Add(cam);
            centralTab.TabPages.Add(page);
        }

        //load tab page for Arm handler controls
        private void LoadArmControlTab()
        {
            TabPage page = new TabPage();
            page.Text = "Manual Arm Control";
            ArmControl Arm = new VishnuMain.ArmControl();
            page.Controls.Add(Arm);
            centralTab.TabPages.Add(page);
        }

        //load settings tab
        private void LoadSettingsTab()
        {
            TabPage page = new TabPage();
            page.Text = "Settings";
            SettingsMenu Menu = new VishnuMain.SettingsMenu();
            page.Controls.Add(Menu);
            centralTab.TabPages.Add(page);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        
    }
}
