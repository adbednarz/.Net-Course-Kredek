// Liczba prób przed podaniem średniego wyniku
let howManyTrials = 7;

// Zmierzone czasy reakcji
let reactionTimes = [];
// Rozpoczęcie pomiaru czasu
let trialStart = 0;
// Zakończenie pomiaru czasu
let trialEnd = 0;
// Licznik prób
let trialCounter = 0;

// ID procesu mierzenia czasu
let timeoutId = 0;

// Funkcja resetująca zmierzone czasy reakcji
function ResetTimes() {
    for (let i = 0; i < howManyTrials; i++) {
        reactionTimes[i] = 0;
    }
}

// Rozpoczęcie oczekiwania na pomiar czasu
function StartIdle() {
    document.getElementById("button-timer").src = "Images/buttonBlue.png";
    document.getElementById("button-timer").onclick = FalseStart;

    if (trialCounter > howManyTrials - 1) {
        ResetTimes();
        trialCounter = 0;

        UpdateTable(0);
    }

    trialCounter++;
    let randomTimer = Math.floor(Math.random() * 2000 + 500);
    timeoutId = setTimeout(StartTimer, randomTimer);
}

// Rozpoczęcie pomiaru czasu reakcji
function StartTimer() {
    document.getElementById("button-timer").src = "Images/buttonGreen.png";
    document.getElementById("button-timer").onclick = StopTimer;
    trialStart = new Date().getTime();
}

// Ukaranie za naciśnięcie przycisku zbyt wcześnie
function FalseStart() {
    clearTimeout(timeoutId);
    trialStart = new Date().getTime() - 1000;
    StopTimer();
}

// Zakończenie pomiaru czasu reakcji
function StopTimer() {
    document.getElementById("button-timer").src = "Images/buttonRed.png";
    document.getElementById("button-timer").onclick = StartIdle;

    trialEnd = new Date().getTime() - trialStart;
    reactionTimes[trialCounter - 1] = trialEnd;

    let average = 0;
    if (trialCounter > howManyTrials - 1) {
        for (let i = 0; i < trialCounter; i++) {
            average += reactionTimes[i];
        }

        average = Math.round(average / howManyTrials);
        alert("Your average reaction time: " + average + " ms");
    }

    UpdateTable(average);
}

// Funkcja aktualizująca tabelę z wynikami
function UpdateTable(average) {
    document.getElementById("times-table").innerHTML = "";

    document.getElementById("times-table").innerHTML +=
        '<tr>' +
            '<th> Attempt No. </th>' +
            '<th> Reaction time </th>' +
        '</tr>';

    for (let i = 0; i < howManyTrials; i++) {
        document.getElementById("times-table").innerHTML +=
            '<tr>' +
                '<td> Attempt ' + (i + 1) + ' </td>' +
                '<td> ' + reactionTimes[i] + ' ms </td>' +
            '</tr>';
    }

    document.getElementById("times-table").innerHTML +=
        '<tr>' +
            '<td> Average </td>' +
            '<td> ' + average + ' ms </td>' +
        '</tr>';
}