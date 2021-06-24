using System;
using Enumeracao_Composicao.Entities.Enums;
using System.Collections.Generic;
using System.Text;

namespace Enumeracao_Composicao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Orderitems { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem orderItem)
        {
            Orderitems.Add(orderItem);
        }
        public void RemoveItem(OrderItem orderItem)
        {
            Orderitems.Remove(orderItem);
        }

        public double Total()
        {
            double sum = 0.0;

            foreach(OrderItem orderItem in Orderitems)
            {
                sum += orderItem.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ORDER Moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client.Name + " " + Client.BirhtDate.ToString("dd/MM/yyyy") + " - " + Client.Email);
            sb.AppendLine("Order items: ");
            foreach(OrderItem orderItem in Orderitems)
            {
                sb.AppendLine(orderItem.Product.Name + ", $" + orderItem.Product.Price + ", Quantity: " + orderItem.Quantity + ", Subtotal: $"+ orderItem.SubTotal());
            }
            sb.AppendLine("Total price: $" + Total());

            return sb.ToString();
        }
    }
}
