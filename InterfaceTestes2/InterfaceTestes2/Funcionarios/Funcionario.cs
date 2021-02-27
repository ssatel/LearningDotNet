using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestes2.Funcionarios
{
    public abstract class  Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; protected set; }

        public static int QtdFuncionarios { get; protected set; }

        public Funcionario(string cpf, double salario)
        {
            CPF = cpf;
            Salario = salario;

            QtdFuncionarios++;

        }
        
        public abstract double GetBonus();
        public abstract void AumentarSalario();

    }
}
