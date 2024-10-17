using System;
using System.Collections.Generic;
using System.IO;



namespace FileHandling
{
    internal class Program
    {
        static void Main()
        {
            var path = @"C:\Users\pk\Documents\TestDirectory";
            var file = "data.txt";
            var filepath=Path.Combine(path, file);
            Directory.CreateDirectory(path);
            File.WriteAllText(filepath, "New text from code");
            File.AppendAllText(filepath, "New text from code");
            File.AppendAllText(filepath, "New text from code");
            //Directory.Delete(path);
            //Directory.Delete(path, true);
            var content=File.ReadAllText(filepath);
            string[] contentLines = File.ReadAllLines(filepath);
            Console.WriteLine(content);




        }
    }
}
