using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogarSistemaInterno.Funcionarios
{
    class GerenteConta : Autenticavel
    {
        public GerenteConta(string cpf) : base(cpf, 4000)
        {
        }

        public override void AumentarSalarios()
        {
            Salario *= 1.15;
        }

        public override double getBonus()
        {
            return Salario * 1.25;
        }
    }
}
