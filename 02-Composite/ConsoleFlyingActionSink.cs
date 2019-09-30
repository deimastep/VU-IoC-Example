using System;

namespace FlySimulator
{
    public class ConsoleFlyingActionSink : IFlyingActionSink
    {
        public void Emit(string value)
        {
            Console.Write("\n{0}", value);
        }
    }
}