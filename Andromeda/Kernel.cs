using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Hardware;

namespace Andromeda
{
    public class Kernel : Sys.Kernel
    {
        public Driver driver;
        protected override void BeforeRun()
        {
            driver = new Driver();
            driver.BeforeRun();
        }

        protected override void Run()
        {
            driver.Run();
        }
    }
}
