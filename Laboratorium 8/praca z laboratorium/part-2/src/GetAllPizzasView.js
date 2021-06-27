import React, { useEffect, useState } from 'react';
import axios from 'axios';
import { Table, Menu, Dropdown, Button, Modal } from 'antd';
import { SettingFilled } from '@ant-design/icons';
import PizzaForm from './PizzaForm';

const GetAllPizzasView = () => {
	const [data, setData] = useState([]);
	const [isDataFetching, setDataFetching] = useState([]);
	const [showDeleteModal, setShowDeleteModal] = useState(false);
	const [showUpdateModal, setShowUpdateModal] = useState(false);
	const [selectedPizza, setSelectedPizza] = useState(null);
	const [useEffectInvoker, setUseEffectInvoker] = useState(false);

	// Deleting Pizza
	const handleShowDeleteModal = (pizzaInfo) => {
		return () => {
			setSelectedPizza(pizzaInfo);
			setShowDeleteModal(true);
		};
	};
	const handleDeleteFinish = () => {
		fetch(`http://localhost:4900/api/Pizza/${selectedPizza.id}`, { method: 'delete' }).then(() => {
			closeDeleteModal();
			setUseEffectInvoker(!useEffectInvoker);
		});
	};
	const closeDeleteModal = () => setShowDeleteModal(false);

	// Updating Pizza
	const handleShowUpdateModal = (pizzaInfo) => {
		return () => {
			setSelectedPizza(pizzaInfo);
			setShowUpdateModal(true);
		};
	};
	const handleUpdateFinish = (values) => {
		fetch(`http://localhost:4900/api/Pizza/${selectedPizza.id}`, {
			body: JSON.stringify(values),
			method: 'put',
			headers: { 'Content-type': 'application/json' }
		}).then(() => {
			closeUpdateModal();
			setUseEffectInvoker(!useEffectInvoker);
		});
	};
	const closeUpdateModal = () => setShowUpdateModal(false);

	useEffect(() => {
		setDataFetching(true);
		axios.get('http://localhost:4900/api/Pizza')
			.then(response => {
				setData(response.data);
				setDataFetching(false);
			});
		/*fetch('http://localhost:4900/api/Pizza', { method: 'get' })
			.then((res) => res.json())
			.then((dataParsed) => {
				setData(dataParsed);
				setDataFetching(false);
			});*/
	}, [useEffectInvoker]);

	const menu = (pizza) => (
		<Menu>
			<Menu.Item key='1' onClick={handleShowUpdateModal(pizza)}>
				Edytuj
			</Menu.Item>
			<Menu.Item key='2' onClick={handleShowDeleteModal(pizza)}>
				Usuń
			</Menu.Item>
		</Menu>
	);

	const columns = [
		{
			title: 'Nazwa Pizzy',
			dataIndex: 'name'
		},
		{
			title: 'Opis',
			dataIndex: 'description'
		},
		{
			title: 'Koszt',
			align: 'right',
			render: ({ cost }) => <>{cost.toFixed(2)} zł</>
		},
		{
			title: 'Opcje',
			align: 'center',
			render: (data) => (
				<Dropdown placement='bottomCenter' trigger='click' overlay={menu(data)}>
					<Button type='link' icon={<SettingFilled />} />
				</Dropdown>
			)
		}
	];
	

	return (
		<div>
			<h1 className='text-center m-3 font-display'>Pizza Menu!</h1>
			<Table size='large' columns={columns} dataSource={data} rowKey={(d) => d.id} loading={isDataFetching} />
			<Modal visible={showUpdateModal} onCancel={closeUpdateModal}>
				<h1>Edytuj pizze</h1>
				<PizzaForm initialValues={selectedPizza} submitText='Zapisz!' onFinish={handleUpdateFinish} />
			</Modal>
			<Modal visible={showDeleteModal} onCancel={closeDeleteModal} onOk={handleDeleteFinish}>
				Czy checesz usunąć Pizze?
			</Modal>
		</div>
	);
};

export default GetAllPizzasView;