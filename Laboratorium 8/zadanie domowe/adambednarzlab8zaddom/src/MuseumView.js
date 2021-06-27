import React, { useEffect, useState } from 'react';
import axios from 'axios';
import MuseumForm from './MuseumForm';
import { notification, Table, Menu, Dropdown, Button, Modal } from 'antd';
import { CaretDownOutlined } from '@ant-design/icons';

const MuseumView = props => {
    const [data, setData] = useState([]);
	const [artWorks, setArtWorks] = useState([]);
    const [isDataFetching, setDataFetching] = useState([]);
	const [showDeleteModal, setShowDeleteModal] = useState(false);
	const [showUpdateModal, setShowUpdateModal] = useState(false);
	const [showArtWorksModal, setShowArtWorksModal] = useState(false);
	const [selectedMuseum, setSelectedMuseum] = useState(null);
	const [useEffectInvoker, setUseEffectInvoker] = useState(false);

	// pobiera wszystkie dzieła znajdujące się w muzeum
	const handleShowArtWorksModal = (museum) => {
		return () => {
			axios.get(`https://localhost:${props.localhost}/api/Museum/${museum.id}/ArtWorks`)
			.then(response => {
				setArtWorks(response.data);
			});
			setShowArtWorksModal(true);
		};
	};
	
	const closeArtWorksModal = () => setShowArtWorksModal(false);

	const handleShowDeleteModal = (museum) => {
		return () => {
			setSelectedMuseum(museum);
			setShowDeleteModal(true);
		};
	};

	// usuwa muzeum
	const handleDeleteFinish = () => {
		axios.delete(`https://localhost:${props.localhost}/api/Museum/${selectedMuseum.id}`)
			.then(() => {
				closeDeleteModal();
				setUseEffectInvoker(!useEffectInvoker);
			});
	};
	const closeDeleteModal = () => setShowDeleteModal(false);

	const handleShowUpdateModal = (museum) => {
		return () => {
			setSelectedMuseum(museum);
			setShowUpdateModal(true);
		};
	};

	// modyfikuje muzeum
	const handleUpdateFinish = (values) => {
		axios.put(`https://localhost:${props.localhost}/api/Museum/${selectedMuseum.id}`, values)
			.then(() => {
				closeUpdateModal();
				setUseEffectInvoker(!useEffectInvoker);
			});
	};
	const closeUpdateModal = () => setShowUpdateModal(false);

	// dodaje nowe muzeum
    const handleFinish = (values) => {
		axios.post(`https://localhost:${props.localhost}/api/Museum`, values)
			.then(() => {
				props.onClose();
				setUseEffectInvoker(!useEffectInvoker);	
				notification.success({
					title: 'Sukces',
					description: 'Pomyślnie dodano nowe muzeum'
				});			
			}, (error) => {
				notification.error({
					title: 'Niepowodzenie',
					description: 'Wystąpił błąd :('
				});
				console.log(error);					
			})
	};

	// pobiera wszystkie muzea
    useEffect(() => {
		setDataFetching(true);
		axios.get(`https://localhost:${props.localhost}/api/Museum`)
			.then(response => {
				setData(response.data);
				setDataFetching(false);
		});
	}, [props.localhost, useEffectInvoker]);

	const menu = (museum) => (
		<Menu>
			<Menu.Item key='1' onClick={handleShowArtWorksModal(museum)}>
				Pokaż dzieła znajdujące się w tym muzeum
			</Menu.Item>
			<Menu.Item key='2' onClick={handleShowUpdateModal(museum)}>
				Edytuj
			</Menu.Item>
			<Menu.Item key='3' onClick={handleShowDeleteModal(museum)}>
				Usuń
			</Menu.Item>
		</Menu>
	);

	const columns = [
		{
			title: 'ID',
			dataIndex: 'id'
		},
		{
			title: 'Nazwa',
			dataIndex: 'name'
		},
		{
			title: 'Rok powstania',
			dataIndex: 'year'
		},
		{
			title: 'Miasto',
			dataIndex: 'city'
		},
		{
			title: 'Opis',
			dataIndex: 'description'
		},
		{
			title: 'Opcje',
			align: 'center',
			render: (data) => (
				<Dropdown placement='bottomCenter' trigger='click' overlay={menu(data)}>
					<Button type='link' icon={<CaretDownOutlined />} />
				</Dropdown>
			)
		}
	];

	const columnsArtWorks = [
		{
			title: 'Tytuł',
			dataIndex: 'name'
		},
		{
			title: 'Rok powstania',
			dataIndex: 'year'
		},
		{
			title: 'Artysta',
			dataIndex: ["artist", "surname"]
		},
		{
			title: 'Opis',
			dataIndex: 'description'
		},
	];

	return (
		<>
            <Table size='large' columns={columns} dataSource={data} rowKey={(d) => d.id} loading={isDataFetching} />
            <Modal visible={props.visible} footer={null} onCancel={props.onClose}>
                <MuseumForm onFinish={handleFinish} submitText='Dodaj!' />
			</Modal>
			<Modal visible={showArtWorksModal} footer={null} onCancel={closeArtWorksModal}>
				<Table size='large' columns={columnsArtWorks} dataSource={artWorks} rowKey={(d) => d.id} />
			</Modal>
			<Modal visible={showUpdateModal} footer={null} onCancel={closeUpdateModal}>
				<h1>Edytuj muzeum</h1>
				<MuseumForm initialValues={selectedMuseum} submitText='Zapisz!' onFinish={handleUpdateFinish} />
			</Modal>
			<Modal visible={showDeleteModal} onCancel={closeDeleteModal} onOk={handleDeleteFinish}>
				Czy na pewno checesz usunąć to muzeum?
			</Modal>
        </>
	);
};

export default MuseumView;