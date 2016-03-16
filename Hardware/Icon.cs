using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware
{
    public class Icon
    {
        public string text;
        public byte color;
        public int x;
        public int y;

        private static int size = 30;

        public Icon(string text, byte color, int x, int y)
        {
            this.text = text;
            this.color = color;
            this.x = x;
            this.y = y;
        }

        public void Draw()
        {
            Display.DrawFilledRectangle(x, y, x + size, y + size, color);
            FontDrawer.WriteText(text, x + 2, y + 10, 0);
        }

        public bool MouseInside()
        {
            return Mouse.InRectangle(x, y, x + size, y + size);
        }
    }
}
