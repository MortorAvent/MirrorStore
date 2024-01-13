# **Dokumentacja Projektu: MirrorStore**

### **Wstęp:**
Przedstawiam projekt sklepu internetowego ,który zajmuje się sprzedażą luster ręcznie robionych.

### Wymagania systemowe:
Lista wymagań, które muszą być spełnione, aby uruchomić projekt, np.:

.NET MVC SDK (6.0)
Serwer SQL (SQL Server)
Wymagane uprawnienia administracyjne
Przeglądarka internetowa wspierająca HTML5, CSS3, JavaScript

### Instalacja:
Krok po kroku opis instalacji projektu:

Sklonuj repozytorium projektu z GitHub.
Otwórz rozwiązanie MirrorStore.sln w Visual Studio.
Zbuduj projekt, aby pobrać wszystkie zależności NuGet.

### Konfiguracja
Szczegółowy opis konfiguracji środowiska i aplikacji:

Konfiguracja appsettings.json z łańcuchem połączenia do bazy danych:
**"DevConnection": "Server=DUDA;Database=MirrorStore;Trusted_Connection=True;TrustServerCertificate=True;",**

Ustawienia dotyczące autoryzacji i uwierzytelniania użytkowników:
Admin może wszystko.
User może wysyłać formularze oraz przeglądać sklep, nie może nic edytować ,usuwać ,dodawać. 

Przykłady tworzenia testowych użytkowników i ich haseł:
**Admin** - **Login:**  szczepanduda11@gmail.com      **Hasło:** #EDC4r
**User **- **Login:** paweł@gmail.com   **Hasło:** #EDC4r

### Opis używania aplikacji:

Możliwość zarejestrowania użytkownika.
Możliwość zalogowania się.
Możliwość wysłania formularza.
Admin może edytować ,usuwać ,tworzyć przedmioty.
Rejestracja użytkownika ,jest zapisywana w bazie danych.
Jest użyta autoryzacja ,to znaczy użytkownik ,któy nie jest adminem ,ma przyblokowane opcje usuwania, edytowania ,tworzenia przedmiotów.

