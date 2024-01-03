using Abstraction.Models;

namespace Inheritance.Models
{
    public class Student : Person
    {
        public double Grade { get; set; }

        public override void Introduce()
        {
            Console.WriteLine(
                $"Hello, my name is {Name}, I'm {Age} and I'm a {Grade:N2} student"
            );
        }
    }
}