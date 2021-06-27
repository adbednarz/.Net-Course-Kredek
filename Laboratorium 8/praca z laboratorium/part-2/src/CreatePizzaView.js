import React from 'react';
import PizzaForm from './PizzaForm';
import { notification } from 'antd';

const CreatePizzaView = () => {
	const handleFinish = (values) => {
		console.log(values);
		fetch('http://localhost:4900/api/Pizza', {
			body: JSON.stringify(values),
			method: 'post',
			headers: {
				'Content-type': 'application/json'
			}
		})
			.then(() => {
				notification.success({
					title: 'Sukces',
					description: 'Pomyślnie dodano nową pizze o nazwie: ' + values.name
				});
			})
			.catch((err) => {
				notification.error({
					title: 'Wystąpił błąd :(',
					description: JSON.stringify(err)
				});
			});
	};

	return (
		<>
			<h1 className='text-center m-5 font-display'>Kreator nowej pizzy!</h1>
			<div style={{ margin: '1rem auto', width: '350px', maxWidth: '400px' }}>
				<PizzaForm onFinish={handleFinish} submitText='Dodaj!' />
			</div>
		</>
	);
};

export default CreatePizzaView;