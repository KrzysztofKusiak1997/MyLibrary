using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryDesktopApp
{
    public class Author
    {
        private string _name { get; set; }
        private string _surname { get; set; }
        
        public Author (string name, string surname)
        {
            _name = name;
            _surname = surname;
        }
    }
}
