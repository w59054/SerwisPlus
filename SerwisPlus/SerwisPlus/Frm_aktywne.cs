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
using SerwisPlus;



namespace SerwisPlus
{
    public partial class Frm_aktywne : Form
    {
        public string Data_wydruku, Nazwa_firmy, Nip, Adres, Kod_pocztowy, Tel_nr, Typ_zgloszenia, Data, Opis, Miejscowosc, Ulica, Imie_Serwisanta, Nazwisko_Serwisanta;
        public int ID;


        public Frm_aktywne()
        {
            InitializeComponent();

        }

        private void btn_aktualizuj_Click(object sender, EventArgs e) // Przycisk aktualizujący poszczególne dane w zgłoszeniu (poprawione)
        {

               DataGridViewRow row = dgv_aktywne1.Rows[dgv_aktywne1.CurrentRow.Index] as DataGridViewRow;
               dtp_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
               SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30;" +
                   " Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
               SqlCommand cmd = new SqlCommand("UPDATE tb_dane_zgloszen SET Typ_zgloszenia=@Typ_zgloszenia,Data_zgloszenia=@Data_zgloszenia,Status=@Status,Opis=@Opis,Id_serwisanta=@Id_serwisanta WHERE ID=@ID", con);
               cmd.Parameters.AddWithValue("@ID", row.Cells[0].Value);
               cmd.Parameters.AddWithValue("@Typ_zgloszenia", cb_typ_zgloszenia.SelectedItem.ToString());
               cmd.Parameters.AddWithValue("@Data_zgloszenia", dtp_data.Text);
               cmd.Parameters.AddWithValue("@Status", "Przyjęte");
               cmd.Parameters.AddWithValue("@Opis", tb_opis.Text);
               cmd.Parameters.AddWithValue("@Id_serwisanta", Convert.ToInt32(lbl_id_serwisant.Text));
            


            con.Open();
               cmd.ExecuteNonQuery();
               con.Close();

            MessageBox.Show("Zaktualizowano zgłoszenie");
        }

        private void dgv_aktywne1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_pokaz_na_mapie_Click(object sender, EventArgs e) // Przycisk wyszukuje klienta na mapie google (poprawione)
        {
            DataGridViewRow row = dgv_aktywne1.Rows[dgv_aktywne1.CurrentRow.Index] as DataGridViewRow;
            SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30;" +
                " Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

            con.Open();
            SqlCommand cmd = new SqlCommand("Select z.ID,k.Nazwa_firmy,k.Miejscowosc,k.Kod_pocztowy,k.Ulica from tb_dane_zgloszen z INNER JOIN tb_klienci k ON z.ID_klienta = k.Id WHERE z.Status='Przyjęte' And z.ID=@ID ", con);
            cmd.Parameters.AddWithValue("ID", row.Cells[0].Value);
            SqlDataReader srd = cmd.ExecuteReader();

            while (srd.Read())
            {
                Nazwa_firmy = srd.GetValue(1).ToString();
                Miejscowosc = srd.GetValue(2).ToString();
                Kod_pocztowy = srd.GetValue(3).ToString();
                Ulica = srd.GetValue(4).ToString();
            }
            try
            {
                webBrowser2.Navigate("https://www.google.com/maps?q="+Nazwa_firmy+","+Kod_pocztowy+","+Miejscowosc+","+Ulica);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Błąd wyszukiwania"); 
            }

            panel_aktywne.Hide();
            dgv_aktywne1.Hide();
            panel_aktualizuj.Hide();
            webBrowser2.Show();

        }

