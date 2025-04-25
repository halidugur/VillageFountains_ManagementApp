💧 Village Fountains Management App
🖥️ Platform: Windows
🛠️ Teknoloji: Windows Forms (.NET Framework)
🗄️ Veritabanı: Microsoft SQL Server
🚀 Durum: Aktif geliştirme aşamasında

📌 Genel Bilgi
Bu proje, yerel çeşme verilerini yönetmek amacıyla geliştirilmiş bir masaüstü uygulamasıdır. SQL Server üzerinde tutulan veriler, kullanıcı dostu bir arayüz ile Windows Forms üzerinden görüntülenip yönetilebilir.

🧠 Kırsal bölgelerdeki çeşme altyapılarını dijitalleştirme, bakım süreçlerini kolaylaştırma ve sürdürülebilir kayıt sistemi oluşturma amacı taşır.

🧩 Özellikler
🗂️ SQL Server destekli veritabanı yönetimi

🖱️ Windows Forms tabanlı kullanıcı arayüzü

🔍 Kayıt listeleme, arama ve filtreleme

➕ Yeni çeşme ekleme

🛠️ Kayıt güncelleme ve silme

💾 Otomatik bağlantı ve hata kontrol mekanizması

🛠️ Kullanılan Teknolojiler

Teknoloji	Açıklama
C#	Uygulama geliştirme dili
Windows Forms	Masaüstü arayüz oluşturma
SQL Server	Veritabanı yönetimi
ADO.NET	Veri bağlantısı ve işlemler
Git & GitHub	Sürüm kontrolü ve işbirliği

💽 Veritabanı Yapısı
Proje ile birlikte gelen Script.sql dosyası şunları içerir:

Cesmeler tablosu

ID, Adres, Semt, Mahalle, Durum gibi alanlar

Hazır test verileri

Kurulum için:

sql
-- SQL Server Management Studio'da:
CREATE DATABASE VillageFountainsDB;
GO
USE VillageFountainsDB;
GO
-- Ardından Script.sql dosyasını çalıştırın.
🔧 Kurulum Adımları
SQL Server'da VillageFountainsDB veritabanını oluştur.
Script.sql dosyasını çalıştırarak tablo ve verileri yükle.
Visual Studio üzerinden projeyi aç.
App.config dosyasındaki connection string'i düzenle:

xml kodu:
<connectionStrings>
  <add name="VillageFountainsDB" connectionString="Data Source=.;Initial Catalog=VillageFountainsDB;Integrated Security=True"/>
</connectionStrings>
Projeyi başlat (F5) ve sistemi test et!

📷 Ekran Görüntüleri

![vtys1](https://github.com/user-attachments/assets/b83244d5-5abc-4dee-8a40-0a29976d9b66)
![vtys2](https://github.com/user-attachments/assets/d990d018-9304-4258-be5f-10b85b7f4b28)

🚧 Bilinen Hatalar
 Hatalı girişlerde kullanıcı bilgilendirmesi eksik

 Bağlantı hataları için gelişmiş logging mekanizması planlanıyor

✨ Katkıda Bulun
Projeyi fork'layarak geliştirebilir, pull request gönderebilir ya da issue açarak önerilerini paylaşabilirsin.
