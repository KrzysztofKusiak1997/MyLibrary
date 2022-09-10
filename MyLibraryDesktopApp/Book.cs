using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryDesktopApp
{
    public class Book
    {
        private string _title { get; set; }
        private string _description { get; set; }
        private Author _author { get; set; }
        private string _genre { get; set; }
        private string _type { get; set; }
        public Person _owner { get; set; }
        public Person _holder { get; set; }

        public Book(string title, string description, Author author, string genre, string type, Person owner, Person holder)
        {
            _title = title;
            _description = description; 
            _author = author;   
            _genre = genre;
            _type = type;
            _owner = owner;
            _holder = holder;
        }

    }
}
