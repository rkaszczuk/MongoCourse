## MongoDB 6 - pobranie i uruchomienie serwera - MacOS

### 1. Pobieramy binaria odpowiednie dla naszego systemu operacyjnego:
https://www.mongodb.com/try/download/community

![](https://i.imgur.com/Q7StCct.png)

### 2. Wypakowujemy pobrany plik
W tym celu możemy użyć możemy użyć dowolnego narzędzia pozwalającego na wypakowanie archiwów .tgz, np Archive Utility

![](https://i.imgur.com/4R9C4rc.png)

Po wypakowaniu naszym oczom powinien ukazać się podkatalog bin z binarią mongod

### 3. Otwieramy terminal i przechodzimy do katalogu w którym wypakowaliśmy archiwum, wchodzimy do katalogu bin:
```
cd ....mongodb-xxxxxxx-6.0.13\bin
```

### 4. W podkatalogu bin tworzomy katalog na dane
MongoDB potrzebuje katalogu na przechowywanie danych. Na potrzeby warsztatowe umieścimy go w tym samym katalogu co binaria - żeby mieć do niego łatwy dostęp

```
mkdir db
```

### 5. Uruchamiamy serwer
Za pomocą konsoli, z poziomu katalogu ....mongodb-xxxxxxx-6.0.13\bin uruchamiamy program mongod.

```
.\mongod --dbpath db
```

#### Uwaga
Jeśli pierwszy raz używasz Mongo to mo otrzymać komunikat o zablokowaniu procesu przez Apple (niezidentyfikowany developer) 
![](https://i.imgur.com/ChQRHo0.png)

W takim przypadku musisz zezwolić na działanie procesu mongod z poziomu sekcji Privacy & Security w ustawieniach:
![](https://i.imgur.com/ULmHv5b.png)

Po odblokowaniu spróbuj ponownie uruchomić serwer:
```
.\mongod --dbpath db
```

### 6. Serwer powinien rozpocząć nasłuch na porcie 27017:

![](https://i.imgur.com/8dStgcX.jpeg)

### 7. Wyłączenie serwera
Jeśli wszystko zadziałało poprawnie możemy wyłączyć serwer. W tym celu należy użyć kombinacji ctrl+c. Po chwili zauważymy komunikaty potwierdzające zamknięcie serwer oraz wrócimy do konsoli
