#🚀 C# Eğitim Kampı Financial CRM Projesi
Bu repository, Murat Yücedağ’ın C# Eğitim Kampı adlı eğitim serisinin final projesini içermektedir. 
Katılımcıların öğrendikleri bilgileri uygulamalı olarak pekiştirdiği bu aşama, aynı zamanda genel bir değerlendirme süreciyle eğitimin tamamlandığı bölümü temsil etmektedir.

---

#📌 Kullanılan Teknolojiler:
 - C# (Windows Forms)
 - DB First Modeli
 - Entity Framework
 - SQL Server
 - Linq Sorguları

---

#📌 Login Formu:
![login](https://github.com/user-attachments/assets/2894cf41-f1a1-4542-948a-ccf321ac3b27)
Bu form, kullanıcıların uygulamaya güvenli bir şekilde giriş yapmasını sağlar.
Kullanıcı adı veya şifrenin eksik ya da hatalı girilmesi durumunda, sistem kullanıcıyı bilgilendiren bir hata mesajı gösterir ve giriş bilgilerinin yeniden girilmesini ister.
Giriş bilgileri doğru şekilde doğrulandığında, kullanıcı Dashboard paneline yönlendirilir.

---

#📌 Dashboard Formu:
![Ekran görüntüsü 2025-06-30 171753](https://github.com/user-attachments/assets/993628e5-dbea-4292-81fe-99c7732b6788)
Dashboard Formu, kullanıcıların finansal verilerini kolayca görüntüleyebileceği ve çeşitli işlevlere erişim sağlayabileceği merkezi bir kontrol panelidir.
 - Toplam Bakiye Görüntüleme: Kullanıcının toplam finansal varlıkları anlık olarak izlenebilir ve güncel bakiye durumu görüntülenebilir.
 - Dinamik Fatura Bilgileri: Faturalara ait veriler gerçek zamanlı olarak güncellenmekte ve kullanıcı tarafından anlık olarak takip edilebilmektedir.
 - Son Gelen Havale Bilgileri: En son gerçekleşen havale işlemlerini ayrıntılı biçimde görüntülenebilir ve kullanıcı tarafından incelenebilir.
 - Banka Hesaplarının Dağılım Grafiği: Kullanıcıların banka hesaplarındaki varlıklarının istatistiksel dağılımı grafiksel olarak sunulmuştur.
 - Borç Yönetimi Grafiği: Kullanıcının geçmişte ödediği ve gelecekte ödemesi gereken borçlara ilişkin veriler analiz edilip görselleştirilmiştir.
Ayrıca, sol panelde bulunan gezinme menüsü sayesinde kullanıcılar farklı sayfalar arasında hızlı ve kolay bir şekilde geçiş yapabilir.
Bu yapı, kullanıcıların finansal durumlarını kapsamlı biçimde analiz etmelerini ve verimli bir şekilde yönetmelerini sağlamak amacıyla tasarlanmıştır.

---

#📌 Kategori Formu:
![Ekran görüntüsü 2025-06-30 172243](https://github.com/user-attachments/assets/fce92fdd-b9a6-488b-9d10-e39df8be2d51)
Kullanıcılar bu platform üzerinden temel CRUD (Create, Read, Update, Delete) işlemlerini gerçekleştirebilirler.
Sistem üzerinden:
 - Yeni kategoriler ekleyebilir,
 - Mevcut kategorileri listeleyebilir,
 - Kayıtlı verileri güncelleyebilir
 - İhtiyaç duyduklarında silme işlemi yapabilirler.
Bu esnek yapı, kullanıcıların verilerini kolayca yönetmelerine ve içerikleri kendi ihtiyaçlarına göre organize edebilmelerine olanak tanır.

---

#📌 Banka Formu:
![Ekran görüntüsü 2025-06-30 172525](https://github.com/user-attachments/assets/ff7f3a2b-ab34-4733-b5fc-7eb886b4d7da)
Kullanıcılar bu ekran üzerinden, çalıştıkları bankalardaki toplam bakiyelerini görüntüleyebilir ve farklı banka hesaplarına ait son 5 banka işleminin detaylarına erişim sağlayabilirler.
Bu özellik, finansal hareketlerin kolayca izlenmesini sağlayarak kullanıcıların hesap yönetimini daha etkin ve kontrollü bir şekilde gerçekleştirmelerine olanak tanır.

---

#📌 Fatura Formu:
![Ekran görüntüsü 2025-06-30 172800](https://github.com/user-attachments/assets/11febfab-5947-4a62-b493-c59ed6eb8a95)
Kullanıcılar bu modül üzerinden gerçekleştirdikleri fatura ödeme işlemlerini sisteme kaydedebilir, mevcut faturaları detaylı olarak listeleyebilir, kayıtlı veriler üzerinde güncellemeler yapabilir ve gerektiğinde silme işlemi gerçekleştirebilirler.
Bu form, fatura bilgilerinin sistematik şekilde yönetilmesine olanak tanıyarak kullanıcıların ödeme geçmişini etkin biçimde takip etmesini sağlar.

---

#📌 Gider Formu:
![Ekran görüntüsü 2025-06-30 172957](https://github.com/user-attachments/assets/bc3df17a-4778-45af-8b85-0b568bf535d4)
Kullanıcılar bu modül üzerinden gerçekleştirdikleri tüm harcama işlemlerini sisteme kaydedebilir, mevcut harcamaları detaylı bir şekilde listeleyebilir, kayıtlı veriler üzerinde güncellemeler yapabilir ve gerektiğinde silme işlemi gerçekleştirebilirler.
Bu yapı sayesinde, kullanıcıların ödeme süreçlerini etkin bir şekilde yönetebilmesi için gerekli olan CRUD (Create, Read, Update, Delete) işlemleri eksiksiz şekilde desteklenmektedir.

---

#📌 Banka Hareketleri Formu:
![Ekran görüntüsü 2025-06-30 173215](https://github.com/user-attachments/assets/199c69e6-ce03-4467-b03c-e5628633b436)
Kullanıcılar, bu ekran üzerinden hesaplarına gelen havale işlemlerinin detaylarını görüntüleyebilirler.

---

#📌 Çıkış Yap Butonu:
![Ekran görüntüsü 2025-06-30 173416](https://github.com/user-attachments/assets/9944f778-6eb6-424a-9de7-3063b84803aa)
Kullanıcılar, yan panelde bulunan “Çıkış Yap” butonuna tıkladıklarında, programdaki aktif kullanıcı oturumu sonlandırılır ve uygulamadan güvenli bir şekilde çıkış yapmaları sağlanır.

