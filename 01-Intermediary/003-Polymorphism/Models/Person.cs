namespace Abstraction.Models
{
    public class Person
    {
        public string Name { get; set; }
        public uint Age { get; set; }

        public virtual void Introduce()
        {
            Console.WriteLine(
                $"Hello, my name is {Name} and I'm {Age} years old"
            );
        }
    }
}