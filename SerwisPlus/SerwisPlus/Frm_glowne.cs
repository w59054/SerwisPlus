using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerwisPlus
{
    public partial class Frm_glowne : Form
    {
        public Frm_glowne()
        {
            InitializeComponent();
        }
        private void Frm_main_Load(object sender, EventArgs e)
        {
        }

        public void Loadform(object Form)
        {
            if (this.main_panel.Controls.Count > 0)
                this.main_panel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(f);
            this.main_panel.Tag = f;
            f.Show();
        }

        private void btn_wyjscie_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy opuścić aplikację?", "Uwaga!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_dodaj_zgloszenie_Click(object sender, EventArgs e)
        {
            Loadform(new Frm_dodaj_zgloszenie());
        }

        private void btn_aktywne_Click(object sender, EventArgs e)
        {
            Loadform(new Frm_aktywne());
        }

        private void btn_historia_Click(object sender, EventArgs e)
        {
            Loadform(new Frm_historia());
        }
        
        private void aktualizuj(object sender, EventArgs e)
        {
            Loadform(new Frm_dodaj_zgloszenie());
        }

        private void btn_klienci_Click(object sender, EventArgs e)
        {
            Loadform(new Frm_Klienci());
        }

        private void btn_serwisanci_Click(object sender, EventArgs e)
        {
            Loadform(new Frm_serwisanci());
        }
    }
}
