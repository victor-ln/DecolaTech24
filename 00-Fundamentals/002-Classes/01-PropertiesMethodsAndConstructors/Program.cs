using PropertiesMethodsAndConstructors.Models;

Person person1 = new(name: "Victor", lastName: "Nunes", age: 21);
Person person2 = new(name: "Maria", lastName: "Nevez", age: 20);

Course course = new(courseName: "Computer Science");

person1.Introduce();
person2.Introduce();

course.AddStudent(person1);
course.AddStudent(person2);

course.ListStudents();

Console.WriteLine($"Enrolled students: {course.GetNumberOfEnrolledStudents()}");
course.RemoveStudent(person1);
Console.WriteLine($"Enrolled students: {course.GetNumberOfEnrolledStudents()}");

course.ListStudents();
