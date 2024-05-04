using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Note
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime CreationDate { get; private set; }

        public Note(string title, string text)
        {
            Title = title;
            Text = text;
            CreationDate = DateTime.Now;
        }
    }

    public class NoteCollection
    {
        public string Author { get; private set; }
        public List<Note> Notes { get; private set; }

        public NoteCollection(string author)
        {
            Author = author;
            Notes = new List<Note>();
        }

        public void AddNote(Note note)
        {
            Notes.Add(note);
        }
    }
}
