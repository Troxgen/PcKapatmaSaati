#include <LiquidCrystal_I2C.h>

LiquidCrystal_I2C lcd(0x27, 20, 4);
bool Giris = true;
unsigned long previousMillis = 0;

const long interval = 1000;
int Saat;
int Dakika;
int Saniye;

void setup() {
    Serial.begin(9600);
    lcd.init();
    lcd.backlight();
}

void KarsilamaEkrani() {
    if (Giris) {
        lcd.setCursor(1,0);
        lcd.print("Secim Yapiniz");
        lcd.setCursor(3,1);
        lcd.print("1h, 2h, 3h");  
    }
}

void loop() {
    KarsilamaEkrani();
    if (Serial.available() > 0) {
        lcd.clear();
        char veri = Serial.read();
        if (veri >= '1' && veri <= '3') {
            Saat = 0;
            Dakika = 0;
            Saniye = 0;
            Saat = veri - '0'; 
           
            Giris = false; 
        } else if (veri == 'E') {
            Saat = 0;
            Dakika = 0;
            Saniye = 0;
            KarsilamaEkrani();
        }
    }
    if (!Giris) {
        unsigned long currentMillis = millis();
        if (currentMillis - previousMillis >= interval) {
            previousMillis = currentMillis;
            ZamanGuncelleme();
            EkranGosterme();
        }
    }
}

void EkranGosterme() {
    char tablo[20];
    sprintf(tablo, "%02d:%02d:%02d", Saat, Dakika, Saniye);
    lcd.setCursor(2, 0);
    lcd.print("Kalan Sure :"); 
    lcd.setCursor(4, 1);
    lcd.print(tablo);
}

void ZamanGuncelleme() {
    if (Saniye > 0) {
        Saniye--;
    } else if (Dakika > 0) {
        Saniye = 59;
        Dakika--;
    } else if (Saat > 0) {
        Dakika = 59;
        Saniye = 59;
        Saat--;
    } else {
        Giris = true; 
        lcd.clear();
        KarsilamaEkrani();
    }
}
