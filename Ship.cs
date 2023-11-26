using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_ship
{
    internal class Ship
    {
        private Windows window;

        public float Life { get; set; }
        public Point Position { get; set; }
        public ConsoleColor Color { get; set; }
        public Windows WindowsC { get; set; }
        public List<Point> PositionShip {  get; set; }



        public Ship( Point position, ConsoleColor color, Windows windows) 
        {
            Position = position;
            Color = color;
            WindowsC = windows;
            Life = 100;
            PositionShip = new List<Point>();
        }

        public Ship(Windows window)
        {
            this.window = window;
        }

        public void Frame() 
        {
            int x = Position.X; 
            int y = Position.Y;

            Console.ForegroundColor = Color;


            Console.SetCursorPosition(x+3, y);
            Console.Write("A");
            Console.SetCursorPosition(x + 1, y + 1);
            Console.Write("<[x]>");
            Console.SetCursorPosition(x, y+2);
            Console.Write("± W W ±");
           

       

        }


    }
}
