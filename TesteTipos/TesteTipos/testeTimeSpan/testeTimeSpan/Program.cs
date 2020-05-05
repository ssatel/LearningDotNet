using System;

namespace testeTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // representa duracao, duracao em ticks 100 nanos segundos = 1 tick, uso para calculo de duração, multas juros e etc
            TimeSpan t1 = new TimeSpan(0, 1, 30); //HH, mm, ss
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            //construtores vazio
            TimeSpan t2 = new TimeSpan();
            Console.WriteLine(t2);

            TimeSpan t3 = new TimeSpan(900000000L); //passando ticks
            Console.WriteLine(t3);

            //passando, dias, horas, minutos e segundos
            TimeSpan t4 = new TimeSpan(1,4,5,0); //passando ticks
            Console.WriteLine(t4);

            //passando, dias, horas, minutos, segundos e milsegundos
            TimeSpan t5 = new TimeSpan(1, 4, 5, 0, 100); //passando ticks
            Console.WriteLine(t5);

            //utilizando o metodo from
            TimeSpan t6 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t6);

            t6 = TimeSpan.FromHours(1.5); 
            Console.WriteLine(t6);

            t6 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(t6);

            t6 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine(t6);

            t6 = TimeSpan.FromMilliseconds(1.5);
            Console.WriteLine(t6);

            t6 = TimeSpan.FromTicks(900000000l);
            Console.WriteLine(t6);

        }
    }
}
