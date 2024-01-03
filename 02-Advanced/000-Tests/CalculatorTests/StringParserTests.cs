using Calculator.Services;

namespace CalculatorTests
{
    public class StringParserTests
    {
        private readonly StringParser _stringParser = new();

        [Fact]
        public void ShouldRetriveAllNumbersFromExpressions()
        {
            string mathExpression = "2 + 4 + 6 + 8";

            int[] result = _stringParser.GetNumbersFromMathExpression(mathExpression);

            Assert.Equal([2, 4, 6, 8], result);
        }
    }
}