using System;
using Enumeracao_Composicao.Entities;
using Enumeracao_Composicao.Entities.Enums;
using System.Globalization;

namespace Enumeracao_Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(
                    name,
                    email,
                    birthDate
                );


            Console.WriteLine("Enter order data: ");

            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            Order order = new Order(
                    DateTime.Now,
                    orderStatus,
                    client
                );

            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Enter #" + (i+1) + " item data: ");

                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(
                        productName,
                        productPrice
                    );

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(
                        quantity,
                        productPrice,
                        product
                    );

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);

        }
    }
}
