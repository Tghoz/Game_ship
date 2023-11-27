using Game_ship;
using System.Drawing;
using System.Numerics;

Windows window;
Ship ship;

bool play = true;

void Start()
{
    window = new(170, 45, ConsoleColor.Black, new Point(5, 3), new Point(165, 43));
    window.Frame();

    ship = new Ship(new Point(80,30), ConsoleColor.White, window);
    ship.Frame();
}

void Game()
{
    while (play)
    {
        ship.MoveShip(2);
    }
}

Start();
Game();
Console.ReadKey();