        private void Frm_aktywne_Load_1(object sender, EventArgs e)  // Załadowanie danych do GridView o statusie Przyjęte (poprawione)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'serwis_plus_DBDataSet1.tb_serwisanci' . Możesz go przenieść lub usunąć.
            this.tb_serwisanciTableAdapter.Fill(this.serwis_plus_DBDataSet1.tb_serwisanci);
            this.cb_serwisant.DisplayMember = "Imie_Serwisanta" + "Nazwisko_Serwisanta";
            SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select z.ID,z.Typ_zgloszenia,k.Nazwa_firmy,k.NIP,k.Miejscowosc,k.Kod_pocztowy,k.Nr_tel,z.Data_zgloszenia,z.Opis,s.Imie_Serwisanta,s.Nazwisko_Serwisanta from tb_dane_zgloszen z INNER JOIN tb_klienci k ON z.ID_klienta = k.Id INNER JOIN tb_serwisanci s ON z.Id_serwisanta = s.Id where z.Status='Przyjęte'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_aktywne1.DataSource = dt;
            con.Close();
            dgv_aktywne1.BringToFront();
        } 

        private void btn_usun_zgloszenie_Click(object sender, EventArgs e) // Usuwanie zgłoszenia (poprawione)
        {

            DataGridViewRow row = dgv_aktywne1.Rows[dgv_aktywne1.CurrentRow.Index] as DataGridViewRow;
            if (row != null)
            {
                if (MessageBox.Show("Czy napewno usunąć zgłoszenie?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
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
 //                       SqlCommand cmd2 = new SqlCommand("Select ID,Nazwa_firmy,Adres,Nr_tel,Typ_zgloszenia,Data_zgloszenia,Opis from tb_dane_zgloszenia where Status='Przyjęte'", con);

                        SqlCommand cmd2 = new SqlCommand("Select z.ID,z.Typ_zgloszenia,k.Nazwa_firmy,k.NIP,k.Miejscowosc,k.Kod_pocztowy,k.Nr_tel,z.Data_zgloszenia,z.Opis from tb_dane_zgloszen z INNER JOIN tb_klienci k ON z.ID_klienta = k.Id where Status='Przyjęte'", con);
                        SqlDataAdapter da = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgv_aktywne1.DataSource = dt;
                        con.Close();
                    }
                }
            }
        }  

        private void txt_szukaj_KeyPress(object sender, KeyPressEventArgs e)  // Wyszukiwanie zgłoszenia w Przyjęte + zatwierdzenie Enter (poprawione)
        {

                using (SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
                {
                    DataTable dt = new DataTable("tb_dane_zgloszen");
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select z.ID,z.Typ_zgloszenia,k.Nazwa_firmy,k.NIP,k.Miejscowosc,k.Kod_pocztowy,k.Nr_tel,z.Data_zgloszenia,z.Opis,s.Imie_Serwisanta,s.Nazwisko_Serwisanta from tb_dane_zgloszen z INNER JOIN tb_klienci k ON z.ID_klienta = k.Id INNER JOIN tb_serwisanci s ON z.Id_serwisanta = s.Id WHERE z.Status ='Przyjęte' AND (k.Nazwa_firmy like @Search OR z.Data_zgloszenia like @Search)", con);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@Search", $"%{txt_szukaj.Text}%");
                    dataAdapter.Fill(dt);
                    dgv_aktywne1.DataSource = dt;
                }

        }


        private void txt_szukaj_Enter(object sender, EventArgs e)  // Czyszczenie txtbox po kliknięciu
        {
            txt_szukaj.Clear();
        }  

