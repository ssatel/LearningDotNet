
using System;
using ConsoleApp1.Entities; //para utilizar a class Order e outra que estão nesse name space
using ConsoleApp1.Entities.Enums; //para que o compilador ajude na semantica
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment //quanto utilizado enums o compilador nos ajuda com auto-complete

            };

            Console.WriteLine(order);

            //conversao de string para enumeracao e vice-versa

            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);

            //Enum.Parse<de_qual_enum>("texto_Enum"), deve ser exatamente igual ao definido no Enum para correto funcionamento
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);



     
        }
    }
}
