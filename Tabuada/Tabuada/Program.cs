using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tabuada do " + i);
                for (int y = 0; y < 10; y++)
                {
                    Console.WriteLine(i + " X " + y + " = " + (i * y));

                }
                Console.WriteLine("---------------------------------");
                

            }

            Console.ReadLine();

        }
    }
}
