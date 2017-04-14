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
        string xmlPathString;
        string invPathString;
        int trayLength;
        int trayWidth;
        int trayStack;

        //intertraydimensions
        //distance between chips (center to center)
        //distance top to bottom rows (center to center)
        //distance from origin to center of first cpu
        //tray height (10.2mm)

        public SettingsMenu()
        {
            InitializeComponent();
        }

        private void trayLengthValue_ValueChanged(object sender, EventArgs e)
        {
            trayLength = (int)trayLengthValue.Value;
        }

        private void trayWidthValue_ValueChanged(object sender, EventArgs e)
        {
            trayWidth = (int)trayWidthValue.Value;
        }

        private void trayStackValue_ValueChanged(object sender, EventArgs e)
        {
            trayStack = (int)trayStackValue.Value;
        }

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
            XDocument settingsmenu = XDocument.Load(xmlPathString + "\\settings.xml");

            //use NULL COALESCING with ?? to set default if not found
            var groupEl = from setting in settingsmenu.Nodes()
                    select setting;

            foreach(XElement setting in groupEl)
            {

                //UI variable to update = (type?) setting.element("xmlnodename" ?? default value
                trayLength = (int?)setting.Element("TrayLength") ?? 11;
                trayWidth = (int?)setting.Element("TrayWidth") ?? 2;
                trayStack = (int?)setting.Element("TrayHeight") ?? 10;
                invPathString = (string)setting.Element("inventoryPath") ?? string.Empty;
            }

            //update UI
            trayLengthValue.Value = trayLength;
            trayWidthValue.Value = trayWidth;
            trayStackValue.Value = trayStack;
            invPathTextBox.Text = invPathString;
        }

        


        public void savetoXML()
        {
            XDocument settings = new XDocument(
            //create new elements given element name, and the value.
            new XElement("Root",
                new XElement("TrayLength", trayLengthValue.Value.ToString()),
                new XElement("TrayWidth", trayWidthValue.Value.ToString()),
                new XElement("TrayHeight", trayStackValue.Value.ToString()),
                new XElement("inventoryPath", invPathString)
                )
            );

            //save to file
            settings.Save(xmlPathString+"\\settings.xml");
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
