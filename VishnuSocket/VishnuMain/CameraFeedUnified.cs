using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.CvEnum;

namespace VishnuMain
{
    public static class CameraFeedUnified
    {
        public static Capture camera_feed = null;


        /// <summary>
        /// Enables single camera feed and returns type Capture.
        /// </summary>
        /// <returns></returns>
        public static Capture EnableCameraFeed()
        {
            camera_feed = new Capture();
            camera_feed.SetCaptureProperty(CapProp.FrameHeight, 480);
            camera_feed.SetCaptureProperty(CapProp.FrameWidth, 640);

            return camera_feed;
        }

        /// <summary>
        /// Disables camera feed and returns null to type Capture
        /// </summary>
        /// <returns></returns>
        public static Capture DisableCameraFeed()
        {
            camera_feed.Dispose();
            return camera_feed = null;
        }

    }
}
