using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware
{
    public class Driver
    {
        Window window;
        Icon icon;
        public void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully.");
            //initialize
            Display.Init();
            Mouse.Init(Display.GetWidth(), Display.GetHeight());
            window = new Window(50, 50, 170, 30, "Welcome", "Welcome to the\nAndromeda Operating System.", 2);
            Desktop.Add(window);
            icon = new Icon("Info", 2, 10, 10);
            Desktop.Add(icon);
            icon = new Icon("Power", 2, 50, 10);
            Desktop.Add(icon);
            icon = new Icon("Pong", 2, 90, 10);
            Desktop.Add(icon);
        }

        public void Run()
        {
            Desktop.Step();
            Mouse.DrawMouse();
            Display.ReDraw();
        }
    }
}
