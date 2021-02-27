using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteException2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possivel a operacao de divisão por Zero");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Tudo certo por aqui :D ");

            Console.ReadLine();

                
        }

        static void Metodo()
        {
            ContaCorrente conta = null;
            //Console.WriteLine(conta.ContaNumero);

            TestaDivisao();
        }

        static void TestaDivisao()
        {
            Console.WriteLine("10 divido por 10 é " + Dividir(0));
        }

        static int Dividir( int numero)
        {
            try
            {
                return 10 / numero;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possivel dividir 10 por " + numero );
                throw;
            }
            
        }
    }
}
