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
    abstract class Produkcja
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

        public static void pbUstaw<Tkl>(ProgressBar pb, Tkl tkl)
        {
            try
            {
                Produkcja tkl1 = tkl as Produkcja;
                pb.Maximum = tkl1.maxIlosc[tkl1.poziom - 1];
                if (tkl1.ilosc_surowca >= 0) pb.Value = tkl1.ilosc_surowca;
                else pb.Value = 0;
            }
            catch { }
        }
    }

    //--------------------------------------------------------------------------------------------
    class Spichlez : Produkcja
    {
        public static new int[] maxIlosc = new int[5] { 80, 150, 210, 250, 300 };
        public static new int[] stanProdukcji = new int[5] { 10, 14, 17, 21, 25 };

        public static new int[] potrzebaBudo = new int[5] { 10, 20, 35, 45, 60 };
        public static new int[] potrzebaDesek = new int[5] { 30, 60, 100, 160, 200 };
        public static new int[] potrzebaKamienia = new int[5] { 20, 70, 110, 200, 250 };

        //konstruktor
        public Spichlez(int ilosc_zboza)
        {
            this.ilosc_surowca = ilosc_zboza;
        }

        //metody
        public void Ilosc_calkowita()
        {
            ilosc_surowca += (produkcja - zapotrzebowanie);
            if (ilosc_surowca > maxIlosc[Magazyn.poziomMag-1]) ilosc_surowca = maxIlosc[Magazyn.poziomMag - 1];
        }

        public void Oblicz_produkcje(int ilosc_ludzi)
        {
            produkcja = ilosc_ludzi * stanProdukcji[poziom - 1];
        }

        public void Oblicz_zapotrzebowanie(int ilosc_ludzi)
        {
            zapotrzebowanie = ilosc_ludzi * 2;
        }

        public void ShowHowerText(ToolTip toolTip, Button HowerButton)
        {
            toolTip.SetToolTip(HowerButton, String.Format("Poziom: " + poziom.ToString() +
                "\naktualna produkcja na osobe: " + stanProdukcji[poziom-1].ToString() +
                "\nprodukcja na osobę po ulepszeniu: " + stanProdukcji[poziom].ToString() +
                "\n\nwymagana ilość budowlańców do ulepszenia: " + potrzebaBudo[poziom-1].ToString() +
                "\nwymagana ilość desek do ulepszenia: " + potrzebaDesek[poziom-1].ToString() +
                "\nwymagana ilość kamienia do ulepszenia: " + potrzebaKamienia[poziom-1].ToString()));
        }
    }

    //--------------------------------------------------------------------------------------------
    class Rzeznia : Produkcja
    {
        public static new int[] maxIlosc = new int[5] { 60, 100, 150, 200, 240 };
        public static new int[] stanProdukcji = new int[5] { 8, 9, 11, 12, 14 };
                                
        public static new int[] potrzebaBudo = new int[5] { 12, 20, 30, 45, 60 };
        public static new int[] potrzebaDesek = new int[5] { 35, 90, 150, 200, 300 };
        public static new int[] potrzebaKamienia = new int[5] { 30, 100, 170, 250, 310 };


        //konstruktor
        public Rzeznia(int ilosc_miesa)
        {
            this.ilosc_surowca = ilosc_miesa;
        }

        //metody
        public void Ilosc_calkowita()
        {
            ilosc_surowca += (produkcja - zapotrzebowanie);
            if (ilosc_surowca > maxIlosc[Magazyn.poziomMag - 1]) ilosc_surowca = maxIlosc[Magazyn.poziomMag - 1];
        }

        public void Oblicz_produkcje(int ilosc_ludzi)
        {
            produkcja = ilosc_ludzi * stanProdukcji[poziom - 1];
        }

        public void Oblicz_zapotrzebowanie(int ilosc_ludzi)
        {
            zapotrzebowanie = ilosc_ludzi * 2;
        }

        public void ShowHowerText(ToolTip toolTip, Button HowerButton)
        {
            toolTip.SetToolTip(HowerButton, String.Format("Poziom: " + poziom.ToString() +
                "\naktualna produkcja na osobe: " + stanProdukcji[poziom - 1].ToString() +
                "\nprodukcja na osobę po ulepszeniu: " + stanProdukcji[poziom].ToString() +
                "\n\nwymagana ilość budowlańców do ulepszenia: " + potrzebaBudo[poziom - 1].ToString() +
                "\nwymagana ilość desek do ulepszenia: " + potrzebaDesek[poziom - 1].ToString() +
                "\nwymagana ilość kamienia do ulepszenia: " + potrzebaKamienia[poziom - 1].ToString()));
        }
    }

    //---------------------------------------------------------------------------------------------------
    class Tartak : Produkcja, IProdukcja_obliczenia
    {
        public static new int[] maxIlosc = new int[5] { 60, 100, 150, 200, 240 };
        public static new int[] stanProdukcji = new int[5] { 8, 9, 11, 12, 14 };

        public static new int[] potrzebaBudo = new int[5] { 12, 20, 30, 45, 60 };
        public static new int[] potrzebaDesek = new int[5] { 35, 90, 150, 200, 300 };
        public static new int[] potrzebaKamienia = new int[5] { 30, 100, 170, 250, 310 };


        //konstruktor
        public Tartak(int ilosc_desek)
        {
            this.ilosc_surowca = ilosc_desek;
        }

        //metody
        public void Ilosc_calkowita()
        {
            ilosc_surowca += (produkcja - zapotrzebowanie);
            if (ilosc_surowca > maxIlosc[Magazyn.poziomMag - 1]) ilosc_surowca = maxIlosc[Magazyn.poziomMag - 1];
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
            toolTip.SetToolTip(HowerButton, String.Format("Poziom: " + poziom.ToString() +
                "\naktualna produkcja na osobe: " + stanProdukcji[poziom - 1].ToString() +
                "\nprodukcja na osobę po ulepszeniu: " + stanProdukcji[poziom].ToString() +
                "\n\nwymagana ilość budowlańców do ulepszenia: " + potrzebaBudo[poziom - 1].ToString() +
                "\nwymagana ilość desek do ulepszenia: " + potrzebaDesek[poziom - 1].ToString() +
                "\nwymagana ilość kamienia do ulepszenia: " + potrzebaKamienia[poziom - 1].ToString()));
        }
    }

    //-------------------------------------------------------------------------------------------------
    class Kamien : Produkcja, IProdukcja_obliczenia
    {
        public static new int[] maxIlosc = new int[5] { 60, 100, 150, 200, 240 };
        public static new int[] stanProdukcji = new int[5] { 8, 9, 11, 12, 14 };

        public static new int[] potrzebaBudo = new int[5] { 12, 20, 30, 45, 60 };
        public static new int[] potrzebaDesek = new int[5] { 35, 90, 150, 200, 300 };
        public static new int[] potrzebaKamienia = new int[5] { 30, 100, 170, 250, 310 };


        //konstruktor
        public Kamien(int ilosc_kamienia)
        {
            this.ilosc_surowca = ilosc_kamienia;
        }

        //metody
        public void Ilosc_calkowita()
        {
            ilosc_surowca += (produkcja - zapotrzebowanie);
            if (ilosc_surowca > maxIlosc[Magazyn.poziomMag - 1]) ilosc_surowca = maxIlosc[Magazyn.poziomMag - 1];
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
            toolTip.SetToolTip(HowerButton, String.Format("Poziom: " + poziom.ToString() +
                "\naktualna produkcja na osobe: " + stanProdukcji[poziom - 1].ToString() +
                "\nprodukcja na osobę po ulepszeniu: " + stanProdukcji[poziom].ToString() +
                "\n\nwymagana ilość budowlańców do ulepszenia: " + potrzebaBudo[poziom - 1].ToString() +
                "\nwymagana ilość desek do ulepszenia: " + potrzebaDesek[poziom - 1].ToString() +
                "\nwymagana ilość kamienia do ulepszenia: " + potrzebaKamienia[poziom - 1].ToString()));
        }
    }
    class Magazyn : Produkcja
    {
        public static int poziomMag = 1;

        public static new int[] potrzebaBudo = new int[5] { 15, 25, 37, 45, 56 };
        public static new int[] potrzebaDesek = new int[5] { 50, 90, 140, 180, 220 };
        public static new int[] potrzebaKamienia = new int[5] { 50, 90, 140, 180, 220 };

        public void ShowHowerText(ToolTip toolTip, Button HowerButton)
        {
            toolTip.SetToolTip(HowerButton, String.Format("Poziom: " + poziom.ToString() +
                "\nmax ilość zboża w magazynie: " + Spichlez.maxIlosc[poziom - 1].ToString() +
                "\nmax ilość mięsa w magazynie: " + Rzeznia.maxIlosc[poziom - 1].ToString() +
                "\nmax ilość desek w magazynie: " + Tartak.maxIlosc[poziom - 1].ToString() +
                "\nmax ilość kamienia w magazynie: " + Kamien.maxIlosc[poziom - 1].ToString() +

                "\n\nmax ilość zboża w magazynie po ulepszeniu: " + Spichlez.maxIlosc[poziom].ToString() +
                "\nmax ilość mięsa w magazynie po ulepszeniu: " + Rzeznia.maxIlosc[poziom].ToString() +
                "\nmax ilość desek w magazynie po ulepszeniu: " + Tartak.maxIlosc[poziom].ToString() +
                "\nmax ilość kamienia w magazynie po ulepszeniu: " + Kamien.maxIlosc[poziom].ToString() +

                "\n\nwymagana ilość budowlańców do ulepszenia: " + potrzebaBudo[poziom - 1].ToString() +
                "\nwymagana ilość desek do ulepszenia: " + potrzebaDesek[poziom - 1].ToString() +
                "\nwymagana ilość kamienia do ulepszenia: " + potrzebaKamienia[poziom - 1].ToString()));
        }
    }
}
