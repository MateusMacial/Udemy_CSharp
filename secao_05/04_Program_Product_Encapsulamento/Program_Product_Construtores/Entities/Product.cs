using System.Globalization;

namespace Program_Product_Construtores.Entities
{
    class Product
    {
        private string _name;
        private double _price;
        private int _quantity;
        public Product()
        {
        }
        public Product(string name, double price, int quantity)
        {
            _name = name;
            _price = price;
            _quantity = quantity;
        }
        public Product(string name, double price)
        {
            _name = name;
            _price = price;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName( string name)
        {
            if(name != null && name.Length > 1)
            {
                _name = name;
            }
        }

        public double GetPrice()
        {
            return _price;
        }

        public int GetQuantity()
        {
            return _quantity;
        }

        public double TotalStockValue()
        {
            return _price * _quantity;
        }

        public void AddProd(int quantityToAdd)
        {
            _quantity += quantityToAdd;
        }

        public void RemoveProd(int quantityToRemove)
        {
            _quantity -= quantityToRemove;
        }

        public override string ToString()
        {
            return _name + ", $" + _price + ", " + _quantity + ", " + " Total stock value: " + TotalStockValue().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
