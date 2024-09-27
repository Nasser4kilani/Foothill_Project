using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foothill_Project.Simple_Inventory_Management_System
{
    public class Inventory
    {
        public Inventory() { }
        List<Product> products = new List<Product>();
        public void AddProduct(string name, int price, int quantity)
        {
            Product product = new Product(name, price, quantity);
            products.Append(product);
        }
        public void RemoveProduct(string name)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Name1 == name)
                {
                    products.RemoveAt(i);
                }
            }
        }
        
    }
}
