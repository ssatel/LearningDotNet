using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConstrutores.Funcionarios
{
    class GerenteConta : Funcionario
    {
        public GerenteConta(string cpf) : base(cpf, 4000)
        {

        }
        public override double GetBonus()
        {
            return Salario * .25 ;
        }
        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
    }
}
