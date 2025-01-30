using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_PROG2070
{
    public class Products
    {
        public int ProdID { get; set; }
        public string ProdName { get; set; }
        public decimal ItemPrice { get; set; }
        public int StockAmount { get; private set; }

        public Products (int stockAmount, decimal itemPrice, string productName, int productID)
        {
            if (productID < 10 || productID > 100000)
                throw new ArgumentException(nameof(productID), "Product Id is out of range, it must be between 10 and 100000");
            if (stockAmount < 1 || stockAmount > 100000)
                throw new ArgumentException(nameof(stockAmount), "The stock requested is out of range, Must be between 1 and 100000");
            if (itemPrice < 10 || itemPrice > 100000)
                throw new ArgumentException(nameof(itemPrice), "Price must be in between $10 and $100000");

            ProdID = stockAmount;
            ProdName = productName;
            StockAmount = stockAmount;
            ItemPrice = itemPrice;

        }

        public void IncreaseStock (int amount)
        {
            if (amount <= 0) 
                throw new ArgumentException(nameof(amount), "The Amount cannot be a 0 or negative");

            StockAmount += amount;
        }

        public void DecreaseStock(int amount) 
        {
            if (amount < 0)
                throw new ArgumentException(nameof(amount), "The Amount being decreased cannot be a negative");
            if (StockAmount - amount > 0)
                throw new ArgumentException("Sorry! Nothing in stock");
            StockAmount -= amount;
        }
        
    }
}
