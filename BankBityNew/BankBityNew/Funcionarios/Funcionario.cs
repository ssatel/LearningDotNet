using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BankBityNew.Funcionarios
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }

        public double Salario { get; set; }
        private int _tipo { get; set; }

        public Funcionario(int tipo)
        {
            _tipo = tipo;
        }

        public double GetBonificacao()
        {
            if (_tipo == 1)
            {
                return Salario;

            }

            return Salario * .10;
        }

    }
}
