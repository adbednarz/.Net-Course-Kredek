import React, { useState, useEffect } from 'react';
import Card from './Card';
import './App.css';

function App() {
	const [value, setValue] = useState('initial');
	const [data, setData] = useState([
		{
			text: 'Zadanie 1',
			checked: true
		}
	]);

	// on data Change
	useEffect(() => {
		document.title = `Ilość zadań ${data.length}`;
	}, [data]);

	// on component Load
	useEffect(() => {
		console.log('zostałem uruchomiony');

		// on component umount
		return () => {
			console.log();
		};
	}, []);

	// on component update
	useEffect(() => {
		console.log('aktualizuje sie');
	});

	const handleInput = (event) => {
		setValue(event.target.value);
	};

	const handleClick = () => {
		const newData = [...data];
		newData.push({
			text: value,
			checked: false
		});
		setData(newData);
	};

	const handleCheckboxChange = (index) => {
		return (event) => {
			const newData = [...data];
			newData[index].checked = event.target.checked;
			setData(newData);
		};
	};

	const handleDeleteClick = (index) => {
		return (e) => {
			let newData = [...data];
			newData = newData.filter((value, i) => i !== index);
			setData(newData);
		};
	};

	return (
		<div className='App'>
			<header className='App-header'>Witaj Kredek!</header>
			<div>
				<input className='input' placeholder='Tutaj wpisz cokolwiek..' onInput={handleInput} />
				<button onClick={handleClick} className='btn'>
					Dodaj
				</button>
				<div className='container'>
					{data.map((value, index) => {
						return (
							<Card
								key={index}
								text={value.text}
								checked={value.checked}
								handleCheckboxChange={handleCheckboxChange(index)}
								handleDeleteClick={handleDeleteClick(index)}
							/>
						);
					})}
				</div>
			</div>
		</div>
	);
}

export default App;
