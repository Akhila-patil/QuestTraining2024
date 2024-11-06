using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteTakingApp.Repository;
using NoteTakingApp.Services;

namespace NoteTakingApp
{
    internal class Program
    {
        public const string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pk\Documents\QuestDB.mdf;Integrated Security=True;Connect Timeout=30";
        static void Main(string[] args)
        {
            var logger = new LogConsole();
            var noteRepo = new NoteRepository(connStr);
            var noteServices = new NoteService(noteRepo, logger);

            while (true)
            {
                Console.WriteLine("1.Create a Note:");
                Console.WriteLine("2. View All Notes");
                Console.WriteLine("3.Update the Notes");
                Console.WriteLine("4.Delete the Note");
                Console.WriteLine("5.Exit");
                var Choice = Console.ReadLine();
                switch (Choice)
                {
                    case "1":
                        noteServices.CreateNote();
                        break;
                    case "2":
                        noteServices.ViewAllNotes();
                        break;
                    case "3":
                        noteServices.UpdateNote();
                        break;
                    case "4":
                        noteServices.DeleteNote();
                        break;
                    default:
                        Console.WriteLine("Invalid choice!!!!!");
                        break;
                }



            }
        }
    }
}
