using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SerwisPlus
{
    public partial class Frm_wydruk_zgloszenia : Form
    {
        public string Data_wydruku, Nazwa_firmy, Nip, Adres, Kod_pocztowy, Tel_nr, Typ_zgloszenia, Data, Opis, Miejscowosc, Ulica, Imie_serwisanta, Nazwisko_serwisanta;

        private void btn_drukuj_Click(object sender, EventArgs e)
        {
            Print(this.panel_wydruku);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panel_wydruku.Width / 2), this.panel_wydruku.Location.Y);
        }

        public Frm_wydruk_zgloszenia()
        {
            InitializeComponent();
            Data_wydruku = DateTime.Now.ToString("d/M/yyyy");
        }
        private void Print (Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panel_wydruku = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private Bitmap memoryimg;

        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        public void Frm_wydruk_zgloszenia_Load(object sender, EventArgs e)
        {
            lbl_data_wydruku.Text = Data_wydruku;
            lbl_nazwa_firmy.Text = Nazwa_firmy;
            lbl_nip.Text = Nip;
            lbl_miejscowosc.Text = Adres;
            lbl_kod_pocztowy.Text = Kod_pocztowy;
            lbl_ulica.Text = Ulica;
            lbl_tel_nr.Text = Tel_nr;
            lbl_typ_zgloszenia.Text = Typ_zgloszenia;
            lbl_data_zgloszenia.Text = Data;
            lbl_opis.Text = Opis;
            lbl_imie_serwisanta.Text = Imie_serwisanta;
            lbl_nazwisko_serwisanta.Text = Nazwisko_serwisanta;
        }
    }
}
