using Cosmos.HAL;
using Sys = Cosmos.System;
namespace Drivers
{
    public class DisplayDriver
    {

        protected VGAScreen screen;
        private int width, height;
        private byte[] buffer;
        private byte[] screenBuffer;

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
            there's 255 of them...
            */
            screen.Clear(0);
            width = screen.PixelWidth;
            height = screen.PixelHeight;

            buffer = new byte[width * height];
            screenBuffer = new byte[width * height];
        }

        public virtual void setPixel(int x, int y, int c)
        {
            buffer[y * width + x] = (byte)c;
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

        public void reDraw() //double buffer the screen
        {
            int c = 0;
            byte cl;
            byte dl;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //cl = (byte)screen.GetPixel320x200x8((uint)x, (uint)y);
                    cl = screenBuffer[c]; //reading from the screen is too damn slow, this buffer represents the pixels that are on the screen and reading the values out of it is wicked fast.
                    dl = buffer[c];
                    if (cl > dl || cl < dl) //there's a funny story behind this line, in release mode beq tries to pop the stack too many times and it fails to build if you use !=, but it works fine this way.
                    {
                        screen.SetPixel320x200x8((uint)x, (uint)y, buffer[c]);
                        screenBuffer[c] = buffer[c];
                    }
                    buffer[c] = 0;
                    c++;
                }
            }
        }

        public void drawFilledRectangle(int x0, int y0, int x1, int y1, int color)
        {
            for (int i = 0; i < x1 - x0; i++)
            {
                for (int h = 0; h < y1 - y0; h++)
                {
                    setPixel((x0 + i), (y0 + h), color);
                }
            }
        }
    }
}