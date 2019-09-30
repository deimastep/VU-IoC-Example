using System;

namespace FlySimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPlease press direction key, +/- to change speed (q for exit).");

            // var flyer = new AeroMachine1(0, 0, 0);
            var flyer = new AeroMachine2(0, 0, 0, new ConsoleFlyingActionSink());

            while (true)
            {
                var keyInfo = Console.ReadKey(true);
                if (keyInfo.KeyChar == 'q' || keyInfo.KeyChar == 'Q')
                {
                    Console.WriteLine("\nEject...");
                    return;
                }
                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        flyer.TurnLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        flyer.TurnRight();
                        break;
                    case ConsoleKey.UpArrow:
                        flyer.GoUp();
                        break;
                    case ConsoleKey.DownArrow:
                        flyer.GoDown();
                        break;
                    case ConsoleKey.Oem4:
                        flyer.SpeedUp();
                        break;
                    case ConsoleKey.OemPlus:
                        flyer.SloDown();
                        break;
                }
            }
        }
    }
}
