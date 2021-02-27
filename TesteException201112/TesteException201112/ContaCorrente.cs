using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteException201112
{
    public class ContaCorrente
    {
        public int Agencia { get; }
        public int Conta { get; }

        public double Saldo { get; private set; }

        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidos { get; private set; }

        public ContaCorrente(int agencia, int conta)
        {
            Agencia = agencia;
            Conta = conta;
            Saldo = 100;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                ArgumentException e = new ArgumentException("Não permitido valor negativo ", nameof(valor));
                throw e;
            }
            if (valor > Saldo)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(valor, Saldo);
            }
            Saldo -= valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw (new ArgumentException("Não permitido valor negativo " , nameof(valor)));

            }
            try
            {
                Sacar(valor);   
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidos++;
                throw(new OperacaoFinanceiraException("Operacao ñão permitida", ex));
            }

            contaDestino.Depositar(valor);

        }
    }
}
