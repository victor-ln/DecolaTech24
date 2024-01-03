namespace Collections.Models
{
    class QueueExample
    {
        public static void Run()
        {
            Queue<int> queue = new();

            for (int number = 0; number < 10; number += 2) {
                queue.Enqueue(number);
            }

            foreach (int number in queue) {
                Console.WriteLine(number);
            }

            Console.WriteLine($"Removing the number: {queue.Dequeue()}");

            foreach (int number in queue) {
                Console.WriteLine(number);
            }
        }
    }
}