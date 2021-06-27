import React, { useEffect, useState } from 'react';
import axios from 'axios';
import ArtWorkForm from './ArtWorkForm';
import { notification, Table, Menu, Dropdown, Button, Modal } from 'antd';
import { CaretDownOutlined } from '@ant-design/icons';

const ArtWorkView = props => {
    const [data, setData] = useState([]);
    const [isDataFetching, setDataFetching] = useState([]);
	const [showDeleteModal, setShowDeleteModal] = useState(false);
	const [showUpdateModal, setShowUpdateModal] = useState(false);
	const [selectedArtWork, setSelectedArtWork] = useState(null);
	const [useEffectInvoker, setUseEffectInvoker] = useState(false);

	const handleShowDeleteModal = (artWork) => {
		return () => {
			setSelectedArtWork(artWork);
			setShowDeleteModal(true);
		};
	};

	// usuwa dzieło sztuki 
	const handleDeleteFinish = () => {
		axios.delete(`https://localhost:${props.localhost}/api/ArtWork/${selectedArtWork.id}`)
			.then(() => {
				closeDeleteModal();
				setUseEffectInvoker(!useEffectInvoker);
			});
	};
	const closeDeleteModal = () => setShowDeleteModal(false);

	const handleShowUpdateModal = (artWork) => {
		return () => {
			setSelectedArtWork(artWork);
			setShowUpdateModal(true);
		};
	};

	// modyfikuje dzieło sztuki
	const handleUpdateFinish = (values) => {
		axios.put(`https://localhost:${props.localhost}/api/ArtWork/${selectedArtWork.id}`, values)
			.then(() => {
				closeUpdateModal();
				setUseEffectInvoker(!useEffectInvoker);
			});
	};
	const closeUpdateModal = () => setShowUpdateModal(false);

	// dodaje nowe dzieło sztuki
    const handleFinish = (values) => {
		axios.post(`https://localhost:${props.localhost}/api/ArtWork`, values)
			.then(() => {
				props.onClose();
				setUseEffectInvoker(!useEffectInvoker);	
				notification.success({
					title: 'Sukces',
					description: 'Pomyślnie dodano nowe dzieło sztuki'
				});			
			}, (error) => {
				notification.error({
					title: 'Niepowodzenie',
					description: 'Wystąpił błąd :('
				});
				console.log(error);					
			})
	};

	// pobiera na początku wszystkie dzieła sztuki
    useEffect(() => {
		setDataFetching(true);
		axios.get(`https://localhost:${props.localhost}/api/ArtWork`)
			.then(response => {
				setData(response.data);
				setDataFetching(false);
		});
	}, [props.localhost, useEffectInvoker]);

	const menu = (ArtWork) => (
		<Menu>
			<Menu.Item key='1' onClick={handleShowUpdateModal(ArtWork)}>
				Edytuj
			</Menu.Item>
			<Menu.Item key='2' onClick={handleShowDeleteModal(ArtWork)}>
				Usuń
			</Menu.Item>
		</Menu>
	);

	const columns = [
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
			title: 'Artysta',
			dataIndex: ["artist", "surname"]
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

	return (
		<>
            <Table size='large' columns={columns} dataSource={data} rowKey={(d) => d.id} loading={isDataFetching} />
            <Modal visible={props.visible} footer={null} onCancel={props.onClose}>
                <ArtWorkForm onFinish={handleFinish} submitText='Dodaj!' />
			</Modal>
			<Modal visible={showUpdateModal} footer={null} onCancel={closeUpdateModal}>
				<h1>Edytuj dzieło sztuki</h1>
				<ArtWorkForm initialValues={selectedArtWork} submitText='Zapisz!' onFinish={handleUpdateFinish} />
			</Modal>
			<Modal visible={showDeleteModal} onCancel={closeDeleteModal} onOk={handleDeleteFinish}>
				Czy na pewno checesz usunąć to dzieło sztuki?
			</Modal>
        </>
	);
};

export default ArtWorkView;