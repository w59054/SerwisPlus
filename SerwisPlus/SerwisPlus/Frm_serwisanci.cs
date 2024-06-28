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


namespace SerwisPlus
{
    public partial class Frm_serwisanci : Form
    {
        public string Imie_Serwisanta, Nazwisko_Serwisanta, Nr_tel_Serwisanta, Mail_Serwisanta;
        public int Id;

        public Frm_serwisanci()
        {
            InitializeComponent();
        }

        private void btn_aktualizuj_serwisanta_Click(object sender, EventArgs e)
        {
            btn_dodaj_serwisanta.Hide();
            panel_serwisanci.Hide();
            DataGridViewRow row = dgv_serwisanci.Rows[dgv_serwisanci.CurrentRow.Index] as DataGridViewRow;
            SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30;" +
                " Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand cmd = new SqlCommand("UPDATE tb_serwisanci SET Imie_Serwisanta=@Imie_Serwisanta,Nazwisko_Serwisanta=@Nazwisko_Serwisanta,Nr_tel_Serwisanta=@Nr_tel_Serwisanta,Mail_Serwisanta=@Mail_Serwisanta WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", row.Cells[0].Value);
            cmd.Parameters.AddWithValue("@Imie_Serwisanta", tb_imie_serwisanta.Text);
            cmd.Parameters.AddWithValue("@Nazwisko_Serwisanta", tb_Nazwisko_serwisanta.Text);
            cmd.Parameters.AddWithValue("@Nr_tel_Serwisanta", tb_nr_tel_serwisanta.Text);
            cmd.Parameters.AddWithValue("@Mail_Serwisanta", tb_email_serwisanta.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Zaktualizowano dane serwisanta");

            panel_serwisanci.Show();
            dgv_serwisanci.Show();
            btn_aktualizuj_serwisanta.Hide();
        }


        private void btn_usun_serwisanta_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_serwisanci.Rows[dgv_serwisanci.CurrentRow.Index] as DataGridViewRow;
            if (row != null)
            {
                if (MessageBox.Show("Czy napewno usunąć serwisanta?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30;" +
                        " Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        using (SqlCommand cmd = new SqlCommand("delete from tb_serwisanci where ID=@ID", con))
                        {
                            cmd.Parameters.AddWithValue("ID", row.Cells[0].Value);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        con.Open();
                        SqlCommand cmd2 = new SqlCommand("SELECT * from tb_serwisanci", con);
                        SqlDataAdapter da = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgv_serwisanci.DataSource = dt;
                        con.Close();

                    }
                }
            }
        }

        private void btn_dodaj_serwisanta2_Click(object sender, EventArgs e)
        {
            btn_aktualizuj_dane_serwisanta.Hide();
            panel_serwisanci.Hide();
            DataGridViewRow row = dgv_serwisanci.Rows[dgv_serwisanci.CurrentRow.Index] as DataGridViewRow;
            SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand cmd = new SqlCommand("INSERT INTO tb_serwisanci VALUES (@Imie_Serwisanta,@Nazwisko_Serwisanta,@Nr_tel_Serwisanta,@Mail_Serwisanta)", con);
            cmd.Parameters.AddWithValue("@ID", row.Cells[0].Value);
            cmd.Parameters.AddWithValue("@Imie_Serwisanta", tb_imie_serwisanta.Text);
            cmd.Parameters.AddWithValue("@Nazwisko_Serwisanta", tb_Nazwisko_serwisanta.Text);
            cmd.Parameters.AddWithValue("@Nr_tel_Serwisanta", tb_nr_tel_serwisanta.Text);
            cmd.Parameters.AddWithValue("@Mail_Serwisanta", tb_email_serwisanta.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Dodano nowego Serwisanta!");

            panel_serwisanci.Show();
            dgv_serwisanci.Show();
            btn_aktualizuj_serwisanta.Hide();
        }

        private void Frm_testowy_Load(object sender, EventArgs e)
        {
            dgv_serwisanci.BringToFront();
            panel_dodaj_aktualizuj_serwisanta.Hide();
            SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from tb_serwisanci", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_serwisanci.DataSource = dt;
            con.Close();
        }

        private void btn_dodaj_serwisanta_Click(object sender, EventArgs e)
        {
            panel_serwisanci.Hide();
            panel_dodaj_aktualizuj_serwisanta.Show();
            btn_aktualizuj_serwisanta.Hide();
            dgv_serwisanci.Hide();
        }

        private void btn_aktualizuj_dane_serwisanta_Click(object sender, EventArgs e)
        {
            panel_serwisanci.Hide();
            panel_dodaj_aktualizuj_serwisanta.Show();
            btn_dodaj_serwisanta2.Hide();
            dgv_serwisanci.Hide();

            DataGridViewRow row = dgv_serwisanci.Rows[dgv_serwisanci.CurrentRow.Index] as DataGridViewRow;
            SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30; " +
                "Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

            con.Open();
            SqlCommand cmd = new SqlCommand("Select Id,Imie_Serwisanta,Nazwisko_Serwisanta,Nr_tel_Serwisanta,Mail_Serwisanta from tb_serwisanci where Id=@ID ", con);
            cmd.Parameters.AddWithValue("ID", row.Cells[0].Value);
            SqlDataReader srd = cmd.ExecuteReader();

            while (srd.Read())
            {
                Imie_Serwisanta = srd.GetValue(1).ToString();
                Nazwisko_Serwisanta = srd.GetValue(2).ToString();
                Nr_tel_Serwisanta = srd.GetValue(3).ToString();
                Mail_Serwisanta = srd.GetValue(4).ToString();
            }
            panel_serwisanci.Hide();
            panel_dodaj_aktualizuj_serwisanta.BringToFront();
            tb_imie_serwisanta.Text = Imie_Serwisanta;
            tb_Nazwisko_serwisanta.Text = Nazwisko_Serwisanta;
            tb_nr_tel_serwisanta.Text = Nr_tel_Serwisanta;
            tb_email_serwisanta.Text = Mail_Serwisanta;
        }
    }
}
