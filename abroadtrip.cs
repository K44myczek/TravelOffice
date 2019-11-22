using System;
using System.Collections.Generic;
using System.Text;

namespace TravelOffice
{
    class abroadtrip : trip
    {
        public abroadtrip(date start, date end, string destination) : base(start, end, destination)
        {
            
        }
        private double insurance;

        public double Insurance { get => insurance; set => insurance = value; }
        public void gInsuarance(double insurance)
        {
            this.insurance = insurance;
        }
        public void gPrice()
        {
            base.Price += insurance;
        }
    }
}
