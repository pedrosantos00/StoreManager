namespace StoreManager
{
    public class Address
    {

        public string City { get; set; }
        public string Country { get; set; }


        public Address()
        {

        }

        public Address(string city)
        {
            City = city;
        }

        public Address(string city, string country)
        {
            City = city;
            Country = country;
        }
    }
}