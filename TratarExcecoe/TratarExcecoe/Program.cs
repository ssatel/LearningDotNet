using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratarExcecoe
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch(DivideByZeroException erro)
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace);


            }
            
            Console.ReadLine();
        }

        public static void Metodo()
        {

            TestaDivisao(0);
        }

        public static void TestaDivisao( int numero)
        {

            Console.WriteLine("10 dividido por " + numero + " é igual a " + Divide(numero));
        }

        public static int Divide(int numero)
        {
            
            return 10 / numero;
        }
    }
}
