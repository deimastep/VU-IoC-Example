namespace FlySimulator
{
    public class AeroMachine2
    {
        private readonly IFlyingActionSink _sink;

        public int Speed { get; private set; }

        public int Angle { get; private set; }

        public int Height { get; private set; }

        public AeroMachine2(int angle, int height, int speed, IFlyingActionSink sink)
        {
            Angle = angle;
            Height = height;
            Speed = speed;
            _sink = sink;

            _sink.Emit($"Speed {Speed}, Height {Height}, Angle {Angle}.");
        }

        public void TurnLeft()
        {
            Angle--;
            _sink.Emit($"Angle {Angle}.");
        }

        public void TurnRight()
        {
            Angle++;
            _sink.Emit($"Angle {Angle}.");
        }

        public void GoUp()
        {
            Height++;
            _sink.Emit($"Height {Height}.");
        }

        public void GoDown()
        {
            Height--;
            _sink.Emit($"Height {Height}.");
        }

        public void SpeedUp()
        {
            Speed++;
            _sink.Emit($"Speed {Speed}.");
        }

        public void SloDown()
        {
            Speed--;
            _sink.Emit($"Speed {Speed}.");
        }
    }
}