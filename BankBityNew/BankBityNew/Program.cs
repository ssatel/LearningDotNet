using BankBityNew.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBityNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario carlos = new Funcionario(1);

            carlos.Salario = 1000;

            Console.WriteLine("Carlos Bonus: " + carlos.GetBonificacao());

            Console.ReadLine();


        }
    }
}
