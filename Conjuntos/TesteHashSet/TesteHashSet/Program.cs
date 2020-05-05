using System;
using System.Collections.Generic;

namespace TesteHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>(); // conjunto de elementos mais performaticos
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            A.Add(9); //Não permiti incluir um elemento que ja existe

            B.Add(3);
            B.Add(4);
            B.Add(5);

            B.Remove(4);

            Console.WriteLine("Elementos conjunto A: ");
            foreach (int x in A)
            {
                Console.WriteLine("=> " + x);
            }
            Console.WriteLine("Elementos conjunto B:");
            foreach (int x in B)
            {
                Console.WriteLine("=> " + x);
            }

            Console.WriteLine("Digite um valor inteiro: ");

            int N = int.Parse(Console.ReadLine());

            if (B.Contains(N))
            {
                Console.WriteLine(N + " pertence ao conjunto B");
            }
            else
            {
                if (A.Contains(N))
                {
                    Console.WriteLine(N + "pertence ao conjunto A");
                }
                else
                {
                    Console.WriteLine(N + " não pertece a nenhum conjunto.");
                }
            }

            A.ExceptWith(B);

            Console.WriteLine("Uniao dos conjuntos A e B");
            foreach (int x in A)
            {
                Console.WriteLine("=>" + x);
            }

            B.ExceptWith(A);
            Console.WriteLine("Uniao dos conjuntos B e A");
            foreach (int x in B)
            {
                Console.WriteLine("=>" + x);
            }

            A.IntersectWith(B);
            Console.WriteLine("Intercsessão dos conjuntos A e B");
            foreach (int x in A)
            {
                Console.WriteLine("=>" + x);
            }

            B.IntersectWith(A);
            Console.WriteLine("Intercsessão dos conjuntos B e A");
            foreach (int x in B)
            {
                Console.WriteLine("=>" + x);
            }




        }
    }
}
