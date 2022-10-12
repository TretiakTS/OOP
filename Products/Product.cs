using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    abstract public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string CountryOfOrigin { get; set; }
        public DateTime DatePackage { get; set; }
        public string Details { get; set; }
        public Product(string Name, decimal Price, string Country, DateTime DatePackage, string Details)
        {
            this.Name = Name;
            this.Price = Price;
            this.CountryOfOrigin = Country;
            this.DatePackage = DatePackage;
        }
        

    }

    class Groceries : Product
    {
        public DateTime ExpirationDate { get; set; }
        public int Quantity{ get; set; }
        public string Unit { get; set; }
        public Groceries(string Name, decimal Price, string Country, DateTime DatePackage, string Details, DateTime Expiration, int Quantity, string Unit) : 
            base(Name, Price, Country, DatePackage, Details) 
        {
            this.ExpirationDate = Expiration;
            this.Quantity = Quantity;
            this.Unit = Unit;
        }
        
    }

    class Book : Product
    {
        public int NumberOfPages { get; set; }
        public string PublishingHouse { get; set; }
        public string Authors { get; set; }
        public Book(string Name, decimal Price, string Country, DateTime DatePackage, string Details, int QuantityPages, string PublishingHouse, string Authors) :
            base(Name, Price, Country, DatePackage, Details)
        {
            this.NumberOfPages = QuantityPages;
            this.PublishingHouse = PublishingHouse;
            this.Authors = Authors;
        }
    }
}
