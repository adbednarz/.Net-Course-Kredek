// zmienna przechowuj¹ca liczbê punktów zdobytych przez gracza
let points = 0;

// ID procesu mierzenia czasu
let timeoutId = 0;

// funkcja powracaj¹ca do strony startowej quizu
function Back() {
    window.location.href = "index.html";
}

// funkcja wywo³uj¹ca siê, gdy strona siê za³aduje
$(document).ready(function () {
    // wziêcie z adresu strony liczby punktów
    points = parseInt(window.location.href.split('?').pop());
    // dodanie informacji na stronie o liczbie zdobytych punktów
    $("h1").after("Uzyska&#322;e&#347; " + points + " na 10 mo&#380;liwych punkt&#243w.");
    // w zale¿noœci od liczby punktów, dodaj odpowiedni komunikat
    if (points < 4) {
        $("p").before("<br> Nast&#281;pnym razem p&#243jdzie Ci lepiej!");
    } else if (points < 7) {
        $("p").before("<br> Masz spor&#261; dawk&#281; wiedzy, nie poprzestawaj na tym!");
    } else if (points !== 10) {
        $("p").before("<br> &#346;wietnie sobie poradzi&#322;e&#347; z testem! Gratulacje!");
    } else {
        $("p").before("<br> Mistrzosko sobie poradzi&#322;e&#347 z testem! Gratulacje!");
    }
    // ustaw licznik automatycznego powrotu na stronê g³ówn¹ strony
    timeoutId = setTimeout(Back, 10000);
});

// funkcja wywo³uj¹ca siê po klikniêciu w przycisk powrotu
$("button").click(function () {
    // reset licznika
    clearTimeout(timeoutId);
    // powrót do strony g³ównej quizu
    window.location.href = "index.html";
});