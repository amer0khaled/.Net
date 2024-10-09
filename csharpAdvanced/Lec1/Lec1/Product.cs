using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec1
{
    internal class Product
    {
        private double price;
        private int stockQuantity;

        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            StockQuantity = stock;
        }
        public string Name { get; private set; }
        public double Price 
        { 
            get { return price; } 
            set 
            {
                if (value >= 0)
                    price = value;
            } 
        }
        public int StockQuantity 
        {
            get
            {
                return stockQuantity;
            }
            set
            {
                if (value >= 0)
                    stockQuantity = value;
            } 
        }

        public bool IsAvailable
        {
            get
            {
                return StockQuantity > 0;
            }
        }

        public void UpadateStock(int stock)
        {
            if (stock >= 0)
                StockQuantity += stock;
            else if (StockQuantity >= Math.Abs(stock))
                StockQuantity -= stock;
            else
                Console.WriteLine("Stock Quantity Not Enough\n");
        }


    }
}
