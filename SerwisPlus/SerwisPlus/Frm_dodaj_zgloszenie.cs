using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerwisPlus
{
    public partial class Frm_dodaj_zgloszenie : Form
    {
        public Frm_aktywne frm_aktywne;
        SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        public string Id_klienta;

        public Frm_dodaj_zgloszenie()
        {
            InitializeComponent();
        }

        public Frm_dodaj_zgloszenie(Frm_aktywne frm_aktywne)
        {
            this.frm_aktywne = frm_aktywne;
        }


        private void btn_dodaj_nowe_zgloszenie_Click(object sender, EventArgs e) // przycisk dodaje nowy rekord do tabeli zgłoszenia
        {
            if (lb_id_klienta.Text == "" || cb_typ_zgloszenia.SelectedItem == null)
            {
                MessageBox.Show("Nie wybrano klienta lub typu zgłoszenia!");
                return;
            };

            dtp_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30;" +
                " Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand cmd = new SqlCommand("Insert into tb_dane_zgloszen values (@Typ_zgloszenia,@Data_zgloszenia,@Id_klienta,@Status,@Opis,@Data_wykonania,@Id_serwisanta)", con);
            cmd.Parameters.AddWithValue("@Id_klienta", lb_id_klienta.Text);
            cmd.Parameters.AddWithValue("@Typ_zgloszenia", cb_typ_zgloszenia.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Data_zgloszenia", dtp_data.Text);
            cmd.Parameters.AddWithValue("@Status", "Przyjęte");
            cmd.Parameters.AddWithValue("@Opis", tb_opis.Text);
            cmd.Parameters.AddWithValue("@Data_wykonania", "Null");
            cmd.Parameters.AddWithValue("@Id_serwisanta", 1);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Dodano nowe zgłoszenie");
        }



        private void Frm_dodaj_zgloszenie_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'serwis_plus_DBDataSet.tb_klienci' . Możesz go przenieść lub usunąć.
            this.tb_klienciTableAdapter.Fill(this.serwis_plus_DBDataSet.tb_klienci);
        }

    }
}
