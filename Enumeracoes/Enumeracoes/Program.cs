using System;
using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;

namespace Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1012,
                Moment = DateTime.Now,
                Status = OrderStatus.Shipped
            };

            Console.WriteLine(order);

            string os = OrderStatus.Processing.ToString();
            OrderStatus os1 = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.WriteLine(os);
            Console.WriteLine(os1);

        }
    }
}
