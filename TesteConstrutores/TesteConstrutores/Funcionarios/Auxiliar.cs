using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConstrutores.Funcionarios
{
    class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 2000)
        {

        }
        public override double GetBonus()
        {
            return Salario * .1;
        }
        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }
    }
}
