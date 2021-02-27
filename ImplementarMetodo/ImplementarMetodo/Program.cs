using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementarMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            Console.WriteLine("conta.saldo: " + conta.saldo);

            bool deucerto = conta.Sacar(150);

            Console.WriteLine("Deu certo: " + deucerto);

            Console.WriteLine("Novo saldo após Sacar:" + conta.saldo);

            conta.Depositar(200);

            Console.WriteLine("Novo saldo após Depositar 200:" + conta.saldo);

            deucerto = conta.Sacar(150);

            Console.WriteLine("Deu certo agora?: " + deucerto);

            Console.WriteLine("Novo saldo após Sacar novamente:" + conta.saldo);

            ContaCorrente contaJoao = new ContaCorrente();
            ContaCorrente contaAna = new ContaCorrente();

            Console.WriteLine("João transfere 100 para Ana");

            deucerto = contaJoao.Transferir(100, contaAna);

            Console.WriteLine("Saldo conta Joao ápós Transferir: " + contaJoao.saldo);
            Console.WriteLine("Saldo conta Ana após receber transferencia: " + contaAna.saldo);
            Console.WriteLine("Deu certo:" + deucerto);

            Console.WriteLine("Ana transfere 250 para joao");

            deucerto = contaAna.Transferir(150, contaJoao);

            Console.WriteLine("Saldo Ana após transferencia: " + contaAna.saldo);
            Console.WriteLine("Saldo conta Joao após receber transferencia: " + contaJoao.saldo);
            Console.WriteLine("Deu certo? " + deucerto);






            Console.ReadLine();
        }
    }
}
