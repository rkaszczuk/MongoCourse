4.1 Case I:
    Web shop basket. Each user (anonymous and authenticated) has a basket.
    Any number of items can be added to a basket.
    The items stay in the basket unitl the user makes an order.
    Price for items in the basket is guaranteed.

4.2 Case II:
    Mini-system bankowy. Każdy użytkownik ma konto z określoną sumą "pieniędzy". Konta można zasilać z zewnątrz, wypłacać oraz przelewać między kontami. Kluczowe jest utrzymanie prawidłowego stanu wszystkich kont w systemie, czyli:
    * balans konta nie spada nigdy poniżej 0;
    * obecny stan wszystkich kont = poczatkowy stan wszystkich kont + suma wpłat - suma wypłat.
Model danych musi uwzględniać pełną tranzakcyjność danej operacji (zasilenia/potrącenia/przelewu).
Potrzebna jest pełna historia transakcji, ale jej odczyt będzie następował bardzo rzadko.
Każdy użytkownik musi widzieć w miarę aktualny stan swojego konta.
Użytkownik jest reprezentowany przez id w postaci stringa.

4.3 Case III:
    Hierarchical categories filter.
    Each category consists of "id" and "name" and can have any number of subcategories.
    A child category can have only one parent.
    Only categories of any given level are displayed until the user clicks and unfolds one of them. 
    After unfolding only direct children ar displayed.
    Writes are uncommon and most of them move a category (with all its direct and indirect children) to another parent.

4.4 Case IV.
    Parameter monitoring.
    Each sensor reports parameter reads (e.g. temperature) with constant and high frequency.
    There are very many sensors.
    Each sensor has complex metadata (name, producer, production date, date of inspection, supported protocols, etc).
    The application displays only the current sensor state and its metadata.

4.5 Case V.
    Tracking data from a script that spies on user behaviour.
    Very frequently written small amount of data (ip, time, location, unique user id from a cookie) about user's visit.
    There are 2 use cases for reading the accumulated data:
    
        * aggregate view of which pages are visited most frequently;
        * aggregate view of which pages are most commonly visited as a first page that the user sees;
