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
        private Control control;
        private DS4Device device;
        Int32 currentTypeInd = 0;
        public TPadModeSwitcher(Control control, DS4Device device, int deviceID)
        {
            this.control = control;
            this.device = device;
            modes.Add(TouchpadDisabled.singleton);
            modes.Add(new Mouse(deviceID));
            modes.Add(new ButtonMouse(deviceID));
            modes.Add(new MouseCursorOnly(deviceID));
        }

        public void switchMode(int ind)
        {
            ITouchpadBehaviour currentMode = modes.ElementAt(currentTypeInd);
            device.touchpad.TouchButtonDown -= currentMode.touchButtonDown;
            device.touchpad.TouchButtonUp -= currentMode.touchButtonUp;
            device.touchpad.TouchesBegan -= currentMode.touchesBegan;
            device.touchpad.TouchesMoved -= currentMode.touchesMoved;
            device.touchpad.TouchesEnded -= currentMode.touchesEnded;
            setMode(ind);
        }
        
        public void setMode(int ind)
        {
            ITouchpadBehaviour tmode = modes.ElementAt(ind);
            device.touchpad.TouchButtonDown += tmode.touchButtonDown;
            device.touchpad.TouchButtonUp += tmode.touchButtonUp;
            device.touchpad.TouchesBegan += tmode.touchesBegan;
            device.touchpad.TouchesMoved += tmode.touchesMoved;
            device.touchpad.TouchesEnded += tmode.touchesEnded;
            currentTypeInd = ind;
            control.LogDebug("Touchpad mode for " + device.MacAddress + " is now " + tmode.ToString());
        }

        public override string ToString()
        {
            return modes.ElementAt(currentTypeInd).ToString();
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
