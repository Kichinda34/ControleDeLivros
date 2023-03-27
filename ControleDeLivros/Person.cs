using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeLivros
{
    internal class Person
    {
        public string _name { get; set; }

        public string _telphone { get; set; }
        
        public string _email { get; set; } 

        public Person(string n, string t, string e) 
        {
            _name = n;
            _telphone = t;
            _email = e;
        }

        //public override string ToString()
        //{
        //  return;
        //}
    }
}
