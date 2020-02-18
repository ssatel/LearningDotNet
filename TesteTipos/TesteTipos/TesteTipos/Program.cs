using System; // entrada das dependencias
using System.Globalization; // permitir utilizar invariantculter, trocar ponto por virla no separador

namespace ConsoleApplication2 // somente para organizar o arquivo
{
    class Program // Classe utilizar Pascal Case
    {
        static void Main(string[] args) // entry point do programa
        {

            double x = 10.35784; // maior que float que é o tipo primitivo
            int y = 32; 
            string z = "Maria"; //string é um tipo contruido
            char w = 'F'; //tipoprimitigo 

            Console.Write("Olá mundo!"); // o line a linha não é quebrada
            Console.WriteLine("Bom dia!"); // line no fim do comando quebra a linha
            Console.WriteLine("Até mais.");

            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2")); //F2 determinar que o float sera arredondado em duas casas
            Console.WriteLine(x.ToString("F4")); // arredondamento em duas casas
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture)); // arredondamento em duas casas com virvula no lugar do ponto

            Console.WriteLine();
            Console.WriteLine("RESULTADO = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais"); //Concatenação 
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");

            Console.WriteLine();
            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);

            Console.ReadLine();
        }
    }
}