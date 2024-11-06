using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTakingApp
{
    public class NoteCreationException : Exception
    {

        public NoteCreationException() : base("An error occurred while creating the note.")
        { }
        public NoteCreationException(string message) : base(message)
        { }
    }

}
