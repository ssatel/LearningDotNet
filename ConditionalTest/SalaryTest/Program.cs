using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = 3751.01;
            double deduction = 0;

            if (salary < 1900)
            {
                Console.WriteLine("Congratulations your gain not enought to tax! Don´t worry about it");
            }
            else
            {
                if (salary <= 2800)
                {
                    deduction = 142;

                }
                else
                {
                    if (salary <= 3751)
                    {
                        deduction = 350;
                    }
                    else
                    {
                        deduction = 636;
                    }

                }
            }
            Console.WriteLine("Now you can use deduction on tax :" + deduction);

            Console.ReadLine();
        }
    }
}
