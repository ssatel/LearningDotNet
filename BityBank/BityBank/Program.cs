using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BityBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();

            gabriela.Nome = "Gabriela";
            gabriela.CPF = "215.456.78-21";
            gabriela.Profissao = "Administradora";

            ContaCorrente conta = new ContaCorrente(1,02);

            conta.Titular = gabriela;
            conta.Agencia = 500;
            conta.Conta = 500001;
            conta.DefinirSaldo(-500);

            Console.WriteLine("gabriela.nome: " + gabriela.Nome);
            Console.WriteLine("conta.titular.nome: " + conta.Titular.Nome);

            conta.Titular.Nome = "Gabriela Costa";

            Console.WriteLine("Após atribuir a conta.titular.nome = Gabriela Costa");
            Console.WriteLine("gabriela.nome: " + gabriela.Nome);
            Console.WriteLine("conta.titular.nome: " + conta.Titular.Nome);

            ContaCorrente contaNull = new ContaCorrente(1,01);

            //contaNull.titular = new Cliente();

            if (contaNull.Titular == null)
            {
                Console.WriteLine("Sem informações disponiveis");
            }
            else
            {
                Console.WriteLine("Lendo atributo nulo da conta " + contaNull.Titular.Nome);
            }

            Console.WriteLine("Total de contas Criadas:" + ContaCorrente.TotalContasCriadas);
            
            Console.ReadLine();

        }
    }
}
