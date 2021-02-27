using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 32;
            int myAge = age;

            age = 30;

            Console.WriteLine(age);
            Console.WriteLine(myAge);
            Console.ReadLine();
        }
    }
}
