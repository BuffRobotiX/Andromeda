using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.HAL;

namespace Hardware
{
    public static class Desktop
    {
        public static string MenuText = "Desktop";
        public static Window[] windows = new Window[256];
        private static int winIndex = 0;
        public static Window dragging = null;
        public static int xOffset = 0;
        public static int yOffset = 0;

        public static Icon[] icons = new Icon[256];
        public static int iconIndex = 0;
        public static Pong pong;

        public static void Step()
        {
            //Display.DrawFilledRectangle(0, 0, 320, 11, 56);
            //FontDrawer.WriteText(MenuText, 25, 1, 0);

            for (int i = 0; i < iconIndex; i++)
            {
                if (Mouse.GetLeftButton())
                {
                    if (icons[i].MouseInside())
                        IconCallback(icons[i].text);
                }
                icons[i].Draw();
            }

            if (Mouse.GetLeftButton())
            {
                if (dragging != null)
                {
                    dragging.x = Mouse.GetX() + xOffset;
                    dragging.y = Mouse.GetY() + yOffset;
                }
            }
            else
                dragging = null;

            for (int i = 0; i < winIndex; i++)
            {
                Window win = windows[i];
                if (win != null)
                {
                    if (Mouse.GetLeftButton())
                    {
                        if (win.MouseInExit())
                        {
                            win = null;
                            windows[i] = null;
                        }
                        else if (win.MouseInTitle())
                        {
                            dragging = win;
                            xOffset = dragging.x - Mouse.GetX();
                            yOffset = dragging.y - Mouse.GetY();
                        }
                    }
                    if (win != null)
                        win.Draw();
                }
            }
        }

        public static void Add(Window win)
        {
            windows[winIndex] = win;
            winIndex++;
        }

        public static void Add(Icon icon)
        {
            icons[iconIndex] = icon;
            iconIndex++;
        }

        public static Window win2;
        public static void IconCallback(string text)
        {
            string date;
            string time;
            if (text == "Info")
            {
                date = "Month: " + RTC.Month.ToString() + " Day: " + RTC.DayOfTheMonth.ToString() + "\nYear: " + RTC.Year.ToString();
                time = RTC.Hour.ToString() + ":" + RTC.Minute.ToString() + ":" + RTC.Second.ToString();
                string str = "Andromeda OS 0.1\n" + date + "\n" + time;
                win2 = new Window(100, 50, 100, 50, "Info", str, 2);
                Add(win2);
            }
            else if (text == "Power")
            {
                Power.Reboot();
            }
            else if (text == "Pong")
            {
                pong = new Pong();
            }
        }
    }
}
