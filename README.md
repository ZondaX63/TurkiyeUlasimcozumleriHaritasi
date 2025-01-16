### README (English)

# Türkiye Ulaşım Çözümleri Haritası

Türkiye Ulaşım Çözümleri Haritası is a project designed to provide transportation solutions across Turkey using an interactive map interface. The project is built with the following technologies:
- **Backend**: .NET Web API
- **Database**: MySQL
- **Frontend**: HTML, CSS, and JavaScript

---

## Features
- Interactive map interface to explore transportation solutions.
- Backend API for data retrieval and processing.
- Integration with a MySQL database for data persistence.
- Simple and user-friendly frontend interface.

---

## Getting Started

### Prerequisites
To run this project, you will need the following installed on your system:
- .NET SDK (6.0 or later)
- MySQL Server
- A modern web browser (for the frontend)

---

### Installation

#### Backend Setup (.NET Web API)
1. Navigate to the `UlasimAPI` directory:
   ```bash
   cd UlasimAPI
   ```
2. Restore the dependencies:
   ```bash
   dotnet restore
   ```
3. Configure the MySQL connection string:
   - Open `appsettings.json` in the `UlasimAPI` directory.
   - Update the `ConnectionStrings` section with your MySQL database credentials:
     ```json
     {
       "ConnectionStrings": {
         "DefaultConnection": "Server=your_server;Database=your_database;User=your_user;Password=your_password;"
       }
     }
     ```
4. Apply database migrations (if applicable):
   ```bash
   dotnet ef database update
   ```
5. Run the backend server:
   ```bash
   dotnet run
   ```

#### Frontend Setup (HTML, CSS, JS)
1. Navigate to the `UlasimFrontend` directory:
   ```bash
   cd UlasimFrontend
   ```
2. Open the `index.html` file in your browser or serve it using a local HTTP server (e.g., `live-server` or similar).

---

## Usage
1. Start the backend server as described above.
2. Open the frontend in your browser.
3. Use the interactive map to explore transportation solutions.

---

## Contribution
Contributions are welcome! Feel free to fork this repository, submit pull requests, or open issues to report bugs or suggest new features.

---

## License
This project is licensed under the MIT License.

---

### README (Turkish)

# Türkiye Ulaşım Çözümleri Haritası

Türkiye Ulaşım Çözümleri Haritası, Türkiye genelinde ulaşım çözümleri sunmak için etkileşimli bir harita arayüzü kullanan bir projedir. Proje aşağıdaki teknolojilerle geliştirilmiştir:
- **Backend**: .NET Web API
- **Veritabanı**: MySQL
- **Frontend**: HTML, CSS ve JavaScript

---

## Özellikler
- Ulaşım çözümlerini keşfetmek için etkileşimli harita arayüzü.
- Veri alma ve işleme için backend API'si.
- Veri kalıcılığı için MySQL veritabanı entegrasyonu.
- Basit ve kullanıcı dostu bir frontend arayüzü.

---

## Başlarken

### Gereksinimler
Bu projeyi çalıştırmak için sisteminizde aşağıdakiler kurulu olmalıdır:
- .NET SDK (6.0 veya üstü)
- MySQL Server
- Modern bir web tarayıcısı (frontend için)

---

### Kurulum

#### Backend Kurulumu (.NET Web API)
1. `UlasimAPI` dizinine gidin:
   ```bash
   cd UlasimAPI
   ```
2. Bağımlılıkları geri yükleyin:
   ```bash
   dotnet restore
   ```
3. MySQL bağlantı dizesini yapılandırın:
   - `UlasimAPI` dizinindeki `appsettings.json` dosyasını açın.
   - `ConnectionStrings` bölümünü MySQL veritabanı bilgilerinizle güncelleyin:
     ```json
     {
       "ConnectionStrings": {
         "DefaultConnection": "Server=sunucunuz;Database=veritabani_adiniz;User=kullanici_adiniz;Password=sifreniz;"
       }
     }
     ```
4. Veritabanı migration'larını uygulayın (eğer gerekliyse):
   ```bash
   dotnet ef database update
   ```
5. Backend sunucusunu çalıştırın:
   ```bash
   dotnet run
   ```

#### Frontend Kurulumu (HTML, CSS, JS)
1. `UlasimFrontend` dizinine gidin:
   ```bash
   cd UlasimFrontend
   ```
2. `index.html` dosyasını bir tarayıcıda açın veya yerel bir HTTP sunucusu (örneğin `live-server`) ile çalıştırın.

---

## Kullanım
1. Yukarıda belirtilen şekilde backend sunucusunu başlatın.
2. Frontend'i tarayıcınızda açın.
3. Ulaşım çözümlerini keşfetmek için etkileşimli haritayı kullanın.

---

## Katkı
Katkılarınızı bekliyoruz! Bu depoyu fork'layabilir, pull request gönderebilir veya hata bildirmek ya da yeni özellikler önermek için issue açabilirsiniz.

---

## Lisans
Bu proje MIT Lisansı ile lisanslanmıştır.
