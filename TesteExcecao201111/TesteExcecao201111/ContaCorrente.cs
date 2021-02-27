using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteExcecao201111
{
    class ContaCorrente
    {
        public int AgenciaNumero { get; }
        public int NumeroConta { get; }

        public double Saldo { get; private set; }

        public int TentativasSaqueNaoEfetivadas { get;  private set; }
        public int TentativasTransferenciasNaoEfetivadas { get; private set; }

        public ContaCorrente(int agencia, int conta)
        {
            AgenciaNumero = agencia;
            NumeroConta = conta;

            Saldo = 100;
        }

        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                throw(new ArgumentException("Valor negativo invalido para deposito", nameof(valor)));
            }
            
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw (new ArgumentException("Valor negativo invalido para Saque", nameof(valor)));
            }
            if (valor > Saldo)
            {
                TentativasSaqueNaoEfetivadas++;
                throw (new SaldoInsuficienteException(valor, Saldo));

            }
            Saldo -= valor;
        }

        public void Transferir(double valor, ContaCorrente contadestino)
        {
            try
            {
                Sacar(valor);
            }
            catch(SaldoInsuficienteException)
            {
                TentativasTransferenciasNaoEfetivadas++;
                throw;
            }   
            
            contadestino.Depositar(valor);
        }



    }
}
