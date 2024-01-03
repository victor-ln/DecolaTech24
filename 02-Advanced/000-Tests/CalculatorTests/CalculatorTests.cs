using Calculator.Services;

namespace CalculatorTests;

public class CalculatorTests
{
    private CalculatorImp _calc;

    public CalculatorTests()
    {
        _calc = new();
    }

    [Fact]
    public void ValidateSum_ShouldSum10And20AndReturn30()
    {
        // Arrange
        int num1 = 10;
        int num2 = 20;

        // Act
        int result = _calc.Sum(num1, num2);

        // Assert
        Assert.Equal(30, result);
    }

    [Theory]
    [InlineData(new int[] { 2, 4, 6, 8, 91615140 })]
    public void ValidateIsEven_ShouldReturnTrue(int[] numArray)
    {
        Assert.All(numArray, num => Assert.True(_calc.IsEven(num)));
    }
}