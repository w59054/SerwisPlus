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
    public partial class Frm_Klienci : Form
    {
        public string Nazwa_firmy, NIP, Miejscowosc,Ulica,Kod_pocztowy, Nr_tel, Email;
        public int Id;

        public Frm_Klienci()
        {
            InitializeComponent();
        }

        private void btn_aktualizuj_klienta_Click(object sender, EventArgs e) // Update klienta w bazie danych, aktualizacja danych klienta (poprawione)
        {


            btn_dodaj_klienta_2.Hide();
            panel_klienci.Hide();
            DataGridViewRow row = dgv_klienci.Rows[dgv_klienci.CurrentRow.Index] as DataGridViewRow;
            SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30;" +
                " Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand cmd = new SqlCommand("UPDATE tb_klienci SET Nazwa_firmy=@Nazwa_firmy,NIP=@NIP,Miejscowosc=@Miejscowosc,Ulica=@Ulica,Kod_pocztowy=@Kod_pocztowy,Nr_tel=@Nr_tel,Email=@Email WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", row.Cells[0].Value);
            cmd.Parameters.AddWithValue("@Nazwa_firmy", tb_nazwa_firmy.Text);
            cmd.Parameters.AddWithValue("@NIP", tb_nip.Text);
            cmd.Parameters.AddWithValue("@Miejscowosc", tb_miejscowosc.Text);
            cmd.Parameters.AddWithValue("@Ulica", tb_ulica.Text);
            cmd.Parameters.AddWithValue("@Kod_pocztowy", tb_kod_pocztowy.Text);
            cmd.Parameters.AddWithValue("@Nr_tel", tb_nr_tel.Text);
            cmd.Parameters.AddWithValue("@Email", tb_email.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Zaktualizowano klienta");

            panel_klienci.Show();
            dgv_klienci.Show();
            panel_aktualizuj_klienta.Hide();
        }

        private void btn_usun_klienta_Click(object sender, EventArgs e) // Usuwanie klienta z bazy
        {
            DataGridViewRow row = dgv_klienci.Rows[dgv_klienci.CurrentRow.Index] as DataGridViewRow;
            if (row != null)
            {
                if (MessageBox.Show("Czy napewno usunąć klienta?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30;" +
                        " Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        using (SqlCommand cmd = new SqlCommand("delete from tb_klienci where ID=@ID", con))
                        {
                            cmd.Parameters.AddWithValue("ID", row.Cells[0].Value);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        con.Open();
                        SqlCommand cmd2 = new SqlCommand("SELECT * from tb_klienci", con);
                        SqlDataAdapter da = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgv_klienci.DataSource = dt;
                        con.Close();

                    }
                }
            }
        }

        private void txt_szukaj_KeyPress(object sender, KeyPressEventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30;" +
                " Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            {
                DataTable dt = new DataTable("tb_klienci");
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from tb_klienci where (Nazwa_firmy like @Search OR NIP like @Search)", con);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@Search", $"%{txt_szukaj.Text}%");
                dataAdapter.Fill(dt);
                dgv_klienci.DataSource = dt;
            }
        }

        private void Frm_Klienci_Load(object sender, EventArgs e) // załadaowanie listy klientów przy uruchomieniu okna klienci
        {
            dgv_klienci.BringToFront();
            panel_aktualizuj_klienta.Hide();
            SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30; " +
                "Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from tb_klienci", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_klienci.DataSource = dt;
            con.Close();
        }



        public void btn_dodaj_klienta_2_Click(object sender, EventArgs e) // Dodanie klienta do bazy danych, zczytuje dane z text_boxów
        {
            if (tb_nazwa_firmy.Text == "" || tb_nip.Text == "" || tb_miejscowosc.Text == "" || tb_kod_pocztowy.Text == "" && (tb_nr_tel.Text == "" || tb_email.Text ==""))
            {
                MessageBox.Show("Nie wypełniono wszystkich wymaganych danych!");
                return;
            };
            int nip_liczba;
            if (!int.TryParse(tb_nip.Text, out nip_liczba))
            {
                MessageBox.Show("Błędnie wypełnione pole NIP, dozwolone tylko liczby!");
                return;
            };

            SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30;" +
                " Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand cmd = new SqlCommand("Insert into tb_klienci values (@Nazwa_firmy,@NIP,@Miejscowosc,@Ulica,@Kod_pocztowy,@Nr_tel,@Email)", con);
            cmd.Parameters.AddWithValue("@Nazwa_firmy", tb_nazwa_firmy.Text);
            cmd.Parameters.AddWithValue("@NIP", tb_nip.Text);
            cmd.Parameters.AddWithValue("@Miejscowosc", tb_miejscowosc.Text);
            cmd.Parameters.AddWithValue("@Ulica", tb_ulica.Text);
            cmd.Parameters.AddWithValue("@Kod_pocztowy", tb_kod_pocztowy.Text);
            cmd.Parameters.AddWithValue("@Nr_tel", tb_nr_tel.Text);
            cmd.Parameters.AddWithValue("@Email", tb_email.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Dodano nowego Klienta");

            panel_klienci.Show();
            dgv_klienci.Show();
            panel_aktualizuj_klienta.Hide();
        }


        private void btn_aktualizuj_dane_Click(object sender, EventArgs e) // Wczytanie danych do textboxów akutalizacji danych klienta
        {
            panel_klienci.Hide();
            panel_aktualizuj_klienta.Show();
            btn_dodaj_klienta_2.Hide();
            dgv_klienci.Hide();

            DataGridViewRow row = dgv_klienci.Rows[dgv_klienci.CurrentRow.Index] as DataGridViewRow;
            SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30; " +
                "Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

            con.Open();
            SqlCommand cmd = new SqlCommand("Select ID,Nazwa_firmy,Nip,Miejscowosc,Ulica,Kod_pocztowy,Nr_tel,Email from tb_klienci where Id=@ID ", con);
            cmd.Parameters.AddWithValue("ID", row.Cells[0].Value);
            SqlDataReader srd = cmd.ExecuteReader();

            while (srd.Read())
            {
                Nazwa_firmy = srd.GetValue(1).ToString();
                NIP = srd.GetValue(2).ToString();
                Miejscowosc = srd.GetValue(3).ToString();
                Ulica = srd.GetValue(4).ToString();
                Kod_pocztowy = srd.GetValue(5).ToString();
                Nr_tel = srd.GetValue(6).ToString();
                Email = srd.GetValue(7).ToString();
            }
            panel_klienci.Hide();
            panel_aktualizuj_klienta.BringToFront();
            tb_nazwa_firmy.Text = Nazwa_firmy;
            tb_nip.Text = NIP;
            tb_miejscowosc.Text = Miejscowosc;
            tb_ulica.Text = Ulica;
            tb_kod_pocztowy.Text = Kod_pocztowy;
            tb_nr_tel.Text = Nr_tel;
            tb_email.Text = Email;
        }


        private void txt_szukaj_Enter(object sender, EventArgs e)
        {
            txt_szukaj.Clear();
        }

        private void btn_szukaj_Click(object sender, EventArgs e) // Wyszukiwanie klienta po Nazwie lub NIP, aktywacja po wciśnięciu przycisku Szukaj
        {
            using (SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30;" +
                " Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            {
                DataTable dt = new DataTable("tb_klienci");
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from tb_klienci where (Nazwa_firmy like @Search OR NIP like @Search)", con);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@Search", $"%{txt_szukaj.Text}%");
                dataAdapter.Fill(dt);
                dgv_klienci.DataSource = dt;
            }

        }

        private void btn_dodaj_klienta_Click(object sender, EventArgs e) // Pokazanie panelu dodawania klienta po kliknięciu przycisku dodaj klienta
        {
            panel_klienci.Hide();
            panel_aktualizuj_klienta.Show();
            btn_aktualizuj_klienta.Hide();
            dgv_klienci.Hide();
        }
    }
}

