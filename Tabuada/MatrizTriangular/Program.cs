using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizTriangular
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 10; x++)
            {
                for (int y = 1; y < x; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
