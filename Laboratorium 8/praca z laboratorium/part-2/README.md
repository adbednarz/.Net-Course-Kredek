# Część 2 - Asynchroniczny JavaScript

## 0. Prerekwizyty

1. Spullować (`git pull`) najnowszą wersję brancha. Powinnien sie znaleźć podstawowt projekt w katalogu `./part-2`
2. W terminalu przejsc do katalogu z projektem i wywołać komendę `npm i` lub też `npm install`. Jedno i drugie to jest to samo. Pierwsza wersja to jest poprostu skrót drugiej.
3. Uruchomić projekt komendą `npm start`

#### Powinnien wam sie ukazac nastepujacy widok: <div style="width:fit-content;margin:auto">![widok instalacyjny](https://i.imgur.com/k4ZTjs2.png 'widok')</div>

4. Znaleźc i otworzyć projekt z zajęć z Laboratoriów nr 6.
5. W tym projekcie musimy wprowadzić małe zmiany. Otworzyć plik `Startup.cs` i wprowadzić następujące zmiany:

    5.1. Skopiować i dodać linijke `app.UseCors(...)` jeśli takowej nie ma w tej metodzie.

```C#
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            ...

            app.UseRouting();

            app.UseCors(
                options => options.WithOrigins("http://localhost:3000").AllowAnyMethod().AllowAnyHeader()
            );

            app.UseSwagger();

            ...
        }
```

5.2. Skopiować i dodać linijke `services.AddCors()` w tym samym pliku.

```C#
       // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            ...
            services.AddControllers();
            services.AddCors();
            services.AddSwaggerGen(...);
            ...
        }
```

Umożliwi to nam na wykonywanie i odbieranie danych z serwera :D

## 1. Wykonywanie requestów po dane do serwera (GET)

```JavaScript
    fetch('http://localhost:63567/api/Pizza', { method: 'get' })
        // ^ ustawiamy także rodzaj metody HTTP aby wywołać konkretne zachowanie na serwerze
        // ważna linijka służy aby sparsować odpowiedź ze stringa na obiekt JavaScript
        .then((res) => res.json())
        .then((dataParsed) => {
            // gotowe dane kryją się pod dataParsed
            // tutaj robi sie najczesciej setState(dataParsed)
        });
```

## 2. Metoda POST

```JavaScript
    fetch('http://localhost:63567/api/Pizza', {
        // dane do przesłania parsujemy na string, ponieważ HTTP to protokół tekstowy
        body: JSON.stringify(values),
        method: 'post',
        headers: {
        // Dodajemy nagłówek jakiego typu dane przesyłamy, abe serwer mógł poprawnie wykonać żądanie
            'Content-type': 'application/json'
        }
    })
    .then(() => {

    })
```

## 3. Metoda PUT

```JavaScript
    fetch(`http://localhost:63567/api/Pizza/${selectedPizza.id}`, {
        // podobnie jak przy POST parsujemy obiekt danych na tekst
        body: JSON.stringify(values),
        method: 'put',
        // Dodajemy nagłówek jakiego typu dane przesyłamy, abe serwer mógł poprawnie wykonać żądanie
        headers: { 'Content-type': 'application/json' }
    }).then(() => {
        // jako że otrzymujemy 204 - NoConent to nie ma potrzeby parsować odpowedzi
    });
```

## 4. Metoda DELETE

```JavaScript
    fetch(`http://localhost:63567/api/Pizza/${selectedPizza.id}`, { method: 'delete' }).then(() => {
        // tutaj wystarczy nam sama poprawna odpowiedź
        // nie przesyłamy też body wiec i Content type nie musi byc ustawione
    });
```
