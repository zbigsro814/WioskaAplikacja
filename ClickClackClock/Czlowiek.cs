using System;
using System.Collections.Generic;
using System.Text;

namespace ClickClackClock
{
    public class Czlowiek
    {
        public int ilosc_Ludzi;
        public int ilosc;
        public int ilosc_potencjalnych;
        public int zbieraczy = 0;
        public int lowcy = 0;
        public int budowlancy = 0;
        public int zwiadowcy = 0;
        public int drwale = 0;
        public int kamien = 0;
        public int populacja = 0;

        public Czlowiek(int ilosc)
        {
            this.ilosc_Ludzi = ilosc;
            this.ilosc = ilosc;
            this.ilosc_potencjalnych = ilosc;
        }
    }
}