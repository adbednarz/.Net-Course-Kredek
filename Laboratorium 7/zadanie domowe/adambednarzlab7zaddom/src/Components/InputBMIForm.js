import React, { useState } from "react";
import { 
    Row, 
    Col, 
    Form, 
    FormGroup, 
    Label, 
    Input,
    Button } 
from "reactstrap";

export const InputBMIForm = props => {
    const { updateBMIArray } = props;
    const initialInputState = { gender: 0, weight: "", height: ""};
    const [eachEntry, setEachEntry] = useState(initialInputState);
    const { gender, weight, height} = eachEntry;

    const handleInputChange = e => {
        let modifiedInput = e.target.value.replace(/\D/,'');
        setEachEntry({ ...eachEntry, [e.target.name]: modifiedInput });
    };
    
    const handleFinalSubmit = e => {
      updateBMIArray(eachEntry)
    };

    return (
        <div>
            <Row>
            <Col sm="12" md={{ size: 6, offset: 3 }} className="text-center">
                <h2>Kalkulator BMI</h2>
            </Col>
            </Row>
            <Row className="mt-4">
            <Col sm="12" md={{ size: 6, offset: 3 }}>
                <Form>
                    <FormGroup>
                        <Label for="gender">Płeć</Label>
                        <Input type="select" name="gender" onChange={handleInputChange} value={gender} >
                            <option value={0}>Kobieta</option>
                            <option value={1}>Mężczyzna</option>
                        </Input>
                    </FormGroup>
                    <FormGroup>
                        <Label for="weight">Waga (kg)</Label>
                        <Input name="weight" onChange={handleInputChange} value={weight} />
                    </FormGroup>
                    <FormGroup>
                        <Label for="height">Wzrost (cm)</Label>
                        <Input name="height" onChange={handleInputChange} value={height} />
                    </FormGroup>
                    <Button onClick={handleFinalSubmit}>Oblicz</Button>
                </Form>
            </Col>
            </Row>
        </div> 
    );
};