namespace Exceptions.Models
{
    public class ReadingFileException
    {
        public static void ReadFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                Console.WriteLine("File content:");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"FileNotFoundException: {e.Message}");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine($"DirectoryNotFoundException: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Generic Exception: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Process finished.");
            }
            Console.WriteLine();
        }
    }
}