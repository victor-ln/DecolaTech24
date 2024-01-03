using Calculator.Services;

CalculatorImp calculator = new CalculatorImp();

int num1 = 10;
int num2 = 20;

Console.WriteLine($"{num1} + {num2} = {calculator.Sum(num1, num2)}");
