using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteExcecao201111
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaOrigem = new ContaCorrente(1, 1);
            ContaCorrente contaDestino = new ContaCorrente(2, 2);

            try
            {
                contaOrigem.Transferir(200, contaDestino);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Saldo);
                Console.WriteLine(ex.Valor);
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                contaOrigem.Sacar(200);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Saldo);
                Console.WriteLine(ex.Valor);
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                contaOrigem.Sacar(-200);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Saldo);
                Console.WriteLine(ex.Valor);
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Tentativas:");
            Console.WriteLine(contaOrigem.TentativasSaqueNaoEfetivadas);
            Console.WriteLine(contaOrigem.TentativasTransferenciasNaoEfetivadas);

            Console.ReadLine();
        }
    }
}
