## MongoDB 4.4

### 1. Pobieramy binaria dla naszego OS

Wszystkie binaria:
https://www.mongodb.com/try/download/community

Wybieramy wersję 4.4.25, system operacyjny oraz paczkę .zip / .tgz

- #### Maszyna wirtualna PW / Ubuntu 18.04
https://fastdl.mongodb.org/linux/mongodb-linux-x86_64-ubuntu1804-4.4.25.tgz

```
wget https://fastdl.mongodb.org/linux/mongodb-linux-x86_64-ubuntu1804-4.4.25.tgz

tar xvzf mongodb-linux-x86_64-ubuntu1804-4.4.25.tgz
```

- #### Windows
https://fastdl.mongodb.org/windows/mongodb-windows-x86_64-4.4.25.zip

- #### Debian 11
https://fastdl.mongodb.org/linux/mongodb-linux-x86_64-debian11-4.4.25.tgz

```
wget https://fastdl.mongodb.org/linux/mongodb-linux-x86_64-debian11-4.4.25.tgz

tar xvzf mongodb-linux-x86_64-debian11-4.4.25.tgz
```

- #### Ubuntu 20
https://fastdl.mongodb.org/linux/mongodb-linux-x86_64-ubuntu2004-4.4.25.tgz

```
wget https://fastdl.mongodb.org/linux/mongodb-linux-x86_64-ubuntu2004-4.4.25.tgz

tar xvzf mongodb-linux-x86_64-ubuntu2004-4.4.25.tgz
```

- #### Ubuntu 22
Wersja 4.4 oraz 5.0 nie wspierają oficjalnie Ubuntu 22. Można natomiast wykorzystać paczkę Ubuntu 20. Konieczne będzie doinstalowanie dodatkowego pakietu:

```
echo "deb http://security.ubuntu.com/ubuntu focal-security main" | sudo tee /etc/apt/sources.list.d/focal-security.list

sudo apt-get update
sudo apt-get install libssl1.1
```
Następnie pobrać i wypakować binarnia z sekcji Ubuntu 20

- #### MacOS

https://fastdl.mongodb.org/osx/mongodb-macos-x86_64-4.4.25.tgz

```
wget https://fastdl.mongodb.org/osx/mongodb-macos-x86_64-4.4.25.tgz

tar xvzf mongodb-macos-x86_64-4.4.25.tgz
```
##### UWAGA - dodatkowe ustawienia w MacOS  
```
macOS Prevents mongod From Opening
macOS may prevent mongod from running after installation. If you receive a security error when starting mongod indicating that the developer could not be identified or verified, do the following to grant mongod access to run:

Open System Preferences

Select the Security and Privacy pane.

Under the General tab, click the button to the right of the message about mongod, labelled either Open Anyway or Allow Anyway depending on your version of macOS.
```


### 2. Rozpakowujemy pobraną paczkę
### 3. Otwieramy konsolę i przechodzimy do katalogu w którym wypakowaliśmy archiwum, wchodzimy do katalogu bin:
```
cd ....mongodb-xxxxxxx-4.4.25\bin
```
### 4. W podkatalogu bin tworzomy katalog na dane
```
mkdir db
```
### 5. Uruchamiamy serwer

- #### Windows (zwykłe CMD)
```
mongod --dbpath db
```

- #### Linux / Windows (PowerShell)
```
./mongod --dbpath db
```




### 6. Serwer powinien rozpocząć nasłuch na porcie 27017 
(konsola zawiśnie - nie wyłączać jej!):
![](https://i.imgur.com/DgypFgd.png)


--------------------------------------
#### Przykładowy przebieg komend:
![](https://i.imgur.com/9y04uDD.png)

