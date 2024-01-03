namespace Calculator.Services
{
    public class CalculatorImp
    {
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public bool IsEven(int num)
        {
            return num % 2 == 0;
        }
    }
}