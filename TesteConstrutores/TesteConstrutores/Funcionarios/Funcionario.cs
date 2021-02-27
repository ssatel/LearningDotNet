using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConstrutores.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        private string CPF { get; set; }
        public double Salario { get; protected set; }

        public static int TotalFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            CPF = cpf;
            Salario = salario;
            TotalFuncionarios++;
        }

        public abstract double GetBonus();

        public abstract void AumentarSalario();

    }
}
