using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BityBankVer0911
{
    class ContaCorrente
    {
        public int Agencia { get; }
        public int NumeroConta { get;}

        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Saldo { get; private set; }

        public static int TotalContas { get; private set; }
        public static double Taxa { get; private set; }

        public ContaCorrente(int agencia, int numeroconta)
        {
            string mensagem = "";

            if (agencia == 0) mensagem += nameof(agencia) + " ";
            if (numeroconta == 0)   mensagem += nameof(numeroconta);

            if (mensagem != "")
            {
                ArgumentException ex = new ArgumentException("Deve-se informar um valor diferente de 0 para: " + mensagem + ".", mensagem);


                throw (ex);
            }
            

            Agencia = agencia;
            NumeroConta = numeroconta;

            TotalContas++;

            Taxa = 30 / TotalContas;

        }

        public void Sacar(double valor)
        {

            Saldo -= valor;
        }
        public void Depositar (double valor)
        {
            Saldo += valor;
        }

        public void Transferir(ContaCorrente contadestino, double valor)
        {
            contadestino.Sacar(valor);
            Depositar(valor);
        }
    }
}
