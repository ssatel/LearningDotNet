using InterfaceTestes2.Funcionarios;
using InterfaceTestes2.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Diretor usuario = new Diretor("123.456.789-12");
            usuario.Nome = "Saulo";
            usuario.Senha = "123";

            ParceiroComercial com = new ParceiroComercial();

            com.Senha = "abc";

            SistemaInterno SisInt = new SistemaInterno();

            SisInt.Logar(usuario, "456");

            SisInt.Logar(com, "abc");

            Console.ReadLine();

        }
    }
}
