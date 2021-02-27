using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteException
{
    
    class ContaCorrente
    {
        public int Agencia { get; set; }
        public int Conta { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }

        public double Saldo { get; private set; }

        public static int TotalContas { get; private set; }

        public static double Taxa { get; private set; }

        public ContaCorrente(int agencia, int conta)
        {
            Agencia = agencia;
            Conta = conta;
            Saldo = 100;
            Taxa = 30 / TotalContas;
            TotalContas++;

        }

        public void Sacar(double valor)
        {
            Saldo -= valor;
        }
        public void Depositar(double valor)
        {
            Saldo = +valor;
        }

        public void Transferir(ContaCorrente destino, double valor)
        {
            this.Sacar(valor);
            destino.Depositar(valor);
        }
    }
}
