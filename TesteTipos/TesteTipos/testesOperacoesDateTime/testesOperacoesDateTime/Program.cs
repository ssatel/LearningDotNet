using System;

namespace testesOperacoesDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DateTime d = new DateTime(2020, 04, 22, 15, 03, 00, 100);
            Console.WriteLine(d);
            Console.WriteLine("01) Date.......: " + d.Date);
            Console.WriteLine("02) Day........: " + d.Day);
            Console.WriteLine("03) DayOfWeek..: " + d.DayOfWeek);
            Console.WriteLine("04) DayOfYear..: " + d.DayOfYear);
            Console.WriteLine("05) Hour.......: " + d.Hour);
            Console.WriteLine("06) Kind.......: " + d.Kind); // hora local ou universal
            Console.WriteLine("07) Millisecond: " + d.Millisecond);
            Console.WriteLine("08) Minute.....: " + d.Minute);
            Console.WriteLine("09) Month......: " + d.Month);
            Console.WriteLine("10) Second.....: " + d.Second);
            Console.WriteLine("11) Ticks......: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay..: " + d.TimeOfDay);
            Console.WriteLine("13) Year.......: " + d.Year);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("toLongDateString.: " + d.ToLongDateString()); // converte a data para uma string, utiliza o formato e idioma do S.O
            Console.WriteLine("toLongTimeString.: " + d.ToLongTimeString());
            Console.WriteLine("toShortDateString: " + d.ToShortDateString());
            Console.WriteLine("toShortTimeString: " + d.ToShortTimeString());
            Console.WriteLine("toString.........: " + d.ToString());
            Console.WriteLine("toString1........: " + d.ToString("yyyy-MM-dd HH:mm:ss")); // permite formatar 
            Console.WriteLine("toString2........: " + d.ToString("yyyy-MM-dd HH:mm:ss.fff")); // permite formatar, onde fff são os milisegundos

            Console.WriteLine("-----------------OPERACÕES-----------------");
            //util para operacoes com calculos de datas por exemplo
            DateTime d1 = d.AddHours(2);

            Console.WriteLine("Original : " + d.ToString());
            Console.WriteLine("Apos addHours : " + d1.ToString());

            d1 = d.AddMinutes(3);
            Console.WriteLine("Apos addMinutes : " + d1.ToString());

            d1 = d.AddDays(3);
            Console.WriteLine("Apos addDays : " + d1.ToString());

            TimeSpan t = d1.Subtract(d); // data final menos a data inicial

            Console.WriteLine("Substract diferença entre datas : " + t.ToString());







        }
    }
}
