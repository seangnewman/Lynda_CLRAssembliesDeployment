using People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var sean = new Person("Sean", "Newman", 56);

            Console.WriteLine($"Hello, {sean.FirstName}");

            Assembly assem = Assembly.GetEntryAssembly();
            Console.WriteLine(  assem.FullName);

            Assembly people = sean.GetType().Assembly;
            Console.WriteLine(people.FullName);
        }
    }
}
