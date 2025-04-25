using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1;

using System.Data;
using System.Data.SqlClient;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnGetir_Click(object sender, RoutedEventArgs e)
        {
            string koyAdi = txtKoyAdi.Text; // Kullanıcının girdiği köy adı

            if (string.IsNullOrWhiteSpace(koyAdi))
            {
                MessageBox.Show("Lütfen köy adı giriniz!", "Uyarı", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Veriyi getir ve DataGrid'e yükle
            DataTable result = GetMuhtarVeDurumBilgisi(koyAdi);
            if (result.Rows.Count > 0)
            {
                dataGridKoyBilgileri.ItemsSource = result.DefaultView;
            }
            else
            {
                MessageBox.Show("Girilen köy adına ait veri bulunamadı!", "Bilgi", MessageBoxButton.OK, MessageBoxImage.Information);
                dataGridKoyBilgileri.ItemsSource = null;
            }
        }

        private DataTable GetMuhtarVeDurumBilgisi(string koyAdi)
        {
            DataTable dt = new DataTable();
            string connectionString = "Server=localhost;Database=cesme;User Id=sa;Password=1;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT M.MuhtarAdi, M.Telefon, KD.Durum
                        FROM Koyler AS K

                        INNER JOIN Muhtarlar AS M ON K.KoyID = M.KoyID
                        INNER JOIN Cesmeler AS C ON K.KoyID = C.KoyID
                        INNER JOIN KullanimDurumu AS KD ON C.CesmeID = KD.CesmeID
                        WHERE K.KoyAdi = @KoyAdi;";


                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@KoyAdi", koyAdi);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return dt;
        }

        private void btnKoyGetir_Click(object sender, RoutedEventArgs e)
        {
            VeritabaniYonetici databaseHelper = new VeritabaniYonetici();

            List<string> koyListesi = databaseHelper.GetKoyler(1);

            // TextBox'a verileri yazdırma
            text1.Text = string.Join("\n", koyListesi); // Her çeşme adını alt alta yaz
        }

        private void btnKoyGetir_Click1(object sender, RoutedEventArgs e)
        {
            VeritabaniYonetici databaseHelper = new VeritabaniYonetici();

            List<string> koyListesi = databaseHelper.GetKoyler(2);

            // TextBox'a verileri yazdırma
            text2.Text = string.Join("\n", koyListesi); // Her çeşme adını alt alta yaz
        }
    }
}