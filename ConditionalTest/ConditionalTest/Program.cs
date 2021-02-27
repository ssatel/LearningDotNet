using System;

namespace ConditionalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageJohn = 17;
            int numberPeople = 1;
            if (ageJohn >= 18)
            {
                Console.WriteLine("John is 18 years old or more, he may access");
            }
            else
            {
                if (numberPeople >= 2)
                {
                    Console.WriteLine("John isn´t 18 years old, but he doesn´t alone, so he may access");

                }
                else
                {
                    Console.WriteLine("Access Denied!!!");
                }

            }
            Console.ReadLine();
        }
    }
}
