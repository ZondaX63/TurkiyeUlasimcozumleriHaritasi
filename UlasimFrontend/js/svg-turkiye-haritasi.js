function svgturkiyeharitasi() {
    const element = document.querySelector('#svg-turkiye-haritasi'); // SVG haritasının ana container'ı
    const info = document.querySelector('.il-isimleri'); // İl ismi için info container'ı
    const selectedCity = document.getElementById('selected-city'); // Seçilen şehir ismi
    const transportationInfo = document.getElementById('transportation-info'); // Ulaşım bilgileri

    // Şehir üzerine geldiğimizde il adı gösterilir
    element.addEventListener('mouseover', function (event) {
        if (event.target.tagName === 'path') {
            const cityName = event.target.parentNode.getAttribute('data-iladi');
            info.innerHTML = cityName;
            info.style.display = 'block';
        }
    });

    // Şehirden ayrıldığımızda il adı gizlenir
    element.addEventListener('mouseout', function () {
        info.style.display = 'none';
    });

    // Şehir üzerinde fare hareket ettikçe il adı taşınır
    element.addEventListener('mousemove', function (event) {
        info.style.top = event.pageY + 20 + 'px';
        info.style.left = event.pageX + 20 + 'px';
    });

    // Şehre tıklandığında spor kulüpleri ve ulaşım çözümleri alınır
    element.addEventListener('click', function (event) {
        if (event.target.tagName === 'path') {
            const parent = event.target.parentNode;
            const cityId = parent.getAttribute('data-plakakodu'); // data-plakakodu ile şehir ID'si alınmalı
            const cityName = parent.getAttribute('data-iladi');

            // Seçilen şehri göstermek
            selectedCity.textContent = cityName;

            // Ulaşım çözümlerini al
            fetch(`http://localhost:5004/api/sehirler/${cityId}/ulasim-cozumleri`)
                .then(response => response.json())
                .then(data => {
                    // API yanıtı bir dizi içeriyor, diziyi işleyelim
                    if (data && data.length > 0) {
                        // Ulaşım türlerini liste halinde ekleyelim
                        transportationInfo.innerHTML = '<strong>Ulaşım Çözümleri:</strong><ul>';
                        data.forEach(item => {
                            transportationInfo.innerHTML += `<li>${item.ulasim_turu}</li>`;
                        });
                        transportationInfo.innerHTML += '</ul>';
                    } else {
                        transportationInfo.innerHTML = '<strong>Ulaşım çözümleri:</strong><p>Bu şehirde ulaşım çözümleri bulunamadı.</p>';
                    }
                })
                .catch(error => {
                    console.error('Ulaşım çözümleri alınırken bir hata oluştu:', error);
                    transportationInfo.innerHTML = '<strong>Ulaşım çözümleri:</strong><p>Ulaşım çözümleri alınırken bir hata oluştu.</p>';
                });
        }
    });
}

// Sayfa yüklendiğinde harita fonksiyonunun başlatılması
window.onload = function() {
    svgturkiyeharitasi();
};
