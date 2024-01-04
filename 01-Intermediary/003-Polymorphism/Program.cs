using Inheritance.Models;

// Creating a Student object
Person student = new Student
{
    Name = "Victor",
    Age = 21,
    Grade = 9.85
};

// Creating a Teacher object
Person teacher = new Teacher
{
    Name = "Leo",
    Age = 25,
    Salary = 5000.00M
};

// Invoking the Introduce method on both objects
student.Introduce();
teacher.Introduce();
