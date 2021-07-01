using System.Globalization;

namespace Program_Product_Construtores.Entities
{
    class Product
    {
        private string _name;
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Product()
        {
        }
        public Product(string name, double price, int quantity)
        {
            _name = name;
            Price = price;
            Quantity = quantity;
        }
        public Product(string name, double price)
        {
            _name = name;
            Price = price;
        }
        
        public string Name
        {
            get { return _name; }
            set {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
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
            return _name + ", $" + Price + ", " + Quantity + ", " + " Total stock value: " + TotalStockValue().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
