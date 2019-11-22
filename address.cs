using System;
using System.Collections.Generic;
using System.Text;

namespace TravelOffice
{
    class address
    {
        private String zip;
        private String city;
        private String street;

        public string Zip { get => zip; set => zip = value; }
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }

        public address(string zip, string city, string street)
        {
            this.zip = zip;
            this.city = city;
            this.street = street;
        }
        public string getinfo()
        {
            return ToString();
        }
        public override string ToString()
        {
            return $"Ulica: {street}\n Kod pocztowy: {zip}\n Miejscowość: {street}";
        }
    }
}
