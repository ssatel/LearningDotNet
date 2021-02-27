using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteHeranca.Funcionarios;

namespace TesteHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario pedro = new Funcionario();

            GerenciadorBonus gerenciador = new GerenciadorBonus();

            pedro.Nome = "Pedro";
            pedro.CPF = "456.789.123.78";
            pedro.Salario = 2000;

            gerenciador.Registrar(pedro);

            Funcionario sandra = new Diretor();

            sandra.Nome = "Sandra";
            sandra.CPF = "987.654.987-89";
            sandra.Salario = 4500;

            gerenciador.Registrar(sandra);

            Console.WriteLine("Funcionario => Salarios => Bonus");
            Console.WriteLine(pedro.Nome + " => " + pedro.Salario + " => " + pedro.GetBonificacao());
            Console.WriteLine(sandra.Nome + " => " + sandra.Salario + " => " + sandra.GetBonificacao());
            Console.WriteLine("Total Bonus: " + gerenciador.GetBonusTotal());


            Console.ReadLine();

        }
    }
}
