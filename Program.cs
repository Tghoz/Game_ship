using Game_ship;
using System.Drawing;



Windows window;
Ship ship;

void Start()
{
    window = new(170, 45, ConsoleColor.Black, new Point(5, 3), new Point(165, 43));
    window.Frame();

    ship = new Ship(new Point(80,30), ConsoleColor.White, window);
    ship.Frame();
}

Start();

Console.ReadKey();

