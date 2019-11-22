using System;
using System.Collections.Generic;
using System.Text;

namespace TravelOffice
{
    class date
    {
        private int rok;
        private int miesiac;
        private int dzien;

        public int Rok { get => rok; set => rok = value; }
        public int Miesiac { get => miesiac; set => miesiac = value; }
        public int Dzien { get => dzien; set => dzien = value; }

        public date(int rok, int miesiac, int dzien)
        {
            this.rok = rok;
            this.miesiac = miesiac;
            this.dzien = dzien;
        }
        public String getinfo()
        {
            return ToString();

        }
        public override string ToString()
        {
            return $"{rok} {miesiac} {dzien}";
        }
       
    }
}
