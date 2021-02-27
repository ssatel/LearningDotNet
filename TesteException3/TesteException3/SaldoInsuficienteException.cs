using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteException3
{
    class SaldoInsuficienteException : Exception
    {
        public double Valor { get;}
        public double Saldo { get;}

        public SaldoInsuficienteException(double valor, double saldo)
            :this("Não é possivel sacar o valor de " + valor + " Saldo disponivel para operacao: " + saldo)
        {

        }
        public SaldoInsuficienteException(string arg)
            : base(arg)
        {

        }
    }
}
