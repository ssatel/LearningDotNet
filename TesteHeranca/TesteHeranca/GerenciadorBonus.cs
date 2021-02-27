using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteHeranca.Funcionarios;

namespace TesteHeranca
{
    class GerenciadorBonus
    {
        double _totalBonus;
        public void Registrar(Funcionario funcionario)
        {
            _totalBonus += funcionario.GetBonificacao();
        }

        public double GetBonusTotal()
        {
            return _totalBonus;
        }
    }
}
