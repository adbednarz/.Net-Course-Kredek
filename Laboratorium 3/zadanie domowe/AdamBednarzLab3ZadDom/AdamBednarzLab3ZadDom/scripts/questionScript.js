
// lista pyta�; z powodu problem�w z polskimi znakami oraz brakiem czasu uciek�em si� do takiej metody
let questions = [
    "W kt&#243;rym kraju nie obowi&#261;zuje waluta Euro?",
    "W kt&#243;rym roku otworzono metro w Warszawie?",
    "Kt&#243;ry kraj nie nale&#380;y do tr&#243;jk&#261;ta Weimarskiego?",
    "W kt&#243;rym roku Polska przyst&#261;pi&#322;a do NATO?",
    "Kt&#243;ra nazwa nie by&#322;a mark&#261; polskiego samochodu?",
    "W kt&#243;rym roku zawarto pierwsz&#261; uni&#281; polsko-litewsk&#261;?",
    "Kt&#243;re miasto nie bra&#322;o udzia&#322;u w Euro 2012?",
    "Kt&#243;re z miast ma najwi&#281;cej mieszka&#324;c&#243;w?",
    "Na jakim p&#243;&#322;wyspie po&#322;o&#380;ona jest Dania?",
    "Najd&#322;u&#380;sza rzeka Europy to?"
];

// lista mo�liwych odpowiedzi
let options = [
    ["Kosowo", "Czarnog&#243;ra", "Watykan", "Szwecja"],
    ["1995", "1999", "1991", "1987"],
    ["Polska", "Wlk. Brytania", "Niemcy", "Francja"],
    ["1991", "2004", "1999", "1995"],
    ["Nysa", "Syrenka", "Warszawa", "Vistula"],
    ["1401", "1413", "1385", "1569"],
    ["Wroc&#322;aw", "Pozna&#324;", "Krak&#243;w", "Gda&#324;sk"],
    ["Berlin", "Pary&#380;", "Londyn", "Moskwa"],
    ["Iberyjskim", "Jutlandzkim", "Jugorskim", "Kurlandzkim"],
    ["Wo&#322;ga", "Dniepr", "Sekwana", "Dunaj"]
];

// indeks dobrych odpowiedzi
let goodAnswers = [
    4,
    1,
    2,
    3,
    4,
    3,
    3,
    4,
    2,
    1
];

// liczba uzyskanych punkt�w
let points = 0;

// czas przeznaczony na poszczeg�lne pytanie
let counter = 20;

// ID procesu mierzenia czasu
let intervalId = 0;

// obecnie wy�wietlane pytanie
let currentQuestion = 0;

// sekudnik, zmniejsza dost�pny czas na pytanie
function StartCounter() {
    intervalId = setInterval(Count, 1000); 
}

// funkcja, kt�ra wy�wietla nast�pne pytanie
function NextQuestion() {
    currentQuestion += 1;
    // je�li ju� przeszli�my przez 10 pyta� (0 .. 9) to przejd� do strony podsumuj�cej
    if (currentQuestion === 10) {
        // za znakiem zapytania przeka� drugiej stronie liczb� punkt�w
        window.location.href = "result.html?" + points;
    } else {
        // ustaw na nowo czas 20s
        counter = 20;
        // zresetuj sekudnik
        clearInterval(intervalId);
        // wy�wietl na stronie numer pytania
        $("h4").html("Pytanie " + (currentQuestion + 1));
        // wy�wietl na stronie tre�� pytania
        $("h5").html(questions[currentQuestion]);
        // odznacz wszystkie pytania (wyklucza pozostawienie zaznaczonej opcji z poprzedniego zadania)
        $("#1 input").prop("checked", false);
        $("#2 input").prop("checked", false);
        $("#3 input").prop("checked", false);
        $("#4 input").prop("checked", false);
        // wstaw kolejno cztery dost�pne odpowied�i na obecne pytanie
        $("#1 span").html(options[currentQuestion][0]);
        $("#2 span").html(options[currentQuestion][1]);
        $("#3 span").html(options[currentQuestion][2]);
        $("#4 span").html(options[currentQuestion][3]);
        // wy�wietl dost�pny czas
        $("#counter").text("Czas: 20s");
        // zacznij odliczanie czasu
        StartCounter();
    }
}

// pomniejsza dost�pny czas, wy�wietla i w przypadku wyczerpania czasu, wywo�uje metod� NextQuestion()
function Count() {
    counter -= 1;
    $("#counter").text("Czas: " + counter + " s");
    if (counter === 0) {
        NextQuestion();
    }
}

// metoda wywo�uj�ca si� po klikni�ciu w przycisk Nast�pne
$(".btn-success").click(function () {
    var currentGoodAnswer = goodAnswers[currentQuestion];
    // je�li jest zaznaczona opcja z dobr� odpowiedzi�, zwi�ksz punkt
    if ($("#" + currentGoodAnswer + " input").is(":checked")) {
        points += 1;
    }
    NextQuestion();
});

// metoda wywo�uj�ca si� po klikni�ciu w przycik Przerwij
$(".btn-primary").click(function () {
    // powr�t do strony startowej quizu
    window.location.href = "index.html";
});

// metoda wywo�uj�ca si� po klikni�ciu w pierwsz� odpowied�
$("#1 input").click(function () {
    // zaznacz wszystkie inne odpowiedzi na niezaznaczone, test jest jednokrotnego wyboru
    $("#2 input").prop("checked", false);
    $("#3 input").prop("checked", false);
    $("#4 input").prop("checked", false);
});

// metoda wywo�uj�ca si� po klikni�ciu w drug� odpowied�
$("#2 input").click(function () {
    // zaznacz wszystkie inne odpowiedzi na niezaznaczone, test jest jednokrotnego wyboru
    $("#1 input").prop("checked", false);
    $("#3 input").prop("checked", false);
    $("#4 input").prop("checked", false);
});

// metoda wywo�uj�ca si� po klikni�ciu w trzeci� odpowied�
$("#3 input").click(function () {
    // zaznacz wszystkie inne odpowiedzi na niezaznaczone, test jest jednokrotnego wyboru
    $("#1 input").prop("checked", false);
    $("#2 input").prop("checked", false);
    $("#4 input").prop("checked", false);
});

// metoda wywo�uj�ca si� po klikni�ciu w czwart� odpowied�
$("#4 input").click(function () {
    // zaznacz wszystkie inne odpowiedzi na niezaznaczone, test jest jednokrotnego wyboru
    $("#1 input").prop("checked", false);
    $("#2 input").prop("checked", false);
    $("#3 input").prop("checked", false);
});

// gdy strona si� za�aduje, rozpocznij odliczanie czasu
$(document).ready(StartCounter());