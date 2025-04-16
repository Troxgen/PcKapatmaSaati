# PC Kapatma Saati (Arduino Destekli)

**PcKapatmaSaati**, bilgisayarınızı belirli bir süre sonra otomatik olarak kapatmanızı sağlayan, Arduino destekli bir masaüstü uygulamasıdır. Bu proje, Arduino Uno ve C# (Windows Forms) kullanılarak geliştirilmiştir.

---

## 🚀 Özellikler

- Geri sayım başlatıldığında bilgisayarın belirlenen sürede kapanması
- Arduino ile seri haberleşme üzerinden kontrol
- Basit ve kullanıcı dostu arayüz
- Açık kaynak kod

---

## 🛠️ Kurulum Kılavuzu

### 1️⃣ Arduino Bağlantısı

- Arduino Uno’nuzu bilgisayarınızdaki herhangi bir USB porta bağlayınız.

### 2️⃣ Arduino Kodunun Yüklenmesi

1. Arduino IDE'yi açınız. (Eğer yüklü değilse: https://www.arduino.cc/en/software)
2. "Dosya" > "Aç" menüsünden `Arduino/Trx.ino` dosyasını seçiniz.
3. Arduino Uno’nuzun bağlı olduğu portu seçmek için:
- "Araçlar" > "Kart" menüsünden `Arduino Uno` seçin.
- "Araçlar" > "Port" menüsünden uygun COM portu seçin (örneğin `COM3`).
4. Üstteki "Yükle" (✔) butonuna tıklayarak programı Arduino Uno’ya yükleyin.

### 3️⃣ Masaüstü Uygulamanın Çalıştırılması

1. Proje klasöründe yer alan `Csharp` klasörünü açın.
2. `PcKapatmaSaati.sln` dosyasını Visual Studio ile açın.
3. Gerekli NuGet paketleri varsa yükleyin.
4. F5 tuşuna basarak projeyi çalıştırın.

✅ Kurulum tamamlandıktan sonra program arayüzü açılacak ve Arduino üzerinden kontrol sağlanacaktır.

---

## ⚙️ Gereksinimler

- **Arduino Uno**
- **Arduino IDE** (sürüm 1.8.19 veya üstü önerilir)
- **Visual Studio 2019/2022**
- **.NET Framework 4.7.2 veya üstü**
- Windows işletim sistemi

---


## 📄 Lisans

Bu proje MIT lisansı ile lisanslanmıştır. Detaylar için [LICENSE](LICENSE) dosyasına göz atabilirsiniz.

---

## 👤 Geliştirici

**Troxgen**  
GitHub: [github.com/Troxgen](https://github.com/Troxgen)

---

Projeyi faydalı bulduysanız ⭐ vermeyi unutmayın!
