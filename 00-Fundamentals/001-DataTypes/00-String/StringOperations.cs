namespace DataTypes.String
{
    public class StringOperations
    {
        public static void Run()
        {
            Console.WriteLine("Running StringOperations...");
            string str1 = "Hello";
            string str2 = "World";

            /* Concat with plus operator */
            Console.WriteLine(str1 + " " + str2);
            /* Concat with string.Concat() method */
            Console.WriteLine(string.Concat(str1, " ", str2));
            /* Concat with string interpolation */
            Console.WriteLine($"{str1} {str2}");

            string fullName = string.Join(" ", ["Victor", "Nunes"]);
            Console.WriteLine(fullName);

            string substring = fullName[..4];
            Console.WriteLine(substring);

            string upperCase = fullName.ToUpper();
            Console.WriteLine(upperCase);

            string lowerCase = fullName.ToLower();
            Console.WriteLine(lowerCase);
            Console.WriteLine();
        }
    }
}