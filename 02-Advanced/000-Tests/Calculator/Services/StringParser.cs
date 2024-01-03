using System.Text.RegularExpressions;

namespace Calculator.Services
{
    public partial class StringParser
    {
        public int[] GetNumbersFromMathExpression(string expression)
        {
            MatchCollection matches = NumbersRegex().Matches(expression);
            IEnumerable<int> numbers = matches
                .Cast<Match>()
                .Select(match => int.Parse(match.Value));

            return numbers.ToArray();
        }

        [GeneratedRegex(@"-?\d+")]
        private static partial Regex NumbersRegex();
    }
}