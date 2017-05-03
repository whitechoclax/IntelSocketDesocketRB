using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VishnuMain
{
    public partial class SettingsMenu : UserControl
    {
        //strings to save
        string xmlPathString;
        string invPathString;

        //tray properties for different sizes
        int trayLength;
        int trayWidth;
        int trayStack;

        //intertraydimensions
        double trayOrigin2CenterX;
        double trayOrigin2CenterY;
        double trayCenter2CenterRow;
        double trayCenter2CenterCol;
        double trayHeight;

        public SettingsMenu()
        {
            InitializeComponent();
            loadFromXML();
        }

        //UI changes section
        private void trayLengthValue_ValueChanged(object sender, EventArgs e)
        {
            trayLength = (int)trayLengthValue.Value;
            SettingsLibrary.TrayLength = trayLength;
        }

        private void trayWidthValue_ValueChanged(object sender, EventArgs e)
        {
            trayWidth = (int)trayWidthValue.Value;
            SettingsLibrary.TrayWidth = trayWidth;
        }

        private void trayStackValue_ValueChanged(object sender, EventArgs e)
        {
            trayStack = (int)trayStackValue.Value;
            SettingsLibrary.TrayStack = trayStack;
        }

        private void trayOr2CenterValue_ValueChanged(object sender, EventArgs e)
        {
            trayOrigin2CenterX = (double)trayOr2CenterValueX.Value;
            SettingsLibrary.TrayOrigin2CenterX = trayOrigin2CenterX;
        }

        private void trayCenter2CenterValue_ValueChanged(object sender, EventArgs e)
        {
            trayCenter2CenterRow = (double)trayCenter2CenterValueRow.Value;
            SettingsLibrary.TrayCenter2CenterRow = trayCenter2CenterRow;
        }

        private void trayHeightValue_ValueChanged(object sender, EventArgs e)
        {
            trayHeight = (double)trayHeightValue.Value;
            SettingsLibrary.TrayHeight = trayHeight;
        }
        private void trayCenter2CenterValueCol_ValueChanged(object sender, EventArgs e)
        {
            trayCenter2CenterCol = (double)trayCenter2CenterValueCol.Value;
            SettingsLibrary.TrayCenter2CenterCol = trayCenter2CenterCol;
        }

        private void trayOr2CenterValueY_ValueChanged(object sender, EventArgs e)
        {
            trayOrigin2CenterY = (double)trayOr2CenterValueY.Value;
            SettingsLibrary.TrayOrigin2CenterY = trayOrigin2CenterY;
        }

        private void invPathTextBox_TextChanged(object sender, EventArgs e)
        {
            //var assignment is handled in inventorysave click event handler
            SettingsLibrary.InvPathString = invPathString; 
        }

        //load button handler
        private void inventorySaveFileButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.ShowNewFolderButton = true;
            
            DialogResult result = folderDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                //assign path to textbox and save as string
                invPathTextBox.Text = folderDialog.SelectedPath;
                invPathString = invPathTextBox.Text;
                Environment.SpecialFolder root = folderDialog.RootFolder;
            }
        }

        //save button handler
        private void xmlSaveFileButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog_xml = new FolderBrowserDialog();
            folderDialog_xml.ShowNewFolderButton = true;
            DialogResult result = folderDialog_xml.ShowDialog();
            if (result == DialogResult.OK)
            {
                //assign path to textbox and save as string
                xmlPathTextBox.Text = folderDialog_xml.SelectedPath;
                xmlPathString = xmlPathTextBox.Text;
                Environment.SpecialFolder root = folderDialog_xml.RootFolder;
            }
        }

        public void loadFromXML()
        {
            XDocument settingsmenu = XDocument.Load("..\\..\\..\\..\\Common\\Settings\\settings.xml");

            //use NULL COALESCING with ?? to set default if not found
            var groupEl = from setting in settingsmenu.Nodes()
                    select setting;

            foreach(XElement setting in groupEl)
            {

                //UI variable to update = (type?) setting.element("xmlnodename" ?? default value
                trayLength = (int?)setting.Element("TrayLength") ?? 11;
                trayWidth = (int?)setting.Element("TrayWidth") ?? 2;
                trayStack = (int?)setting.Element("TrayStack") ?? 10;
                trayOrigin2CenterX = (double?)setting.Element("TrayOR2CenterX") ?? 15.5;
                trayOrigin2CenterY = (double?)setting.Element("TrayOR2CenterY") ?? 15.5;
                trayCenter2CenterRow = (double?)setting.Element("TrayCenter2CenterRow") ?? 25.5;
                trayCenter2CenterCol = (double?)setting.Element("TrayCenter2CenterCol") ?? 25.5;
                trayHeight = (double?)setting.Element("TrayHeight") ?? 12.00;
                invPathString = (string)setting.Element("inventoryPath") ?? string.Empty;
                //Need to add origin to tray location and for socket location (XYZ)
            }

            //update UI
            trayLengthValue.Value = trayLength;
            trayWidthValue.Value = trayWidth;
            trayStackValue.Value = trayStack;

            //tray dimensions
            trayHeightValue.Value = (decimal)trayHeight;
            trayCenter2CenterValueRow.Value = (decimal)trayCenter2CenterRow;
            trayCenter2CenterValueCol.Value = (decimal)trayCenter2CenterCol;
            trayOr2CenterValueX.Value = (decimal)trayOrigin2CenterX;
            trayOr2CenterValueY.Value = (decimal)trayOrigin2CenterY;
            invPathTextBox.Text = invPathString;
        }

        


        public void savetoXML()
        {
            XDocument settings = new XDocument(
            //create new elements given element name, and the value.
            new XElement("Root",
                new XElement("TrayLength", trayLengthValue.Value.ToString()),
                new XElement("TrayWidth", trayWidthValue.Value.ToString()),
                new XElement("TrayStack", trayStackValue.Value.ToString()),
                new XElement("inventoryPath", invPathString),
                new XElement("TrayOR2CenterX", trayOr2CenterValueX.Value.ToString()),
                new XElement("TrayOR2CenterY", trayOr2CenterValueY.Value.ToString()),
                new XElement("TrayCenter2CenterRow", trayCenter2CenterValueRow.Value.ToString()),
                new XElement("TrayCenter2CenterCol", trayCenter2CenterValueCol.Value.ToString()),
                new XElement("TrayHeight", trayHeightValue.Value.ToString())

                )
            );

            //save to file
            settings.Save("..\\..\\..\\..\\Common\\Settings\\settings.xml");
            return;
        }

        private void xmlSaveButton_Click(object sender, EventArgs e)
        {
            savetoXML();

        }

        private void loadxmlButton_Click(object sender, EventArgs e)
        {
            loadFromXML();
        }
    }
}
