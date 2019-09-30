using System.Collections.Generic;
using Moq;
using Xunit;

namespace FlySimulator
{
    public class AeroMachineTests
    {
        private readonly Mock<IFlyingActionSink> _sinkMock;
        private readonly List<string> _sinkActions = new List<string>();

        public AeroMachineTests()
        {
            _sinkMock = new Mock<IFlyingActionSink>();
            _sinkMock
                .Setup(s => s.Write(It.IsAny<string>()))
                .Callback<string>(value => _sinkActions.Add(value));
        }

        [Fact]
        public void AlwaysEmitPrimaryStatus()
        {
            // Setup & Act
            new AeroMachine(0, 1, 2, _sinkMock.Object);

            // Assert
            Assert.Single(_sinkActions);
            Assert.Equal("Speed 2, Height 1, Angle 0.", _sinkActions[0]);
        }

        [Theory]
        [InlineData(1, 2, "Speed 2.")]
        public void ShouldIncreaseSpeed(
            int initialSpeed,
            int expectedValue,
            string expectedAction)
        {
            // Setup
            var sut = new AeroMachine(0, 0, initialSpeed, _sinkMock.Object);

            // Act
            sut.SpeedUp();

            // Assert
            Assert.Equal(2, _sinkActions.Count);
            Assert.Equal(expectedValue, sut.Speed);
            Assert.Equal(expectedAction, _sinkActions[1]);
        }
    }
}
