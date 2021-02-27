using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = 1000;
            int period = 0;
            double taxrate = 0.0036;

            while (period <= 12)
            {
                

                Console.WriteLine("Amount invest in " + period + " is R$ " + amount);

                amount = amount + (amount * taxrate);

                period++;

            }

            Console.ReadLine();

        }
    }
}
