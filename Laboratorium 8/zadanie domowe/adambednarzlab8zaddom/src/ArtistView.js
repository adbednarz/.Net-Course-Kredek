import React, { useEffect, useState } from 'react';
import axios from 'axios';
import ArtistForm from './ArtistForm';
import { notification, Table, Menu, Dropdown, Button, Modal } from 'antd';
import { CaretDownOutlined } from '@ant-design/icons';

const ArtistView = props => {
    const [data, setData] = useState([]);
	const [artWorks, setArtWorks] = useState([]);
    const [isDataFetching, setDataFetching] = useState([]);
	const [showDeleteModal, setShowDeleteModal] = useState(false);
	const [showUpdateModal, setShowUpdateModal] = useState(false);
	const [showArtWorksModal, setShowArtWorksModal] = useState(false);
	const [selectedArtist, setSelectedArtist] = useState(null);
	const [useEffectInvoker, setUseEffectInvoker] = useState(false);

	// pobiera wszystkie dzieła artysty
	const handleShowArtWorksModal = (artist) => {
		return () => {
			axios.get(`https://localhost:${props.localhost}/api/Artist/${artist.id}/ArtWorks`)
			.then(response => {
				setArtWorks(response.data);
			});
			setShowArtWorksModal(true);
		};
	};
	
	const closeArtWorksModal = () => setShowArtWorksModal(false);

	const handleShowDeleteModal = (artist) => {
		return () => {
			setSelectedArtist(artist);
			setShowDeleteModal(true);
		};
	};

	// usuwa artystę
	const handleDeleteFinish = () => {
		axios.delete(`https://localhost:${props.localhost}/api/Artist/${selectedArtist.id}`)
			.then(() => {
				closeDeleteModal();
				setUseEffectInvoker(!useEffectInvoker);
			});
	};
	const closeDeleteModal = () => setShowDeleteModal(false);

	const handleShowUpdateModal = (artist) => {
		return () => {
			setSelectedArtist(artist);
			setShowUpdateModal(true);
		};
	};

	// zmienia dane danego artysty
	const handleUpdateFinish = (values) => {
		axios.put(`https://localhost:${props.localhost}/api/Artist/${selectedArtist.id}`, values)
			.then(() => {
				closeUpdateModal();
				setUseEffectInvoker(!useEffectInvoker);
			});
	};
	const closeUpdateModal = () => setShowUpdateModal(false);

	// dodaje nowego artysty
    const handleFinish = (values) => {
		axios.post(`https://localhost:${props.localhost}/api/Artist`, values)
			.then(() => {
				setUseEffectInvoker(!useEffectInvoker);
				props.onClose();
				notification.success({
					title: 'Sukces',
					description: 'Pomyślnie dodano nowego artystę'
				});			
			}, (error) => {
				notification.error({
					title: 'Niepowodzenie',
					description: 'Wystąpił błąd :('
				});
				console.log(error);					
			})
	};

	// na załadowanie komponentu pobiera wszystkich artystów
    useEffect(() => {
		setDataFetching(true);
		axios.get(`https://localhost:${props.localhost}/api/Artist`)
			.then(response => {
				setData(response.data);
				setDataFetching(false);
		});
	}, [props.localhost, useEffectInvoker]);

	const menu = (artist) => (
		<Menu>
			<Menu.Item key='1' onClick={handleShowArtWorksModal(artist)}>
				Pokaż dzieła artysty
			</Menu.Item>
			<Menu.Item key='2' onClick={handleShowUpdateModal(artist)}>
				Edytuj
			</Menu.Item>
			<Menu.Item key='3' onClick={handleShowDeleteModal(artist)}>
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
			title: 'Imię',
			dataIndex: 'name'
		},
		{
			title: 'Nazwisko',
			dataIndex: 'surname'
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
			title: 'Muzeum',
			dataIndex: ["museum", "name"]
		},
		{
			title: 'Opis',
			dataIndex: 'description'
		},
	];

	return (
		<div>
            <Table size='large' columns={columns} dataSource={data} rowKey={(d) => d.id} loading={isDataFetching} />
            <Modal visible={props.visible} footer={null} onCancel={props.onClose}> 
                <ArtistForm onFinish={handleFinish} submitText='Dodaj!' />
			</Modal>
			<Modal visible={showArtWorksModal} footer={null} onCancel={closeArtWorksModal}>
				<Table size='large' columns={columnsArtWorks} dataSource={artWorks} rowKey={(d) => d.id} />
			</Modal>			
			<Modal visible={showUpdateModal} footer={null} onCancel={closeUpdateModal}>
				<h1>Edytuj artystę</h1>
				<ArtistForm initialValues={selectedArtist} submitText='Zapisz!' onFinish={handleUpdateFinish} />
			</Modal>
			<Modal visible={showDeleteModal} onCancel={closeDeleteModal} onOk={handleDeleteFinish}>
				Czy na pewno chcesz usunąć tego artystę?
			</Modal>
        </div>
	);
};

export default ArtistView;