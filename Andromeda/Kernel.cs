using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Display;

namespace Andromeda
{
    public class Kernel : Sys.Kernel
    {
        DisplayDriver display;

        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully.");
        }

        protected override void Run()
        {
            display = new DisplayDriver();
            display.init();
        }
    }
}
