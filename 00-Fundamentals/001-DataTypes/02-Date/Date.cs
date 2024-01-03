using System.Globalization;

namespace DataTypes.Date
{
    public class Date
    {
        public static void Run()
        {
            Console.WriteLine("Running Date...");
            DateTime date = DateTime.Now;

            Console.WriteLine(date.ToString("dd/MM/yyyy HH:mm"));
            Console.WriteLine(date.ToShortDateString());
            Console.WriteLine(date.ToShortTimeString());

            date = DateTime.Parse("27/12/2023 18:00");
            Console.WriteLine(date);

            string dateString = "27/12/2023 18:00";

            DateTime.TryParseExact(
                dateString,
                "dd/MM/yyyy HH:mm",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime parsedDate
            );
            Console.WriteLine(parsedDate);
            Console.WriteLine();
        }
    }
}