using System;
using System.Collections.Generic;
using System.Text;

namespace TravelOffice
{
    class trip
    {
        private String destination;
        private date end;
        private date start;
        private double price;
        


        public string Destination { get => destination; set => destination = value; }
        public date End { get => end; set => end = value; }
        public date Start { get => start; set => start = value; }
        public double Price { get => price; set => price = value; }

        public trip(date start, date end, string destination)
        {
            this.start = start;
            this.end = end;
            this.destination = destination;
        }
        public void prizeoftrip(double price)
        {
            this.price = price;
        }
        public String getinfo()
        {
            return ToString();
        }
        public override string ToString()
        {
            return $"Data początkowa {start.getinfo()} \n Data końcowa {end.getinfo()}\nCena wynosi: {price}";
        }
    }
}
