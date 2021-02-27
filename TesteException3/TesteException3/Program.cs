using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteException3
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(1, 1);

            try
            {
                conta.Sacar(-200);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção tipo SaldoInfucienteException");
                
            }
            catch (Exception ex)
            {

                Console.WriteLine("Outra Exception");
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
