## MongoDB 6 - pobranie i uruchomienie serwera - Windows

### 1. Pobieramy binaria odpowiednie dla naszego systemu operacyjnego:
https://www.mongodb.com/try/download/community

![](https://i.imgur.com/nxsCgly.png)

### 2. Wypakowujemy pobrany plik
W tym celu możesz użyć dowolnego narzedzia (np. wbudowane w Windows "Wyodrębnij pliki" lub 7zip)

### 3. Otwieramy konsolę i przechodzimy do katalogu w którym wypakowaliśmy archiwum, wchodzimy do katalogu bin:
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

Komenda będzie różnić się w zależności od użytej w windowsie "konsoli" 

- #### Windows (zwykłe CMD)
```
mongod --dbpath db
```

- #### Windows (PowerShell)
```
.\mongod --dbpath db
```

### 6. Serwer powinien rozpocząć nasłuch na porcie 27017:
Sprawdzamy czy serwer rozpoczął nasłuch. Jeśli wszystko się powiodło zauważymy komunikat "Waiting for connections". Konsola powinna zawisnąć w oczekiwaniu na połączenia klientów

![](https://i.imgur.com/DgypFgd.png)

### 7. Wyłączenie serwera
Jeśli wszystko zadziałało poprawnie możemy wyłączyć serwer. W tym celu należy użyć kombinacji ctrl+c. Po chwili zauważymy komunikaty potwierdzające zamknięcie serwer oraz wrócimy do konsoli

