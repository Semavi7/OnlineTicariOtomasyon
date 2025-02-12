# Mağaza Yönetim Paneli Projesi

Merhaba! Bu projede ASP.NET MVC 5 ve .NET Framework kullanarak dinamik bir mağaza yönetim sistemi geliştirdim. Proje üç temel panelden oluşuyor:

&#8226;Vitrin Paneli → Ürünlerin listelendiği kısım

&#8226;Admin Paneli → Ürünler, siparişler, kullanıcılar ve carilerin yönetildiği panel

&#8226;Kullanıcı Paneli → Sipariş geçmişi, mağaza ile mesajlaşma ve kargo takibi gibi özellikleri içeren panel


Bu proje sayesinde Entity Framework, LINQ, SQL Trigger & Stored Procedure, Authentication & Authorization gibi ileri seviye konuları uygulamalı olarak deneyimledim. Yaklaşık 20 kadar tablo kullandım
Tabloların büyük bir kısminda ilişkiler var. Veri tabanı
olarak MSSQL tercih ettim.


---

## 🎯 Projenin Amacı

Bu projeyi geliştirirken ASP.NET MVC 5 ve .NET Framework ile dinamik bir mağaza yönetim sistemi oluşturmayı hedefledim. Temel CRUD işlemlerinin ötesinde, veri yönetimi, SQL entegrasyonu ve güvenlik konularına da odaklandım.

Katmanlı mimari kullanmadan, doğrudan MVC'nin özelliklerini deneyimlemeye odaklandım.


---

## 🛠 Kullanılan Teknolojiler

Bu projede aşağıdaki teknolojileri ve araçları kullandım:

&#8226;ASP.NET MVC 5 – Web uygulamasının temelini oluşturan framework

&#8226;Entity Framework 6 – ORM aracı olarak Code First yöntemi ile

&#8226;SQL Server – Veritabanı yönetimi

&#8226;LINQ – Veritabanı sorguları için

&#8226;Stored Procedure & Trigger – Veritabanı işlemlerini optimize etmek için

&#8226;HTML, CSS, Bootstrap – Kullanıcı arayüzünü oluşturmak için

&#8226;JavaScript & jQuery – Dinamik bileşenler ve kullanıcı etkileşimi için

&#8226;Session & Authentication – Kullanıcı ve admin girişlerini yönetmek için



---

## 📌 Proje İçeriği

Projede Admin, Kullanıcı ve Vitrin Paneli olmak üzere üç ana yapı bulunuyor:

### 🛍 Vitrin Paneli (Mağaza Ön Yüzü)

&#8226;Ürünlerin listelendiği sayfa

&#8226;Ürün detay sayfası

### ⚙️ Admin Paneli

&#8226;Dashboard – Sipariş, kullanıcı ve ürün istatistikleri

&#8226;CRUD işlemleri – Ürün, kategori, sipariş ve kullanıcı yönetimi

&#8226;Cari Paneli – Kullanıcıların hesaplarının takibi

&#8226;Fatura Sistemi – Dinamik fatura oluşturma

&#8226;Kargo Takip Sistemi – Sipariş durum takibi

&#8226;Yetkilendirme & Authentication – Admin ve kullanıcı giriş kontrolü


### 👤 Kullanıcı Paneli

&#8226;Kullanıcıların mağazaya kayıt olup giriş yapabilmesi

&#8226;Sipariş geçmişi ve kargo takibi

&#8226;Mağaza ile mesajlaşma özelliği

&#8226;Şifre değiştirme ve profil güncelleme



---

## 🔧 Öğrendiklerim & Deneyimlerim

Bu proje boyunca ASP.NET MVC 5 ve Entity Framework kullanımını geliştirdim:

✅ ASP.NET MVC 5 Yapısı – Controller, View ve Model yapısını etkin şekilde kullandım

✅ Entity Framework 6 ile Code First Yaklaşımı – Migration, ilişkili tablolar ve veri yönetimi konularında pratik yaptım

✅ LINQ Sorguları – SQL sorgularını LINQ ile daha performanslı hale getirdim

✅ Trigger & Stored Procedure Kullanımı – SQL tarafında veri işleme optimizasyonları yaptım

✅ Yetkilendirme & Authentication – Session, Cookie yönetimi ve Role-Based Authorization yapılarını uyguladım

✅ Dashboard & Google Charts – Yönetim panelinde grafiklerle görselleştirilmiş veri gösterimi

✅ Dinamik Fatura Sistemi – Kullanıcıların siparişleri için otomatik fatura oluşturma

✅ QR Kod Üretme – Ürünler için otomatik QR kod oluşturup entegrasyon sağladım

✅ Hata Sayfaları (403, 404, 500) – Kullanıcı deneyimi için özel hata sayfaları ekledim


---

## 🎉 Sonuç & Gelecek Planlarım

Bu proje sayesinde ASP.NET MVC 5 ve Entity Framework konusunda kendimi geliştirdim. Gerçek bir mağaza yönetim sisteminin temel bileşenlerini oluşturdum ve MVC’nin avantajlarını deneyimledim.

Ancak proje benim için bitmedi.
İlerleyen süreçte projeyi katmanlı mimari ile yeniden düzenlemeyi ve Web API ile entegre hale getirmeyi düşünüyorum.

Bu proje, Murat Yücedağ hocanın Udemy'de ki eğitimi kapsamında geliştirildi. Kendisine böyle değerli bir içeriği paylaştığı için teşekkür ederim!
