using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лб2
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = 02003;
            address.Country = "Ukraine";
            address.City = "Kyiv";
            address.Street = "Shevchenko";
            address.House = 35;
            address.Apartment = 45;
            Console.WriteLine($"{address.Index}, { address.Country},{address.City},{ address.Street}, { address.House},{ address.Apartment}");
            Console.ReadLine();
        }
    }
    class Address
    {
        private int index;
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
        private string country;
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        private string city;
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        private string street;
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        private int house;
        public int House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }
        private int apartment;
        public int Apartment
        {
            get
            {
                return apartment;
            }
            set
            {
                apartment = value;
            }
        }
    }
}
