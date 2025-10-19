<h1 align="center"> NoSQLBooster + MongoDB Database Tools - dzień 2</h1>


## GUI do obsługi MongoDB - NoSQLBooster (wymagana instalacja na Windows)
Cała cześć warsztatowa możliwa jest do realizacji w środowisku konsolowym, jednak ze względu na większą czytelność przeglądania danych zachęcam do wykorzystania środowiska graficznego i GUI.

- Ze strony: https://nosqlbooster.com/downloads pobieramy instalator (lub dla systemów Linux paczkę tgz) i go uruchamiamy.
- Uruchamiamy aplikacje NoSQLBooster for MongoDB i sprawdzamy czy pojawi się GUI

![](https://i.imgur.com/kvTiRAN.png)

Jeśli korzystasz już z innego GUI (np. Studio3t) to śmiało możesz użyć go na zajęciach. Ważne żeby GUI miało możliwość wpisywania pełnych komend. 

Jeśli nie masz możliwości instalacji na systemie Windows możesz użyć Robomongo (nierozwijane - czasem będą błędy): https://github.com/Studio3T/robomongo/releases/tag/v1.4.4




## MongoDB Database Tools
(pakiet dodatkowych narzędzi do MongoDB)


Wszystkie binaria:
https://www.mongodb.com/try/download/database-tools

![](https://i.imgur.com/7imxxeq.png)


(wybieramy system operacyjny oraz paczkę .zip / tgz)

---------------------------
### Instalacja (pobranie i wypakowanie paczki)

- #### Maszyna PW
Pomiń ten krok - pakiet jest już zainstalowany

- #### Linux

Link zależy od konkretnej dystrybucji


Przykładowe pobranie i wypakowanie z poziomu konsoli:

```
wget https://fastdl.mongodb.org/tools/db/mongodb-database-tools-XXXXXXX-100.13.0.tgz

tar xvzf mongodb-database-tools-XXXXXXX-100.13.0.tgz
```
- #### Windows:
Pobieramy paczkę: 
[https://fastdl.mongodb.org/tools/db/mongodb-database-tools-windows-x86_64-100.13.0.zip](https://fastdl.mongodb.org/tools/db/mongodb-database-tools-windows-x86_64-100.13.0.zip)

i wypakowujemy za pomocą dowolnego narzędzia

- #### MacOS:

Pobieramy paczkę:

x86:  [https://fastdl.mongodb.org/tools/db/mongodb-database-tools-macos-x86_64-100.13.0.zip](https://fastdl.mongodb.org/tools/db/mongodb-database-tools-macos-x86_64-100.13.0.zip)

lub

ARM:  [https://fastdl.mongodb.org/tools/db/mongodb-database-tools-macos-arm64-100.13.0.zip](https://fastdl.mongodb.org/tools/db/mongodb-database-tools-macos-arm64-100.13.0.zip)

</br>
i wypakowujemy za pomocą dowolnego narzędzia


---------------------
### Testowe uruchomienie

- #### Maszyny PW
Z poziomy konsoli uruchamiany komendę:
```
mongoimport --help
```

- #### Pozostałe systemy
1. Otwieramy nową konsole / terminal
3. Przechodzimy do katalogu w którym wypakowaliśmy archiwum, wchodzimy do katalogu bin:
cd ....mongodb-database-tools-xxxxxxx-100.13.0\bin
4. Sprawdzamy czy mongoimport działa:

Windows (starszy / zwykłe CMD):
```
mongoimport --help
```
Windows (nowszy / powershell) / Linux:
```
./mongoimport --help
```
Przykładowe wykonanie (pobranie za pomocą konsoli, wypakowanie i testowe uruchomienie):
![](https://i.imgur.com/Z6G0AzI.png)

----
### Pobieranie pliku z danymi:

1. Należy pobrać plik:

      Windows:
      
      https://github.com/rkaszczuk/MongoCourse/raw/master/0_Movies_Data/moviesBackup.zip
      
      Linux:
      
      https://github.com/rkaszczuk/MongoCourse/raw/master/0_Movies_Data/moviesBackup.tar.gz

2. Wypakować i przekopiować zawartośc do katalogu ....mongodb-database-tools-xxxxxxx-100.13.0\bin

      Windows / Linux (GUI):
      Ctrl+C / Ctrl+V z poziomu UI

      Linux (konsola):
      ```
      wget https://github.com/rkaszczuk/MongoCourse/raw/master/0_Movies_Data/moviesBackup.tar.gz
      
      tar xvzf moviesBackup.tar.gz
      ```

Przykładowe wykonanie:
![](https://i.imgur.com/sshXCSh.png)

