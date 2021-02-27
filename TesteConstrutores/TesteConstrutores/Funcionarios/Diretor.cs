using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConstrutores.Funcionarios
{
    class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(cpf, 5000)
        {

        }

        public override double GetBonus()
        {
            return Salario / 2;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }


    }
}
