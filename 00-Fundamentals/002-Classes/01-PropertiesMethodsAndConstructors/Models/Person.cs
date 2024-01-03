namespace PropertiesMethodsAndConstructors.Models {
    public class Person {
        protected string _name;
        protected string _lastName;
        protected int _age;
        public string Name {
            /* Body expressions */
            get => _name;
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("Name cannot be null/empty");
                }
                _name = value;
            }
        }
        public string LastName {
            get => _lastName;
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("Name cannot be null/empty");
                }
                _lastName = value;
            }
        }
        public int Age {
            get => _age;
            set {
                if (value < 0) {
                    throw new ArgumentException("Age cannot be negative");
                }
                _age = value;
            }
        }
        /* String interpolation */
        public string FullName => $"{Name} {LastName}";

        public Person(string name, string lastName, int age) {
            Name = name;
            LastName = lastName;
            Age = age;
        }

        public void Introduce() {
            Console.WriteLine(
                $"Hello, my name is {FullName} and I am {Age} years old"
            );
        }
    }
}
