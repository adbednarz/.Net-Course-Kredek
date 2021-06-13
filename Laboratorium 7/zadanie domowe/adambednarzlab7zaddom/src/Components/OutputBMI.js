import React from 'react';

export const OutputBMI = props => {
  let resultat = "";
  const weight = parseFloat(props.BMI.weight, 10);
  const height = parseFloat(props.BMI.height, 10) / 100;
  const valueBMI = (weight / (height * height)).toFixed(2);
  if (isNaN(valueBMI)) {
    resultat = "Podano nieprawidłowe dane";
  } else if (valueBMI >= 40) {
    resultat = "Skrajna otyłość";
  } else if (valueBMI >= 35) {
    resultat = "II stopień otyłości";
  } else if (valueBMI >= 30) {
    resultat = "I stopień otyłości";
  } else if (valueBMI >= 25) {
    resultat = "Nadwaga";
  } else if (valueBMI >= 18.5) {
    resultat = "Prawidłowa masa ciała";
  } else {
    resultat = "Niedowaga";
  }

  return (
    <div>  
      <h1 className="text-center">Twój rezultat: {valueBMI}</h1>
      <p className="font-weight-lighter text-center mt-3">{resultat}</p> 
      <p>Wyniki BMI jest taki sam zarówno dla mężczyzn i kobiet.</p>
      <p>
        Nie jest to dokładny wskaźnik, ponieważ nie uwzględnia płci oraz masy mięśni, 
        która zawyża ogólną masę. Wskaźnik ten przeznaczony jest głównie dla statystyk populacyjnych,
        aniżeli dla indywidualnej jednostki.
      </p>
      <p className="font-italic">Aby ponownie wprowadzić dane, kliknij przycisk BMI.</p>
    </div>  
  );
};