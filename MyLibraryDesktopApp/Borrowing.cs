using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryDesktopApp
{
    public class Borrowing
    {
        private Book _book { get; set; }
        private Person _borrowers { get; set; }
        private DateTime _borrowingDate { get; set; }
        private string _note { get; set; }

        public Borrowing(Book book, Person borrowers, DateTime borrowingDate, string note)
        {
            _book = book;
            _borrowers = borrowers;
            _borrowingDate = borrowingDate;
            _note = note;
        }

    }
}
