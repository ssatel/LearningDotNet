using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileTestingCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int iCounter = 0;
            while (iCounter < 10)
            {
                Console.WriteLine("Line: " + iCounter );

                iCounter++;

            }
            Console.ReadLine();
        }
    }
}
