<h1 align="center"> MongoDB 8.0 </h1>

W ramach szkolenia wykorzystywać będziemy wersję portable MongoDB, która nie wymaga pełnej instalacji a jedynie wypakowania i uruchomienia binariów. Wersja jest w pełni funkcjonalna i pod kątem funkcjonalności nie różni się od wersji instalacyjnej.
Mongo jest wysoce multiplatformowe - zachowuje się tak samo niezależnie od systemu operacyjnego. Jeśli planujesz w przyszłości hostować MongoDB na serwerze z Linuxem, a wygodniej będzie ci uczestniczyć w szkoleniach na komputerze z Windowsem, to nie stanowi to żadnego problemu. Zachowanie MongoDB i jego możliwości będą identyczne niezależnie od użytego systemu operacyjnego.

W ramach części warsztatowej będziemy wykorzystywali wersję MongoDB 8.0. Zanim przejdziemy dalej upewnij się że twój system operacyjny jest z nią kompatybilny.

Na zielono zaznaczyłem wszystkie oficjalnie wspierane systemy operacyjne.

![](https://i.imgur.com/L80Lcdm.png)

Jeśli twój system jest na szaro, albo nie ma go na liście - wciąż możesz spróbować uruchomić na nim Mongo.
Często pomimo braku oficjalnego wsparcia Mongo będzie na nim działać.

Jeśli próba uruchomienia się nie powiedzie to aby korzystać z Mongo będziesz musiał zapewnić sobie dostęp
do jednego ze wspieranych systemów operacyjnych np. za pomocą wirtualnej maszyny.

---
### Serwer MongoDB 8.0.X (portable - nie wymaga instalacji)

Na stronie https://www.mongodb.com/try/download/community 
- wybieramy wersję 8.0.X
- nasz system operacyjny
- Packages -> zip lub tgz


[Pobranie i testowe uruchomienie serwera mongod - Windows ](mongod_windows.md)

[Pobranie i testowe uruchomienie serwera mongod - Linux ](mongod_linux.md)

[Pobranie i testowe uruchomienie serwera mongod - MacOS ](mongod_macos.md)

---
###  Konsola klienta MongoDB Shell (portable - nie wymaga instalacji):

Na stronie https://www.mongodb.com/try/download/shell
- wybieramy wersję 2.5.X
- nasz system operacyjny (dla Linuxa należy wybrać uniwersalną paczkę Linux x64)
- Packages -> zip lub tgz

Przykładowy wybór:

![](https://i.imgur.com/VusvnI4.png)

Pobieramy i wypakowujemy archiwum w dowolnej lokalizacji (którą oczywiście zapamiętujemy :) )

(Uruchomienie konsoli klienta i proces połączenia z serwerem zostanie omówiony na szkoleniu) 


---
---
###  Zestaw narzędzi bazodanowych MongoDB Database Tools (portable - nie wymaga instalacji):

Na stronie https://www.mongodb.com/try/download/database-tools
- wybieramy wersję 100.12.X 
- nasz system operacyjny
- Packages -> zip lub tgz

Przykładowy wybór:

![](https://i.imgur.com/h2RMA8m.png)

Pobieramy i wypakowujemy archiwum w dowolnej lokalizacji (którą oczywiście zapamiętujemy :) )

(Obsługa narzędzi bazodanowych zostanie omówiona na szkoleniu) 


### GUI do obsługi MongoDB - NoSQLBooster (wymagana instalacja na Windows)
Cała cześć warsztatowa możliwa jest do realizacji w środowisku konsolowym, jednak ze względu na większą czytelność przeglądania danych zachęcam do wykorzystania środowiska graficznego i GUI.

- Ze strony: https://nosqlbooster.com/downloads pobieramy instalator (lub dla systemów Linux paczkę tgz) i go uruchamiamy.
- Uruchamiamy aplikacje NoSQLBooster for MongoDB i sprawdzamy czy pojawi się GUI

Jeśli korzystasz już z innego GUI (np. Studio3t) to śmiało możesz użyć go na szkoleniu. Ważne żeby GUI miało możliwość wpisywania pełnych komend. 
