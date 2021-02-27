using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTeste.Sistemas
{
    class SistemaInterno
    {
        public bool Logar(IAutenticavel usuario, string senha)
        {
            return usuario.Autenticar(senha);
        }

}
}