        private void btn_szukaj_Click(object sender, EventArgs e)  // Wyszukiwanie zgłoszeni w oknie aktywne + zatwierdzenie przyciskiem szukaj (poprawione)
        {

            using (SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            {
                DataTable dt = new DataTable("tb_dane_zgloszen");
                SqlDataAdapter dataAdapter = new SqlDataAdapter("Select z.ID, z.Typ_zgloszenia, k.Nazwa_firmy, k.NIP, k.Miejscowosc, k.Kod_pocztowy, k.Nr_tel, z.Data_zgloszenia, z.Opis, s.Imie_Serwisanta, s.Nazwisko_Serwisanta from tb_dane_zgloszen z INNER JOIN tb_klienci k ON z.ID_klienta = k.Id INNER JOIN tb_serwisanci s ON z.Id_serwisanta = s.Id WHERE z.Status = 'Przyjęte' AND(k.Nazwa_firmy like @Search OR z.Data_zgloszenia like @Search)", con);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@Search", $"%{txt_szukaj.Text}%");
                dataAdapter.Fill(dt);
                dgv_aktywne1.DataSource = dt;
            }


        }


        private void btn_ukoncz_zgloszenie_Click(object sender, EventArgs e)   // Przycisk ukończ zgłoszenie, zmienia w wybranym wierszu tabeli status z Przyjęte na Ukończone (poprawione)
        {
            DataGridViewRow row = dgv_aktywne1.Rows[dgv_aktywne1.CurrentRow.Index] as DataGridViewRow;
            if (row != null)
            {
                if (MessageBox.Show("Czy napewno zakończyć zgłoszenie?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30;" +
                        " Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        using (SqlCommand cmd = new SqlCommand("UPDATE tb_dane_zgloszen SET Status='Ukończone',Data_wykonania=@Data_wykonania WHERE ID = @ID", con))
                        {
                            cmd.Parameters.AddWithValue("@Data_wykonania", DateTime.Today.ToShortDateString());
                            cmd.Parameters.AddWithValue("@ID", row.Cells[0].Value);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        con.Open();
                        SqlCommand cmd2 = new SqlCommand("Select z.ID,z.Typ_zgloszenia,k.Nazwa_firmy,k.NIP,k.Miejscowosc,k.Kod_pocztowy,k.Nr_tel,z.Data_zgloszenia,z.Opis,s.Imie_Serwisanta,s.Nazwisko_Serwisanta" +
                            " from tb_dane_zgloszen z INNER JOIN tb_klienci k ON z.ID_klienta = k.Id INNER JOIN tb_serwisanci s ON z.Id_serwisanta = s.Id where z.Status='Przyjęte'", con);
                        SqlDataAdapter da = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgv_aktywne1.DataSource = dt;
                        con.Close();
                    }
                }
            }
        }

        public void btn_podglad_wydruku_Click(object sender, EventArgs e) // Przycisk podgląd wydruku, wyświetla Panel wydruku z uzupelnionymi danymi dla wybranego wiersza tabeli z okna aktywne
        {
            Frm_wydruk_zgloszenia frm_wydruk_zgloszenia = new Frm_wydruk_zgloszenia();

            DataGridViewRow row = dgv_aktywne1.Rows[dgv_aktywne1.CurrentRow.Index] as DataGridViewRow;
            SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30;" +
                " Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False") ;
                con.Open();
                SqlCommand cmd = new SqlCommand("Select z.ID,z.Typ_zgloszenia,k.Nazwa_firmy,k.NIP,k.Miejscowosc,k.Kod_pocztowy,k.Nr_tel,z.Data_zgloszenia,z.Opis,s.Imie_Serwisanta,s.Nazwisko_Serwisanta " +
                    "from tb_dane_zgloszen z INNER JOIN tb_klienci k ON z.ID_klienta = k.Id INNER JOIN tb_serwisanci s ON z.Id_serwisanta = s.Id where z.Status='Przyjęte' And z.ID=@ID", con);
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

        private void btn_aktualizuj_dane_Click(object sender, EventArgs e) // Przycisk powoduje przesuniecię okna aktualizowania danych na wierzch, oraz załadowanie danych z zaznaczonego wiersza (poprawione)
        {
              DataGridViewRow row = dgv_aktywne1.Rows[dgv_aktywne1.CurrentRow.Index] as DataGridViewRow;
              SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30;" +
                  " Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

              con.Open();
              SqlCommand cmd = new SqlCommand("Select z.ID,z.Typ_zgloszenia,k.Nazwa_firmy,k.NIP,k.Miejscowosc,k.Kod_pocztowy,k.Ulica,k.Nr_tel,z.Data_zgloszenia,z.Opis" +
                  " FROM tb_dane_zgloszen z INNER JOIN tb_klienci k ON z.ID_klienta = k.Id WHERE z.Status='Przyjęte' And z.ID=@ID", con);
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
        panel_aktywne.Show();
        webBrowser2.Hide();
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
        




