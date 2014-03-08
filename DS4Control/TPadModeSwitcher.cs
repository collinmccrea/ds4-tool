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
        private DS4Touchpad touchpad;
        int currentTypeInd = 0;
        public TPadModeSwitcher(DS4Touchpad tpad, int deviceID)
        {
            touchpad = tpad;
            modes.Add(new Mouse(deviceID));
            modes.Add(new CursorOnlyMode(deviceID));
        }

        public void setMode(int ind)
        {
            if (ind + 1 > modes.Count)
            {
                throw new Exception("The mode under this index doesn't exist");
            }
            ITouchpadBehaviour currentMode = modes.ElementAt(currentTypeInd);
            touchpad.TouchButtonDown -= currentMode.touchButtonDown;
            touchpad.TouchButtonUp -= currentMode.touchButtonUp;
            touchpad.TouchesBegan -= currentMode.touchesBegan;
            touchpad.TouchesMoved -= currentMode.touchesMoved;
            touchpad.TouchesEnded -= currentMode.touchesEnded;

            ITouchpadBehaviour tmode = modes.ElementAt(ind);
            touchpad.TouchButtonDown += tmode.touchButtonDown;
            touchpad.TouchButtonUp += tmode.touchButtonUp;
            touchpad.TouchesBegan += tmode.touchesBegan;
            touchpad.TouchesMoved += tmode.touchesMoved;
            touchpad.TouchesEnded += tmode.touchesEnded;
            currentTypeInd = ind;
        }

        public void goToNextMode()
        {
            
            //remove old mode listeners
            ITouchpadBehaviour currentMode = modes.ElementAt(currentTypeInd);
            touchpad.TouchButtonDown -= currentMode.touchButtonDown;
            touchpad.TouchButtonUp -= currentMode.touchButtonUp;
            touchpad.TouchesBegan -= currentMode.touchesBegan;
            touchpad.TouchesMoved -= currentMode.touchesMoved;
            touchpad.TouchesEnded -= currentMode.touchesEnded;

            if ((currentTypeInd + 1) == modes.Count)
            {
                currentTypeInd = -1;
            }
            //add new mode listeners

            ITouchpadBehaviour tmode = modes.ElementAt(currentTypeInd + 1);
            touchpad.TouchButtonDown += tmode.touchButtonDown;
            touchpad.TouchButtonUp += tmode.touchButtonUp;
            touchpad.TouchesBegan += tmode.touchesBegan;
            touchpad.TouchesMoved += tmode.touchesMoved;
            touchpad.TouchesEnded += tmode.touchesEnded;
            currentTypeInd++;
            Console.WriteLine(tmode.ToString());

        }
    }
}
