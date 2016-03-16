using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware
{
    public static class FontDrawer
    {
        public static void DrawTextChar(int x, int y, byte[] Data, int Color)
        {
            int c = 0;
            for (int p = y; p < y + 9; p++)
            {
                for (int i = x; i < x + 5; i++)
                {
                    if (Data[c] == 1)
                    {
                        Display.SetPixel(i, p, Color);
                    }

                    c = c + 1;
                }
            }
        }
        public static void DrawArray(int x, int y, byte[] Data, int Color, int w, int h)
        {
            int c = 0;
            for (int p = y; p < y + w; p++)
            {
                for (int i = x; i < x + h; i++)
                {
                    if (Data[c] == 1)
                    {
                        Display.SetPixel(i, p, Color);
                    }

                    c = c + 1;
                }
            }
        }

        public static void WriteText(string text, int Textx, int Texty, int Color)
        {
            int Startx = Textx;
            string[] lines = text.Split('\n');
            for(int i = 0; i < lines.Length; i++)
            {
                string Text = lines[i];
                for (int j = 0; j < Text.Length; j++)
                {
                    char a = Text[j];
                    if (a == 'A')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapA, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'a')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlA, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'B')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapB, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'b')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlB, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'C')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapC, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'c')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlC, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'D')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapD, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'd')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlD, Color);
                        Textx = Textx + 6;
                    }

                    else if (a == 'E')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapE, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'e')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlE, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'F')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapF, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'f')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlF, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'G')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapG, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'g')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlG, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'H')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapH, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'h')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlH, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'I')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapI, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'i')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlI, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'J')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapJ, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'j')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlJ, Color);
                        Textx = Textx + 6;
                    }

                    else if (a == 'K')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapK, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'k')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlK, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'L')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapL, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'l')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlL, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'M')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapM, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'm')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlM, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'N')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapN, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'n')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlN, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'O')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapO, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'o')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlO, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'P')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapP, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'p')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlP, Color);
                        Textx = Textx + 6;
                    }

                    else if (a == 'Q')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapQ, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'q')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlQ, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'R')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapR, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'r')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlR, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'S')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapS, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 's')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlS, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'T')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapT, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 't')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlT, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'U')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapU, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'u')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlU, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'V')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapV, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'v')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlV, Color);
                        Textx = Textx + 6;
                    }

                    else if (a == 'W')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapW, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'w')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlW, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'X')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapX, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'x')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlX, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'Y')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapY, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'y')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlY, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'Z')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapZ, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == 'z')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlZ, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == '.')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Dote, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == '!')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Utro, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == ' ')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Null, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == '0')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Zero, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == '1')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.One, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == '2')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Two, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == '3')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Three, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == '4')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Four, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == '5')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Five, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == '6')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Six, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == '7')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Seven, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == '8')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Eight, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == '9')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Nine, Color);
                        Textx = Textx + 6;
                    }
                    else if (a == ':')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Colon, Color);
                        Textx = Textx + 6;
                    }
                }
                Texty = Texty + 8;
                Textx = Startx;
            }
        }
    }

    public static class Font8x8
    {
        //5X9
        public static byte[] Dote = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] Utro = { 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] CapA = { 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] SmlA = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 1, 1, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] CapB = { 1, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] SmlB = { 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 1, 0, 1, 1, 0, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] CapC = { 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] SmlC = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] CapD = { 1, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] SmlD = { 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] CapE = { 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] SmlE = { 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] CapF = { 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] SmlF = { 0, 0, 0, 1, 1, 0, 0, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] CapG = { 0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] SmlG = { 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0 };

        public static byte[] CapH = { 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] SmlH = { 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 1, 0, 1, 1, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] CapI = { 1, 1, 1, 1, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] SmlI = { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] CapJ = { 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] SmlJ = { 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0 };

        public static byte[] CapK = { 1, 0, 0, 0, 1, 1, 0, 0, 1, 0, 1, 1, 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] SmlK = { 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] CapL = { 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] SmlL = { 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] CapM = { 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] SmlM = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 1, 0, 1, 0, 1, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] CapN = { 1, 0, 0, 0, 1, 1, 1, 0, 0, 1, 1, 0, 1, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] SmlN = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] CapO = { 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] SmlO = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] CapP = { 1, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] SmlP = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0 };

        public static byte[] CapQ = { 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0 };

        public static byte[] SmlQ = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1 };

        public static byte[] CapR = { 1, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] SmlR = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] CapS = { 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] SmlS = { 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] CapT = { 1, 1, 1, 1, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] SmlT = { 0, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] CapU = { 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] SmlU = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] CapV = { 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] SmlV = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] CapW = { 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 1, 0, 1, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] SmlW = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 1, 0, 1, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] CapX = { 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] SmlX = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] CapY = { 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] SmlY = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0 };

        public static byte[] CapZ = { 1, 1, 1, 1, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] SmlZ = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] Null = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] Zero = { 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 0, 1, 1, 1, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] One = { 0, 1, 1, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] Two = { 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] Three = { 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] Four = { 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] Five = { 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] Six = { 0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 1, 0, 1, 1, 0, 1, 1, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] Seven = { 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] Eight = { 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] Nine = { 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 1, 1, 0, 1, 1, 0, 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static byte[] Colon = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };



        //16x16
        public static byte[] Logo2 =
        {
            1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
            0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
            1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        };// 16 by 16 onhow om cla te maak

        public static byte[] Loading1of4 =
        {
           1, 0, 0, 0,
       };

        public static byte[] Loading2of4 =
        {
           0, 1, 0, 0,
       };

        public static byte[] Loading3of4 =
        {
           0, 0, 1, 0,
       };

        public static byte[] Loading4of4 =
        {
           0, 0, 0, 1,
       };
    }
}
