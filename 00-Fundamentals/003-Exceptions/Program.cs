using Classes.Models;
using Exceptions.Models;

ReadingFileException.ReadFile("Files/folder/notes1.txt");
ReadingFileException.ReadFile("Files/notes1.txt");
ReadingFileException.ReadFile("Files/notes.txt");

Console.WriteLine("Handling exceptions: ");
ExceptionStackTrace.Method1();
Console.WriteLine();

Console.WriteLine("Exception not handled, stack trace example: ");
ExceptionStackTrace.Method2();
