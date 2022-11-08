using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager
{
    public class Store
    {

        //Basic Data
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string SocialNumber { get; set; }
        public DateTime StartDate { get; set; }
        public Address Adress { get; set; }

        //Social Data
        public decimal PhoneNumber { get; set; }
        public string Email { get; set; }

        //Stock manager
        public IList<Stocks> Stock { get; set; }

        public Store()
        {
            this.Adress = new Address();
            this.Stock = new List<Stocks>();
        }

        public Store(string companyName, string socialNumber, DateTime startDate, Address adress, decimal phoneNumber, string email)
        {
            this.CompanyName = companyName;
            this.SocialNumber = socialNumber;
            this.StartDate = startDate;
            this.Adress = adress;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Stock = new List<Stocks>();
        }

        public Store(int id, string companyName, string socialNumber, DateTime startDate, Address adress, decimal phoneNumber, string email, Stocks stock)
        {
            this.Id = id;
            this.CompanyName = companyName;
            this.SocialNumber = socialNumber;
            this.StartDate = startDate;
            this.Adress = adress;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Stock = new List<Stocks>();
        }

        public void AddStock(Stocks stock, string stockName)
        {
            stock = new Stocks(stockName);
        }

        public void RemoveStock(Stocks stock)
        {
            this.Stock.Remove(stock);
        }

        public void ListStocks()
        {
            Console.WriteLine($"Company: {this.CompanyName}");
            foreach (Stocks stock in this.Stock)
            {
                Console.WriteLine($"\t+Stock: {stock.StockName}");
                foreach (Products product in stock.Product)
                {
                    Console.WriteLine($"\t Prodcut Name - {product.Name}\n" +
                        $"\t  Price - {product.Price.ToString("0.00")} Euros \n" +
                        $"\t   Quantity - {stock.Quantity} UN");
                }
            }
        }

        public static void ListStores(IList<Store> type)
        {
            foreach (Store store in type)
            {
                Console.WriteLine($"{store.CompanyName} : \n" +
                    $"\tSocial Number: {store.SocialNumber} \n" +
                    $"\tStarted Date: {store.StartDate.ToString("d")}\n" +
                    $"\tAdress: {store.Adress.City}, {store.Adress.Country}\n" +
                    $"\tPhone Number: {store.PhoneNumber} Email : {store.Email}\n");

            }
        }

        public void ChangeAdress(string city, string country)
        {
            if (city != "" && city != null)
                this.Adress.City = city;
            if (country != "" && country != null)
                this.Adress.Country = country;
        }

    }
}
