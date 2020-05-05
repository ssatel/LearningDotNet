using System;

namespace stringtestes
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abc HGFJI ABC abc DEFG    ";

            string s1 = original.ToUpper(); // todos em UPPER CASE

            string s2 = original.ToLower(); // todos em lower case

            string s3 = original.Trim(); // remove espaços no inicio e no fim da string

            int n1 = original.IndexOf("AB"); // indica a posição da primeira ocorrencia de string informada

            int n2 = original.LastIndexOf("bc"); //indica a posição da ultima ocorrencia de string informada

            string s4 = original.Substring(3); // indica o inicio 

            string s5 = original.Substring(3, 5); //recortar a string do inicio com 5 caracteres

            string s6 = original.Replace('a', 'x'); //trocar um caracter

            string s7 = original.Replace("ab", "xxzz"); //trocar uma sequencia pela outra, não precisa ser a mesma quantidade de carater

            string s8 = "  "; 

            bool b1 = string.IsNullOrEmpty(original); //interessante para validar formulario verificar se usuario digitou todos os campos
            bool b2 = string.IsNullOrWhiteSpace(s8); // verificar se é nulo ou somente espaços em branco


            Console.WriteLine(original);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(original.Length.ToString());
            Console.WriteLine(s3.Length.ToString());
            Console.WriteLine(n1.ToString());
            Console.WriteLine(n2.ToString());
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
            Console.WriteLine(b1);
            Console.WriteLine(b2);


        }
    }
}
