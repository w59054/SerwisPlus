using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SerwisPlus;

namespace SerwisPlus
{
    public partial class Frm_historia : Form
    {
        public string Data_wydruku, Nazwa_firmy, Nip, Adres, Kod_pocztowy, Tel_nr, Typ_zgloszenia, Data, Opis, Miejscowosc, Ulica, Imie_Serwisanta, Nazwisko_Serwisanta;
        public int ID;

        public Frm_historia()
        {
            InitializeComponent();
            dgv_historia.BringToFront();
        }

        private void btn_podglad_zgloszenia_Click(object sender, EventArgs e)
        {
            Frm_wydruk_zgloszenia frm_wydruk_zgloszenia = new Frm_wydruk_zgloszenia();
            
            DataGridViewRow row = dgv_historia.Rows[dgv_historia.CurrentRow.Index] as DataGridViewRow;
            SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30;" +
                " Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select z.ID,z.Typ_zgloszenia,k.Nazwa_firmy,k.NIP,k.Miejscowosc,k.Kod_pocztowy,k.Nr_tel,z.Data_zgloszenia,z.Opis,s.Imie_Serwisanta,s.Nazwisko_Serwisanta " +
                "from tb_dane_zgloszen z INNER JOIN tb_klienci k ON z.ID_klienta = k.Id INNER JOIN tb_serwisanci s ON z.Id_serwisanta = s.Id where z.Status='Ukończone' And z.ID=@ID", con);
            cmd.Parameters.AddWithValue("ID", row.Cells[0].Value);
            SqlDataReader srd = cmd.ExecuteReader();

            while (srd.Read())
            {
                frm_wydruk_zgloszenia.Typ_zgloszenia = srd.GetValue(1).ToString();
                frm_wydruk_zgloszenia.Nazwa_firmy = srd.GetValue(2).ToString();
                frm_wydruk_zgloszenia.Nip = srd.GetValue(3).ToString();
                frm_wydruk_zgloszenia.Miejscowosc = srd.GetValue(4).ToString();
                frm_wydruk_zgloszenia.Kod_pocztowy = srd.GetValue(5).ToString();
                frm_wydruk_zgloszenia.Tel_nr = srd.GetValue(6).ToString();
                frm_wydruk_zgloszenia.Data = srd.GetValue(7).ToString();
                frm_wydruk_zgloszenia.Opis = srd.GetValue(8).ToString();
                frm_wydruk_zgloszenia.Imie_serwisanta = srd.GetValue(9).ToString();
                frm_wydruk_zgloszenia.Nazwisko_serwisanta = srd.GetValue(10).ToString();
            }
            con.Close();


            frm_wydruk_zgloszenia.ShowDialog();
        }


