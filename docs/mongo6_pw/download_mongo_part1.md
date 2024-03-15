<h1 align="center"> MongoDB 6.0 - dzień 1</h1>

W ramach zajęć wykorzystywać będziemy wersję portable MongoDB, która nie wymaga pełnej instalacji a jedynie wypakowania i uruchomienia binariów. Wersja jest w pełni funkcjonalna i pod kątem funkcjonalności nie różni się od wersji instalacyjnej.
Mongo jest wysoce multiplatformowe - zachowuje się tak samo niezależnie od systemu operacyjnego. Jeśli planujesz w przyszłości hostować MongoDB na serwerze z Linuxem, a wygodniej będzie ci uczestniczyć w zajęciach na komputerze z Windowsem, to nie stanowi to żadnego problemu. Zachowanie MongoDB i jego możliwości będą identyczne niezależnie od użytego systemu operacyjnego.

W ramach części warsztatowej będziemy wykorzystywali wersję MongoDB 6.X. Zanim przejdziemy dalej upewnij się że twój system operacyjny jest z nią kompatybilny.

Na zielono zaznaczyłem wszystkie oficjalnie wspierane systemy operacyjne.

![](https://i.imgur.com/1nCx1Xj.png)

Jeśli twój system jest na szaro, albo nie ma go na liście - wciąż możesz spróbować uruchomić na nim Mongo.
Często pomimo braku oficjalnego wsparcia Mongo będzie na nim działać (np. MacOS 13)

Jeśli próba uruchomienia się nie powiedzie to aby korzystać z Mongo będziesz musiał zapewnić sobie dostęp
do jednego ze wspieranych systemów operacyjnych np. za pomocą wirtualnej maszyny PW.


---
#### W celu rozpoczęcia pracy z MongoDB będziemy musieli wykonać następujące kroki:
1. Pobrać paczkę serwera MongoDB (proces mongod) - krok pomijamy na maszynach PW
2. Utworzyć katalog na dane
3. Uruchomić proces serwer mongod wkazując folder na dane
4. Pobrać paczkę konsoli klienta (proces mongosh) - krok pomijamy na maszynach PW
5. Za pomocą klienta połączyć się z serwerem



      
---
### 1. Serwer MongoDB 6.0.X (portable - nie wymaga instalacji)

Na stronie https://www.mongodb.com/try/download/community 
- wybieramy wersję 6.0.X
- nasz system operacyjny
- Packages -> zip lub tgz

[Uruchomienie serwera mongod - Maszyny PW ](mongod_maszyny_pw.md)

[Pobranie i uruchomienie serwera mongod - Windows ](../mongo6/mongod_windows.md)

[Pobranie i uruchomienie serwera mongod - Linux ](../mongo6/mongod_linux.md)

[Pobranie i uruchomienie serwera mongod - MacOS ](../mongo6/mongod_macos.md)

---
### 2. (Krok pomijamy na maszynach PW) Pobranie konsoli klienta MongoDB Shell 2.1.X (portable - nie wymaga instalacji)


Na stronie https://www.mongodb.com/try/download/shell
- wybieramy wersję 2.1.X
- nasz system operacyjny (dla Linuxa należy wybrać uniwersalną paczkę Linux x64)
- Packages -> zip lub tgz

Przykładowy wybór:

![](https://i.imgur.com/LRjdFSx.png)

Pobieramy i wypakowujący archiwum w dowolnej lokalizacji (którą oczywiście zapamiętujemy :) )

---
### 3. Połączenie do serwera

- #### Maszyna wirtualna PW:
    a) Otwieramy nowy terminal
    
    b) Uruchamiamy proces mongosh:
    
    ```
    mongosh
    ```
    
    c) W celu weryfikacji możemy uruchomić komendę:
    
    ```
    show dbs
    ```
- #### Pozostałe maszyny:
    a) Otwieramy nową konsolę / terminal
  
    b) Przechodzimy do katalogu (podkatalog bin) w którym wypakowaliśmy paczkę klienta mongosh, przykładowe wykonanie:
    
    ```
    cd ....mongosh-2.1.x-xxxxx\bin
    ```
    
    c) Uruchamiany konsolę klienta
    
        - Windows (zwykłe CMD)
        ```
        mongosh
        ```
    
        - Linux / Windows (PowerShell)
        ```
        ./mongosh
        ```
  
    d) W celu weryfikacji możemy uruchomić komendę 
    ```
    show dbs
    ```


    Przykładowe uruchomienie
    ![](https://i.imgur.com/BqLXb9f.png)
   
