using InterfaceTeste.Funcionarios;
using InterfaceTeste.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            Diretor diretor = new Diretor("123.456.789");
            diretor.Nome = "Saulo";
            diretor.Senha = "123";



            SistemaInterno sistema = new SistemaInterno();

            if(sistema.Logar(diretor, "23"))
            {
                Console.WriteLine("Sucesso !!");
            }
            else
            {
                Console.WriteLine("Deu Ruim!");
            }

            Console.WriteLine("Parceiro Comercial");

            ParceiroComercial comercial = new ParceiroComercial();

            comercial.Senha = "123456";

            if (sistema.Logar(comercial, "123456"))
            {
                Console.WriteLine("Sucesso !!");
            }
            else
            {
                Console.WriteLine("Deu Ruim!");
            }


            Console.ReadLine();
        }
    }
}
