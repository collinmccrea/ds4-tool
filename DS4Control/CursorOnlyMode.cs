using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using DS4Library;
namespace DS4Control
{
    public class CursorOnlyMode : ITouchpadBehaviour
    {
        private DateTime pastTime;
        private Touch firstTouch;
        private int deviceNum;
        private bool rightClick = false;
        public CursorOnlyMode(int deviceID)
        {
            deviceNum = deviceID;
        }


        public void touchesMoved(object sender, TouchpadEventArgs arg)
        {
            if (arg.touches.Length == 1)
            {
                double sensitivity = Global.getTouchSensitivity(deviceNum) / 100.0;
                int mouseDeltaX = (int)(sensitivity * (arg.touches[0].deltaX));
                int mouseDeltaY = (int)(sensitivity * (arg.touches[0].deltaY));
                InputMethods.MoveCursorBy(mouseDeltaX, mouseDeltaY);
            }
        }

        public void touchesBegan(object sender, TouchpadEventArgs arg) { }

        public void touchesEnded(object sender, TouchpadEventArgs arg) { }

        public void touchButtonUp(object sender, TouchpadEventArgs arg) { }

        public void touchButtonDown(object sender, TouchpadEventArgs arg) { }
    }
}
