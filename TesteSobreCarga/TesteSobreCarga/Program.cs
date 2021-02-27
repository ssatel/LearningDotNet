using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteSobreCarga.Funcionarios;

namespace TesteSobreCarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Diretor carlos = new Diretor();
            carlos.Nome = "Carlos";
            carlos.Salario = 2000;

            Funcionario saulo = new Funcionario();

            saulo.Nome = "Saulo";
            saulo.Salario = 1300;

            GerenciadorBonificacao geral = new GerenciadorBonificacao();

            geral.Registrar(saulo);
            geral.Registrar(carlos);

            Console.WriteLine("Funcionario | Salario | Bônus ");
            Console.WriteLine(saulo.Nome + " | " + saulo.Salario + " | " + saulo.GetBonificacao());
            Console.WriteLine(carlos.Nome + " | " + carlos.Salario + " | " + carlos.GetBonificacao());
            Console.WriteLine("Total Bônus: " + geral.GetTotalBonificacao());
            


            Console.ReadLine();


        }
    }
}