        private void btn_aktualizuj_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_historia.Rows[dgv_historia.CurrentRow.Index] as DataGridViewRow;
            dtp_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand cmd = new SqlCommand("UPDATE tb_dane_zgloszenia SET Typ_zgloszenia=@Typ_zgloszenia,Data_wykonania=@Data_wykonania,Status=@Status,Opis=@Opis WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", row.Cells[0].Value);
            cmd.Parameters.AddWithValue("@Typ_zgloszenia", cb_typ_zgloszenia.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Data_wykonania", dtp_data.Text);
            cmd.Parameters.AddWithValue("@Status", "Ukończone");
            cmd.Parameters.AddWithValue("@Opis", tb_opis.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Zaktualizowano historię zgłoszenia");
        }



        private void Frm_historia_Load(object sender, EventArgs e) // Załadowanie danych do GridView o statusie Ukończone (poprawione)
        {
            SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select z.ID,z.Typ_zgloszenia,k.Nazwa_firmy,k.NIP,k.Miejscowosc,k.Kod_pocztowy,k.Nr_tel,z.Data_wykonania,z.Opis,s.Imie_Serwisanta,s.Nazwisko_Serwisanta from tb_dane_zgloszen z INNER JOIN tb_klienci k ON z.ID_klienta = k.Id INNER JOIN tb_serwisanci s ON z.Id_serwisanta = s.Id WHERE Status='Ukończone'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_historia.DataSource = dt;
            con.Close();
        }

        public void txt_szukaj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                using (SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
                {
                    con.Open();
                    DataTable dt = new DataTable("tb_dane_zgloszen");
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select z.ID,z.Typ_zgloszenia,k.Nazwa_firmy,k.NIP,k.Miejscowosc,k.Kod_pocztowy,k.Nr_tel,z.Data_wykonania,z.Opis,s.Imie_Serwisanta,s.Nazwisko_Serwisanta from tb_dane_zgloszen z INNER JOIN tb_klienci k ON z.ID_klienta = k.Id INNER JOIN tb_serwisanci s ON z.Id_serwisanta = s.Id WHERE z.Status ='Ukończone' AND (k.Nazwa_firmy like @Search OR z.Data_wykonania like @Search)", con);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@Search", $"%{txt_szukaj.Text}%");
                    dataAdapter.Fill(dt);
                    dgv_historia.DataSource = dt;
                    e.Handled = true;
                    con.Close();
                }
            }
        }

        public void btn_szukaj_Click(object sender, EventArgs e) // Wyszukiwanie zgłoszeni w oknie Ukończone + zatwierdzenie przyciskiem szukaj (poprawione)
        {
            using (SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            {
                con.Open();
                DataTable dt = new DataTable("tb_dane_zgloszen");
                SqlDataAdapter dataAdapter = new SqlDataAdapter("Select z.ID, z.Typ_zgloszenia, k.Nazwa_firmy, k.NIP, k.Miejscowosc, k.Kod_pocztowy, k.Nr_tel, z.Data_wykonania, z.Opis, s.Imie_Serwisanta, s.Nazwisko_Serwisanta from tb_dane_zgloszen z INNER JOIN tb_klienci k ON z.ID_klienta = k.Id INNER JOIN tb_serwisanci s ON z.Id_serwisanta = s.Id WHERE z.Status = 'Ukończone' AND(k.Nazwa_firmy like @Search OR z.Data_wykonania like @Search)", con);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@Search", $"%{txt_szukaj.Text}%");
                dataAdapter.Fill(dt);
                dgv_historia.DataSource = dt;
                con.Close();
            }
        }

        private void btn_usun_zgloszenie_Click(object sender, EventArgs e) // Usuwanie zgłoszenia (poprawione)
        {
            DataGridViewRow row = dgv_historia.Rows[dgv_historia.CurrentRow.Index] as DataGridViewRow;
            if (row != null)
            {
                if (MessageBox.Show("Czy napewno usunąć zgłoszenie?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30;" +
                        " Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        using (SqlCommand cmd = new SqlCommand("delete from tb_dane_zgloszen where ID = @ID", con))
                        {
                            cmd.Parameters.AddWithValue("ID", row.Cells[0].Value);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        con.Open();
                        SqlCommand cmd2 = new SqlCommand("Select z.ID,z.Typ_zgloszenia,k.Nazwa_firmy,k.NIP,k.Miejscowosc,k.Kod_pocztowy,k.Nr_tel,z.Data_wykonania,z.Opis,s.Imie_Serwisanta,s.Nazwisko_Serwisanta " +
                            "from tb_dane_zgloszen z INNER JOIN tb_klienci k ON z.ID_klienta = k.Id INNER JOIN tb_serwisanci s ON z.Id_serwisanta = s.Id WHERE Status='Ukończone'", con);
                        SqlDataAdapter da = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgv_historia.DataSource = dt;
                        con.Close();
                    }
                }
            }
        } 

        private void txt_szukaj_Click(object sender, EventArgs e)  // Czyszczenie txtbox po kliknięciu 
        {
            txt_szukaj.Clear();
        }

        private void btn_przywroc_zgloszenie_Click(object sender, EventArgs e) // Przycisk przywróć zgłoszenie, zmienia w wybranym wierszu tabeli status z Ukończone na Przyjęte (poprawione)
        {
           
               DataGridViewRow row = dgv_historia.Rows[dgv_historia.CurrentRow.Index] as DataGridViewRow;
                if (row != null)
                {
                    if (MessageBox.Show("Czy napewno przywrócić zgłoszenie do aktywnych?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30;" +
                            " Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
                        {
                            if (con.State == ConnectionState.Closed)
                                con.Open();
                            using (SqlCommand cmd = new SqlCommand("UPDATE tb_dane_zgloszen SET Status='Przyjęte' WHERE ID = @ID", con))
                            {
                                cmd.Parameters.AddWithValue("@ID", row.Cells[0].Value);
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }

                            con.Open();
                            SqlCommand cmd2 = new SqlCommand("Select z.ID,z.Typ_zgloszenia,k.Nazwa_firmy,k.NIP,k.Miejscowosc,k.Kod_pocztowy,k.Nr_tel,z.Data_wykonania,z.Opis,s.Imie_Serwisanta,s.Nazwisko_Serwisanta" +
                                " from tb_dane_zgloszen z INNER JOIN tb_klienci k ON z.ID_klienta = k.Id INNER JOIN tb_serwisanci s ON z.Id_serwisanta = s.Id WHERE Status='Ukończone'", con);
                            SqlDataAdapter da = new SqlDataAdapter(cmd2);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgv_historia.DataSource = dt;
                            con.Close();
                        }
                    }
                }
            

        }

        private void btn_aktualizuj_dane_Click(object sender, EventArgs e) //Poprawione łądowanie danych do okna aktualizacji danych w historii
        {
            DataGridViewRow row = dgv_historia.Rows[dgv_historia.CurrentRow.Index] as DataGridViewRow;
            SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30; " +
                "Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

            con.Open();
            SqlCommand cmd = new SqlCommand("Select z.ID,z.Typ_zgloszenia,k.Nazwa_firmy,k.NIP,k.Miejscowosc,k.Kod_pocztowy,k.Ulica,k.Nr_tel,z.Data_wykonania,z.Opis " +
                "FROM tb_dane_zgloszen z INNER JOIN tb_klienci k ON z.ID_klienta = k.Id WHERE z.Status='Ukończone' And z.ID=@ID", con);
            cmd.Parameters.AddWithValue("ID", row.Cells[0].Value);
            SqlDataReader srd = cmd.ExecuteReader();

            while (srd.Read())
            {
                Typ_zgloszenia = srd.GetValue(1).ToString();
                Nazwa_firmy = srd.GetValue(2).ToString();
                Nip = srd.GetValue(3).ToString();
                Miejscowosc = srd.GetValue(4).ToString();
                Kod_pocztowy = srd.GetValue(5).ToString();
                Ulica = srd.GetValue(6).ToString();
                Tel_nr = srd.GetValue(7).ToString();
                Data = srd.GetValue(8).ToString();
                Opis = srd.GetValue(9).ToString();
            }
            panel_historia.Hide();
            panel_aktualizuj.Show();
            panel_aktualizuj.BringToFront();
            tb_nazwa_firmy.Text = Nazwa_firmy;
            tb_nazwa_firmy.Enabled = false;
            tb_nip.Text = Nip;
            tb_nip.Enabled = false;
            tb_miejscowosc.Text = Adres;
            tb_miejscowosc.Enabled = false;
            tb_kod_pocztowy.Text = Kod_pocztowy;
            tb_kod_pocztowy.Enabled = false;
            tb_ulica.Text = Ulica;
            tb_ulica.Enabled = false;
            tb_tel_nr.Text = Tel_nr;
            tb_tel_nr.Enabled = false;
            cb_typ_zgloszenia.Text = Typ_zgloszenia;
            dtp_data.Text = Data;
            tb_opis.Text = Opis;

        }
    }
}
