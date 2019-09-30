using System;

namespace FlySimulator
{
    public class AeroMachine1
    {
        public int Speed { get; private set; }

        public int Angle { get; private set; }

        public int Height { get; private set; }

        public AeroMachine1(int angle, int height, int speed)
        {
            Angle = angle;
            Height = height;
            Speed = speed;
            Console.Write("\nSpeed {0}, Height {1}, Angle {2}.", Speed, Height, Angle);
        }

        public void TurnLeft()
        {
            Angle--;
            Console.Write("\nAngle {0}.", Angle);
        }

        public void TurnRight()
        {
            Angle++;
            Console.Write("\nAngle {0}.", Angle);
        }

        public void GoUp()
        {
            Height++;
            Console.Write("\nHeight {0}.", Height);
        }

        public void GoDown()
        {
            Height--;
            Console.Write("\nHeight {0}.", Height);
        }

        public void SpeedUp()
        {
            Speed++;
            Console.Write("\nSpeed {0}.", Speed);
        }

        public void SloDown()
        {
            Speed--;
            Console.Write("\nSpeed {0}.", Speed);
        }
    }
}