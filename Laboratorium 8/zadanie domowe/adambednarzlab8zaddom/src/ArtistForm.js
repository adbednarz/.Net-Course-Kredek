import React, { useEffect } from 'react';
import { Form, InputNumber, Input, Button } from 'antd';

const ArtistForm = ({ onFinish, submitText, initialValues }) => {
	const [form] = Form.useForm();

	useEffect(() => {
		form.setFieldsValue(initialValues);
	}, [form, initialValues]);

	return (
		<Form form={form} layout='vertical' onFinish={onFinish} initialValues={initialValues}>
			<Form.Item name='id' hidden>
				<InputNumber />
			</Form.Item>
			<Form.Item name='name' label='Imię'>
				<Input />
			</Form.Item>
			<Form.Item name='surname' label='Nazwisko'>
				<Input />
			</Form.Item>
			<Form.Item name='description' label='Opis'>
				<Input />
			</Form.Item>
			<Form.Item className='text-center'>
				<Button className='w-100' htmlType='submit' size='large' type='primary'>
					{submitText}
				</Button>
			</Form.Item>
		</Form>
	);
};

export default ArtistForm;