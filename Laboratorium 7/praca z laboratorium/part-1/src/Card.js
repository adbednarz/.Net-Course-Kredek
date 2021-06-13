import React from 'react';

const Card = (props) => {
	return (
		<div className='card'>
			<input checked={props.checked} type='checkbox' onChange={props.handleCheckboxChange} />
			<div className={props.checked ? 'text-strike' : ''}>{props.text}</div>
			<button className='btn' onClick={props.handleDeleteClick}>
				X
			</button>
		</div>
	);
};

export default Card;
