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

FrmBanks formumuzun tasarımını bu şekilde ayarladık. Sol tarafta bulunan kategoriler, bankalar gibi işlemler "Button", bankalar ve üzerinde bulunan bakiyeler tablosundaki araç "Panel" ve GroupBox araçları kullanıldı.

Katmanımıza gelerek Models isminde yeni bir klasör oluşturuyoruz.

Models klasörüne sağ tıklayıp Add kısmından New Item diyoruz.

![image](https://github.com/user-attachments/assets/e4259796-7a7f-4384-ae03-1393f3b032bb)

Sol tarafta yer alan seçeneklerden Data olanı seçiyoruz ve ilk çıkan ADO.NET Entity Data Model'ini seçiyoruz.

![image](https://github.com/user-attachments/assets/cb9474a7-f3ee-4f28-a965-e0f1dcb6f547)

İlk baştaki seçili gelecektir. Next diyoruz.

![image](https://github.com/user-attachments/assets/8c5b28b1-dbd6-4d2f-a39a-f66b91748505)

New Connection diyoruz.

![image](https://github.com/user-attachments/assets/8d8bf3e6-8c21-4315-8f05-7e37bf1b14bc)

Server name kısmına kendi SQL serverimizi giriyoruz. Eğer SQL Express son sürümünü kullanıyorsanız burada Trust Server Certificate kısmını seçmelisiniz. Ardından hangi veri tabanıyla çalışacaksak onu seçiyoruz. Burada FinancialCrmDb adlı veri tabanımızı seçiyoruz ve OK diyoruz.

![image](https://github.com/user-attachments/assets/8cf01bee-7239-4c1e-b7ca-16b1508388fa)

Veri tabanı modelimize ait bağlantıyı oluşturduktan sonra Next diyoruz.

![image](https://github.com/user-attachments/assets/0c454ee3-a2f3-43dc-8d03-20fc28107c54)

Entity Framework 6.x seçili gelecektir. Next diyoruz.

![image](https://github.com/user-attachments/assets/18dfdb7e-d7a3-47f8-a46c-e8b3dc1229a9)

Burada Tables kısmındaki bütün alanları seçtikten sonra Finish diyoruz.

![image](https://github.com/user-attachments/assets/735d6983-113c-4a2f-a868-8b61494f3d7f)

Modelimiz hazır. Artık kaydedebiliriz.

![image](https://github.com/user-attachments/assets/743363e0-e854-4613-82f5-a59d96665ef5)

FrmBanks formuna tıklayarak kodlarımızı yazmaya başlıyoruz. Burada ilk olarak oluşturduğumuz modelin ismini (FinancialCrmDbEntities) yazıyoruz. Burada form yüklendiği zaman bankalara ait bakiyelerin görüntülenmesini istiyoruz.

![image](https://github.com/user-attachments/assets/fc7e9cf9-1c87-4568-a2f4-de3e3072cc0f)

Burada yer alan kodları formun Load kısmına yazıyoruz. Burada var türünden tek tek değişkenleri tanımlıyoruz. Değişkenleri tanımladıktan sonra Banks tablosunu seçerek "Where" şartını kullanıyoruz. Buradaki amaç SQL'de oluşturduğumuz BankTitle sütununa karşılık gelen değerin ismi nasıl yazıldıysa aynısını buraya yazıyoruz. Örneğin SQL'de "Ziraat Bankası" diye yazarsak buradaki kod kısmında da aynısını yazmamız gerekecektir. Eğer BankTitle değerin ismi doğruysa Select fonksiyonunu kullanarak bakiyeyi görüntülemek istediğimiz sütun olan "BankBalance" seçiyoruz. Burada tek bir değeri göstereceğimiz için FirstOrDefault fonksiyonunu kullanıyoruz. Aynı şekilde diğer bankaların bakiyelerini göstermek için aynı kodları uyguluyoruz ve en sonda label araçlarına yazdırıyoruz.

![image](https://github.com/user-attachments/assets/f7a81f3a-e812-4819-9b57-a07d0e6e6cbd)

Programı çalıştırdığımız zaman bakiyeler bu şekilde görüntülenecektir. Bakiyeleri başlangıçta SQL tablosundaki değerleri kendimiz belirledik.

![image](https://github.com/user-attachments/assets/26c7ccf3-8e32-4d7d-a80b-cfe27e1d00b0)

Formumuzda daha önceden bir tane GroupBox oluşturmuştuk. Buradaki amacımız son 5 banka hareketini göstermeye çalışacağız. Buradaki Metin 1, 2 gibi labellara isimler belirledik.

![image](https://github.com/user-attachments/assets/97657e45-1367-4363-ac85-4083203058ff)

Burada var türünden bankProcess1 isminde bir değişken oluşturduk. Amacımız en son yapılan banka işlemini getirmektir. Buradan BankProcess sütununu seçip en son sıradakini göstereceğimiz için ID değerini alıyoruz ve OrderByDescending fonksiyonunu kullanıyoruz. Ardından Take fonksiyonunu kullanarak sadece bir tane göstereceğimiz için 1 diyoruz ve FirstOrDefault fonksiyonunu ekliyoruz. Label'a yazdırmak istediğimizde buradan istediğimiz sütunları alıyoruz. Burada açıklamayı, miktarı ve tarihi aldık.

![image](https://github.com/user-attachments/assets/9883b4d2-d7e7-4bab-a30f-f1f8a89d86c0)

Bir sonraki değeri göstermek için burada Take fonksiyonundan son 2 değeri alsak da burada Skip fonksiyonunu kullandık. Burada Skip dedikten sonra 1 dememizin sebebi son değeri bize göstermeyecektir.

![image](https://github.com/user-attachments/assets/dcc74b3b-2cfa-4d08-a776-fa201abab2d8)

Banka Hareketleri için kodlar bu şekildedir.

![image](https://github.com/user-attachments/assets/f249aa59-432d-4564-9a4e-98fdc0e33204)

Programı çalıştırdığımız zaman bize son 5 banka hareketlerini görüntüleyecektir.

FrmBilling isminde yeni bir form oluşturuyoruz.

![image](https://github.com/user-attachments/assets/9cb9189a-7d99-45cc-a5f8-3c6b31ace52e)

FrmBilling formunu bu şekilde oluşturduk. Burada Bills tablosuna ait olan sütunları ekleyeceğiz. Burada Label,TextBox,Button ve DataGridView araçlarını kullandık.

![image](https://github.com/user-attachments/assets/aced95eb-a49e-494d-8a2b-d84d9fe98ca6)

Faturaları DataGridView'de listeleme işlemi için gerekli kodlarımızı yazdık. Hem Form Load kısmına, hem de Ödeme Listesi butonuna yazıyoruz.

![image](https://github.com/user-attachments/assets/cc406b88-5af6-457b-9609-8324a550b918)

Form yüklendiği zaman DataGridView'e faturalara ait listeyi görüntüleyecektir.

![image](https://github.com/user-attachments/assets/cb6cf2c1-2487-4960-93d1-9031c039278d)

Yeni bir ödeme oluşturmak için gerekli kodlarımızı yazdık. Burada string, decimal türünde olan değerleri ilgili TextBox'a atadık. Ardından Bills tablosuna ait yeni bir sınıf oluşturduk. Oluşturduğumuz bu sınıfı aynı şekilde ilgili olan sütunlara karşılık gelen TextBox değerlerine tek tek atamalarımızı yapıyoruz. Ekleme işlemi için Add metodunu kullandıktan sonra kaydetmek için SaveChanges metodunu kullanıyoruz.

![image](https://github.com/user-attachments/assets/9b162111-5d1a-4868-a5d1-7558251c0c98)

Yeni bir fatura girişi yaptıktan sonra değerleri doğru girdiğimizde bizi bir mesajla karşılayacaktır.

![image](https://github.com/user-attachments/assets/91c299ea-ff5f-4e46-b541-20ebd53d28cf)

Silme işlemi için ID değerini bulmamız gerekir. Burada int türünden id isminde bir değişken oluşturduktan sonra ilgili TextBox'a atadık. Ardından removeValue isminde bir değişken oluşturup id değerini bulduruyoruz. Değeri buldurduktan sonra silme işlemi için Remove metodunu kullanıyoruz ve en sonunda SaveChanges metodunu kullanıyoruz.

![image](https://github.com/user-attachments/assets/60f4176a-6448-4ccd-8061-171af4059639)

Buradan id değerini 4 girdikten sonra Ödeme Sil butonuna bastığımızda bizi bir mesajla karşılayacaktır. Tamam dedikten sonra veri silinecektir.

![image](https://github.com/user-attachments/assets/4667edb2-087e-4a34-8a81-4dc822c29978)

Güncelleme işlemi için tek tek değerlere TextBox'a atıyoruz. Ardından id değerini buldurmaya çalıştıktan sonra tek tek değerleri ilgili sütunlara eşleştiriyoruz ve SaveChanges metodunu kullanıyoruz.

![image](https://github.com/user-attachments/assets/be2d06d2-8f47-4aab-8703-506a3a8c0cff)

Buradaki değeri güncellemek için önce ID değerini giriyoruz, ardından değiştirmek istediğimiz değerleri giriyoruz ve güncelle dedikten sonra ilgili veriler güncellenecektir.

![image](https://github.com/user-attachments/assets/eeee82c9-2068-465b-8d0f-9da87de6bbc7)

FrmBilling formundan FrmBanks formuna gidebilmek için sol tarafta yer alan Bankalar butonuna tıkladığımız zaman yazacağımız kodlar bu şekilde olacaktır. Buradan ilk önce FrmBanks formundan bir tane fr değişkeni oluşturuyoruz. Ardından formu göstermek için Show metodunu kullanıyoruz ve en sonda FrmBilling formunu gizlemesi için this.Hide metodunu kullanıyoruz.

Daha önceden oluşturduğumuz FrmDashboard formuna geliyoruz ve tasarımlarımızı yapıyoruz.

![image](https://github.com/user-attachments/assets/b84fe8e2-4e07-4a85-b778-205ec20ca231)

Burada Toplam Bakiyem, Fatura Başlığı ve Gelen Son Havaleyi formun Load kısmında görüntüleyeceğiz. Burada Timer adında yeni bir araç tanımladık. Timer aracına tıkladığımız zaman özellikler penceresinden ilk olarak Enabled kısmı false olarak gelecektir. Enabled kısmını true yapıyoruz ve Interval değerini 100 yerine 1000 olarak belirliyoruz.

Form yüklendiği zaman yazacağımız kodlar şunlardır.

![image](https://github.com/user-attachments/assets/990e0f23-7331-436a-b4be-f6049394ffad)

İlk önce global alana entities'i belirliyoruz.

![image](https://github.com/user-attachments/assets/90bee470-6ee4-4811-819a-bbc93764e27c)

Toplam bakiyeyi görüntülemek için gerekli kodlar bu şekildedir. Burada var türünden totalBalance değişkeni tanımlıyoruz. Ardından Banks tablosundan Sum metodunu kullanarak BankBalance olanı seçiyoruz ve label'a yazdırıyoruz.

![image](https://github.com/user-attachments/assets/ef5b9c9d-1458-4c58-a9ad-8ae91b552f7e)

![image](https://github.com/user-attachments/assets/af8ab247-ce96-4903-9182-7e4cf8c14062)

İkinci işlemimiz ise Fatura Başlığı olacaktır. Buradaki amaç, her saniyede farklı fatura başlığı ve miktarını görüntüleyecektir.

![image](https://github.com/user-attachments/assets/4839333f-4d5d-4736-afd2-aa5fa94b7a7b)

Üçüncüsü ve son kısım olan Gelen Son Havale işlemi için gerekli kodlar bu şekildedir. Burada OrderByDescending metodu kullanılarak en sondan başlayarak ilk değere kadar olan değerleri almasını sağlar, ancak burada Take metodunu kullandık. Take metodundan sonra bir sayı belirlersek sadece o değere kadar alır. Burada 1 dediğimiz için sadece 1 değer alacaktır.

![image](https://github.com/user-attachments/assets/da1c8fff-0bf2-4f88-95fa-99766f856105)

Programı çalıştırdığımız zaman fatura başlığı her saniye değişecektir.

![image](https://github.com/user-attachments/assets/a8ba94bf-bf86-4b9f-ac76-30da184319c8)

Bu kez FrmDashboard formumuza 2 tane Chart aracı ekledik. Buradadki amaç, form yüklendiği zaman grafiğin üzerinde yer alan metne göre grafiklerimizi oluşturacağız.

![image](https://github.com/user-attachments/assets/4515bbb4-a3dd-4c4a-89dc-75c64f63ffec)

Buradaki kodları Form Load kısmına yazıyoruz. Burada var türünden bankData isminde bir değişken oluşturup Banks tablosundan Select metodunu uyguluyoruz. Daha sonra seçmek istediğimiz alanları yazıyoruz. Ardından başlangıçta Chart aracını eklediğimizde grafiğin sağında Series1 olarak yazacaktır. Bunun için kod kısmında ilk olarak chart1.Series.Clear() metodunu uyguluyoruz. Daha sonra var türünden series isminde bir değişken oluşturup ekleme işlemini uyguluyoruz ve ismini Series1 olarak belirliyoruz. Daha sonra burada bir foreach döngüsü oluşturup grafiğe ait olan değerlerin konumlarını belirliyoruz. Burada önce Points daha sonra AddXY dememizin sebebi her iki sütunu da eklememiz gerektiğini belirtmektedir. X olan kısım BankTitle, Y olan kısım ise BankBalance'ı temsil etmektedir.

![image](https://github.com/user-attachments/assets/6fbbda08-7dc3-4fbc-a804-a60a6097a7ff)

Programımızı çalıştırdığımız zaman grafik karşımıza bu şekilde çıkacaktır.

![image](https://github.com/user-attachments/assets/b0f7e275-07fc-49b0-a927-3777d632a42a)

İkinci grafik için bu kez formumuza gidip ikinci grafiğe bir kez tıkladıktan sonra sağ köşede yer alan özellikler penceresinden Series yazan kısmın (Collection) yanındaki üç noktaya tıklıyoruz. 

![image](https://github.com/user-attachments/assets/90398082-cfd3-4bd5-aeaf-c25591b0dbfd)

Buradan isterseniz grafiğin tipini ChartType kısmından, grafiğin ismini ise Name kısmından değiştirebilirsiniz.

![image](https://github.com/user-attachments/assets/79abb0c6-81f0-4d68-8637-745ac9c2a938)

İkinci grafik için gerekli kodlar bu şekildedir. Buradaki tek fark, eğer series2.ChartType kodu yazılmazsa, programı çalıştırdığımız zaman direkt Chart aracındaki gibi sütun grafiğini gösterecektir. Burada sadece grafiğin türünü değiştirmek için bu kodu kullandık.
