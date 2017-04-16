4.1 Przypadek I:
    Koszyk w sklepie online. Każdy użytkownik (anonimowy i zalogowany), który odwiedzi stronę ma koszyk. Do koszyka można dodać dowolne ilości produktów, które zostają w nim dopóki użytkownik nie złoży zamówienia. Na dodane do koszyka produkty jest gwarancja ceny.

4.2 Przypadek II:
    Mini-system bankowy. Każdy użytkownik ma konto z określoną sumą "pieniędzy". Konta można zasilać z zewnątrz, wypłacać oraz przelewać między kontami. Kluczowe jest utrzymanie prawidłowego stanu wszystkich kont w systemie, czyli:
    * balans konta nie spada nigdy poniżej 0;
    * obecny stan wszystkich kont = poczatkowy stan wszystkich kont + suma wpłat - suma wypłat.
Model danych musi uwzględniać pełną tranzakcyjność danej operacji (zasilenia/potrącenia/przelewu).
Potrzebna jest pełna historia transakcji, ale jej odczyt będzie następował bardzo rzadko.
Każdy użytkownik musi widzieć w miarę aktualny stan swojego konta.
Użytkownik jest reprezentowany przez id w postaci stringa.

4.3 Przypadek III:
    Hierarchiczny filtr po kategoriach. Każda kategoria to id i nazwa, może mieć dowolną ilość podkategorii. Podkategoria ma tylko jednego rodzica. Wyświetlamy tylko kategorie z danego poziomu, dopóki użytkownik którejś nie rozwinie, wtedy wyświetlamy jej podkategorie. Zapisy nieczęste, zazwyczaj polegają na przeniesieniu jednej podkategorii (razem z pochodnymi) z jednego rodzica do drugiego.

4.4 Przypadek IV.
    Monitoring parametrów. Każdy czujnik zgłasza odczytane parametry (np temperaturę) ze stałą i sporą częstotliwością. Czujników jest bardzo dużo. Oprócz tego czujniki mają złożone metadane (nazwa, producent, data produkcji, data przeglądu, wspierane protokoły, itp). W aplikacji wyświetlany jest obecny stan czujnika oraz jego metadane.

4.5. Przypadek V.
    Dane trackingowe ze skryptu do śledzenia zachowań użytkownika. Bardzo często zapisywany mały zestaw danych (ip, czas, lokalizacja, unikalny id użytkownika np. z ciasteczka) odnośnie odwiedzin użytkownika na stronie. Dane są odczytywane w ramach agregacji w celu sprawdzenia na które strony użytkownicy wchodzą najczęściej w ramach wizyt oraz które odwiedzają pierwsze (żeby nadać im większe wagi).
