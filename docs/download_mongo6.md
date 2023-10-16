## MongoDB 6.0 - serwer

### 1. Pobieramy binaria dla naszego OS

Wszystkie binaria:
https://www.mongodb.com/try/download/community

(wybieramy system operacyjny oraz paczkę .zip / tgz)

- #### Windows
https://fastdl.mongodb.org/windows/mongodb-windows-x86_64-6.0.10.zip

- #### Debian 11
https://fastdl.mongodb.org/linux/mongodb-linux-x86_64-debian11-6.0.10.tgz

```
wget https://fastdl.mongodb.org/linux/mongodb-linux-x86_64-debian11-6.0.10.tgz

tar xvzf mongodb-linux-x86_64-debian11-6.0.10.tgz
```

- #### Ubuntu 20
https://fastdl.mongodb.org/linux/mongodb-linux-x86_64-ubuntu2004-6.0.10.tgz

```
wget https://fastdl.mongodb.org/linux/mongodb-linux-x86_64-ubuntu2004-6.0.10.tgz

tar xvzf mongodb-linux-x86_64-ubuntu2004-6.0.10.tgz
```

### 2. Rozpakowujemy pobraną paczkę
### 3. Otwieramy konsolę i przechodzimy do katalogu w którym wypakowaliśmy archiwum, wchodzimy do katalogu bin:
```
cd ....mongodb-xxxxxxx-6.0.10\bin
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
.\mongod --dbpath db
```


### 6. Serwer powinien rozpocząć nasłuch na porcie 27017:
![](https://i.imgur.com/DgypFgd.png)
