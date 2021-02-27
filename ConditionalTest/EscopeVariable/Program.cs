using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscopeVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageJohn = 16;
            bool alone = false;

            string aditionalStatement = "";

            if (alone)
            {
                aditionalStatement = "He is alone in the dark!";

            }
            else
            {
                aditionalStatement = "Very good, Always are good don´t be alone";
            }

            if (ageJohn < 18 && alone)
            {
                Console.WriteLine("Access Denied!");
            }
            else
            {
                Console.WriteLine("Access Alowed!");
            }

            Console.WriteLine(aditionalStatement);
            Console.ReadLine();
        }
    }
}
