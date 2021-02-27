using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteExcecao201111
{
    class SaldoInsuficienteException : Exception
    {
        public double Valor { get; }
        public double Saldo { get; }

        public SaldoInsuficienteException(double valor, double saldo) 
            :base("Saque no valor de " + valor + " acima do saldo disponivel de " + saldo)
        {
            Valor = valor;
            Saldo = saldo;
        }
    }
}
