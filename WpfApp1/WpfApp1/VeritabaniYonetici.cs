using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;
namespace WpfApp1
{
    public class VeritabaniYonetici
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;
        
        public List<string> GetKoyler(int ilceID)
        {
            List<string> veriler = new List<string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT KoyAdi FROM Koyler WHERE IlceID = {ilceID}";
                SqlCommand cmd = new SqlCommand(query, connection);

                using (SqlDataReader reader = cmd.ExecuteReader()) // Sorguyu çalıştır ve sonucu oku
                {
                    while (reader.Read()) // Veritabanından satır satır veriyi oku
                    {
                        veriler.Add(reader["KoyAdi"].ToString()); // CesmeAdi sütununu alıp listeye ekle
                    }
                }
            }
            return veriler;
        }
        private List<string> Prototip(string alanAdi, string tabloAdi)
        {
            List<string> veriler = new List<string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT {alanAdi} FROM {tabloAdi}";
                SqlCommand cmd = new SqlCommand(query, connection);

                using (SqlDataReader reader = cmd.ExecuteReader()) 
                {
                    while (reader.Read()) 
                    {
                        veriler.Add(reader[alanAdi].ToString()); 

                    }
                }
            }
            return veriler;
        }
    }
}
