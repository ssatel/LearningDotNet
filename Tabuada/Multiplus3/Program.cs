using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplus3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerosDivisiveis = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i + " é multiplo de 3 " );
                    numerosDivisiveis++;

                }

            }
            Console.WriteLine("Total de numero divisiveis por 3: " + numerosDivisiveis);
            Console.ReadLine();
        }

    }
}
