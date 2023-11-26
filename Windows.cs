using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Game_ship
{
    internal class Windows 
    {
        public int Width { get; set; }
        public int High { get; set; }

        public ConsoleColor Color { get; set; }

        public Point UpperLimit { get; set; }
        public Point LowerLimit { get; set; }



        public Windows(int width, int high, ConsoleColor color, Point upperLimit, Point lowerLimit)
        {
            Width = width;
            High = high;
            Color = color ;

            UpperLimit = upperLimit ;
            LowerLimit = lowerLimit ;  
            Init();
        }

        public void Init()
        {
            Console.SetWindowSize(Width, High);
            Console.SetBufferSize(Width, High);
            Console.Title = ("Ship");
            Console.CursorVisible = false;
            Console.BackgroundColor = Color;
            Console.Clear();
        }

        public void Frame()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = UpperLimit.X; i <= LowerLimit.X; i++ )
            {
                Console.SetCursorPosition(i, UpperLimit.Y);
                Console.Write("═");
                Console.SetCursorPosition(i, LowerLimit.Y);
                Console.Write("═");
            }

            for (int i = UpperLimit.Y; i <= LowerLimit.Y; i++)
            {
                Console.SetCursorPosition(UpperLimit.X, i);
                Console.Write("║");
                Console.SetCursorPosition(LowerLimit.X, i);
                Console.Write("║");
            }

            Console.SetCursorPosition(UpperLimit.X, UpperLimit.Y);
            Console.Write("╔");
            Console.SetCursorPosition(UpperLimit.X, LowerLimit.Y);
            Console.Write("╚");
            Console.SetCursorPosition(LowerLimit.X, UpperLimit.Y);
            Console.Write("╗");
            Console.SetCursorPosition(LowerLimit.X, LowerLimit.Y);
            Console.Write("╝");

            

        }
    }
}
