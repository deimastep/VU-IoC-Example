using System.Collections.Generic;
using Xunit;

namespace FlySimulator
{
    public class AeroMachineTests2
    {
        [Fact]
        public void AlwaysEmitPrimaryStatus()
        {
            var sink = new TestFlyingActionSink();
            var sut = new AeroMachine2(0, 1, 2, sink);

            // Assert
            Assert.Equal(1, sink.Actions.Count);
            Assert.Equal("Speed 2, Height 1, Angle 0.", sink.Actions[0]);
        }

        [Theory]
        [InlineData(1, 2, "Speed 2.")]
        public void ShouldIncreaseSpeed(
            int initialSpeed,
            int expectedValue,
            string expectedAction)
        {
            var sink = new TestFlyingActionSink();
            var sut = new AeroMachine2(0, 0, initialSpeed, sink);

            // Act
            sut.SpeedUp();

            // Assert
            Assert.Equal(expectedValue, sut.Speed);
            Assert.Equal(expectedAction, sink.Actions[1]);
        }

        private class TestFlyingActionSink : IFlyingActionSink
        {
            private readonly List<string> _actions = new List<string>();

            public IReadOnlyList<string> Actions => _actions;

            public void Emit(string value)
            {
                _actions.Add(value);
            }
        }
    }
}
