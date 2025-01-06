#  <img height="50" src="https://user-images.githubusercontent.com/25181517/121405384-444d7300-c95d-11eb-959f-913020d3bf90.png"> EĞİTİM KAMPI
👋 Merhabalar, oluşturmuş olduğum bu repo, Murat Yücedağ hocamızın YouTube üzerinden hazırlamış olduğu C# Eğitim Kampı süresince tamamlamış olduğum projeleri içermektedir. Bu eğitimde Finansal CRM Projesi anlatılmaktadır.

İlk olarak Microsoft SQL Server'i açıyoruz ve bir tane veri tabanı oluşturuyoruz. Veri tabanımızın ismini FinancialCrmDb olarak belirledik.

![image](https://github.com/user-attachments/assets/7bd87eeb-b20b-412c-a429-dd76c6c1702f)

Burada Finansal CRM'ye ait olan bölümler yer verilmiştir. Bu bölümlere ait tek tek tablolarımızı oluşturuyoruz.

![image](https://github.com/user-attachments/assets/cba70739-14aa-4243-ba97-d17e40e030f1)

![image](https://github.com/user-attachments/assets/72271045-a047-4e17-9b7c-e52acb3ae353)

İlk tablo ismini Categories olarak belirleyip örnek veri girişlerimizi yaptık.

![image](https://github.com/user-attachments/assets/0a72d694-bbf7-43b1-b737-5b5da3ffde3d)

![image](https://github.com/user-attachments/assets/e7e6026d-ec8b-4837-bd9a-dc6161151484)

İkinci tablo ismini Banks olarak belirleyip örnek veri girişlerimizi yaptık.

![image](https://github.com/user-attachments/assets/6b049133-5846-40e3-8bec-49bb1ed99983)

Üçüncü tablo ismini BankProcess olarak belirledik, ancak burada örnek veri girişi yapmadan önce ilişkili diyagramı oluşturmamız gerekmektedir.

![image](https://github.com/user-attachments/assets/c64d776d-d103-4ef9-ad1e-f3b7fc522a9c)

Database Diagrams'a sağ tıklayıp New Database Diagram diyoruz ve çıkan uyarıda Yes diyoruz.

![image](https://github.com/user-attachments/assets/de8ee7d6-0d64-45a6-81d3-3f20ee448754)

Burada ilişkili tablolar hangisiyse onları alıyoruz ancak isterseniz bütün tabloları seçebilirsiniz. Burada BankProcess ile Banks tablolarını seçip önce Add, sonra Close diyoruz.

![image](https://github.com/user-attachments/assets/c45783ba-90c7-4124-9019-6d8985aaa745)

Diyagramlar karşımıza bu şekilde çıkmaktadır.

![image](https://github.com/user-attachments/assets/ef5bc570-f388-452e-8afe-624ba0eeaa25)

Banks tablosunda yer alan BankID sütundaki anahtar sembolüne basılı tutup BankProcess tablosunda yer alan BankID sütununa sürüklüyoruz ve gelen pencerelere direkt OK diyoruz ve diyagramı kaydediyoruz. Kaydedeceğimiz diyagramın ismi Diagram_0 olarak kalabilir.

Artık BankProcess tablosundan veri girişi yapabiliriz.

![image](https://github.com/user-attachments/assets/be96b6c4-fe4a-4a3d-b7e9-395bceb77b66)

BankProcess tablosuna örnek veri girişlerimizi yaptık.

![image](https://github.com/user-attachments/assets/e2d6d9a4-0597-4293-8858-bab20528fb44)

![image](https://github.com/user-attachments/assets/334a0c03-8ea6-467a-8547-098a15e429b0)

Dördüncü tablonun ismini Bills olarak belirleyip örnek veri girişlerimizi yaptık.

![image](https://github.com/user-attachments/assets/1f346996-48af-4914-ab76-0873b020ced2)

Beşinci tablonun ismini Spendings olarak belirledik, örnek veri girişi yapmadan önce bu kez daha önceden oluşturduğumuz diyagramı açıyoruz ve diyagramdaki herhangi bir alana sağ tıklayıp Add Table diyoruz.

![image](https://github.com/user-attachments/assets/ff8008e0-3017-4fc3-b192-a2bbd3a44dfb)

Bu kez Categories ve Spendings tablolarını seçiyoruz. (İsterseniz tümünü seçebilirsiniz.)

Categories tablosundaki CategoryID sütundaki anahtar sembolüne basılı tutup Spendings tablosunda yer alan CategoryID sütununa sürüklüyoruz ve gelen pencerelere direkt OK diyoruz ve diyagramı kaydediyoruz.

![image](https://github.com/user-attachments/assets/d3d0c102-0b86-4ec4-b8fd-4d21571a7217)

Spendings tablosuna örnek veri girişlerimizi yaptık.

![image](https://github.com/user-attachments/assets/b2a24464-0513-4e96-a2da-1d88665917c4)

![image](https://github.com/user-attachments/assets/14be1ca6-34fa-4784-b924-73b0cdcd6682)

Burada kullanıcı girişi için Users tablosu oluşturduk ve kullanıcı ile şifre belirledik.

Veri tabanı işlemlerimizi tamamladıktan sonra Visual Studio'ya dönüyoruz.

Başlangıçta bize verilen Form1'in ismini FrmDashboard olarak değiştirdik ve bunun yanında FrmBanks adında yeni bir Form ekledik. Program.cs kısmına geldiğimizde uygulamayı FrmBanks'tan başlatacağız.

![image](https://github.com/user-attachments/assets/03efa6a7-abf7-48e6-b8a9-e924ae96f6c2)

FrmBanks formumuzun tasarımını bu şekilde ayarladık.
