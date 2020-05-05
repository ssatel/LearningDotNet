using System;

namespace testeOperacoesTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TimeSpan t1 = TimeSpan.MaxValue; // maior valor possivel em um objeto timeSpan
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero; // Com duração zero

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            TimeSpan t4 = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine(t4);

            Console.WriteLine("Days.............: " + t4.Days);
            Console.WriteLine("Hours............: " + t4.Hours);
            Console.WriteLine("Minutes..........: " + t4.Minutes);
            Console.WriteLine("Milliseconds.....: " + t4.Milliseconds);
            Console.WriteLine("Seconds..........: " + t4.Seconds);
            Console.WriteLine("Ticks............: " + t4.Ticks);
            Console.WriteLine("TotalDays........: " + t4.TotalDays);
            Console.WriteLine("TotalHours.......: " + t4.TotalHours);
            Console.WriteLine("TotalMinutes.....: " + t4.TotalMinutes);
            Console.WriteLine("TotalSeconds.....: " + t4.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t4.TotalMilliseconds);

            Console.WriteLine("--------------------OPERACOES----------------------");

            TimeSpan t5 = new TimeSpan(1, 30, 10);
            TimeSpan t6 = new TimeSpan(0, 30, 5);

            TimeSpan sum  = t5.Add(t6);
            TimeSpan dif  = t5.Subtract(t6);
            TimeSpan mult = t5.Multiply(2.0);
            TimeSpan div  = t5.Divide(2.0);


            Console.WriteLine("t5  :" + t5);
            Console.WriteLine("t6  :" + t6);
            Console.WriteLine("tot :" + sum);
            Console.WriteLine("dif :" + dif);
            Console.WriteLine("mult:" + mult);
            Console.WriteLine("div:"  + div);




        }
    }
}
