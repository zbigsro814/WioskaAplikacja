using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ClickClackClock
{


    public partial class Form1 : Form
    {
        private void Zegar_1sek_Tick(object sender, EventArgs e)
        {
            Ludzie.ilosc_potencjalnych += 1;
            Dodaj_Czlowieka_btn.Enabled = true;
        }

        private void aktualizacja_100ms_Tick(object sender, EventArgs e)
        {
            #region True/false klawiszy
            if (Ludzie.ilosc == 0)
            {
                Wysli_Zbieranie_btn.Enabled = false;
                Wyslij_Zwiad_btn.Enabled = false;
                Wyslij_Polowac_btn.Enabled = false;
                Wyslij_Budowac_btn.Enabled = false;
                Wysli_Zbieranie_btn.Enabled = false;
            }
            else
            {
                Wysli_Zbieranie_btn.Enabled = true;
                Wyslij_Zwiad_btn.Enabled = true;
                Wyslij_Polowac_btn.Enabled = true;
                Wyslij_Budowac_btn.Enabled = true;
                Wysli_Zbieranie_btn.Enabled = true;
            }
            #endregion

            if (Ludzie.ilosc_potencjalnych == 0)
            {
                Dodaj_Czlowieka_btn.Enabled = false;
            }

            txtPotenc.Text = Ludzie.ilosc_potencjalnych.ToString();
            txtZbier.Text = Ludzie.zbieraczy.ToString();
            txtLowcy.Text = Ludzie.lowcy.ToString();
            txtBudo.Text = Ludzie.budowlancy.ToString();
            txtZwiad.Text = Ludzie.zwiadowcy.ToString();
            txtMieso.Text = rzeznia.ilosc_surowca.ToString();
            txtZboze.Text = spichlez.ilosc_surowca.ToString();
            txtDrwale.Text = Ludzie.drwale.ToString();
            txtDeski.Text = tartak.ilosc_surowca.ToString();
            txtKamrz.Text = Ludzie.kamien.ToString();
            txtKam.Text = kamien.ilosc_surowca.ToString();

            Produkcja.pbUstaw<Spichlez>(pbZboz, spichlez);

            Ludzie.populacja = (Ludzie.ilosc + Ludzie.zbieraczy + Ludzie.lowcy
                + Ludzie.budowlancy + Ludzie.zwiadowcy);

            txtPopulacja.Text = Ludzie.populacja.ToString();
            txtWolnych.Text = Ludzie.ilosc.ToString();
            // Ludzie_2.Text = Ludzie.ilosc_potencjalnych.ToString();
        }

        

        private void timer_popul_Tick(object sender, EventArgs e)
        {
            rzeznia.Oblicz_zapotrzebowanie(Ludzie.populacja);
            spichlez.Oblicz_zapotrzebowanie(Ludzie.populacja);
            rzeznia.Ilosc_calkowita();
            spichlez.Ilosc_calkowita();
        }

        private void timer_zbieraczy_Tick(object sender, EventArgs e)
        {
            spichlez.Oblicz_produkcje(Ludzie.zbieraczy);
            spichlez.Ilosc_calkowita();
        }

        private void timer_lowcy_Tick(object sender, EventArgs e)
        {
            rzeznia.Oblicz_produkcje(Ludzie.lowcy);
            rzeznia.Ilosc_calkowita();
        }

        private void timer_drwale_Tick(object sender, EventArgs e)
        {
            tartak.Oblicz_produkcje(Ludzie.drwale);
            tartak.Ilosc_calkowita();
        }

        private void timer_kamien_Tick(object sender, EventArgs e)
        {
            kamien.Oblicz_produkcje(Ludzie.kamien);
            kamien.Ilosc_calkowita();
        }
    } 
}
