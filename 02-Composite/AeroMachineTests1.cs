using System.Collections.Generic;
using Xunit;

namespace FlySimulator
{
    public class AeroMachineTests1
    {
        [Fact]
        public void SetsStateAccordingly()
        {
            var sut = new AeroMachine1(0, 1, 2);

            // Assert
            Assert.Equal(0, sut.Angle);
            Assert.Equal(1, sut.Height);
            Assert.Equal(2, sut.Speed);
        }

        [Theory]
        [InlineData(1, 2)]
        public void ShouldIncreaseSpeed(int initialSpeed, int expectedValue)
        {
            var sut = new AeroMachine1(0, 0, initialSpeed);

            // Act
            sut.SpeedUp();

            // Assert
            Assert.Equal(expectedValue, sut.Speed);
        }
    }
}
