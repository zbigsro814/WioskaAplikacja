using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ClickClackClock
{
    interface IProdukcja_obliczenia
    {
        void Oblicz_produkcje(int ilosc_ludzi);
        void Oblicz_zapotrzebowanie(int ilosc_ludzi);
        void Ilosc_calkowita();
    }

    //--------------------------------------------------------------------------------------------
    class Produkcja
    {
        public int[] maxIlosc = new int[5];
        public int[] stanProdukcji = new int[5];
        public int zapotrzebowanie = 0;
        public int produkcja = 0;
        public int ilosc_surowca = 0;
        //max ilosc surowca na magazynie

        //materiały do rozbudowy
        public int[] potrzebaBudo = new int[5];
        public int[] potrzebaDesek = new int[5];
        public int[] potrzebaKamienia = new int[5];
        //poziom budynku
        public int poziom = 1;
        public int poziomMag = 1;
    }

    //--------------------------------------------------------------------------------------------
    class Spichlez : Produkcja, IProdukcja_obliczenia
    {
        public new int[] maxIlosc = new int[5] { 80, 150, 210, 250, 300 };
        public new int[] stanProdukcji = new int[5] { 10, 14, 17, 21, 25 };

        public new int[] potrzebaBudo = new int[5] { 10, 20, 35, 45, 60 };
        public new int[] potrzebaDesek = new int[5] { 30, 60, 100, 160, 200 };
        public new int[] potrzebaKamienia = new int[5] { 20, 70, 110, 200, 250 };

        //konstruktor
        public Spichlez(int ilosc_zboza)
        {
            this.ilosc_surowca = ilosc_zboza;
        }

        //metody
        public void Ilosc_calkowita()
        {
            ilosc_surowca += (produkcja - zapotrzebowanie);
            if (ilosc_surowca > maxIlosc[poziomMag]) ilosc_surowca = maxIlosc[poziomMag];
        }

        public void Oblicz_produkcje(int ilosc_ludzi)
        {
            produkcja = ilosc_ludzi * stanProdukcji[poziom-1];
        }

        public void Oblicz_zapotrzebowanie(int ilosc_ludzi)
        {
            zapotrzebowanie = ilosc_ludzi * 2;
        }

        public void ShowHowerText(ToolTip toolTip, Button HowerButton)
        {
            toolTip.SetToolTip(HowerButton, String.Format("Poziom: " + this.poziom.ToString() +
                "\naktualna produkcja na osobe: " + this.stanProdukcji[this.poziom].ToString() +
                "\nprodukcja na osobę po ulepszeniu: " + this.stanProdukcji[this.poziom + 1].ToString() +
                "\n\nwymagana ilość budowlańców do ulepszenia: " + this.potrzebaBudo[this.poziom].ToString() +
                "\nwymagana ilość desek do ulepszenia: " + this.potrzebaDesek[this.poziom].ToString() +
                "\nwymagana ilość kamienia do ulepszenia: " + this.potrzebaKamienia[this.poziom].ToString()));
        }
    }

    //--------------------------------------------------------------------------------------------
    class Rzeznia : Produkcja, IProdukcja_obliczenia
    {
        public new int[] maxIlosc = new int[5] { 60, 100, 150, 200, 240 };
        public new int[] stanProdukcji = new int[5] { 8, 9, 11, 12, 14 };

        public new int[] potrzebaBudo = new int[5] { 12, 20, 30, 45, 60 };
        public new int[] potrzebaDesek = new int[5] { 35, 90, 150, 200, 300 };
        public new int[] potrzebaKamienia = new int[5] { 30, 100, 170, 250, 310 };


        //konstruktor
        public Rzeznia(int ilosc_miesa)
        {
            this.ilosc_surowca = ilosc_miesa;
        }

        //metody
        public void Ilosc_calkowita()
        {
            ilosc_surowca += (produkcja - zapotrzebowanie);
            if (ilosc_surowca > maxIlosc[poziomMag]) ilosc_surowca = maxIlosc[poziomMag];
        }

        public void Oblicz_produkcje(int ilosc_ludzi)
        {
            produkcja = ilosc_ludzi * stanProdukcji[poziom-1];
        }

        public void Oblicz_zapotrzebowanie(int ilosc_ludzi)
        {
            zapotrzebowanie = ilosc_ludzi * 2;
        }

        public void ShowHowerText(ToolTip toolTip, Button HowerButton)
        {
            toolTip.SetToolTip(HowerButton, String.Format("Poziom: " + this.poziom.ToString() +
                "\naktualna produkcja na osobe: " + this.stanProdukcji[this.poziom].ToString() +
                "\nprodukcja na osobę po ulepszeniu: " + this.stanProdukcji[this.poziom + 1].ToString() +
                "\n\nwymagana ilość budowlańców do ulepszenia: " + this.potrzebaBudo[this.poziom].ToString() +
                "\nwymagana ilość desek do ulepszenia: " + this.potrzebaDesek[this.poziom].ToString() +
                "\nwymagana ilość kamienia do ulepszenia: " + this.potrzebaKamienia[this.poziom].ToString()));
        }
    }

    //---------------------------------------------------------------------------------------------------
    class Tartak : Produkcja, IProdukcja_obliczenia
    {
        public new int[] maxIlosc = new int[5] { 60, 100, 150, 200, 240 };
        public new int[] stanProdukcji = new int[5] { 8, 9, 11, 12, 14 };

        public new int[] potrzebaBudo = new int[5] { 12, 20, 30, 45, 60 };
        public new int[] potrzebaDesek = new int[5] { 35, 90, 150, 200, 300 };
        public new int[] potrzebaKamienia = new int[5] { 30, 100, 170, 250, 310 };


        //konstruktor
        public Tartak(int ilosc_desek)
        {
            this.ilosc_surowca = ilosc_desek;
        }

        //metody
        public void Ilosc_calkowita()
        {
            ilosc_surowca += (produkcja - zapotrzebowanie);
            if (ilosc_surowca > maxIlosc[poziomMag]) ilosc_surowca = maxIlosc[poziomMag];
        }

        public void Oblicz_produkcje(int ilosc_ludzi)
        {
            produkcja = ilosc_ludzi * stanProdukcji[poziom-1];
        }

        public void Oblicz_zapotrzebowanie(int ilosc_ludzi)
        {
            zapotrzebowanie = 0;
        }

        public void ShowHowerText(ToolTip toolTip, Button HowerButton)
        {
            toolTip.SetToolTip(HowerButton, String.Format("Poziom: " + this.poziom.ToString() +
                "\naktualna produkcja na osobe: " + this.stanProdukcji[this.poziom].ToString() +
                "\nprodukcja na osobę po ulepszeniu: " + this.stanProdukcji[this.poziom + 1].ToString() +
                "\n\nwymagana ilość budowlańców do ulepszenia: " + this.potrzebaBudo[this.poziom].ToString() +
                "\nwymagana ilość desek do ulepszenia: " + this.potrzebaDesek[this.poziom].ToString() +
                "\nwymagana ilość kamienia do ulepszenia: " + this.potrzebaKamienia[this.poziom].ToString()));
        }
    }

    //-------------------------------------------------------------------------------------------------
    class Kamieniolom : Produkcja, IProdukcja_obliczenia
    {
        public new int[] maxIlosc = new int[5] { 60, 100, 150, 200, 240 };
        public new int[] stanProdukcji = new int[5] { 8, 9, 11, 12, 14 };

        public new int[] potrzebaBudo = new int[5] { 12, 20, 30, 45, 60 };
        public new int[] potrzebaDesek = new int[5] { 35, 90, 150, 200, 300 };
        public new int[] potrzebaKamienia = new int[5] { 30, 100, 170, 250, 310 };


        //konstruktor
        public Kamieniolom(int ilosc_kamienia)
        {
            this.ilosc_surowca = ilosc_kamienia;
        }

        //metody
        public void Ilosc_calkowita()
        {
            ilosc_surowca += (produkcja - zapotrzebowanie);
            if (ilosc_surowca > maxIlosc[poziomMag]) ilosc_surowca = maxIlosc[poziomMag];
        }

        public void Oblicz_produkcje(int ilosc_ludzi)
        {
            produkcja = ilosc_ludzi * stanProdukcji[poziom-1];
        }

        public void Oblicz_zapotrzebowanie(int ilosc_ludzi)
        {
            zapotrzebowanie = 0;
        }

        public void ShowHowerText(ToolTip toolTip, Button HowerButton)
        {
            toolTip.SetToolTip(HowerButton, String.Format("Poziom: " + this.poziom.ToString() +
                "\naktualna produkcja na osobe: " + this.stanProdukcji[this.poziom].ToString() +
                "\nprodukcja na osobę po ulepszeniu: " + this.stanProdukcji[this.poziom + 1].ToString() +
                "\n\nwymagana ilość budowlańców do ulepszenia: " + this.potrzebaBudo[this.poziom].ToString() +
                "\nwymagana ilość desek do ulepszenia: " + this.potrzebaDesek[this.poziom].ToString() +
                "\nwymagana ilość kamienia do ulepszenia: " + this.potrzebaKamienia[this.poziom].ToString()));
        }
    }
    class Magazyn : Produkcja
    {
        public new int[] potrzebaBudo = new int[5] { 15, 25, 37, 45, 56 };
        public new int[] potrzebaDesek = new int[5] { 50, 90, 140, 180, 220 };
        public new int[] potrzebaKamienia = new int[5] { 50, 90, 140, 180, 220 };

        public new int poziom = 1;



        public int[] MaxIloscDesek = new int[5] { 50, 90, 140, 180, 220 };
        public int[] MaxIloscKamien = new int[5] { 40, 70, 100, 150, 190 };

        public void ShowHowerText(ToolTip toolTip, Button HowerButton)
        {
            toolTip.SetToolTip(HowerButton, String.Format("Poziom: " + this.poziom.ToString() +
                "\n\nwymagana ilość budowlańców do ulepszenia: " + this.potrzebaBudo[this.poziom].ToString() +
                "\nwymagana ilość desek do ulepszenia: " + this.potrzebaDesek[this.poziom].ToString() +
                "\nwymagana ilość kamienia do ulepszenia: " + this.potrzebaKamienia[this.poziom].ToString()));
        }
    }
}
