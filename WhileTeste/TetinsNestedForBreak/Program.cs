using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetinsNestedForBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int iLine = 0; iLine < 10; iLine++)
            {
                for (int iColumn = 0; iColumn < 10; iColumn++)
                {
                    Console.Write("+");

                    if (iColumn == iLine) break;
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
