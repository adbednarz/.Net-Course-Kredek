import React, { useEffect } from 'react';
import { Form, InputNumber, Input, Button } from 'antd';

const MuseumForm = ({ onFinish, submitText, initialValues }) => {
	const [form] = Form.useForm();

	useEffect(() => {
		form.setFieldsValue(initialValues);
	}, [form, initialValues]);

	return (
		<Form form={form} layout='vertical' onFinish={onFinish} initialValues={initialValues}>
			<Form.Item name='id' hidden>
				<InputNumber />
			</Form.Item>
			<Form.Item name='name' label='Nazwa'>
				<Input />
			</Form.Item>
			<Form.Item name='year' label='Rok powstania'>
				<InputNumber />
			</Form.Item>
			<Form.Item name='city' label='Miasto'>
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

export default MuseumForm;