using System;

namespace StoreManager
{
    internal class Program
    {
        public static IList<Store> Stores = new List<Store>();
        public static void Main(string[] args)
        {
            // Load Stocks
            LoadStores();
            LoadStockExamples(Stores[0]);
            LoadStockExamples(Stores[0]);
            Stores[0].ListStocks();
            Store.ListStores(Stores);
        }
        public static void CreateCompany()
        {
            DateTime date = new DateTime();
            Console.Write("Companys name -> ");
            string? companyName = Console.ReadLine();
            Console.Write("Social Number -> ");
            string? socialNumber = Console.ReadLine();
            Console.Write("Start Date [YEAR-MONTH-DAY] ex: 2000-01-01 -> ");
            date = DateTime.Parse(Console.ReadLine());
            Console.Write("Phone number -> ");
            decimal phoneNumber = decimal.Parse(Console.ReadLine());
            Console.Write("Email -> ");
            string email = Console.ReadLine();
            Console.Write("City -> ");
            string city = Console.ReadLine();
            Console.Write("Country -> ");
            string country = Console.ReadLine();

            Store newStore = new Store(companyName, socialNumber, date, new(city, country), phoneNumber, email);
            Stores.Add(newStore);
        }

        public static void LoadStores()
        {
            Store StarBucks = new Store("Starbucks", "532532", DateTime.Parse("2000-02-02"), new("Lisboa", "Portugal"), 412412, "@gamil");
            Store McDonalds = new Store("McDonalds", "532532", DateTime.Parse("2000-02-02"), new("Lisboa", "Portugal"), 412412, "@gamil");
            Store Chimarrao = new Store("Chimarrão", "532532", DateTime.Parse("2000-02-02"), new("Lisboa", "Portugal"), 412412, "@gamil");
            Store Portugalia = new Store("Portugália", "532532", DateTime.Parse("2000-02-02"), new("Lisboa", "Portugal"), 412412, "@gamil");
            Stores.Add(StarBucks);
            Stores.Add(McDonalds);
            Stores.Add(Chimarrao);
            Stores.Add(Portugalia);
        }
        public static void LoadStockExamples(Store store)
        {
            Stocks apples = new Stocks("Apples");
            apples.Category = ProductType.Fruits;
            store.Stock.Add(apples);
            LoadProductExample(store, apples);
        }

        public static void LoadProductExample(Store store, Stocks stock)
        {
            Products apple = new Products();
            apple.Name = "Maçã";
            apple.Price = 0.20;
            stock.AddProduct(apple,20);
        }
    }
}