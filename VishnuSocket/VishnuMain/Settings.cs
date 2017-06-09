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
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;

namespace VishnuMain
{
    public partial class SettingsMenu : UserControl
    {
        public string xmlfullpath;
        //To add a new varaible to the settings menu:  
        //add appropriate control.  stick with the camelcaseing naming convention here
        //   yourVariableName should suffice.

        //strings to save
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

        //socket dimensions
        int socketDimX;
        int socketDimY;
        int socketDimZ;

        //calibrated location saved
        double[] restLocationCoords = { 0, 0, 0, 0 };
        double[] socketLocationCoords = { 0, 0, 0, 0 };
        double[] originLocationCoords = { 0, 0, 0, 0 };

        //strings for location coords, not saved in settings library but used to update UI
        string restLocString;
        string socketLocString;
        string originLocString;

        //load menu
        public SettingsMenu()
        {
            InitializeComponent();
            loadFromXML();
            
        }

        //UI changes section
        //Step 2:  click on appropraite control to add event handler.  
        //UI variables (stuff only in UI) are named yourVariableNameValue.
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

        private void socketDimXValue_ValueChanged(object sender, EventArgs e)
        {
            socketDimX = (int)socketDimXValue.Value;
            SettingsLibrary.SocketDimX = socketDimX;
        }

        private void socketDimYValue_ValueChanged(object sender, EventArgs e)
        {
            socketDimY = (int)socketDimYValue.Value;
            SettingsLibrary.SocketDimY = socketDimY;
        }

        private void socketDimZValue_ValueChanged(object sender, EventArgs e)
        {
            socketDimZ = (int)socketDimZValue.Value;
            SettingsLibrary.SocketDimZ = socketDimZ;
        }

        private void invPathTextBox_TextChanged(object sender, EventArgs e)
        {
            //var assignment is handled in inventorysave click event handler
            SettingsLibrary.InvPathString = invPathString; 
        }

        private void restLocationBox_TextChanged(object sender, EventArgs e)
        {
            string[] splitrestBox = (restLocationBox.Text).Split(':');
            for (int i = 0; i < 4; i++)
            {
                restLocationCoords[i] = double.Parse(splitrestBox[i]);
                SettingsLibrary.RestLocationCoords[i] = double.Parse(splitrestBox[i]);
            }
        }

        private void socketLocationBox_TextChanged(object sender, EventArgs e)
        {
            string[] splitsocketBox = (socketLocationBox.Text).Split(':');
            for (int i = 0; i < 4; i++)
            {
                socketLocationCoords[i] = double.Parse(splitsocketBox[i]);
                SettingsLibrary.SocketLocationCoords[i] = double.Parse(splitsocketBox[i]);
            }
        }

        private void originLocationBox_TextChanged(object sender, EventArgs e)
        {
            string[] splitoriginBox = (originLocationBox.Text).Split(':');
            for (int i = 0; i < 4; i++)
            {
                originLocationCoords[i] = double.Parse(splitoriginBox[i]);
                SettingsLibrary.OriginLocationCoords[i] = double.Parse(splitoriginBox[i]);
            }
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

        public void loadFromXML()
        {
            xmlfullpath = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), @"Resources\settings.xml");
            XDocument settingsmenu = XDocument.Load(xmlfullpath);  // doesnt work on install
            
            //use NULL COALESCING with ?? to set default if not found
            var groupEl = from setting in settingsmenu.Nodes()
                    select setting;

