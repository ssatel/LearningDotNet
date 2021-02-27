using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BityBankVer0911
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(0, 0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Excecao argumentException");
                Console.WriteLine(ex.ParamName);
                Console.WriteLine(ex.Message);
                
            }

            Console.WriteLine("e isso é tudo pessoal");
            Console.ReadLine();
            

        }
    }
}
