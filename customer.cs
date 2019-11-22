using System;
using System.Collections.Generic;
using System.Text;

namespace TravelOffice
{
    class customer
    {
        private string name;
        private trip Trip;
        private address Adress;

        public string Name { get => name; set => name = value; }
        public trip Trip1 { get => Trip; set => Trip = value; }
        public address Adress1 { get => Adress; set => Adress = value; }
        public customer(String name)
        {
            this.name = name;
        }
        public void setAddress(address Adres)
        {
            this.Adress = Adres;
        }
        public void setTrip(trip Trip)
        {
            this.Trip = Trip;
        }
        public string getinfo()
        {
            return ToString();
        }
        public override string ToString()
        {
            return $"Nazwa {name} \n {Trip.getinfo()} \n {Adress.getinfo()}"; 
        }

    }
}
