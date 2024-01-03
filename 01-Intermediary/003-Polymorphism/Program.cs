using Inheritance.Models;

Student student = new();

student.Name = "Victor";
student.Age = 21;
student.Grade = 9.85;

student.Introduce();

Teacher teacher = new();

teacher.Name = "Leo";
teacher.Age = 25;
teacher.Salary = 5000.00M;

teacher.Introduce();
