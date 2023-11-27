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
            Console.SetCursorPosition(x+1, y+1);
            Console.Write("<[x]>");
            Console.SetCursorPosition(x, y+2);
            Console.Write("± W W ±");

            PositionShip.Clear();

            PositionShip.Add(new Point (x+3,y));

            PositionShip.Add(new Point (x+1, y+1));
            PositionShip.Add(new Point (x+2, y+1));
            PositionShip.Add(new Point (x+3, y+1));
            PositionShip.Add(new Point (x+4, y+1));
            PositionShip.Add(new Point (x+5, y+1));

            PositionShip.Add(new Point (x, y+2));
            PositionShip.Add(new Point (x+2, y+2));
            PositionShip.Add(new Point (x+4, y+2));
            PositionShip.Add(new Point (x+6, y+2));
        }

        public void Delete()
        {
            foreach (Point item in PositionShip)
            {
                Console.SetCursorPosition (item.X, item.Y);
                Console.Write(' ');
            }
        }

        public void Keyboard(ref Point range, int speed )
        {
           ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.W || key.Key == ConsoleKey.UpArrow)
            {
                range = new Point(0, -1);
            }
            if (key.Key == ConsoleKey.S || key.Key == ConsoleKey.DownArrow) 
            { 
                range = new Point(0, 1); 
            }
            if (key.Key == ConsoleKey.D || key.Key == ConsoleKey.RightArrow)
            {
                range = new Point(1, 0);
            }
            if (key.Key == ConsoleKey.A || key.Key == ConsoleKey.LeftArrow)
            {
                range = new Point(-1, 0);
            }

            range.X *= speed;
            range.Y *= speed;

            Position = new Point(Position.X+range.X, Position.Y+range.Y);
        }

        public void MoveShip(int speed)
        {
            if (Console.KeyAvailable)
            {
                Delete();

                Point range = new Point();
                Keyboard(ref range, speed );

                Frame();
            }
        }
    }
}
