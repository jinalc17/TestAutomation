using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public Product(int productId, string productName, decimal price, int stock)
        {
            ProductID = productId;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        public void IncreaseStock(int amount)
        {
            Stock += amount;

            if (Stock > 600000)
            {
                Stock = 600000;
            }

        }

        public void DecreaseStock(int amount)
        {
            Stock -= amount;
            if (Stock < 6)
            {
                Stock = 6;
            }

        }

        public string ValidateProduct()
        {
            string result = "Valid Product.";

            if (ProductID < 6 || ProductID > 60000)
            {
                result = "Product ID is Invalid.";
            }
            else if (Price < 6 || Price > 6000)
            {
                result = "Price is Invalid.";
            }
            else if (Stock < 6 || Stock > 600000)
            {
                result = "Stock is Invalid.";
            }
            return result;
        }
    }
}
