using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteException201112
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Valor { get; }
        public double Saldo { get; }

        public SaldoInsuficienteException(double valor, double saldo)
            : base("Saque no valor de " + valor + " não permitido. Saldo disponivel para operacao: " + saldo)
        {
            Valor = valor;
            Saldo = saldo;
        }
    }
}
