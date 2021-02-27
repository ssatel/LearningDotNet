using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = 1000;
            for (int iMonth = 0; iMonth < 13; iMonth++)
            {
                
                Console.WriteLine("Total at " + iMonth + " R$ " + amount);

                amount *= 1.0036;

            }
            Console.ReadLine();
        }
    }
}
