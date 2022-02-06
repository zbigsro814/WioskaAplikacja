using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickClackClock
{
    //public static class modifyprogressbarcolor
    //{
    //    [dllimport("user32.dll", charset = charset.auto, setlasterror = false)]
    //    static extern intptr sendmessage(intptr hwnd, uint msg, intptr w, intptr l);
    //    public static void setstate(this progressbar pbar, int state)
    //    {
    //        sendmessage(pbar.handle, 1040, (intptr)state, intptr.zero);
    //    }
    //}

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        #region tworzenie objektów
        Ludzie Ludzie = new Ludzie(1);
        Spichlez spichlez = new Spichlez(20);
        Rzeznia rzeznia = new Rzeznia(10);
        Tartak tartak = new Tartak(5);
        Kamien kamien = new Kamien(5);
        Magazyn magazyn = new Magazyn();
        ToolTip toolTip = new ToolTip();
        #endregion   

        #region Obsługa przycisków
        private void Dodaj_Czlowieka_btn_Click(object sender, EventArgs e)
        {
            Ludzie.ilosc += 1;
            Ludzie.ilosc_potencjalnych -= 1;
            //modifyprogressbarcolor.setstate(pb1, 3);
            //pb1.setstate(3);
            //pb1.value = ludzie.ilosc;
        }

        private void Wysli_Zbieranie_btn_Click(object sender, EventArgs e)
        {
            Ludzie.ilosc -= 1;
            Ludzie.zbieraczy += 1;
        }

        private void Wyslij_Polowac_btn_Click(object sender, EventArgs e)
        {
            Ludzie.ilosc -= 1;
            Ludzie.lowcy += 1;
        }

        private void Wyslij_drwali_Click(object sender, EventArgs e)
        {
            Ludzie.ilosc -= 1;
            Ludzie.drwale += 1;
        }

        private void Wyslij_kamien_Click(object sender, EventArgs e)
        {
            Ludzie.ilosc -= 1;
            Ludzie.kamien += 1;
        }

        private void Wyslij_Budowac_btn_Click(object sender, EventArgs e)
        {
            Ludzie.ilosc -= 1;
            Ludzie.budowlancy += 1;
        }

        private void Wyslij_Zwiad_btn_Click(object sender, EventArgs e)
        {
            Ludzie.ilosc -= 1;
            Ludzie.zwiadowcy += 1;
        }

        private void Rozbudoj_spichlez_Click(object sender, EventArgs e)
        {
            if (Spichlez.potrzebaBudo[spichlez.poziom - 1] <= Ludzie.budowlancy &&
                Spichlez.potrzebaDesek[spichlez.poziom - 1] <= tartak.ilosc_surowca &&
                Spichlez.potrzebaKamienia[spichlez.poziom - 1] <= kamien.ilosc_surowca)
            {
                tartak.ilosc_surowca -= Spichlez.potrzebaDesek[spichlez.poziom - 1];
                kamien.ilosc_surowca -= Spichlez.potrzebaKamienia[spichlez.poziom - 1];
                spichlez.poziom++;
            }
        }

        private void Rozbudoj_rzeznie_Click(object sender, EventArgs e)
        {
            if (Rzeznia.potrzebaBudo[rzeznia.poziom - 1] <= Ludzie.budowlancy &&
                Rzeznia.potrzebaDesek[rzeznia.poziom - 1] <= tartak.ilosc_surowca &&
                Rzeznia.potrzebaKamienia[rzeznia.poziom - 1] <= kamien.ilosc_surowca)
            {
                tartak.ilosc_surowca -= Rzeznia.potrzebaDesek[rzeznia.poziom - 1];
                kamien.ilosc_surowca -= Rzeznia.potrzebaKamienia[rzeznia.poziom - 1];
                rzeznia.poziom++;
            }
        }

        private void Rozbodoj_tartak_Click(object sender, EventArgs e)
        {
            if (Tartak.potrzebaBudo[tartak.poziom-1] <= Ludzie.budowlancy &&
                Tartak.potrzebaDesek[tartak.poziom - 1] <= tartak.ilosc_surowca &&
                Tartak.potrzebaKamienia[tartak.poziom - 1] <= kamien.ilosc_surowca)
            {
                tartak.ilosc_surowca -= Tartak.potrzebaDesek[tartak.poziom - 1];
                kamien.ilosc_surowca -= Tartak.potrzebaKamienia[tartak.poziom - 1];
                tartak.poziom++;
            }
        }

        private void Rozbudoj_kamien_Click(object sender, EventArgs e)
        {
            if (Kamien.potrzebaBudo[kamien.poziom - 1] <= Ludzie.budowlancy &&
                Kamien.potrzebaDesek[kamien.poziom - 1] <= tartak.ilosc_surowca &&
                Kamien.potrzebaKamienia[kamien.poziom - 1] <= kamien.ilosc_surowca)
            {
                tartak.ilosc_surowca -= Kamien.potrzebaDesek[kamien.poziom - 1];
                kamien.ilosc_surowca -= Kamien.potrzebaKamienia[kamien.poziom - 1];
                kamien.poziom++;
            }
        }

        private void Rozbudoj_tartak_Click(object sender, EventArgs e)
        {
            if (Tartak.potrzebaBudo[tartak.poziom] <= Ludzie.budowlancy &&
                Tartak.potrzebaDesek[tartak.poziom] <= tartak.ilosc_surowca &&
                Tartak.potrzebaKamienia[tartak.poziom] <= kamien.ilosc_surowca)
            {
                tartak.ilosc_surowca -= Tartak.potrzebaDesek[tartak.poziom];
                kamien.ilosc_surowca -= Tartak.potrzebaKamienia[tartak.poziom];
                tartak.poziom++;
            }
        }

        private void Rozbuduj_magazyn_Click(object sender, EventArgs e)
        {
            if (Magazyn.potrzebaBudo[magazyn.poziom - 1] <= Ludzie.budowlancy &&
                Magazyn.potrzebaDesek[magazyn.poziom - 1] <= tartak.ilosc_surowca &&
                Magazyn.potrzebaKamienia[magazyn.poziom - 1] <= kamien.ilosc_surowca)
            {
                tartak.ilosc_surowca -= Magazyn.potrzebaDesek[magazyn.poziom - 1];
                kamien.ilosc_surowca -= Magazyn.potrzebaKamienia[magazyn.poziom - 1];
                magazyn.poziom++;

                Magazyn.poziomMag++;
            }
        }
        #endregion

        #region HowetText
        private void Rozbudoj_spichlez_MouseHover(object sender, EventArgs e)
        {
            spichlez.ShowHowerText(toolTip, Rozbudoj_spichlez);
        }

        private void Rozbudoj_rzeznie_MouseHover(object sender, EventArgs e)
        {
            rzeznia.ShowHowerText(toolTip, Rozbudoj_rzeznie);
        }

        private void Rozbodoj_tartak_MouseHover(object sender, EventArgs e)
        {
            tartak.ShowHowerText(toolTip, Rozbodoj_tartak);
        }

        private void Rozbudoj_kamien_MouseHover(object sender, EventArgs e)
        {
            kamien.ShowHowerText(toolTip, Rozbudoj_kamien);
        }

        private void Rozbuduj_magazyn_MouseHover(object sender, EventArgs e)
        {
            magazyn.ShowHowerText(toolTip, Rozbuduj_magazyn);
        }

        #endregion

        

        
    }
}
