using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;

[TestClass]
public class KlientDatabaseTests
{
    private const string ConnectionString = "Data Source=KONRAD-WRZOSEK; Initial Catalog=Serwis_plus_DB; Integrated Security=True; Connect Timeout=30; Encrypt=False; TrustServerCertificate=False; " +
        "ApplicationIntent=ReadWrite; MultiSubnetFailover=False";

    [TestMethod]
    public void DodajKlienta_DoBazyDanych_WarunkiBrakujacychDanych()
    {
        // Arrange
        using (SqlConnection con = new SqlConnection(ConnectionString))
        {
            con.Open();
            string nazwaFirmy = "";
            string nip = "1234567890";
            string miejscowosc = "Warszawa";
            string ulica = "ul. Testowa 123";
            string kodPocztowy = "00-000";
            string nrTel = "";
            string email = "";

            // Act and Assert
            using (SqlCommand cmd = new SqlCommand("Insert into tb_klienci (Nazwa_firmy, NIP, Miejscowosc, Ulica, Kod_pocztowy, Nr_tel, Email) VALUES " +
                "(@NazwaFirmy, @NIP, @Miejscowosc, @Ulica, @KodPocztowy, @NrTel, @Email)", con))
            {
                bool sprawdzanie;

                cmd.Parameters.AddWithValue("@NazwaFirmy", nazwaFirmy);
                cmd.Parameters.AddWithValue("@NIP", nip);
                cmd.Parameters.AddWithValue("@Miejscowosc", miejscowosc);
                cmd.Parameters.AddWithValue("@Ulica", ulica);
                cmd.Parameters.AddWithValue("@KodPocztowy", kodPocztowy);
                cmd.Parameters.AddWithValue("@NrTel", nrTel);
                cmd.Parameters.AddWithValue("@Email", email);

                    if (nazwaFirmy == "" || nip == "" || miejscowosc == "" || kodPocztowy == "" && (nrTel == "" || email == ""))
                    {
                        sprawdzanie = true;
                    }
                    else
                    {
                        sprawdzanie = false;
                    }

                Assert.IsTrue(sprawdzanie);
            }
        
        }
    }

    [TestMethod]
    public void DodajKlienta_DoBazyDanych_PoprawneDane()
    {
        // Arrange
        using (SqlConnection con = new SqlConnection(ConnectionString))
        {
            con.Open();

            string nazwaFirmy = "Testowa Firma";
            string nip = "1234567890";
            string miejscowosc = "Warszawa";
            string ulica = "ul. Testowa 123";
            string kodPocztowy = "00-000";
            string nrTel = "123456789";
            string email = "test@test.com";

            // Act
            using (SqlCommand cmd = new SqlCommand("Insert into tb_klienci (Nazwa_firmy, NIP, Miejscowosc, Ulica, Kod_pocztowy, Nr_tel, Email) VALUES (@NazwaFirmy, @NIP, @Miejscowosc, @Ulica, @KodPocztowy, @NrTel, @Email)", con))
            {
                cmd.Parameters.AddWithValue("@NazwaFirmy", nazwaFirmy);
                cmd.Parameters.AddWithValue("@NIP", nip);
                cmd.Parameters.AddWithValue("@Miejscowosc", miejscowosc);
                cmd.Parameters.AddWithValue("@Ulica", ulica);
                cmd.Parameters.AddWithValue("@KodPocztowy", kodPocztowy);
                cmd.Parameters.AddWithValue("@NrTel", nrTel);
                cmd.Parameters.AddWithValue("@Email", email);

                int rowsAffected = cmd.ExecuteNonQuery();

                // Assert
                Assert.AreEqual(1, rowsAffected, "Nie dodano klienta do bazy danych.");
            }
        }
    }
}
