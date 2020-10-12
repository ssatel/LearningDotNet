using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversoesOutroTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 1250.7;
            int valor = (int)salario;
            Console.WriteLine("Salario double: " + salario);
            Console.WriteLine("Salario int: " + valor);

            float pontoFlutuante = 3.15f;
            double valor1 = 0.1;
            double valor2 = 0.2;
            double total = valor1 + valor2;

            Console.WriteLine("Valor Total: " + total * pontoFlutuante);

            Console.ReadLine();
        }
    }
}
