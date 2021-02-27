using InterfaceTeste.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTeste.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }

        protected FuncionarioAutenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
