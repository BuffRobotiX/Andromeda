using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware
{
    public class Window
    {
        public static byte themeColor = 6;

        public int x;
        public int y;
        public int w;
        public int h;
        public string title;
        public string content;
        public byte color;

        public Window(int x, int y, int w, int h, string title, string content, byte color)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            this.title = title;
            this.content = content;
            this.color = color;
        }

        public void Draw()
        {
            Display.DrawFilledRectangle(x, y, x + w - 10, y + 10, themeColor);
            Display.DrawFilledRectangle(x + w - 10, y, x + w, y + 10, 4);
            Display.DrawFilledRectangle(x, y + 10, x + w, y + h, color);
            FontDrawer.WriteText(title, x + 2, y, 0);
            FontDrawer.WriteText(content, x + 2, y + 10, 0);
        }

        public bool MouseInExit()
        {
            return Mouse.InRectangle(x + w - 10, y, x + w, y + 10);
        }

        public bool MouseInTitle()
        {
            return Mouse.InRectangle(x, y, x + w - 10, y + 10);
        }
    }
}
