using Cosmos.HAL;
using Sys = Cosmos.System;
namespace Display
{
    public class DisplayDriver
    {

        protected VGAScreen screen;
        private int width, height;

        public DisplayDriver()
        {
            screen = new VGAScreen();
        }

        public void init()
        {
            screen.SetGraphicsMode(VGAScreen.ScreenSize.Size320x200, VGAScreen.ColorDepth.BitDepth8);
            /* Colors in 8 bit color depth
            0 is black
            1 is blue
            2 is green
            3 is turquoise
            4 is red
            5 is purpleish pink
            6 is dark yellow
            7 is gray
            8 is dark blue
            9 is bright blue
            */
            screen.Clear(1);
            width = screen.PixelWidth;
            height = screen.PixelHeight;
        }

        public virtual void setPixel(int x, int y, int c)
        {
            if (screen.GetPixel320x200x8((uint)x, (uint)y) != (uint)c)
                setPixelRaw(x, y, c);
        }

        public virtual byte getPixel(int x, int y)
        {
            return (byte)screen.GetPixel320x200x8((uint)x, (uint)y);
        }

        public virtual void clear()
        {
            clear(0);
        }

        public virtual void clear(int c)
        {
            screen.Clear(c);
        }

        public virtual void step() { }

        public int getWidth()
        {
            return width;
        }

        public int getHeight()
        {
            return height;
        }

        public void setPixelRaw(int x, int y, int c)
        {

            screen.SetPixel320x200x8((uint)x, (uint)y, (uint)c);

        }
    }
}