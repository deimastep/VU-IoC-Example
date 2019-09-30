using System;

namespace FlySimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int speed = 0, angle = 0, height = 0;
            Console.WriteLine("\nPlease press direction key, +/- to change speed (q for exit).");
            Console.Write("\nSpeed {0}, Height {1}, Angle {2}.", speed, height, angle);
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
                        angle--;
                        Console.Write("\nAngle {0}.", angle);
                        break;
                    case ConsoleKey.RightArrow:
                        angle++;
                        Console.Write("\nAngle {0}.", angle);
                        break;
                    case ConsoleKey.UpArrow:
                        height++;
                        Console.Write("\nHeight {0}.", height);
                        break;
                    case ConsoleKey.DownArrow:
                        height--;
                        Console.Write("\nHeight {0}.", height);
                        break;
                    case ConsoleKey.Oem4:
                        speed++;
                        Console.Write("\nSpeed {0}.", speed);
                        break;
                    case ConsoleKey.OemPlus:
                        speed--;
                        Console.Write("\nSpeed {0}.", speed);
                        break;
                }
            }
        }
    }
}
