using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

        public Person(string fn, string ln, int a)
        {
            FirstName = fn;
            LastName = ln;
            Age = a;
        }

        public override string ToString()
        {
            return String.Format($"[Person FN: {FirstName} LN:{LastName} A: {Age}]");
        }
    }
}
