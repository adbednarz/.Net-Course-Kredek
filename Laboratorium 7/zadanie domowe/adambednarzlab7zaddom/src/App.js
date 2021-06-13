import React, { useState, useEffect } from 'react';
import { InputBMIForm } from "./Components/InputBMIForm";
import { OutputBMI } from "./Components/OutputBMI";
import { InformationList } from "./Components/InformationList";
import {
  Navbar,
  Nav,
  Button,
  NavbarText,
} from 'reactstrap';

function App() {
  // jeśli true to pokazuje wynik BMI, jeśli false to okienko do wprowadzania danych
  const [resultBMI, setResultBMI] = useState(false);
  // flaga wskazuje, co ma wyświetlić na głownym oknie
  const [content, setContent] = useState("BMI");
  // dane wprowadzone przez użytkownika
  const [BMI, setBMI] = useState();
  // ""ścieżka"" znajdująca się na panelu nawigacyjnym
  const [path, setPath] = useState("AdamBednarzLab7ZadDom/BMI");
  // json nazw kontynentów
  const [continents, setContinents] = useState([{id: "", name: ""}]);
  // json z wybranymi państwami
  const [countries, setCountries] = useState([{id: "", body: "", nameId: ""}]); 

  // na zamontowaniu pobieramy jsony
  useEffect(() => {
    fetch('https://my-json-server.typicode.com/adbednarz/demo/continents', {
        method: 'GET'
    })
    .then((response) => response.json())
    .then((responseJson) => {
        setContinents(responseJson);
    })
    .catch((error) => {
        console.error(error);
    });
    
    fetch('https://my-json-server.typicode.com/adbednarz/demo/countries', {
        method: 'GET'
    })
    .then((response) => response.json())
    .then((responseJson) => {
        setCountries(responseJson);
    })
    .catch((error) => {
        console.error(error);
    });
  }, []);

  // zmienia flagę wyświetlania treści na stronie głównej
  const handleClickNav = e => {
    // naciśnięcie BMI resetuje wcześniej wprowadzone dane
    if (e.target.value === "BMI")
      setResultBMI(false);
    setContent(e.target.value);
  };

  // odebranie danych wprowadzonych przez użytkownika
  const updateBMIArray = eachEntry => {
    // wyświetlaj rezultat wprowadzonych danych   
    setResultBMI(true);
    setBMI(eachEntry);
  };

  // zmień ""ściężke"" znajdującą się na panelu nawigacyjnym
  const changePath = path => {
    setPath(path);
  }

  return (
    <div>
      <Navbar color="light" light expand="md">
        <Nav className="mr-auto" navbar>
          <Button className="mt-1 ml-1 mb-1" value="BMI" onClick={handleClickNav}>BMI</Button>
          <Button className="mt-1 ml-1 mb-1" value="INFO" onClick={handleClickNav}>Information</Button>
        </Nav>
        <NavbarText>{path}</NavbarText>
      </Navbar>
      <div className="container mt-4">
        { content === "BMI" && resultBMI ?
            <OutputBMI BMI={BMI}/>
          : content === "BMI" && !resultBMI ?
            <InputBMIForm updateBMIArray={updateBMIArray}/>        
          : content === "INFO" ?
            <InformationList continents={continents} countries={countries} changePath={changePath}/>
          : null
        }
      </div>      
    </div>
  );
}

export default App;
