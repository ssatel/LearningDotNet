using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestes2.Funcionarios
{
    class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(cpf, 5000)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

        public override double GetBonus()
        {
            return Salario * .5;
        }
    }
}
