using Abstraction.Models;

namespace Inheritance.Models
{
    public class Teacher : Person
    {
        public decimal Salary { get; set; }

        public override void Introduce()
        {
            Console.WriteLine(
                $"Hello, my name is {Name}, I'm {Age}, and I make {Salary:C} per month as a teacher"
            );
        }
    }
}