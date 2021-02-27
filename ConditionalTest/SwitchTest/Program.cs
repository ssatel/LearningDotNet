using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = 5;
            string monthName = "None";
            switch (month)
            {
                case 1:
                    monthName = "January";
                    break;
                case 2:
                    monthName = "February";
                    break;
                case 3:
                    monthName = "March";
                    break;
                case 4:
                    monthName = "April";
                    break;
                default:
                    monthName = "Incorret Data!";
                    break;
            }
            Console.WriteLine("Selected month is " + monthName);

            Console.ReadLine();
        }
    }
}
