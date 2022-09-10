using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryDesktopApp
{
    public class Person
    {
        private string _name { get; set; }
        private string _surname { get; set; }
        private string _city { get; set; }

        public Person (string name, string surname, string city)
        {
            _name = name;
            _surname = surname;
            _city = city;
        }

    }
}
