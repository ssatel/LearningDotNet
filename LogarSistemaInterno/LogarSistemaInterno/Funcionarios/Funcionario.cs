using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogarSistemaInterno.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; protected set; }

        public static int TotalFuncionario { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            CPF = cpf;
            Salario = salario;

            TotalFuncionario++;

        }

        public abstract double getBonus();

        public abstract void AumentarSalarios();

    }
}
