import React, { useState, useEffect } from "react";
import { 
    Row, 
    Col, 
    Button
} 
from "reactstrap";

export const InformationList = props => {
    const changePath = props.changePath;
    const [chosen, setChosen] = useState();

    // jak komponent się załadujemy zmieniamy ""ścieżkę"" na panelu nawigacyjnym
    useEffect(() => {
        changePath("AdamBednarzLab7ZadDom/Information");
    // jak się odmontuje ustawiamy do tego, co było
    return () => {
        changePath("AdamBednarzLab7ZadDom/BMI");
    };
  }, [changePath]);

    // gdy naciśniemy wybrany przycik pokazuje się nam dana treść
	const handleClick = (index) => {
		return (e) => {
            setChosen(index);
		};
	};

    return (
        <div>
            <Row>
                <Col sm="12" md={{ size: 6, offset: 3 }} className="text-center">
                    <h2>Państwa z najwyższą otyłością wśród dorosłych (BMI &gt;= 25)</h2>
                </Col>
            </Row>
            <Row className="mt-4">
                <Col sm="12" md={{ size: 6, offset: 3 }}>
                    {props.continents.map((value, index) => {        
                        return (
                            <div>
                                <Button className="mt-3" onClick={handleClick(index)}>{value.name}</Button>
                                { chosen === index ?
                                    <div>
                                        <li>{props.countries[index].body}</li>
                                    </div>              
                                    : null
                                }
                            </div>
                        );
                    })} 
                </Col>
            </Row>           
        </div> 
    );
}