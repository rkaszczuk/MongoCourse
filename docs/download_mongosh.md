## MongoSh - konsola klienta

### 1. Pobieramy binaria dla naszego OS

Wszystkie binaria:
https://www.mongodb.com/try/download/shell

(wybieramy system operacyjny oraz paczkę .zip / tgz)

- #### Windows
https://downloads.mongodb.com/compass/mongosh-1.10.6-win32-x64.zip

- #### Linux
https://downloads.mongodb.com/compass/mongosh-1.10.6-linux-x64.tgz

```
wget https://downloads.mongodb.com/compass/mongosh-1.10.6-linux-x64.tgz

tar xvzf mongosh-1.10.6-linux-x64.tgz
```

### 2. Rozpakowujemy pobraną paczkę
### 3. Otwieramy konsolę i przechodzimy do katalogu w którym wypakowaliśmy archiwum, wchodzimy do katalogu bin:
```
cd ....mongosh-1.10.6-xxxxx\bin
```

### 5. Uruchamiany konsolę klienta (bez parametrów = localhost:27017)

- #### Windows (zwykłe CMD)
```
mongosh
```

- #### Linux / Windows (PowerShell)
```
.\mongosh
```


### 6. Konsola powinna połączyć się z serwerem i umożliwić wykonywanie komend

W celu weryfikacji możemy uruchomić komendę 
```
show dbs
```

![](https://i.imgur.com/BqLXb9f.png)
