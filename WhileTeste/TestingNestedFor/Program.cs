using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingNestedFor
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = 1000;
            double taxrate = 1.0036;
            for (int iYear = 0; iYear < 5; iYear++)
            {
                for (int iMonth = 0; iMonth < 12; iMonth++)
                {
                    amount *= taxrate;

                }

                taxrate += 0.001;

            }

            Console.WriteLine("Total mount after 5 years: R$ " + amount);

            Console.ReadLine();

        }

    }
}
