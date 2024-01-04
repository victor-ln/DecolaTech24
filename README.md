# DecolaTech24

Welcome to my DecolaTech2024 Learning Repository! This repository contains the comprehensive content covered during the DecolaTech2024 bootcamp, a program designed to provide an online educational track focused on .NET and C#, from basics to advanced concepts, engaging in practical projects alongside industry experts. The complete trail takes 73 hours, and participants receive certification upon successful completion.

## Table of Contents

- [Fundamentals](#fundamentals)

    - [Getting Started](#getting-started)
    - [Data Types](#data-types)
    - [Classes](#classes)
    - [Exceptions](#exceptions)
    - [Collections](#collections)

- [Intermediary](#intermediary)

    - [Abstraction](#abstraction)
    - [Encapsulation](#encapsulation)
    - [Inheritance](#inheritance)
    - [Polymorphism](#polymorphism)

- [Advanced](#advanced)

    - [Tests](#tests)

## Fundamentals

### Getting Started

Here, I've created my first .NET project, [GettingStarted](./00-Fundamentals/000-GettingStarted), with the command:
```bash
dotnet new console --name 'GettingStarted'
```

Inside each folder where there is a file Program.cs, you can run it with:
```bash
dotnet run
```

### Data Types

In [DataTypes](./00-Fundamentals/001-DataTypes) folder, I've explored some data types available in C#, covering string, numeric, and date.

#### String

[StringOperations.cs](./00-Fundamentals/001-DataTypes/00-String/StringOperations.cs) involves string manipulation, such as concatenation, formatting, interpolation, and upper/lowercase transformations.

#### Numeric

[MoneyAndCultures.cs](./00-Fundamentals/001-DataTypes/01-Numeric/MoneyAndCultures.cs) includes examples of manipulating numeric types, such as `decimal` and `int`. The `decimal` type is used to represent financial values, while the `int` type is used for integer numbers.

#### Date

[Date.cs](./00-Fundamentals/001-DataTypes/02-Date/Date.cs) demonstrates the use of the `DateTime` type to handle date and time information, including formatting and parsing dates.

### Classes

In object-oriented programming, a class is a blueprint for creating objects. It defines a data structure that encapsulates data and behavior associated with the data.

#### Class Example

The [Person.cs](./00-Fundamentals/002-Classes/00-Example/Models/Person.cs) class is a basic representation of an individual with properties for name and age, along with a method for introduction.

#### Properties Methods And Constructors

In [PropertiesMethodsAndConstructors](./00-Fundamentals/002-Classes/01-PropertiesMethodsAndConstructors/), we have more complex classes. Let's delve into their concepts and implementations.

The [Course.cs](./00-Fundamentals/002-Classes/01-PropertiesMethodsAndConstructors/Models/Course.cs) class represents a course and includes properties for the course name and a list of enrolled students. It also provides methods for managing student enrollment, retrieval of the number of enrolled students, and listing the enrolled students.

This class demonstrates encapsulation by using private fields and providing methods for controlled access to these fields.

The [Person.cs](./00-Fundamentals/002-Classes/01-PropertiesMethodsAndConstructors/Models/Person.cs) class introduces the concepts of properties with body expressions, string interpolation, and constructor overloading. It includes properties for name, last name, and age, as well as a calculated property for the full name.

This class showcases the use of properties with explicit get and set methods, as well as the implementation of a constructor and a method for self-introduction. It emphasizes the importance of encapsulation and validation in managing class properties.

### Exceptions

In programming, exceptions are unforeseen events that disrupt the normal flow of a program. They allow developers to handle errors and exceptional situations gracefully. The provided code examples demonstrate the use of exceptions in C#.

The [ReadingFileException.cs](./00-Fundamentals/003-Exceptions/Models/ExceptionReadingFile.cs) class showcases exception handling during file reading operations. The ReadFile method attempts to read the content of a file specified by the provided filePath. It catches specific exceptions, such as FileNotFoundException and DirectoryNotFoundException, and a generic Exception for handling any other unexpected errors.

The [ExceptionStackTrace.cs](./00-Fundamentals/003-Exceptions/Models/ExceptionStackTrace.cs) class demonstrates the concept of an exception's stack trace. The methods in this class are deliberately designed to throw an exception (Method4). The stack trace shows the sequence of method calls that led to the exception.

### Collections

In programming, collections are data structures that allow the storage and manipulation of groups of related elements. The provided examples focus on three commonly used collections in C#: Dictionary, List, Queue, and Stack.

The [DictionaryExample.cs](./00-Fundamentals/004-Collections/Models/DictionaryExample.cs) class demonstrates the use of a Dictionary<string, string> to store key-value pairs, representing states and their abbreviations. It showcases various operations such as adding, removing, updating, and checking for the existence of keys.

The [ListExample.cs](./00-Fundamentals/004-Collections/Models/ListExample.cs) class demonstrates the use of a List<int> to store and manipulate a collection of integers. It covers operations such as adding, inserting, removing, and checking for the existence of elements.

The [QueueExample.cs](./00-Fundamentals/004-Collections/Models/QueueExample.cs) class demonstrates the use of a Queue<int> to store and process integers in a first-in-first-out (FIFO) manner. It shows the enqueueing and dequeueing of elements.

The [StackExample.cs](./00-Fundamentals/004-Collections/Models/StackExample.cs) class demonstrates the use of a Stack<int> to store and process integers in a last-in-first-out (LIFO) manner. It shows the pushing, popping, and updating of elements.

## Intermediary

In this section, we delve deeper into the principles that form the foundation of OOP and contribute to creating robust, modular, and maintainable software.
OOP is a paradigm that revolutionized the way we design and structure software. It revolves around the concept of objects, which encapsulate data and behavior, providing a modular and organized approach to code.
OOP is centered around four core pillars: Abstraction, Encapsulation, Inheritance, and Polymorphism.

### Abstraction

Abstraction involves simplifying complex systems by modeling classes based on the essential characteristics and behaviors they share. Abstraction allows developers to focus on relevant details while ignoring unnecessary complexities.

The [Person.cs](./01-Intermediary/000-Abstraction/Models/Person.cs) class exemplifies abstraction. It abstracts the concept of a person by defining properties like Name and Age and a behavior, Introduce, which is a common action for all persons.

### Encapsulation

Encapsulation involves bundling the data (attributes) and methods (behaviors) that operate on the data into a single unit called a class. Encapsulation helps in hiding the internal details of how an object works and exposing only what is necessary for the outside world to interact with.

The [CheckingAccount.cs](./01-Intermediary/001-Encapsulation/Models/CheckingAccount.cs) class demonstrates encapsulation. It represents a simple checking account with an account number, a private balance, and methods for withdrawing and displaying the balance.

### Inheritance

Inheritance is a concept that allows a new class (derived or child class) to inherit attributes and behaviors from an existing class (base or parent class). This promotes code reuse and establishes an "is-a" relationship between the classes, where the derived class is a specialized version of the base class.

Consider the example involving three classes - [Person.cs](./01-Intermediary/002-Inheritance/Models/Person.cs), [Student.cs](./01-Intermediary/002-Inheritance/Models/Student.cs), and [Teacher.cs](./01-Intermediary/002-Inheritance/Models/Teacher.cs). The Student and Teacher classes inherit from the Person class.
This demonstrates how inheritance enables the creation of specialized classes while leveraging the functionality of a more generalized class.

By utilizing inheritance, you can build hierarchical and organized class structures, improving code readability and facilitating the maintenance and extension of your software. It embodies the principle of reusing existing code and establishing relationships between different entities in your program.

### Polymorphism

Polymorphism, is another principle that allows objects of different types to be treated as objects of a common base type. This enables flexibility and extensibility in your code, allowing you to write code that can work with objects of various types without knowing their specific types at compile time.

Consider again the example involving those same three classes - [Person.cs](./01-Intermediary/003-Polymorphism/Models/Person.cs), [Student.cs](./01-Intermediary/003-Polymorphism/Models/Student.cs), and [Teacher.cs](./01-Intermediary/003-Polymorphism/Models/Teacher.cs). The Student and Teacher classes inherit from the Person class and demonstrate polymorphism by overriding the Introduce method.

You can see polymorphism when invoking the Introduce method in [Program.cs](./01-Intermediary/003-Polymorphism/Program.cs).
Both Student and Teacher objects are assigned to a variable of type Person. This allows us to treat objects of different derived types through a common base type. The overridden `Introduce()` method in each derived class are invoked based on the actual type of the object, showcasing dynamic behavior at runtime.

Polymorphism enhances code flexibility, extensibility, and readability. It allows you to write code that can adapt to changes and accommodate new types without modifying existing code, promoting a more scalable and maintainable software design.

## Advanced

### Tests

Testing is a crucial practice in software development. Here, we cover Unit testing with xUnit, which involves testing individual units or components of a system to ensure they behave as expected. The primary goal of unit testing is to catch and fix bugs early in the development process, leading to more reliable and maintainable software.

Several testing frameworks are popular in the C# ecosystem. Some notable ones include:

- xUnit
- MSTest
- NUnit

In our example project, we have a main project named [Calculator](./02-Advanced/000-Tests/Calculator/) and a corresponding unit testing project named [CalculatorTests](./02-Advanced/000-Tests/CalculatorTests/).


#### Creation Process

##### Creating main project and test project

```bash
dotnet new console --name 'Calculator'
dotnet new xunit --name 'CalculatorTests'
```

##### Grouping projects into solution 

```bash
dotnet new sln --name 'CalculatorModule'
dotnet sln '.\CalculatorModule.sln' add  '.\Calculator\Calculator.csproj'
dotnet sln '.\CalculatorModule.sln' add  '.\CalculatorTests\CalculatorTests.csproj'
```

##### Referencing main project into test project

```bash
dotnet add '.\CalculatorTests\CalculatorTests.csproj' reference '.\Calculator\Calculator.csproj'
```

#### Running tests

Inside [Tests](./02-Advanced/000-Tests/) or [CalculatorTests](./02-Advanced/000-Tests/CalculatorTests/) folders, run:
```bash
dotnet test
```
