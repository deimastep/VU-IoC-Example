namespace FlySimulator
{
    public class AeroMachine
    {
        private readonly IFlyingActionSink _sink;

        public int Speed { get; private set; }

        public int Angle { get; private set; }

        public int Height { get; private set; }

        public AeroMachine(int angle, int height, int speed, IFlyingActionSink sink)
        {
            Angle = angle;
            Height = height;
            Speed = speed;
            _sink = sink;

            _sink.Write($"Speed {Speed}, Height {Height}, Angle {Angle}.");
        }

        public void TurnLeft()
        {
            Angle--;
            _sink.Write($"Angle {Angle}.");
        }

        public void TurnRight()
        {
            Angle++;
            _sink.Write($"Angle {Angle}.");
        }

        public void GoUp()
        {
            Height++;
            _sink.Write($"Height {Height}.");
        }

        public void GoDown()
        {
            Height--;
            _sink.Write($"Height {Height}.");
        }

        public void SpeedUp()
        {
            Speed++;
            _sink.Write($"Speed {Speed}.");
        }

        public void SloDown()
        {
            Speed--;
            _sink.Write($"Speed {Speed}.");
        }
    }
}