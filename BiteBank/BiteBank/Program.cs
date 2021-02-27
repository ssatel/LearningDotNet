using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriela2 = new ContaCorrente();
            contaGabriela2.titular = "Gabriela";
            contaGabriela2.agencia = 1;
            contaGabriela2.conta = 1;
            contaGabriela2.saldo = 100;

            Console.WriteLine("Dados Bancarios : ");
            Console.WriteLine("Titular: " + contaGabriela2.titular);
            Console.WriteLine("Agencia: " + contaGabriela2.agencia);
            Console.WriteLine("Conta: " + contaGabriela2.conta);
            Console.WriteLine("Saldo Atual: " + contaGabriela2.saldo);

            contaGabriela2.saldo += 100;

            Console.WriteLine("Após operacao de somar 100");
            Console.WriteLine("Saldo Atual: " + contaGabriela2.saldo);

            Console.WriteLine();

            ContaCorrente contaGabriela3 = new ContaCorrente();
            contaGabriela3.titular = "Gabriela";
            contaGabriela3.agencia = 2;
            contaGabriela3.conta = 2;
            contaGabriela3.saldo = 200;

            Console.WriteLine("Dados Bancarios : ");
            Console.WriteLine("Titular: " + contaGabriela3.titular);
            Console.WriteLine("Agencia: " + contaGabriela3.agencia);
            Console.WriteLine("Conta: " + contaGabriela3.conta);
            Console.WriteLine("Saldo Atual: " + contaGabriela3.saldo);

            contaGabriela3.saldo += 100;

            Console.WriteLine("Após operacao de somar 100");
            Console.WriteLine("Saldo Atual: " + contaGabriela3.saldo);

            Console.WriteLine("Variaveis de referencia não possuem equivalencia: " + (contaGabriela2 == contaGabriela3));

            contaGabriela2 = contaGabriela3;

            contaGabriela2.saldo += 100;

            Console.WriteLine("Conta apontada pela contaGabriela2 " + contaGabriela2.conta);
            Console.WriteLine("Saldo conta referenciada: " + contaGabriela2.saldo) ;

            Console.WriteLine();

            Console.WriteLine("Conta apontada pela contaGabriela3 " + contaGabriela3.conta);
            Console.WriteLine("Saldo conta referenciada: " + contaGabriela3.saldo);


            Console.ReadLine();
        }
        
    }
}
