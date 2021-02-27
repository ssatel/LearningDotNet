using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BityBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }
        

        private double saldo = 100;

        public static int TotalContasCriadas { get; private set; }

        public ContaCorrente(int agencia, int conta) 
        {
            Agencia = agencia;
            Conta = conta;
            TotalContasCriadas++;
        }

        public double ObterSaldo()
        {
            return saldo;
        }

        public void DefinirSaldo(double valor)
        {
            if (valor < 0)
            {
                return;

            }
            saldo = saldo;
        }

        public bool Sacar(double valor)
        {
            if (valor > saldo) return false;
            
            saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contadestino)
        {
            if (this.Sacar(valor))
            {
                contadestino.Depositar(valor);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
