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
        Czlowiek Ludzie = new Czlowiek(1);
        Spichlez spichlez = new Spichlez(20);
        Rzeznia rzeznia = new Rzeznia(10);
        Tartak tartak = new Tartak(5);
        Kamieniolom kamien = new Kamieniolom(5);
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
            if (spichlez.potrzebaBudo[spichlez.poziom] <= Ludzie.budowlancy &&
                spichlez.potrzebaDesek[spichlez.poziom] <= tartak.ilosc_surowca &&
                spichlez.potrzebaKamienia[spichlez.poziom] <= kamien.ilosc_surowca)
            {
                tartak.ilosc_surowca -= spichlez.potrzebaDesek[spichlez.poziom];
                kamien.ilosc_surowca -= spichlez.potrzebaKamienia[spichlez.poziom];
                spichlez.poziom++;
            }
        }

        private void Rozbudoj_rzeznie_Click(object sender, EventArgs e)
        {
            if (rzeznia.potrzebaBudo[rzeznia.poziom] <= Ludzie.budowlancy &&
                rzeznia.potrzebaDesek[rzeznia.poziom] <= tartak.ilosc_surowca &&
                rzeznia.potrzebaKamienia[rzeznia.poziom] <= kamien.ilosc_surowca)
            {
                tartak.ilosc_surowca -= rzeznia.potrzebaDesek[rzeznia.poziom];
                kamien.ilosc_surowca -= rzeznia.potrzebaKamienia[rzeznia.poziom];
                rzeznia.poziom++;
            }
        }

        private void Rozbodoj_tartak_Click(object sender, EventArgs e)
        {
            if (tartak.potrzebaBudo[tartak.poziom] <= Ludzie.budowlancy &&
                tartak.potrzebaDesek[tartak.poziom] <= tartak.ilosc_surowca &&
                tartak.potrzebaKamienia[tartak.poziom] <= kamien.ilosc_surowca)
            {
                tartak.ilosc_surowca -= tartak.potrzebaDesek[rzeznia.poziom];
                kamien.ilosc_surowca -= tartak.potrzebaKamienia[rzeznia.poziom];
                tartak.poziom++;
            }
        }

        private void Rozbudoj_kamien_Click(object sender, EventArgs e)
        {
            if (kamien.potrzebaBudo[kamien.poziom] <= Ludzie.budowlancy &&
                kamien.potrzebaDesek[kamien.poziom] <= tartak.ilosc_surowca &&
                kamien.potrzebaKamienia[kamien.poziom] <= kamien.ilosc_surowca)
            {
                tartak.ilosc_surowca -= kamien.potrzebaDesek[rzeznia.poziom];
                kamien.ilosc_surowca -= kamien.potrzebaKamienia[rzeznia.poziom];
                kamien.poziom++;
            }
        }

        private void Rozbudoj_tartak_Click(object sender, EventArgs e)
        {
            if (tartak.potrzebaBudo[tartak.poziom] <= Ludzie.budowlancy &&
                tartak.potrzebaDesek[tartak.poziom] <= tartak.ilosc_surowca &&
                tartak.potrzebaKamienia[tartak.poziom] <= kamien.ilosc_surowca)
            {
                tartak.ilosc_surowca -= tartak.potrzebaDesek[rzeznia.poziom];
                kamien.ilosc_surowca -= tartak.potrzebaKamienia[rzeznia.poziom];
                tartak.poziom++;
            }
        }

        private void Rozbuduj_magazyn_Click(object sender, EventArgs e)
        {
            if (magazyn.potrzebaBudo[magazyn.poziom] <= Ludzie.budowlancy &&
                magazyn.potrzebaDesek[magazyn.poziom] <= tartak.ilosc_surowca &&
                magazyn.potrzebaKamienia[magazyn.poziom] <= kamien.ilosc_surowca)
            {
                tartak.ilosc_surowca -= magazyn.potrzebaDesek[magazyn.poziom];
                kamien.ilosc_surowca -= magazyn.potrzebaKamienia[magazyn.poziom];
                magazyn.poziom++;

                spichlez.poziomMag++;
                rzeznia.poziomMag++;
                tartak.poziomMag++;
                kamien.poziomMag++;
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
