namespace Collections.Models
{
    class StackExample
    {
        public static void Run()
        {
            Stack<int> stack = new();

            for (int number = 0; number < 10; number += 2) {
                stack.Push(number);
            }

            foreach (int number in stack) {
                Console.WriteLine(number);
            }

            Console.WriteLine($"Removing the element at the top: {stack.Pop()}");

            stack.Push(20);

            foreach (int number in stack) {
                Console.WriteLine(number);
            }
        }
    }
}