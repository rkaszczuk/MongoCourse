## MongoDB 6 - uruchomienie serwera - Maszyny PW (Ubuntu)

Na maszynach PW <b>nie ma konieczności pobierania MongoDB</b> - odpowiednie pakiety są już zainstalowane. Wystarczy utworzyć katalog na dane i uruchomić proces serwera

### 1. Za pomocą konsoli przechodzimy do dowolnego katalogu
W moim przypadku bedzie to folder użytkownika:

```
cd /home/users/xrkaszcz
```
### (opcjonalnie) 2. Tworzymy podfolder mongodb i przechodzimy do niego

```
mkdir mongodb
cd mongodb
```

### 3. Tworzymy folder "db" na dane

```
mkdir db
```

### 4. Uruchamiamy proces serwer mongod
Podczas uruchomienia serwera wykorzystujemy flagę --dbpath w której podajemy nazwę katalogu na dane

```
mongod --dbpath db
```

#### Po uruchomieniu powinniśmy zauważyć komunikat "waiting for connections" a konsola powinna "zawisnąć". 
Minimalizujemy to okno konsoli i zostawiamy "w tle" do końca zajęć

### Przykładowe wykonanie:
Uruchomienie:
![](https://i.imgur.com/T86GIZD.png)

Komunikat "waiting for connections"
![](https://i.imgur.com/52n8eZh.png)

