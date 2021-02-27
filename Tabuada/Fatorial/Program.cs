using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialNumber = 1;

            for (int i = 0; i < 10; i++)
            {
                // 1
                initialNumber = i;

                for (int x = 1; x < i; x++)
                {

                    initialNumber *= x;

                }
                Console.WriteLine("Fatorial de " + i + " é " + initialNumber);

            }

            Console.ReadLine();

        }
        
    }
}
