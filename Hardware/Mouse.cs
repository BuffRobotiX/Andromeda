using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.HAL;
using Sys = Cosmos.System.Kernel;

namespace Hardware
{
    public static class Mouse
    {
        public static Cosmos.HAL.Mouse mouse = new Cosmos.HAL.Mouse();

        public static void Init(int width, int height)
        {
            mouse.Initialize((uint)width, (uint)height);
        }
        
        public static int GetX()
        {
            return mouse.X;
        }

        public static int GetY()
        {
            return mouse.Y;
        }

        public static void DrawMouse()
        {
            int x = GetX();
            int y = GetY();
            int color = 1;

            //if you try to draw something outside the screen it crashes
            if (x >= 0 && x < Display.GetWidth() && y >= 0 && y < Display.GetHeight())
            {
                if (GetLeftButton())
                    color = 4;
                else if (GetRightButton())
                    color = 5;
                else if (GetMiddleButton())
                    color = 6;

                Display.SetPixel(x, y, color);
                Display.SetPixel(x + 1, y, color);
                Display.SetPixel(x + 2, y, color);
                Display.SetPixel(x + 3, y, color);

                Display.SetPixel(x, y + 1, color);
                Display.SetPixel(x, y + 2, color);
                Display.SetPixel(x, y + 3, color);

                Display.SetPixel(x + 1, y + 1, color);
                Display.SetPixel(x + 2, y + 2, color);
                Display.SetPixel(x + 3, y + 3, color);
            }
        }

        public static bool GetLeftButton()
        {
            return mouse.Buttons == Cosmos.HAL.Mouse.MouseState.Left;
        }

        public static bool GetRightButton()
        {
            return mouse.Buttons == Cosmos.HAL.Mouse.MouseState.Right;
        }

        public static bool GetMiddleButton()
        {
            return mouse.Buttons == Cosmos.HAL.Mouse.MouseState.Middle;
        }

        public static bool InRectangle(int x1, int y1, int x2, int y2)
        {
            return (GetX() > x1 && GetX() < x2) && (GetY() > y1 && GetY() < y2);
        }
    }
}
