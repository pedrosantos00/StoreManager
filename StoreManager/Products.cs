using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager
{
    public class Products
    {
        public string Name {get;set;}
        public double Price { get; set; }
        public Products()
        {
        }

        public Products(string nome, double price)
        {
            this.Name = nome;
            this.Price = price;
        }

        public void ChangePrice( double newPrice)
        {
            this.Price = newPrice;
        }

    }
}
