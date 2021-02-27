using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteException201112
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaOrigem = new ContaCorrente(1, 1);
            ContaCorrente contaDestino = new ContaCorrente(2, 2);
            try
            {
                contaOrigem.Sacar(-20);

            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine("Saldo Insuficiente Expediente Detalhes:");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Valor);
                Console.WriteLine(e.Saldo);
                Console.WriteLine(e.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exceção Geral Detalhes:");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }


            try
            {
                contaOrigem.Sacar(200);
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine("Saldo Insuficiente Exceção Detalhes:");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Valor);
                Console.WriteLine(e.Saldo);
                Console.WriteLine(e.StackTrace);

            }
            catch (Exception e)
            {
                Console.WriteLine("Exceção Geral Detalhes:");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            try
            {
                contaOrigem.Transferir(200, contaDestino);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine("Exceção Operacao Financeira Detalhes:");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.InnerException.Message);
                


            }
            Console.WriteLine("Conta Origem:");
            Console.WriteLine("Saldo:"+  contaOrigem.Saldo);

            Console.WriteLine("Conta destino:");
            Console.WriteLine("Saldo:" + contaDestino.Saldo);

            Console.WriteLine("Chegamos ao fim do programa ;)");
            Console.ReadLine();

        }
    }
}
