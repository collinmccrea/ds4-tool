using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DS4Library;
namespace DS4Control
{
    class TPadModeSwitcher
    {
        List<ITouchpadBehaviour> modes = new List<ITouchpadBehaviour>();
        private Control controller;
        private DS4Touchpad touchpad;
        Int32 currentTypeInd = 0;
        public TPadModeSwitcher(Control control, DS4Touchpad tpad, int deviceID)
        {
            controller = control;
            touchpad = tpad;
            modes.Add(TouchpadDisabled.singleton);
            modes.Add(new Mouse(deviceID));
            modes.Add(new MouseCursorOnly(deviceID));
        }

        public void switchMode(int ind)
        {
            ITouchpadBehaviour currentMode = modes.ElementAt(currentTypeInd);
            touchpad.TouchButtonDown -= currentMode.touchButtonDown;
            touchpad.TouchButtonUp -= currentMode.touchButtonUp;
            touchpad.TouchesBegan -= currentMode.touchesBegan;
            touchpad.TouchesMoved -= currentMode.touchesMoved;
            touchpad.TouchesEnded -= currentMode.touchesEnded;
            setMode(ind);
        }
        
        public void setMode(int ind)
        {
            ITouchpadBehaviour tmode = modes.ElementAt(ind);
            touchpad.TouchButtonDown += tmode.touchButtonDown;
            touchpad.TouchButtonUp += tmode.touchButtonUp;
            touchpad.TouchesBegan += tmode.touchesBegan;
            touchpad.TouchesMoved += tmode.touchesMoved;
            touchpad.TouchesEnded += tmode.touchesEnded;
            currentTypeInd = ind;
            controller.LogDebug("Touchpad mode set to " + tmode.ToString());
        }

        public void previousMode()
        {
            int i = currentTypeInd - 1;
            if (i == -1)
                i = modes.Count - 1;
            switchMode(i);
        }

        public void nextMode()
        {
            int i = currentTypeInd + 1;
            if (i == modes.Count)
                i = 0;
            switchMode(i);
        }
    }
}
