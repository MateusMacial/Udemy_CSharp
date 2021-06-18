using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Praticando_Classes_02
{
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

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
