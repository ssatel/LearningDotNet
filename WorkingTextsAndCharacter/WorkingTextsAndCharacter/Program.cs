using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingTextsAndCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            char oneLeter = 's';

            char oneLeterASCII = (char)(65 - 1);

            string listCourse = 
@"-One
-Two
-Three";
            string title = "Its the title my exercise";

            Console.WriteLine("See the results of my testes" + 2020);
            Console.WriteLine(title);
            Console.WriteLine("oneLeter: " + oneLeter);
            Console.WriteLine("oneLeterASCII: " + oneLeterASCII);
            Console.WriteLine("listCourse:" + listCourse);
            Console.ReadLine();
        }
    }
}
