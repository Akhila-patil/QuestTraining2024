using System;
using System.Linq;
using NoteTakingApp.Models;
using NoteTakingApp.Repository;
namespace NoteTakingApp.Services
{

    public class NoteService
    {
        private NoteRepository _noteRepository;
        private ILogger _logger;

        public NoteService(NoteRepository noteRepository, ILogger logger)
        {
            _noteRepository = noteRepository;
            _logger = logger;
        }
        public void CreateNote()
        {
            try
            {
                Console.WriteLine("Enter the title:");
                string title = Console.ReadLine();

                Console.WriteLine("Enter the content:");
                string content = Console.ReadLine();
                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(content))
                {
                    throw new NoteCreationException("Titel or content cannot be null or empty");
                }

                var note = new Note { Title = title, Content = content };
                _noteRepository.AddNote(note);

                _logger.Log("Note created: " + title);
                Console.WriteLine("Note Created Successfully");
            }

            catch (NoteCreationException ex)
            {
                Console.WriteLine($"Cought an Exception {ex.Message}");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error has occured: {ex.Message}");
            }
        }
        public void ViewAllNotes()
        {
            var notes = _noteRepository.GetAllNotes();
            foreach(var note in notes)
            {
                Console.WriteLine($"Id:{note.Id}\n Title:{note.Title}\n CreatedAt:{note.CreatedAt}");
                Console.WriteLine($"Content:{note.Content.Substring(0, Math.Min(note.Content.Length, 40))}");
            }

        }
        public void UpdateNote()
        {
            Console.WriteLine("Enter a note Id to update");
            int id = int.Parse(Console.ReadLine());

            var notes = _noteRepository.GetAllNotes();
            var note = notes.FirstOrDefault(n => n.Id == id);
            if (note == null)
            {
                Console.WriteLine("Note not found");
            }

            Console.WriteLine("Enter a new title or leave blank to keep the same:");
            string title = Console.ReadLine();
            if (string.IsNullOrEmpty(title)) title = note.Title;

            Console.WriteLine("Enter a new content or leave blank to keep the same:");
            string content = Console.ReadLine();
            if (string.IsNullOrEmpty(content)) content = note.Content;

            note.Title = title;
            note.Content = content;

            _noteRepository.UpdateNote(id,note);
            _logger.Log("Note Updated Successfully"+title);
            Console.WriteLine("Notes updated Successfully");
        }
        public void DeleteNote()
        {
            Console.WriteLine("Enter the note Id to delete the note:");
            int id = int.Parse(Console.ReadLine());

            var notes = _noteRepository.GetAllNotes();
            var note = notes.FirstOrDefault(x => x.Id == id);

            if (note == null)
            {
                Console.WriteLine("Note not found");
                return;
            }
            Console.WriteLine("Alert!! Are you sure to delete the note (y/n)");
            string input = Console.ReadLine();
            if (input.ToLower() == "y")
            {
                _noteRepository.DeleteNote(id);
                _logger.Log("Note deleted Successfully" + note.Title);
                Console.WriteLine("Note deleted Successfully");
            }



        }
    }
}
