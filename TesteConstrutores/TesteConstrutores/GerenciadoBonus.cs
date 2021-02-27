using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteConstrutores.Funcionarios;

namespace TesteConstrutores
{
    class GerenciadoBonus
    {
        public double TotalBonus { get; private set; }

        public void Registrar(Funcionario funcionario)
        {

            TotalBonus += funcionario.GetBonus();

        }

        public double getTotalBonus()
        {
            return TotalBonus;
        }
    }
}
