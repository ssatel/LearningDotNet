using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Entities.Enums; //para utilizar o enum OrdemStatus, para que este se torne visivel


namespace ConsoleApp1.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString() //determinando o padrão para a saida ToString
        {
            return Id + ", " + Moment + ", " + Status ;

        }
    }
}
