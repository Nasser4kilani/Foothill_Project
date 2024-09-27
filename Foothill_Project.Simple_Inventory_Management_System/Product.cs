using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foothill_Project.Simple_Inventory_Management_System
{
    public class Product
    {
        private string Name;
        private int Price;
        private int Quantity;

        public string Name1
        {
            set
            {
                Name = value;
            }
            get
            {
                return Name;
            }
        }
        public int Price1
        {
            set
            {
                if (Price < 0)
                {
                    Price = 0;
                }
                else
                    Price = value;
            }
            get
            {
                return Price;
            }
        }
        public int Quantity1
        {
            set
            {
                if (Quantity < 0)
                {
                    Quantity = 0;
                }
                else 
                    Quantity = value;
            }
            get 
            {
                return Quantity;
            }
        }
        public Product(string name, int price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }
    }
}
