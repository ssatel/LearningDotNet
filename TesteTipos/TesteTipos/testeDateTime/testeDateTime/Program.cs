using System;
using System.Globalization;

namespace testeDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;

            Console.WriteLine("Hello World! - " + d1);
            Console.WriteLine(d1.Ticks); // 100 nanos segundos desde o dia 01 da era moderna :O

            //principais contrutores existem 12

            DateTime d2 = new DateTime(2020, 04, 22); //informando literalmente a data, criado na hora 0 do dia
            Console.WriteLine(d2);

            DateTime d3 = new DateTime(2020, 04, 22, 13, 44, 05); //ordem do construtor AAAA, MM, DD, HH, MM, ss
            Console.WriteLine(d3);

            DateTime d4 = new DateTime(2020, 04, 22, 13, 44, 05, 500); //ordem do construtor AAAA, MM, DD, HH, MM, ss, milisegundos
            Console.WriteLine(d4); //nesse caso os milisegundos não são impressos, não faz parte do toString da classe

            DateTime d5 = DateTime.Today;
            Console.WriteLine(d5); //diferente do now porque não mostra as horas

            DateTime d6 = DateTime.UtcNow;
            Console.WriteLine(d6); //horario de greenwich

            //utilizando o parse para construir datas
            DateTime d7 = DateTime.Parse("2000-08-15");
            Console.WriteLine(d7);

            d7 = DateTime.Parse("2000-08-15 14:03:05");
            Console.WriteLine(d7);

            d7 = DateTime.Parse("22/04/2020 14:05");
            Console.WriteLine(d7);

            DateTime d8 = DateTime.Parse("13:05");
            Console.WriteLine(d8);

            //parse exact - determinar o formato da data
            DateTime d9 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d9);                                        //usar , no lugar de ponto     

            DateTime d10 = DateTime.ParseExact("22/04/2020 14:11", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine(d10);



        }
    }
}
