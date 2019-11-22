using System;
using System.Collections.Generic;
using System.Text;

namespace TravelOffice
{
    class domestictrip : trip
    {
        public domestictrip(date start, date end, string destination):base(start,end,destination)
        {


        }
        private double ownArrivalDiscount;

        public double OwnArrivalDiscount {set => ownArrivalDiscount = value; }
        public void getOwnArrival(double ownArrivalDiscount)
        {
            this.ownArrivalDiscount = ownArrivalDiscount;
        }
        public void  gPrice()
        {
           base.Price= base.Price - ownArrivalDiscount;
        }
        
    }
}
