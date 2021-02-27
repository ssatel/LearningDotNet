using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BityBank
{
    public class Cliente
    {
        private string _cpf;
        public string Nome { get; set; }
        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                //validar cpf
                if (value != null && value == "" )
                {
                    _cpf = value;
                }
                
            }
        }
        public string Profissao { get; set; }
        
    }
}
