using Xunit;
using System.Data;
using System;
using System.Data.SqlClient;



namespace SerwisPlus.Tests
{

    public class Frm_KlienciTests
    {
        [Fact]
        public void Btn_dodaj_klienta_2_Click_Should_AddClientToDatabase()
        {
            // Arrange
            var frmKlienci = new Frm_Klienci(); // Create an instance of the Frm_Klienci class
            frmKlienci.tb_nazwa_firmy.Text = "TestFirma";
            frmKlienci.tb_nip.Text = "123456789";
            frmKlienci.tb_miejscowosc.Text = "TestMiejscowosc";
            frmKlienci.tb_kod_pocztowy.Text = "12345";
            frmKlienci.tb_nr_tel.Text = "123456789";
            frmKlienci.tb_email.Text = "test@example.com";
            var expectedMessage = "Dodano nowego Klienta";

            // Act
            frmKlienci.btn_dodaj_klienta_2_Click(null, EventArgs.Empty); // Pass null and EventArgs.Empty as arguments since they are not used in the method

            // Assert
            // Add assertions to check if the client was added to the database

            using (SqlConnection con = new SqlConnection("Data Source = KONRAD-WRZOSEK; Initial Catalog = Serwis_plus_DB; Integrated Security = True; Connect Timeout = 30;" +
                " Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tb_klienci WHERE Nazwa_firmy = @Nazwa_firmy AND NIP = @NIP AND Miejscowosc = @Miejscowosc AND Ulica = @Ulica AND Kod_pocztowy = @Kod_pocztowy AND Nr_tel = @Nr_tel AND Email = @Email", con);
                cmd.Parameters.AddWithValue("@Nazwa_firmy", frmKlienci.tb_nazwa_firmy.Text);
                cmd.Parameters.AddWithValue("@NIP", frmKlienci.tb_nip.Text);
                cmd.Parameters.AddWithValue("@Miejscowosc", frmKlienci.tb_miejscowosc.Text);
                cmd.Parameters.AddWithValue("@Ulica", frmKlienci.tb_ulica.Text);
                cmd.Parameters.AddWithValue("@Kod_pocztowy", frmKlienci.tb_kod_pocztowy.Text);
                cmd.Parameters.AddWithValue("@Nr_tel", frmKlienci.tb_nr_tel.Text);
                cmd.Parameters.AddWithValue("@Email", frmKlienci.tb_email.Text);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                Assert.Equal(1, count); // Expecting 1 row in the table with the given data
            }

            // Assert that the appropriate message box was shown
            var messageBox = MessageBox.Show(null, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Assert.Equal(expectedMessage, messageBox.Message);

            // Additional assertions for other expected changes in the UI or behavior
            Assert.True(frmKlienci.panel_klienci.Visible);
            Assert.True(frmKlienci.dgv_klienci.Visible);
            Assert.False(frmKlienci.panel_aktualizuj_klienta.Visible);
        }
    }
}