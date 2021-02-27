using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteConstrutores.Funcionarios;

namespace TesteConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadoBonus gerenciador = new GerenciadoBonus();
            Funcionario pessoa = new Auxiliar("123.456.789.12");
            pessoa.Nome = "Pedro";
            gerenciador.Registrar(pessoa);
            Diretor pessoa1 = new Diretor("123.654.987-98");
            pessoa1.Nome = "João";
            gerenciador.Registrar(pessoa1);
            Console.WriteLine("Funcioario / Salario / Bonus ");
            Console.WriteLine(pessoa.Nome + " / " + pessoa.Salario + " / " + pessoa.GetBonus());
            Console.WriteLine(pessoa1.Nome + " / " + pessoa1.Salario + " / " + pessoa1.GetBonus());
            Console.WriteLine("Total Bonus: ");
            Console.WriteLine(gerenciador.getTotalBonus());
            
            pessoa.AumentarSalario();
            pessoa1.AumentarSalario();
            GerenciadoBonus newgerenciador = new GerenciadoBonus();

            newgerenciador.Registrar(pessoa);
            newgerenciador.Registrar(pessoa1);

            Console.WriteLine("Apos aumentar salarios");
            Console.WriteLine("Funcioario / Salario / Bonus ");
            Console.WriteLine(pessoa.Nome + " / " + pessoa.Salario + " / " + pessoa.GetBonus());
            Console.WriteLine(pessoa1.Nome + " / " + pessoa1.Salario + " / " + pessoa1.GetBonus());
            Console.WriteLine("Total Bonus: ");
            Console.WriteLine(newgerenciador.getTotalBonus());

            InformacoesGerais();

            Funcionario alex = new Auxiliar("7946.31254");
            alex.Nome = "Alex";
            newgerenciador.Registrar(alex);

            Funcionario katia = new Designer("985.652.125.");
            katia.Nome = "katia";
            newgerenciador.Registrar(katia);

            Funcionario fernando = new Diretor("654987321");
            fernando.Nome = "Fernando";
            newgerenciador.Registrar(fernando);

            Funcionario mario = new GerenteConta("987654321");
            mario.Nome = "Mario";
            newgerenciador.Registrar(mario);

            Console.WriteLine("Funcionario / Salario Base / Bonus ");
            Console.WriteLine("Diretor: " + fernando.Nome + " / " + fernando.Salario + " / " + fernando.GetBonus());
            Console.WriteLine("Designer: " + katia.Nome + " / " + katia.Salario + " / " + katia.GetBonus());
            Console.WriteLine("Gerente: " + mario.Nome + " / " + mario.Salario + " / " + mario.GetBonus());
            Console.WriteLine("Auxiliar: " + alex.Nome + " / " + alex.Salario + " / " + alex.GetBonus());

            Console.WriteLine("Total Bonus: " + newgerenciador.getTotalBonus());

            InformacoesGerais();

            mario.AumentarSalario();
            katia.AumentarSalario();
            fernando.AumentarSalario();
            alex.AumentarSalario();

            Console.WriteLine("Apos aumentar o Salario");

            Console.WriteLine("Funcionario / Salario Base / Bonus ");
            Console.WriteLine("Diretor: " + fernando.Nome + " / " + fernando.Salario + " / " + fernando.GetBonus());
            Console.WriteLine("Designer: " + katia.Nome + " / " + katia.Salario + " / " + katia.GetBonus());
            Console.WriteLine("Gerente: " + mario.Nome + " / " + mario.Salario + " / " + mario.GetBonus());
            Console.WriteLine("Auxiliar: " + alex.Nome + " / " + alex.Salario + " / " + alex.GetBonus());

            Console.WriteLine("Total Bonus: " + newgerenciador.getTotalBonus());

            InformacoesGerais();

            Desenvolvedor gui = new Desenvolvedor("159.621.841-89");
            gui.Nome = "Guilherme";

            Console.WriteLine("Guilher Salario: " + gui.Salario + "Bonus: " + gui.GetBonus());

            InformacoesGerais();






        }
        public static void InformacoesGerais()
        {
            
            Console.WriteLine("Total funcionarios: ");
            Console.WriteLine(Funcionario.TotalFuncionarios);
            Console.ReadLine();

        }
    }
}
