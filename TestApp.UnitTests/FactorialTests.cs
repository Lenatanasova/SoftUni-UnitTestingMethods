using NUnit.Framework;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void Test_CalculateFactorial_InputZero_ReturnsOne()
    {
        // Arrange
        int input = 0;
        int expected = 1;

        // Act
        int result = Factorial.CalculateFactorial(input);


        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        // Arrange
        int input = 4;
        int expected = 24;

        // Act
        int result = Factorial.CalculateFactorial(input);

        // Assert
        Assert.AreEqual(expected, result);

    }
}