            //step 3: add your new varaible to the XML load.  remember to put in default value with the ?? operator
            //
            foreach(XElement setting in groupEl)
            {
                //format:
                //UI variable to update = (type?) setting.element("xmlnodename" ?? default value
                trayLength = (int?)setting.Element("TrayLength") ?? 11;
                trayWidth = (int?)setting.Element("TrayWidth") ?? 2;
                trayStack = (int?)setting.Element("TrayStack") ?? 10;
                trayOrigin2CenterX = (double?)setting.Element("TrayOR2CenterX") ?? 15.5;
                trayOrigin2CenterY = (double?)setting.Element("TrayOR2CenterY") ?? 15.5;
                trayCenter2CenterRow = (double?)setting.Element("TrayCenter2CenterRow") ?? 25.5;
                trayCenter2CenterCol = (double?)setting.Element("TrayCenter2CenterCol") ?? 25.5;
                trayHeight = (double?)setting.Element("TrayHeight") ?? 12.00;
                socketDimX = (int?)setting.Element("SocketDimX") ?? 100;
                socketDimY = (int?)setting.Element("SocketDimY") ?? 100;
                socketDimZ = (int?)setting.Element("SocketDimZ") ?? 100;
                invPathString = (string)setting.Element("inventoryPath") ?? string.Empty;

                //so double arrays are really funky to save.  this is a very hacky way to save it.
                restLocString = (string)setting.Element("restLocation") ?? "-82:230:200:84";
                string[] restLocationCoordString = restLocString.Split(':');
                //populate array
                for (int i = 0; i < 4; i++)
                { restLocationCoords[i] = double.Parse(restLocationCoordString[i]); }
                
                socketLocString = (string)setting.Element("socketLocation") ?? "-82:170:200:84";
                string[] socketLocationCoordString = socketLocString.Split(':');
                //populate array
                for (int i = 0; i < 4; i++)
                { socketLocationCoords[i] = double.Parse(socketLocationCoordString[i]); }

                originLocString = (string)setting.Element("originLocation") ?? "-82:170:200:84";
                string[] originLocationCoordString = originLocString.Split(':');
                //populate array
                for (int i = 0; i < 4; i++)
                { originLocationCoords[i] = double.Parse(originLocationCoordString[i]); }
                
            }
            //step 4: update the UI.  it is yourVariableNameValue.value = yourVariableName
            //you may need to cast it to decimal.  

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

            //socket coords
            socketDimXValue.Value = (decimal)socketDimX;
            socketDimYValue.Value = (decimal)socketDimY;
            socketDimZValue.Value = (decimal)socketDimZ;

            invPathTextBox.Text = invPathString;
            //coordinate field save
            restLocationBox.Text = restLocString;
            socketLocationBox.Text = socketLocString;
            originLocationBox.Text = originLocString;
        }

        
        //step 5: save to xml update. Add the key , in our case the var name we want to add as a string, followed by 
        //the UI varaible *(the stuff saved in numeric boxes and buttons) as the contnet we are saving from user.
        //next step go to settingslibrary.cs to add the encapsulated fields.
        public void savetoXML()
        {
            XDocument settings = new XDocument(
            //create new elements given element name, and the value.
            new XElement("Root",
                new XElement("TrayLength", trayLengthValue.Value.ToString()),
                new XElement("TrayWidth", trayWidthValue.Value.ToString()),
                new XElement("TrayStack", trayStackValue.Value.ToString()),
                new XElement("TrayOR2CenterX", trayOr2CenterValueX.Value.ToString()),
                new XElement("TrayOR2CenterY", trayOr2CenterValueY.Value.ToString()),
                new XElement("TrayCenter2CenterRow", trayCenter2CenterValueRow.Value.ToString()),
                new XElement("TrayCenter2CenterCol", trayCenter2CenterValueCol.Value.ToString()),
                new XElement("TrayHeight", trayHeightValue.Value.ToString()),
                new XElement("SocketDimX", socketDimXValue.Value.ToString()),
                new XElement("SocketDimY", socketDimYValue.Value.ToString()),
                new XElement("SocketDimZ", socketDimZValue.Value.ToString()),
                new XElement("inventoryPath", invPathString),
                new XElement("restLocation", restLocString),
                new XElement("socketLocation", socketLocString),
                new XElement("originLocation", originLocString)
                           

                )
            );

            //save to file
            settings.Save(xmlfullpath);  // doesnt work on install
            //settings.Save(xmlPathString + "\\settings.xml");  // load after setting path
            return;
        }


        private string JoinString(double[] ArrayToCombine)
        {
            string[] joiner = { "0", "0", "0", "0"};                         //declare NULL in scope array of strings
            for (int i = 0; i < 4; i++)
            {
                joiner[i] = ArrayToCombine[i].ToString();   //iterate through each index and convert to string.
            }
            string TextBoxOut = String.Join(":", joiner);   //join via : delimiters
            return TextBoxOut;                              //return to updateUI 
        }
        private void xmlSaveButton_Click(object sender, EventArgs e)
        {
            savetoXML();
        }

        private void loadxmlButton_Click(object sender, EventArgs e)
        {
            loadFromXML();
        }


        private void updateExternalButton_Click(object sender, EventArgs e)
        {
            restLocationBox.Text = JoinString(SettingsLibrary.RestLocationCoords);
            restLocString = restLocationBox.Text;
            socketLocationBox.Text = JoinString(SettingsLibrary.SocketLocationCoords);
            socketLocString = socketLocationBox.Text;
            originLocationBox.Text = JoinString(SettingsLibrary.OriginLocationCoords);
            originLocString = originLocationBox.Text;
        }
    }
}
