using System;
using Microsoft.Extensions.DependencyInjection;

namespace FlySimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IFlyingActionSink, ConsoleFlyingActionSink>()
                .AddTransient(sp => new AeroMachine(0, 0, 0, sp.GetRequiredService<IFlyingActionSink>()))
                .BuildServiceProvider();

            using (serviceProvider) {
                var flyer = serviceProvider.GetRequiredService<AeroMachine>();
                KeyboardController(flyer);
            }
        }

        private static void KeyboardController(AeroMachine flyer)
        {
            Console.WriteLine("\nPlease press direction key, +/- to change speed (q for exit).");
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
