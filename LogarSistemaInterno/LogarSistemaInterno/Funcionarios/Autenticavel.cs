using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogarSistemaInterno.Funcionarios
{
    public abstract class Autenticavel : Funcionario
    {
        public string Senha { get; set; }
        protected Autenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }
    }
}
