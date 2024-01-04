namespace Collections.Models
{
    class ListExample
    {
        public static void Run()
        {
            List<int> numbersList = new List<int>();

            numbersList.Add(10);
            numbersList.Add(20);
            numbersList.Add(30);
            numbersList.Add(40);

            Console.WriteLine("List elements:");

            foreach (int number in numbersList)
            {
                Console.WriteLine(number);
            }

            numbersList.Insert(1, 15);

            Console.WriteLine("\nList after inserting an element:");

            foreach (int number in numbersList)
            {
                Console.WriteLine(number);
            }

            numbersList.Remove(30);

            Console.WriteLine("\nList after removing an element:");

            foreach (int number in numbersList)
            {
                Console.WriteLine(number);
            }

            int searchNumber = 20;
            if (numbersList.Contains(searchNumber))
            {
                Console.WriteLine($"\nThe list contains the number {searchNumber}");
            }
            else
            {
                Console.WriteLine($"\nThe list does not contain the number {searchNumber}");
            }
        }
    }
}
