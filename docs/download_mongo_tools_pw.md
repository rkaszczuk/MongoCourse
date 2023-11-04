## MongoDB Database Tools
(pakiet dodatkowych narzędzi do MongoDB)


Wszystkie binaria:
https://www.mongodb.com/try/download/database-tools

(wybieramy system operacyjny oraz paczkę .zip / tgz)

- #### Maszyna PW / Ubuntu 18.04:

https://fastdl.mongodb.org/tools/db/mongodb-database-tools-ubuntu1804-x86_64-100.7.0.tgz
```
wget https://fastdl.mongodb.org/tools/db/mongodb-database-tools-ubuntu1804-x86_64-100.7.0.tgz

tar xvzf mongodb-database-tools-ubuntu1804-x86_64-100.7.0.tgz
```

- #### Windows 10:
https://fastdl.mongodb.org/tools/db/mongodb-database-tools-windows-x86_64-100.7.0.zip

- #### MacOS:
https://fastdl.mongodb.org/tools/db/mongodb-database-tools-macos-x86_64-100.7.0.zip
	< instrukcja instalacji (zakłądka TGZ Archive)
	https://www.mongodb.com/docs/database-tools/installation/installation-macos/ >

- #### Docker
Powinny być w obrazie
```
docker exec <nazwa_instancji> sh -c 'exec mongoimport --help'
```

------------------------------------
### Instrukcja uruchomienia:

1. Wypakowujemy archiwum
2. Otwieramy nową konsole / terminal
3. Przechodzimy do katalogu w którym wypakowaliśmy archiwum, wchodzimy do katalogu bin:
cd ....mongodb-database-tools-xxxxxxx-100.7.0\bin
4. Sprawdzamy czy mongoimport działa:

Windows (starszy / zwykłe CMD):
```
mongoimport --help
```
Windows (nowszy / powershell) / Linux:
```
./mongoimport --help
```
Przykładowe wykonanie:
![](https://i.imgur.com/Z6G0AzI.png)

------------------------------------
### Pobieranie pliku z danymi:

1. Należy pobrać plik:
Windows:
https://github.com/rkaszczuk/MongoCourse/raw/master/0_Movies_Data/moviesBackup.zip
Linux:
https://github.com/rkaszczuk/MongoCourse/raw/master/0_Movies_Data/moviesBackup.tar.gz

2. Wypakować i przekopiować zawartośc do katalogu ....mongodb-database-tools-xxxxxxx-100.7.0\bin

Linux:
```
wget https://github.com/rkaszczuk/MongoCourse/raw/master/0_Movies_Data/moviesBackup.tar.gz

tar xvzf moviesBackup.tar.gz
```

Przykładowe wykonanie:
![](https://i.imgur.com/sshXCSh.png)
