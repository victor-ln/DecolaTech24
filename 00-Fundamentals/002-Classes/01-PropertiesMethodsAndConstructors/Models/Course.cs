namespace PropertiesMethodsAndConstructors.Models {
    public class Course {
        public string Name { get; set; }
        private List<Person> Students { get; set; }
        public Course(string courseName) {
            Name = courseName;
            Students = [];
        }

        public int GetNumberOfEnrolledStudents() => Students.Count;
        public void AddStudent(Person student) => Students.Add(student);
        public bool RemoveStudent(Person student) => Students.Remove(student);
        public void ListStudents() {
            int index = 1;

            Students.ForEach(student => {
                Console.WriteLine($"N° {index++} - {student.FullName}");
            });
        }
    }
}
