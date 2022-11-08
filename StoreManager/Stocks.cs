using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager
{
    public class Stocks
    {
        public string StockName { get; set; }
        public IList<Products> Product { get; set; }
        public int Quantity { get; set; }
        public ProductType Category { get; set; }

        public Stocks()
        {
            this.Product = new List<Products>();
            this.Quantity = 0;
        }

        public Stocks(string name)
        {
            this.StockName = name;
            this.Product = new List<Products>();
            this.Quantity = 0;
        }

        public Stocks(string name, int quantity)
        {
            this.StockName = name;
            this.Product = new List<Products>();
            this.Quantity = quantity;
        }

        public Stocks(Products product, int quantity)
        {
            this.Product = new List<Products>();
            this.Quantity = quantity;
        }

        public void AddProduct(Products product, int quantity)
        {
            this.Product.Add(product);
            this.Quantity = quantity;
        }

        public void ChangeStockQuantity(int quantity)
        {
            this.Quantity = quantity;
        }

        public void RemoveProduct(Stocks stock, Products product)
        {
            this.Product.Remove(product);
        }

        public void AddCategory(ProductType productType)
        {
            this.Category = productType;
        }

    }
}
