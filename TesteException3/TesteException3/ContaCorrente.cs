using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteException3
{
    class ContaCorrente
    {
        public int Agencia { get; }
        public int Conta { get; }
        public double Saldo { get; private set; }

        public ContaCorrente(int agencia, int conta)
        {
            Agencia = agencia;
            Conta = conta;
            Saldo = 100;
        }

        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw (new ArgumentException("Valor invalido para operacao saque", nameof(valor)));
            }
            if (valor > Saldo)
            {
                throw (new SaldoInsuficienteException(valor, Saldo));
            }
            Saldo -= valor;
        }

        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                throw (new ArgumentException("Valor invalido para operacao de deposito", nameof(valor)));
            }

            Saldo += valor;
        }
        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw (new ArgumentException("Valor invalido para operacao de transferencia", nameof(valor)));
            }

            this.Sacar(valor);

            contaDestino.Depositar(valor);

        }
    }
}
