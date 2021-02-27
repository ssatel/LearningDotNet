using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageJohn = 18;
            bool alone = true;

            if (ageJohn < 18 && alone == true)
            {
                Console.WriteLine("Access Denied!");
            }
            else

            {
                Console.WriteLine("Access Alowed!");
            }

            Console.ReadLine();

        }
    }
}
