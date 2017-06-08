using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VishnuMain
{
    //to add a new paramter/ field to the settings xml file:
    //step 1: add variable here as a static type.  preface with an _ symbol
    //so it appeears as _yourVariableName
    //Step 2: encapsulate it, should now appear as YourVariableName
    public static class SettingsLibrary
    {
        //inter tray dimensions
        static double _trayOrigin2CenterX;
        static double _trayOrigin2CenterY;
        static double _trayCenter2CenterRow;
        static double _trayCenter2CenterCol;
        //basic tray allotment properties
        static double _trayHeight;
        static int _trayLength;
        static int _trayWidth;
        static int _trayStack;
        //socket properties
        static int _socketDimX;
        static int _socketDimY;
        static int _socketDimZ;

        static string _invPathString;
        //you MUST initialize a static array or else it will be null.
        static double[] _restLocationCoords = { 0, 0, 0, 0 };
        static double[] _socketLocationCoords = { 0, 0, 0, 0 };
        static double[] _originLocationCoords = { 0, 0, 0, 0};

        //encapsulated stubs begin here, from step 2 instructions.
        public static double TrayOrigin2CenterX { get { return _trayOrigin2CenterX; } set { _trayOrigin2CenterX = value; } }
        public static double TrayOrigin2CenterY { get { return _trayOrigin2CenterY; } set { _trayOrigin2CenterY = value; } }
        public static double TrayCenter2CenterRow { get { return _trayCenter2CenterRow; } set { _trayCenter2CenterRow = value; } }
        public static double TrayCenter2CenterCol { get { return _trayCenter2CenterCol; } set { _trayCenter2CenterCol = value; } }

        public static double TrayHeight { get { return _trayHeight; } set { _trayHeight = value; } }
        public static int TrayLength { get { return _trayLength; } set { _trayLength = value; } }
        public static int TrayWidth { get { return _trayWidth; } set { _trayWidth = value; } }
        public static int TrayStack { get { return _trayStack; } set { _trayStack = value; } }

        public static int SocketDimX { get { return _socketDimX; } set { _socketDimX = value; } }
        public static int SocketDimY { get { return _socketDimY; } set { _socketDimY = value; } }
        public static int SocketDimZ { get { return _socketDimZ; } set { _socketDimZ = value; } }

        public static string InvPathString { get { return _invPathString; } set { _invPathString = value; } }

        public static double[] RestLocationCoords { get { return _restLocationCoords; } set { _restLocationCoords = value; } }
        public static double[] SocketLocationCoords { get { return _socketLocationCoords; } set { _socketLocationCoords = value; } }
        public static double[] OriginLocationCoords { get { return _originLocationCoords; } set { _originLocationCoords = value; } }
    }
}
