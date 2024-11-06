using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace AsynchronousFileTask
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            string filePath = "D:\\TestFile";

            try
            {
                string content = await File.ReadAllTextAsync(filePath);
                Console.WriteLine("File content");
                Console.WriteLine(content);
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("Error: File not found");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Eror:Unauthorized access to file");
            }
            catch(IOException ex)
            {
                Console.WriteLine("Error occured" + ex.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine($"Unexpected error has occured {e.Message}");
            }
            finally
            {
                Console.WriteLine("File has no errors");
            }
        }
    }
}
