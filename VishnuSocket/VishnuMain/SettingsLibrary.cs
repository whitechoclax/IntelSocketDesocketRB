using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VishnuMain
{
    public static class SettingsLibrary
    {
        static double _trayOrigin2Center;
        static double _trayCenter2Center;
        static double _trayHeight;

        static int _trayLength;
        static int _trayWidth;
        static int _trayStack;

        static string _invPathString;

        public static double TrayOrigin2Center
        {
            get
            {
                return _trayOrigin2Center;
            }

            set
            {
                _trayOrigin2Center = value;
            }
        }

        public static double TrayCenter2Center
        {
            get
            {
                return _trayCenter2Center;
            }

            set
            {
                _trayCenter2Center = value;
            }
        }

        public static double TrayHeight
        {
            get
            {
                return _trayHeight;
            }

            set
            {
                _trayHeight = value;
            }
        }

        public static int TrayLength
        {
            get
            {
                return _trayLength;
            }

            set
            {
                _trayLength = value;
            }
        }

        public static int TrayWidth
        {
            get
            {
                return _trayWidth;
            }

            set
            {
                _trayWidth = value;
            }
        }

        public static int TrayStack
        {
            get
            {
                return _trayStack;
            }

            set
            {
                _trayStack = value;
            }
        }

        public static string InvPathString
        {
            get
            {
                return _invPathString;
            }

            set
            {
                _invPathString = value;
            }
        }
    }
}
