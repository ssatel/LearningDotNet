using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestes2.Sistemas
{
    class SistemaInterno
    {
        public void Logar (IAutenticavel usuario, string senha)
        {
            if (usuario.Autenticar(senha))
            {
                Console.WriteLine("Sucesso!!");
            }
            else
            {
                Console.WriteLine("Fracassou!!");
            }
                
        }
    }
}
