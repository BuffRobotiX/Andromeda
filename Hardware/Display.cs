using Cosmos.HAL;
using Sys = Cosmos.System;
namespace Hardware
{
    public class Display
    {
        protected static VGAScreen screen = new VGAScreen();
        private static int width, height;
        private static byte[] buffer;
        private static byte[] screenBuffer;

        public static void Init()
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
            there's 256 of them...
            */
            screen.Clear(0);
            width = screen.PixelWidth;
            height = screen.PixelHeight;

            buffer = new byte[width * height];
            screenBuffer = new byte[width * height];
        }

        public static void SetPixel(int x, int y, int c)
        {
            buffer[y * width + x] = (byte)c;
        }

        public static byte GetPixel(int x, int y)
        {
            return (byte)screen.GetPixel320x200x8((uint)x, (uint)y);
        }

        public static void Clear()
        {
            Clear(0);
        }

        public static void Clear(int c)
        {
            screen.Clear(c);
        }

        public static int GetWidth()
        {
            return width;
        }

        public static int GetHeight()
        {
            return height;
        }

        public static void SetPixelRaw(int x, int y, int c)
        {
            screen.SetPixel320x200x8((uint)x, (uint)y, (uint)c);

        }

        public static void ReDraw() //double buffer the screen
        {
            int c = 0;
            byte cl;
            byte dl;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
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

        public static void DrawFilledRectangle(int x0, int y0, int x1, int y1, int color)
        {
            for (int i = 0; i < x1 - x0; i++)
            {
                for (int h = 0; h < y1 - y0; h++)
                {
                    SetPixel((x0 + i), (y0 + h), color);
                }
            }
        }
    }
}