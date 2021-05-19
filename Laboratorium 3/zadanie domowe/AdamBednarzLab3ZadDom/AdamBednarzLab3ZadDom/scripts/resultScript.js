// zmienna przechowuj�ca liczb� punkt�w zdobytych przez gracza
let points = 0;

// ID procesu mierzenia czasu
let timeoutId = 0;

// funkcja powracaj�ca do strony startowej quizu
function Back() {
    window.location.href = "index.html";
}

// funkcja wywo�uj�ca si�, gdy strona si� za�aduje
$(document).ready(function () {
    // wzi�cie z adresu strony liczby punkt�w
    points = parseInt(window.location.href.split('?').pop());
    // dodanie informacji na stronie o liczbie zdobytych punkt�w
    $("h1").after("Uzyska&#322;e&#347; " + points + " na 10 mo&#380;liwych punkt&#243w.");
    // w zale�no�ci od liczby punkt�w, dodaj odpowiedni komunikat
    if (points < 4) {
        $("p").before("<br> Nast&#281;pnym razem p&#243jdzie Ci lepiej!");
    } else if (points < 7) {
        $("p").before("<br> Masz spor&#261; dawk&#281; wiedzy, nie poprzestawaj na tym!");
    } else if (points !== 10) {
        $("p").before("<br> &#346;wietnie sobie poradzi&#322;e&#347; z testem! Gratulacje!");
    } else {
        $("p").before("<br> Mistrzosko sobie poradzi&#322;e&#347 z testem! Gratulacje!");
    }
    // ustaw licznik automatycznego powrotu na stron� g��wn� strony
    timeoutId = setTimeout(Back, 10000);
});

// funkcja wywo�uj�ca si� po klikni�ciu w przycisk powrotu
$("button").click(function () {
    // reset licznika
    clearTimeout(timeoutId);
    // powr�t do strony g��wnej quizu
    window.location.href = "index.html";
});