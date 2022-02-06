
namespace ClickClackClock
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Dodaj_Czlowieka_btn = new System.Windows.Forms.Button();
            this.Wysli_Zbieranie_btn = new System.Windows.Forms.Button();
            this.Wyslij_Polowac_btn = new System.Windows.Forms.Button();
            this.Wyslij_Budowac_btn = new System.Windows.Forms.Button();
            this.Wyslij_Zwiad_btn = new System.Windows.Forms.Button();
            this.Rozbudoj_spichlez = new System.Windows.Forms.Button();
            this.Rozbudoj_rzeznie = new System.Windows.Forms.Button();
            this.Zegar_1sek = new System.Windows.Forms.Timer(this.components);
            this.ak_100ms = new System.Windows.Forms.Timer(this.components);
            this.txtZbier = new System.Windows.Forms.TextBox();
            this.txtLowcy = new System.Windows.Forms.TextBox();
            this.txtBudo = new System.Windows.Forms.TextBox();
            this.Ilosc1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtZwiad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPopulacja = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWolnych = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMieso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtZboze = new System.Windows.Forms.TextBox();
            this.timer_zbier = new System.Windows.Forms.Timer(this.components);
            this.timer_lowcy = new System.Windows.Forms.Timer(this.components);
            this.timer_popul = new System.Windows.Forms.Timer(this.components);
            this.txtPotenc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKam = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Rozbodoj_tartak = new System.Windows.Forms.Button();
            this.txtDeski = new System.Windows.Forms.TextBox();
            this.Wyslij_drwali = new System.Windows.Forms.Button();
            this.Rozbudoj_kamien = new System.Windows.Forms.Button();
            this.Wyslij_kamien = new System.Windows.Forms.Button();
            this.txtDrwale = new System.Windows.Forms.TextBox();
            this.txtKamrz = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Rozbuduj_magazyn = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.label13 = new System.Windows.Forms.Label();
            this.timer_drwale = new System.Windows.Forms.Timer(this.components);
            this.timer_kamien = new System.Windows.Forms.Timer(this.components);
            this.pbMieso = new System.Windows.Forms.ProgressBar();
            this.pbZboz = new System.Windows.Forms.ProgressBar();
            this.pbKam = new System.Windows.Forms.ProgressBar();
            this.pbDesk = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Dodaj_Czlowieka_btn
            // 
            this.Dodaj_Czlowieka_btn.Location = new System.Drawing.Point(299, 410);
            this.Dodaj_Czlowieka_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dodaj_Czlowieka_btn.Name = "Dodaj_Czlowieka_btn";
            this.Dodaj_Czlowieka_btn.Size = new System.Drawing.Size(94, 48);
            this.Dodaj_Czlowieka_btn.TabIndex = 0;
            this.Dodaj_Czlowieka_btn.Text = "Dodaj Czlowieka";
            this.Dodaj_Czlowieka_btn.UseVisualStyleBackColor = true;
            this.Dodaj_Czlowieka_btn.Click += new System.EventHandler(this.Dodaj_Czlowieka_btn_Click);
            // 
            // Wysli_Zbieranie_btn
            // 
            this.Wysli_Zbieranie_btn.Location = new System.Drawing.Point(299, 64);
            this.Wysli_Zbieranie_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Wysli_Zbieranie_btn.Name = "Wysli_Zbieranie_btn";
            this.Wysli_Zbieranie_btn.Size = new System.Drawing.Size(94, 26);
            this.Wysli_Zbieranie_btn.TabIndex = 1;
            this.Wysli_Zbieranie_btn.Text = "Wyslij_Zbierac";
            this.Wysli_Zbieranie_btn.UseVisualStyleBackColor = true;
            this.Wysli_Zbieranie_btn.Click += new System.EventHandler(this.Wysli_Zbieranie_btn_Click);
            // 
            // Wyslij_Polowac_btn
            // 
            this.Wyslij_Polowac_btn.Location = new System.Drawing.Point(299, 176);
            this.Wyslij_Polowac_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Wyslij_Polowac_btn.Name = "Wyslij_Polowac_btn";
            this.Wyslij_Polowac_btn.Size = new System.Drawing.Size(94, 26);
            this.Wyslij_Polowac_btn.TabIndex = 2;
            this.Wyslij_Polowac_btn.Text = "Wylij_Polowac";
            this.Wyslij_Polowac_btn.UseVisualStyleBackColor = true;
            this.Wyslij_Polowac_btn.Click += new System.EventHandler(this.Wyslij_Polowac_btn_Click);
            // 
            // Wyslij_Budowac_btn
            // 
            this.Wyslij_Budowac_btn.Location = new System.Drawing.Point(318, 284);
            this.Wyslij_Budowac_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Wyslij_Budowac_btn.Name = "Wyslij_Budowac_btn";
            this.Wyslij_Budowac_btn.Size = new System.Drawing.Size(94, 30);
            this.Wyslij_Budowac_btn.TabIndex = 3;
            this.Wyslij_Budowac_btn.Text = "Wyslij_Budowac";
            this.Wyslij_Budowac_btn.UseVisualStyleBackColor = true;
            this.Wyslij_Budowac_btn.Click += new System.EventHandler(this.Wyslij_Budowac_btn_Click);
            // 
            // Wyslij_Zwiad_btn
            // 
            this.Wyslij_Zwiad_btn.Location = new System.Drawing.Point(318, 318);
            this.Wyslij_Zwiad_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Wyslij_Zwiad_btn.Name = "Wyslij_Zwiad_btn";
            this.Wyslij_Zwiad_btn.Size = new System.Drawing.Size(94, 30);
            this.Wyslij_Zwiad_btn.TabIndex = 4;
            this.Wyslij_Zwiad_btn.Text = "Wyslij_Zwiad";
            this.Wyslij_Zwiad_btn.UseVisualStyleBackColor = true;
            this.Wyslij_Zwiad_btn.Click += new System.EventHandler(this.Wyslij_Zwiad_btn_Click);
            // 
            // Rozbudoj_spichlez
            // 
            this.Rozbudoj_spichlez.Location = new System.Drawing.Point(52, 137);
            this.Rozbudoj_spichlez.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rozbudoj_spichlez.Name = "Rozbudoj_spichlez";
            this.Rozbudoj_spichlez.Size = new System.Drawing.Size(341, 24);
            this.Rozbudoj_spichlez.TabIndex = 0;
            this.Rozbudoj_spichlez.Text = "Rozbudój spichlez";
            this.Rozbudoj_spichlez.UseVisualStyleBackColor = true;
            this.Rozbudoj_spichlez.Click += new System.EventHandler(this.Rozbudoj_spichlez_Click);
            this.Rozbudoj_spichlez.MouseHover += new System.EventHandler(this.Rozbudoj_spichlez_MouseHover);
            // 
            // Rozbudoj_rzeznie
            // 
            this.Rozbudoj_rzeznie.Location = new System.Drawing.Point(52, 255);
            this.Rozbudoj_rzeznie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rozbudoj_rzeznie.Name = "Rozbudoj_rzeznie";
            this.Rozbudoj_rzeznie.Size = new System.Drawing.Size(341, 23);
            this.Rozbudoj_rzeznie.TabIndex = 1;
            this.Rozbudoj_rzeznie.Text = "Rozbudój rzeźnie";
            this.Rozbudoj_rzeznie.UseVisualStyleBackColor = true;
            this.Rozbudoj_rzeznie.Click += new System.EventHandler(this.Rozbudoj_rzeznie_Click);
            this.Rozbudoj_rzeznie.MouseHover += new System.EventHandler(this.Rozbudoj_rzeznie_MouseHover);
            // 
            // Zegar_1sek
            // 
            this.Zegar_1sek.Enabled = true;
            this.Zegar_1sek.Tick += new System.EventHandler(this.Zegar_1sek_Tick);
            // 
            // ak_100ms
            // 
            this.ak_100ms.Enabled = true;
            this.ak_100ms.Tick += new System.EventHandler(this.aktualizacja_100ms_Tick);
            // 
            // txtZbier
            // 
            this.txtZbier.Location = new System.Drawing.Point(52, 64);
            this.txtZbier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZbier.Name = "txtZbier";
            this.txtZbier.ReadOnly = true;
            this.txtZbier.Size = new System.Drawing.Size(110, 23);
            this.txtZbier.TabIndex = 1;
            // 
            // txtLowcy
            // 
            this.txtLowcy.Location = new System.Drawing.Point(52, 176);
            this.txtLowcy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLowcy.Name = "txtLowcy";
            this.txtLowcy.ReadOnly = true;
            this.txtLowcy.Size = new System.Drawing.Size(110, 23);
            this.txtLowcy.TabIndex = 2;
            // 
            // txtBudo
            // 
            this.txtBudo.Location = new System.Drawing.Point(52, 282);
            this.txtBudo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBudo.Name = "txtBudo";
            this.txtBudo.ReadOnly = true;
            this.txtBudo.Size = new System.Drawing.Size(110, 23);
            this.txtBudo.TabIndex = 3;
            // 
            // Ilosc1
            // 
            this.Ilosc1.AutoSize = true;
            this.Ilosc1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Ilosc1.ForeColor = System.Drawing.Color.MediumBlue;
            this.Ilosc1.Location = new System.Drawing.Point(167, 360);
            this.Ilosc1.Name = "Ilosc1";
            this.Ilosc1.Size = new System.Drawing.Size(161, 19);
            this.Ilosc1.TabIndex = 40;
            this.Ilosc1.Text = "Ilosc potencjalnych ludzi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(167, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "Ilosc zbieraczy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(167, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 42;
            this.label2.Text = "Ilosc łowców";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(167, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "Ilosc budowlańców";
            // 
            // txtZwiad
            // 
            this.txtZwiad.Location = new System.Drawing.Point(52, 309);
            this.txtZwiad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZwiad.Name = "txtZwiad";
            this.txtZwiad.ReadOnly = true;
            this.txtZwiad.Size = new System.Drawing.Size(110, 23);
            this.txtZwiad.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(167, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 45;
            this.label4.Text = "Ilosc zwiadowców";
            // 
            // txtPopulacja
            // 
            this.txtPopulacja.Location = new System.Drawing.Point(52, 430);
            this.txtPopulacja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPopulacja.Name = "txtPopulacja";
            this.txtPopulacja.ReadOnly = true;
            this.txtPopulacja.Size = new System.Drawing.Size(110, 23);
            this.txtPopulacja.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(167, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 47;
            this.label5.Text = "Populacja";
            // 
            // txtWolnych
            // 
            this.txtWolnych.Location = new System.Drawing.Point(52, 406);
            this.txtWolnych.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWolnych.Name = "txtWolnych";
            this.txtWolnych.ReadOnly = true;
            this.txtWolnych.Size = new System.Drawing.Size(110, 23);
            this.txtWolnych.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(167, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 19);
            this.label6.TabIndex = 49;
            this.label6.Text = "Wolnych jednostek";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.MediumBlue;
            this.label8.Location = new System.Drawing.Point(167, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 19);
            this.label8.TabIndex = 53;
            this.label8.Text = "Ilosc upolowanych zwierząt";
            // 
            // txtMieso
            // 
            this.txtMieso.Location = new System.Drawing.Point(52, 216);
            this.txtMieso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMieso.Name = "txtMieso";
            this.txtMieso.ReadOnly = true;
            this.txtMieso.Size = new System.Drawing.Size(110, 23);
            this.txtMieso.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Location = new System.Drawing.Point(167, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 19);
            this.label7.TabIndex = 51;
            this.label7.Text = "Ilosc zebranego zboża";
            // 
            // txtZboze
            // 
            this.txtZboze.Location = new System.Drawing.Point(52, 106);
            this.txtZboze.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZboze.Name = "txtZboze";
            this.txtZboze.ReadOnly = true;
            this.txtZboze.Size = new System.Drawing.Size(110, 23);
            this.txtZboze.TabIndex = 50;
            // 
            // timer_zbier
            // 
            this.timer_zbier.Enabled = true;
            this.timer_zbier.Interval = 2000;
            this.timer_zbier.Tick += new System.EventHandler(this.timer_zbieraczy_Tick);
            // 
            // timer_lowcy
            // 
            this.timer_lowcy.Enabled = true;
            this.timer_lowcy.Interval = 3000;
            this.timer_lowcy.Tick += new System.EventHandler(this.timer_lowcy_Tick);
            // 
            // timer_popul
            // 
            this.timer_popul.Enabled = true;
            this.timer_popul.Interval = 2000;
            this.timer_popul.Tick += new System.EventHandler(this.timer_popul_Tick);
            // 
            // txtPotenc
            // 
            this.txtPotenc.Location = new System.Drawing.Point(52, 360);
            this.txtPotenc.Name = "txtPotenc";
            this.txtPotenc.Size = new System.Drawing.Size(110, 23);
            this.txtPotenc.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.MediumBlue;
            this.label9.Location = new System.Drawing.Point(569, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 19);
            this.label9.TabIndex = 65;
            this.label9.Text = "Ilosc kamieni";
            // 
            // txtKam
            // 
            this.txtKam.Location = new System.Drawing.Point(454, 216);
            this.txtKam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKam.Name = "txtKam";
            this.txtKam.ReadOnly = true;
            this.txtKam.Size = new System.Drawing.Size(110, 23);
            this.txtKam.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.MediumBlue;
            this.label10.Location = new System.Drawing.Point(569, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 19);
            this.label10.TabIndex = 63;
            this.label10.Text = "Ilosc desek";
            // 
            // Rozbodoj_tartak
            // 
            this.Rozbodoj_tartak.Location = new System.Drawing.Point(454, 136);
            this.Rozbodoj_tartak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rozbodoj_tartak.Name = "Rozbodoj_tartak";
            this.Rozbodoj_tartak.Size = new System.Drawing.Size(341, 24);
            this.Rozbodoj_tartak.TabIndex = 54;
            this.Rozbodoj_tartak.Text = "Rozbuduj tartak";
            this.Rozbodoj_tartak.UseVisualStyleBackColor = true;
            this.Rozbodoj_tartak.Click += new System.EventHandler(this.Rozbodoj_tartak_Click);
            this.Rozbodoj_tartak.MouseHover += new System.EventHandler(this.Rozbodoj_tartak_MouseHover);
            // 
            // txtDeski
            // 
            this.txtDeski.Location = new System.Drawing.Point(454, 105);
            this.txtDeski.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeski.Name = "txtDeski";
            this.txtDeski.ReadOnly = true;
            this.txtDeski.Size = new System.Drawing.Size(110, 23);
            this.txtDeski.TabIndex = 62;
            // 
            // Wyslij_drwali
            // 
            this.Wyslij_drwali.Location = new System.Drawing.Point(701, 64);
            this.Wyslij_drwali.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Wyslij_drwali.Name = "Wyslij_drwali";
            this.Wyslij_drwali.Size = new System.Drawing.Size(94, 26);
            this.Wyslij_drwali.TabIndex = 55;
            this.Wyslij_drwali.Text = "Wyslij drwali";
            this.Wyslij_drwali.UseVisualStyleBackColor = true;
            this.Wyslij_drwali.Click += new System.EventHandler(this.Wyslij_drwali_Click);
            // 
            // Rozbudoj_kamien
            // 
            this.Rozbudoj_kamien.Location = new System.Drawing.Point(454, 255);
            this.Rozbudoj_kamien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rozbudoj_kamien.Name = "Rozbudoj_kamien";
            this.Rozbudoj_kamien.Size = new System.Drawing.Size(341, 23);
            this.Rozbudoj_kamien.TabIndex = 56;
            this.Rozbudoj_kamien.Text = "Rozbudój kamieniołom";
            this.Rozbudoj_kamien.UseVisualStyleBackColor = true;
            this.Rozbudoj_kamien.Click += new System.EventHandler(this.Rozbudoj_kamien_Click);
            this.Rozbudoj_kamien.MouseHover += new System.EventHandler(this.Rozbudoj_kamien_MouseHover);
            // 
            // Wyslij_kamien
            // 
            this.Wyslij_kamien.Location = new System.Drawing.Point(701, 175);
            this.Wyslij_kamien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Wyslij_kamien.Name = "Wyslij_kamien";
            this.Wyslij_kamien.Size = new System.Drawing.Size(125, 26);
            this.Wyslij_kamien.TabIndex = 58;
            this.Wyslij_kamien.Text = "Wylij kamieniarzy";
            this.Wyslij_kamien.UseVisualStyleBackColor = true;
            this.Wyslij_kamien.Click += new System.EventHandler(this.Wyslij_kamien_Click);
            // 
            // txtDrwale
            // 
            this.txtDrwale.Location = new System.Drawing.Point(454, 64);
            this.txtDrwale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDrwale.Name = "txtDrwale";
            this.txtDrwale.ReadOnly = true;
            this.txtDrwale.Size = new System.Drawing.Size(110, 23);
            this.txtDrwale.TabIndex = 57;
            // 
            // txtKamrz
            // 
            this.txtKamrz.Location = new System.Drawing.Point(454, 175);
            this.txtKamrz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKamrz.Name = "txtKamrz";
            this.txtKamrz.ReadOnly = true;
            this.txtKamrz.Size = new System.Drawing.Size(110, 23);
            this.txtKamrz.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.MediumBlue;
            this.label11.Location = new System.Drawing.Point(569, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 19);
            this.label11.TabIndex = 61;
            this.label11.Text = "Ilosc kamieniarzy";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.MediumBlue;
            this.label12.Location = new System.Drawing.Point(569, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 19);
            this.label12.TabIndex = 60;
            this.label12.Text = "Ilosc drwali";
            // 
            // Rozbuduj_magazyn
            // 
            this.Rozbuduj_magazyn.Location = new System.Drawing.Point(454, 291);
            this.Rozbuduj_magazyn.Name = "Rozbuduj_magazyn";
            this.Rozbuduj_magazyn.Size = new System.Drawing.Size(341, 41);
            this.Rozbuduj_magazyn.TabIndex = 66;
            this.Rozbuduj_magazyn.Text = "Rozbuduj magazyn";
            this.Rozbuduj_magazyn.UseVisualStyleBackColor = true;
            this.Rozbuduj_magazyn.Click += new System.EventHandler(this.Rozbuduj_magazyn_Click);
            this.Rozbuduj_magazyn.MouseHover += new System.EventHandler(this.Rozbuduj_magazyn_MouseHover);
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(210, 13);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(183, 23);
            this.pb1.TabIndex = 67;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 15);
            this.label13.TabIndex = 68;
            this.label13.Text = "Zadowolenie mieszkańców:";
            // 
            // timer_drwale
            // 
            this.timer_drwale.Enabled = true;
            this.timer_drwale.Interval = 3000;
            this.timer_drwale.Tick += new System.EventHandler(this.timer_drwale_Tick);
            // 
            // timer_kamien
            // 
            this.timer_kamien.Enabled = true;
            this.timer_kamien.Interval = 4000;
            this.timer_kamien.Tick += new System.EventHandler(this.timer_kamien_Tick);
            // 
            // pbMieso
            // 
            this.pbMieso.Location = new System.Drawing.Point(52, 204);
            this.pbMieso.Name = "pbMieso";
            this.pbMieso.Size = new System.Drawing.Size(110, 10);
            this.pbMieso.TabIndex = 69;
            // 
            // pbZboz
            // 
            this.pbZboz.Location = new System.Drawing.Point(52, 92);
            this.pbZboz.Name = "pbZboz";
            this.pbZboz.Size = new System.Drawing.Size(110, 10);
            this.pbZboz.TabIndex = 70;
            // 
            // pbKam
            // 
            this.pbKam.Location = new System.Drawing.Point(454, 204);
            this.pbKam.Name = "pbKam";
            this.pbKam.Size = new System.Drawing.Size(110, 10);
            this.pbKam.TabIndex = 71;
            // 
            // pbDesk
            // 
            this.pbDesk.Location = new System.Drawing.Point(454, 92);
            this.pbDesk.Name = "pbDesk";
            this.pbDesk.Size = new System.Drawing.Size(110, 10);
            this.pbDesk.TabIndex = 72;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1199, 526);
            this.Controls.Add(this.pbDesk);
            this.Controls.Add(this.pbKam);
            this.Controls.Add(this.pbZboz);
            this.Controls.Add(this.pbMieso);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.Rozbuduj_magazyn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtKam);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Rozbodoj_tartak);
            this.Controls.Add(this.txtDeski);
            this.Controls.Add(this.Wyslij_drwali);
            this.Controls.Add(this.Rozbudoj_kamien);
            this.Controls.Add(this.Wyslij_kamien);
            this.Controls.Add(this.txtDrwale);
            this.Controls.Add(this.txtKamrz);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPotenc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtWolnych);
            this.Controls.Add(this.Dodaj_Czlowieka_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMieso);
            this.Controls.Add(this.txtPopulacja);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Rozbudoj_spichlez);
            this.Controls.Add(this.txtZwiad);
            this.Controls.Add(this.txtZboze);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Wysli_Zbieranie_btn);
            this.Controls.Add(this.txtBudo);
            this.Controls.Add(this.Wyslij_Zwiad_btn);
            this.Controls.Add(this.Wyslij_Budowac_btn);
            this.Controls.Add(this.Rozbudoj_rzeznie);
            this.Controls.Add(this.Wyslij_Polowac_btn);
            this.Controls.Add(this.txtZbier);
            this.Controls.Add(this.txtLowcy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ilosc1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Dodaj_Czlowieka_btn;
        private System.Windows.Forms.Button Wysli_Zbieranie_btn;
        private System.Windows.Forms.Button Wyslij_Polowac_btn;
        private System.Windows.Forms.Button Wyslij_Budowac_btn;
        private System.Windows.Forms.Button Wyslij_Zwiad_btn;
        private System.Windows.Forms.Button Rozbudoj_spichlez;
        private System.Windows.Forms.Button Rozbudoj_rzeznie;
        private System.Windows.Forms.Timer Zegar_1sek;
        private System.Windows.Forms.Timer ak_100ms;
        private System.Windows.Forms.TextBox txtZbier;
        private System.Windows.Forms.TextBox txtLowcy;
        private System.Windows.Forms.TextBox txtBudo;
        private System.Windows.Forms.Label Ilosc1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtZwiad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPopulacja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWolnych;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMieso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtZboze;
        private System.Windows.Forms.Timer timer_zbier;
        private System.Windows.Forms.Timer timer_lowcy;
        private System.Windows.Forms.Timer timer_popul;
        private System.Windows.Forms.TextBox txtPotenc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Rozbodoj_tartak;
        private System.Windows.Forms.TextBox txtDeski;
        private System.Windows.Forms.Button Wyslij_drwali;
        private System.Windows.Forms.Button Rozbudoj_kamien;
        private System.Windows.Forms.Button Wyslij_kamien;
        private System.Windows.Forms.TextBox txtDrwale;
        private System.Windows.Forms.TextBox txtKamrz;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Rozbuduj_magazyn;
        private System.Windows.Forms.ProgressBar pb1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer timer_drwale;
        private System.Windows.Forms.Timer timer_kamien;
        private System.Windows.Forms.ProgressBar pbMieso;
        private System.Windows.Forms.ProgressBar pbZboz;
        private System.Windows.Forms.ProgressBar pbKam;
        private System.Windows.Forms.ProgressBar pbDesk;
    }
}

