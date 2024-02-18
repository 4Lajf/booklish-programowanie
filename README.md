## Dokumentacja techniczna: Booklish - strona z książkami

Twórcy dokumentacji:

Szymon Koziarz

Jakub Kowalski

## Spis Treści

1.Wprowadzenie

2.Rejestracja i Logowanie użytkownika

3.Strona główna

4.Książki

5.Zamówienia

6.Operacje CRUD dla Administratora

7.Instrukcja uruchomienia projektu

# 1.Wprowadzenie
Dokumentacja techniczna przedstawia ogólny opis strony internetowej związanej z książkami. Projekt zostanie zbudowany w oparciu o:

framework ASP.NET MVC

Entity FrameWork Core dla dostępu do danych

język C#.

Dodatkowo, front end oparty jest na standardach:

* HTML5

* CSS3

* Bootstrap.

# 2.Rejestracja i Logowanie użytkownika
Użytkownicy będą mieli możliwość rejestracji oraz logowania użytkownika, co umożliwi im dostęp do funkcji sklepu, dodawania produktów do strony z zamówieniami oraz realizacji zamówień. Bez niej nie można wejść na żadną stronę.

Każdy użytkownik podczas rejestracji ma do napisania:

* First Name

* Last Name, Email

* Password

* Confirm Password

Rola (W roli trzeba określić w osobnej podstronie, która jest dostępna tylko dla Admina, można wpisać więcej ról.)

# 3.Strona główna
Na stronie głównej sklepu będą produkty, które wyświetlą:

Zdjęcie okładki

* tytuł

* cenę

* opis

* autora

Użytkownik ma możliwość kupić produkt, który zostanie zapisany w zamówieniu.

Na nagłówku będzie możliwość wyboru strony:

* Home

* Książki

* Zamówienie

* Role

* Privacy

* Rejestracja

* Logowanie.

# 4.Książki
Na podstronie, która jest dostępna tylko dla Admina, jest możliwość zobaczenia wszystkich książek. Może je dodawać, edytować i usuwać. Przy dodawaniu książki Admin wpisuje:

* Tytuł

* Autora

* Opis

Img ( ścieżka w kodzie: wwwroot-> img, dotąd można dodawać zdjęcia książek ( przy dodawaniu trzeba wpisać nazwę tego obrazku np. inna.jpg))

# 5.Zamówienia
Użytkownicy mają dostęp do przejrzenia swoich zamówień, w których są podane dane:

* Data dodania zamówienia

* nazwa książki

* imię, nazwisko, email użytkownika, który dodał produkt

* status zamówienia

Każdy użytkownik widzi tylko własne zamówienia, oprócz administratora, który ma dostęp do wszystkich zamówień.

# 6.Operacje CRUD dla Administratora
Administrator sklepu będzie miał możliwość przeprowadzania operacji CRUD (Create, Read, Update, Delete) na wszystkich podstronach.

Baza danych, oparta na systemie zarządzania bazą danych SQL będzie zawierała takie tabele:

Tabela Book przechowuje informacje o książkach, takie jak:

* Obrazek

* Tytuł

* Cena

* Opis

Tabela User zawiera dane użytkowników takie jak:

* Imię

* Nazwisko

* Email

* Hasło

Tabela Orders zawiera dane o zamówieniach zrobionych przez klientów( dane klienta, książka która została wybrana)

# 7.Instrukcja uruchomienia projektu
Po uruchomieniu projektu nie ma dostępu do żadnej strony. Po wprowadzeniu migracji role Admin i User są automatycznie tworzone i można się przy ich pomocy zarejestrować. User będzie mieć dostęp do stron:

* Home

* Zamówienie

* Privacy

* Rejestracja

* Logowanie.

Administrator będzie mieć dostęp do każdej podstrony
