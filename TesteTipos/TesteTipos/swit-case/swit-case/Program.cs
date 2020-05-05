using System;

namespace swit_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x)
            {
                case 1:  day = "Sunday";    break;
                case 2:  day = "Monday";    break;
                case 3:  day = "Tuesday";   break;
                case 4:  day = "Wednesday"; break;
                case 5:  day = "Thursday";  break;
                case 6:  day = "Fryday";    break;
                case 7:  day = "Saturday";  break;
                default: day = "Invalid";   break;
            }

            Console.WriteLine(day);



            Console.WriteLine("Hello World!");
        }
    }
}
