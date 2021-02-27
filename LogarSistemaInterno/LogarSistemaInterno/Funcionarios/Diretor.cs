using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogarSistemaInterno.Funcionarios
{
    public class Diretor : Autenticavel
    {

        
        public Diretor(string cpf) : base(cpf, 5000)
        {

        }
        public override void AumentarSalarios()
        {
            Salario *= 1.5;
        }

        public override double getBonus()
        {
            return Salario * 1.5;
        }
    }
}
