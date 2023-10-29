using Microsoft.Extensions.Logging;
using Moq;

namespace TDDApproach.Test
{
    public class CaclulatorTests
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            // Arrange
            var logger = new Mock<ILogger<Calculator>>();
            var calculator = new Calculator(logger.Object);

            // Act
            var result = calculator.Add(3, 5);

            // Assert
            Assert.Equal(8, result);
        }
    }
}