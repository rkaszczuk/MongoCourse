<h1 align="center"> MongoDB 6.0 - Stacja IT </h1>

W ramach warsztatów wykorzystywać będziemy wersję portable MongoDB, która nie wymaga pełnej instalacji a jedynie wypakowania i uruchomienia binariów. Wersja jest w pełni funkcjonalna i pod kątem funkcjonalności nie różni się od wersji instalacyjnej.
Mongo jest wysoce multiplatformowe - zachowuje się tak samo niezależnie od systemu operacyjnego. Jeśli planujesz w przyszłości hostować MongoDB na serwerze z Linuxem, a wygodniej będzie ci uczestniczyć w warsztatach na komputerze z Windowsem, to nie stanowi to żadnego problemu. Zachowanie MongoDB i jego możliwości będą identyczne niezależnie od użytego systemu operacyjnego.

W ramach cześci warsztatowej będziemy wykorzystywali wersję 6 Mongo. Zanim przejdziemy dalej upewnij się że twój system operacyjny jest z nią kompatybilny.

Na zielono zaznaczyłem wszystkie oficjalnie wspierane systemy operacyjne.

![](https://i.imgur.com/1nCx1Xj.png)

Jeśli twój system jest na szaro, albo nie ma go na liście - wciaż możesz spróbować uruchomić na nim Mongo.
Czesto pomimo braku oficjalnego wsparcia Mongo będzie na nim działać.

Jeśli próba uruchomienia się nie powiedzie to aby korzystać z Mongo będziesz musiał zapewnić sobie dostęp
do jednego ze wspieranych systemów operacyjnych np. za pomocą wirtaulej maszyny.

Istnieje również możliwośc uruchomienia MongoDb w dockerze za pomocą oficjalnego obrazu. Zanim jednak sięgniesz po tą platformę upewnij się że znaszą ja na tyle żeby spomiedzenie wykonać proste konfiguracje jak np. przekierowanie portów.

---
### Serwer MongoDB 6.0.X (portable - nie wymaga instalacji)

Na stronie https://www.mongodb.com/try/download/community 
- wybieramy wersję 6.0.X
- nasz system operacyjny
- Packages -> zip lub tgz

[Pobranie i testowe uruchomienie serwera mongod - Windows ](stacjait_mongod_windows.md)

[Pobranie i testowe uruchomienie serwera mongod - Linux ](stacjait_mongod_linux.md)

---
###  Konsola klienta MongoDB Shell 2.1.X (portable - nie wymaga instalacji):

Na stronie https://www.mongodb.com/try/download/shell
- wybieramy wersję 2.1.X
- nasz system operacyjny (dla Linuxa należy wybrać uniwersalną paczkę Linux x64)
- Packages -> zip lub tgz

Przykładowy wybór:

![](https://i.imgur.com/LRjdFSx.png)

Pobieramy i wypakowujący archiwum w dowolnej lokalizacji (którą oczywiście zapamiętujemy :slightly_smiling_face: )

(Uruchomienie konsoli klienta i proces połączenia z serwerem zostanie omówiony na warsztatach) 


---
###  Zestaw narzędzi bazodanowych MongoDB Database Tools 100.9.X (portable - nie wymaga instalacji):

Na stronie https://www.mongodb.com/try/download/database-tools
- wybieramy wersję 100.9.X 
- nasz system operacyjny
- Packages -> zip lub tgz

Przykładowy wybór:

![](https://i.imgur.com/yBtyYup.png)

Pobieramy i wypakowujący archiwum w dowolnej lokalizacji (którą oczywiście zapamiętujemy :slightly_smiling_face: )

(Obsługa narzędzi bazodanowych zostanie omówiona na warsztatach) 


---
###  (Opcjonalne) GUI do obsługi MongoDB - NoSQLBooster (wymagana instalacja)
Cała cześć warsztatowa możliwa jest do realizacji w środowisku konsolowym, jednak ze względu na większą czytelność przeglądania danych zachęcam do wykorzystania środowiska graficznego i GUI.

- Ze strony: https://nosqlbooster.com/downloads pobieramy instalator i go uruchamiamy.
- Uruchamiamy aplikacje NoSQLBooster for MongoDB i sprawdzamy czy pojawi się GUI


