using System.Globalization;

namespace DataTypes.Numeric
{
    public class MoneyAndCultures
    {
        public static void Run()
        {
            Console.WriteLine("Running MoneyAndCultures...");
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
            decimal price = 1023.13M;

            Console.WriteLine($"{price:C}");
            Console.WriteLine(price.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

            // Custom Format
            Console.WriteLine(price.ToString("C2"));
            Console.WriteLine(price.ToString("N2"));

            int number = 123456;
            Console.WriteLine(number.ToString("##-##-##"));
            Console.WriteLine();
        }
    }
}