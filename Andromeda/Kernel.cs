using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Drivers;

namespace Andromeda
{
    public class Kernel : Sys.Kernel
    {
        //instantiate drivers
        DisplayDriver display = new DisplayDriver();
        MouseDriver mouse = new MouseDriver();

        public void drawMouse()
        {
            int x = mouse.getX();
            int y = mouse.getY();
            int color = 1;

            //if you try to draw something outside the screen it crashes
            if (x >= 0 && x < display.getWidth() && y >= 0 && y < display.getHeight())
            {
                if (mouse.getLeftButton())
                    color = 4;
                else if (mouse.getRightButton())
                    color = 5;
                else if (mouse.getMiddleButton())
                    color = 6;

                display.setPixel(x, y, color);
                display.setPixel(x + 1, y, color);
                display.setPixel(x + 2, y, color);
                display.setPixel(x + 3, y, color);

                display.setPixel(x, y + 1, color);
                display.setPixel(x, y + 2, color);
                display.setPixel(x, y + 3, color);

                display.setPixel(x + 1, y + 1, color);
                display.setPixel(x + 2, y + 2, color);
                display.setPixel(x + 3, y + 3, color);
            }
        }

        public void drawBuff()
        {
            int c1 = 2, c2 = 3, c3 = 6, c4 = 9;

            //c1 = mouse.getX() / display.getWidth() * 255;
            //c1 = (int)((c1 + mouse.getX()) / (double)display.getWidth() * 255);
            //c2 = ((c2 + mouse.getY()) / display.getHeight() * 255);
            //c3 = ((c3 + mouse.getX()) / display.getWidth() * 255);
            //c4 = ((c4 + mouse.getY()) / display.getHeight() * 255);

            //B
            display.drawFilledRectangle(10, 10, 30, display.getHeight() - 10, c1);
            display.drawFilledRectangle(30, 10, 70, 30, c1);
            display.drawFilledRectangle(50, 30, 70, display.getHeight() - 10, c1);
            display.drawFilledRectangle(30, display.getHeight() - 30, 50, display.getHeight() - 10, c1);
            display.drawFilledRectangle(30, (display.getHeight() - 30) / 2, 50, (display.getHeight() - 30) / 2 + 20, c1);

            //u
            display.drawFilledRectangle(80, 10, 100, display.getHeight() - 10, c2);
            display.drawFilledRectangle(140, 10, 160, display.getHeight() - 10, c2);
            display.drawFilledRectangle(100, display.getHeight() - 30, 140, display.getHeight() - 10, c2);

            //f
            display.drawFilledRectangle(170, 10, 190, display.getHeight() - 10, c3);
            display.drawFilledRectangle(190, 10, 240, 30, c3);
            display.drawFilledRectangle(190, 50, 220, 70, c3);

            //f
            display.drawFilledRectangle(250, 10, 270, display.getHeight() - 10, c4);
            display.drawFilledRectangle(270, 10, 310, 30, c4);
            display.drawFilledRectangle(270, 50, 290, 70, c4);

        }

        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully.");
            //initialize
            display.init();
            mouse.init(display.getWidth(), display.getHeight());
        }

        protected override void Run()
        {
            //drawBuff(); //extremely slow function
            drawMouse();
            display.reDraw();
        }
    }
}
