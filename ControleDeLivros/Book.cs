using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeLivros
{
    internal class Book
    {
        public string _title { get; set; }

        public string _author { get; set; }

        public string _isbn { get; set; }

        public Book(string t, string a, string i) 
        { 
            this._title = t;
            this._author = a;
            this._isbn = i; 
        }
    }
}
