using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;

[TestClass]
public class SerwisantDatabaseTests
{
    private const string ConnectionString = "Data Source=KONRAD-WRZOSEK; Initial Catalog=Serwis_plus_DB; Integrated Security=True; Connect Timeout=30; Encrypt=False; " +
        "TrustServerCertificate=False; ApplicationIntent=ReadWrite; MultiSubnetFailover=False";

    [TestMethod]
    public void DodajSerwisanta_DoBazyDanych_SprawdzCzyDodano()
    {
        // Arrange
        using (SqlConnection con = new SqlConnection(ConnectionString))
        {
            con.Open();
            string imie = "Jan";
            string nazwisko = "Kowalski";
            string nrTel = "123456789";
            string email = "jan.kowalski@example.com";

            // Act
            using (SqlCommand cmd = new SqlCommand("INSERT INTO tb_serwisanci (Imie_Serwisanta, Nazwisko_Serwisanta, Nr_tel_Serwisanta, Mail_Serwisanta) VALUES" +
                " (@Imie, @Nazwisko, @NrTel, @Email)", con))
            {
                cmd.Parameters.AddWithValue("@Imie", imie);
                cmd.Parameters.AddWithValue("@Nazwisko", nazwisko);
                cmd.Parameters.AddWithValue("@NrTel", nrTel);
                cmd.Parameters.AddWithValue("@Email", email);

                int rowsAffected = cmd.ExecuteNonQuery();

                // Assert
                Assert.AreEqual(1, rowsAffected, "Nie dodano serwisanta do bazy danych.");
            }
        }
    }
}
