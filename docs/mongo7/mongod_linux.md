## MongoDB 7 - pobranie i uruchomienie serwera - Linux

Instrukcja w formie video:

<p align="center">
<a href="http://www.youtube.com/watch?feature=player_embedded&v=EC5HrvX1BMU" target="_blank">
 <img src="http://img.youtube.com/vi/EC5HrvX1BMU/maxresdefault.jpg" alt="Watch the video" width="600" height="337" border="10" />
</a>
</p>



### 1. Pobieramy binaria odpowiednie dla naszego systemu operacyjnego:
https://www.mongodb.com/try/download/community

![](https://i.imgur.com/ikWstUv.png)

Możemy to zrobić z poziomu przeglądarki lub skopiować link do konsoli
```
wget https://fastdl.mongodb.org/linux/mongodb-linux-x86_64-xxxxxx-7.0.15.tgz
```

### 2. Wypakowujemy pobrany plik
W tym celu możemy użyć możemy użyć dowolnego narzędzia pozwalającego na wypakowanie archiwów .tgz, np. tar z poziomu konsoli:
```
tar xvzf mongodb-linux-x86_64-xxxxxx-7.0.15.tgz
```


### 3. Otwieramy konsolę i przechodzimy do katalogu w którym wypakowaliśmy archiwum, wchodzimy do katalogu bin:
```
cd ....mongodb-xxxxxxx-7.0.15\bin
```
### 4. W podkatalogu bin tworzymy katalog na dane
MongoDB potrzebuje katalogu na przechowywanie danych. Na potrzeby warsztatowe umieścimy go w tym samym katalogu co binaria - żeby mieć do niego łatwy dostęp

```
mkdir db
```
### 5. Uruchamiamy serwer
Za pomocą konsoli, z poziomu katalogu ....mongodb-xxxxxxx-7.0.15\bin uruchamiamy program mongod.

```
./mongod --dbpath db
```

### 6. Serwer powinien rozpocząć nasłuch na porcie 27017:
Sprawdzamy czy serwer rozpoczął nasłuch. Jeśli wszystko się powiodło zauważymy komunikat "Waiting for connections". Konsola powinna "zawisnąć" w oczekiwaniu na połączenia klientów

![](https://i.imgur.com/DgypFgd.png)

### 7. Wyłączenie serwera
Jeśli chcemy zakończyć pracę z MongoDB możemy użyć kombinacji ctrl+c w celu jego wyłączenia. Po chwili zauważymy komunikaty potwierdzające zamknięcie serwer i wrócimy do konsoli
