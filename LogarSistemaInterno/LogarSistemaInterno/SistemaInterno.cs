using LogarSistemaInterno.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogarSistemaInterno
{
    class SistemaInterno
    {
        public bool Logar(Autenticavel funcionario, string senha)
        {
            if (senha == funcionario.Senha)
            {
                Console.WriteLine("Validado");
                return true;
            }
            else
            {
                Console.WriteLine("Deu ruim");
                return false;

            }
                
        }

    }
}
