using System.Globalization;

namespace Program_Product_Construtores.Entities
{
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;
        public Product()
        {
        }
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public double TotalStockValue()
        {
            return Price * Quantity;
        }

        public void AddProd(int quantityToAdd)
        {
            Quantity += quantityToAdd;
        }

        public void RemoveProd(int quantityToRemove)
        {
            Quantity -= quantityToRemove;
        }

        public override string ToString()
        {
            return Name + ", $" + Price + ", " + Quantity + ", " + " Total stock value: " + TotalStockValue().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
