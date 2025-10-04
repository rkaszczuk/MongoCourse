<h1 align="center"> MongoDB 8.0 - dzień 1</h1>

W ramach zajęć wykorzystywać będziemy wersję portable MongoDB, która nie wymaga pełnej instalacji a jedynie wypakowania i uruchomienia binariów. Wersja jest w pełni funkcjonalna i pod kątem funkcjonalności nie różni się od wersji instalacyjnej.
Mongo jest wysoce multiplatformowe - zachowuje się tak samo niezależnie od systemu operacyjnego. Jeśli planujesz w przyszłości hostować MongoDB na serwerze z Linuxem, a wygodniej będzie ci uczestniczyć w zajęciach na komputerze z Windowsem, to nie stanowi to żadnego problemu. Zachowanie MongoDB i jego możliwości będą identyczne niezależnie od użytego systemu operacyjnego.

W ramach części warsztatowej będziemy wykorzystywali wersję MongoDB 8.X. Zanim przejdziemy dalej upewnij się że twój system operacyjny jest z nią kompatybilny.

Na zielono zaznaczyłem wszystkie oficjalnie wspierane systemy operacyjne.

![](https://i.imgur.com/L80Lcdm.png)

Jeśli twój system jest na szaro, albo nie ma go na liście - wciąż możesz spróbować uruchomić na nim Mongo.
Często pomimo braku oficjalnego wsparcia Mongo będzie na nim działać (np. Windows 10)

#### W celu rozpoczęcia pracy z MongoDB będziemy musieli wykonać następujące kroki:
1. Pobrać paczkę serwera MongoDB (proces mongod)
2. Utworzyć katalog na dane
3. Uruchomić proces serwer mongod wkazując folder na dane
4. Pobrać paczkę konsoli klienta (proces mongosh)
5. Za pomocą klienta połączyć się z serwerem

### 1. Serwer MongoDB 8.0.X (portable - nie wymaga instalacji)

Na stronie https://www.mongodb.com/try/download/community 
- wybieramy wersję 8.0.X
- nasz system operacyjny
- Packages -> zip lub tgz

Następnie uruchamiamy serwer według jednej z poniższych instrukcji:

[Pobranie i testowe uruchomienie serwera mongod - Windows ](../mongo8/mongod_windows.md)

[Pobranie i testowe uruchomienie serwera mongod - Linux ](../mongo8/mongod_linux.md)

[Pobranie i testowe uruchomienie serwera mongod - MacOS ](../mongo8/mongod_macos.md)

### 2. Konsola klienta MongoDB Shell (portable - nie wymaga instalacji):

Na stronie https://www.mongodb.com/try/download/shell
- wybieramy wersję 2.5.X
- nasz system operacyjny (dla Linuxa należy wybrać uniwersalną paczkę Linux x64)
- Packages -> zip lub tgz

Przykładowy wybór:

![](https://i.imgur.com/VusvnI4.png)

Pobieramy i wypakowujemy archiwum w dowolnej lokalizacji (którą oczywiście zapamiętujemy :) )

### 3. Połączenie do serwera

a) Otwieramy nową konsolę / terminal
b) Przechodzimy do katalogu (podkatalog bin) w którym wypakowaliśmy paczkę klienta mongosh, przykładowe wykonanie:
 
  ```
  cd ....mongosh-2.5.x-xxxxx\bin
  ```
    
c) Uruchamiamy klienta mongosh:
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
    
  Przykładowe uruchomienie:
  ![](https://i.imgur.com/BqLXb9f.png)
      
