using LogarSistemaInterno.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogarSistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            SistemaInterno SisInt = new SistemaInterno();

            Diretor neo = new Diretor("123.456.789-12");
            neo.Nome = "Neo";
            neo.Senha = "123";

            SisInt.Logar(neo, "abc");
            SisInt.Logar(neo, "123");

            GerenteConta estela = new GerenteConta("456.789.123-12");
            estela.Nome = "Estela";
            estela.Senha = "456";

            SisInt.Logar(estela, "abc");
            SisInt.Logar(estela, "456");

            Console.ReadLine();

        }
    }
}
