using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int idade =  26;
            Console.WriteLine("variavel inteiro numero de 32 bits: "+ idade );
            
            short numeroPequeno = 15000;
            Console.WriteLine("Short um numero pequeno de até 16 bit aprox 1600: " + numeroPequeno);


            long numeroGrande = 13000000000000;
            Console.WriteLine("long um numero grande de 64 bit: " + numeroGrande);

            double salario = 12345.90;
            Console.WriteLine("double é um numero decimal com uma precisao maior que o float: " + salario);

            
            float taxa = 1.4f;
            Console.WriteLine("float é um numero decimal com uma precisao pequena, utilizar f para indicar que esta correto: " + taxa);

            Console.ReadLine();
        }
    }
}
