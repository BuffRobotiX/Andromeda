using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.HAL;
using Sys = Cosmos.System.Kernel;

namespace Drivers
{
    public class MouseDriver
    {
        Mouse mouse;

        public MouseDriver()
        {
            mouse = new Mouse();
        }

        public void init(int width, int height)
        {
            mouse.Initialize((uint)width, (uint)height);
        }
        
        public int getX()
        {
            return mouse.X;
        }

        public int getY()
        {
            return mouse.Y;
        }

        public bool getLeftButton()
        {
            return mouse.Buttons == Mouse.MouseState.Left;
        }

        public bool getRightButton()
        {
            return mouse.Buttons == Mouse.MouseState.Right;
        }

        public bool getMiddleButton()
        {
            return mouse.Buttons == Mouse.MouseState.Middle;
        }
    }
}
