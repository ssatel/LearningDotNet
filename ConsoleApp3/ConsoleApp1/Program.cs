using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade;
            Console.WriteLine("Testando variaveis");
            idade = 5 / 3;
            Console.WriteLine("5 / 3 " + idade );

            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3 " + idade);

            Console.WriteLine("pressione Enter para sair");
            Console.ReadLine();
        }
    }
}
