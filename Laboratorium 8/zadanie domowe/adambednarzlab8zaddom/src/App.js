import React, { useState } from 'react';
import { Layout, Menu } from 'antd';
import { PlusOutlined, UserOutlined, BankOutlined, ClearOutlined } from '@ant-design/icons';
import ArtistView from './ArtistView';
import MuseumView from './MuseumView';
import ArtWorkView from './ArtWorkView';
import './App.css';

const { Content, Header, Footer } = Layout;

function App() {
  const localhost = "44362";
	const [view, setView] = useState(0);
  const [extraItem, setExtraItem] = useState("Dodaj artystę");
  const [modalAddVisible, setModalAddVisible] = useState(false);

  // zmienia widok na artystów
	const handleChangeToArtist = () => {
    setExtraItem("Dodaj artystę");
    setView(0);
  }

  // zmienia widok na muzea
  const handleChangeToMuseum = () => {
    setExtraItem("Dodaj muzeum");
    setView(1);
  }

  // zmienia widok na dzieła sztuki
  const handleChangeToArtWork = () => {
    setExtraItem("Dodaj dzieło");
    setView(2);
  }

  // otwieranie i zamykanie modalu z dodawaniem rekordu do tabeli
  const openAddModal = () => setModalAddVisible(true);
  const closeAddModal = () => setModalAddVisible(false);

	return (
		<Layout style={{ minHeight: '100vh' }}>
			<Header>
				<Menu theme='light' mode='horizontal' selectedKeys={[]}>
					<Menu.Item key='1' icon={<UserOutlined />} onClick={handleChangeToArtist}>
						Artyści
					</Menu.Item>
					<Menu.Item key='2' icon={<BankOutlined />} onClick={handleChangeToMuseum}>
						Muzea
					</Menu.Item>
					<Menu.Item key='3' icon={<ClearOutlined />} onClick={handleChangeToArtWork}>
						Dzieła sztuki
					</Menu.Item>
          <Menu.Item key='4' icon={<PlusOutlined />} style={{color: 'black'}} onClick={openAddModal}>
            {extraItem}
          </Menu.Item>          
				</Menu>
			</Header>        
        <Content>
          { view === 0 ? 
            <ArtistView localhost={localhost} visible={modalAddVisible} onClose={closeAddModal} />
            : view === 1 ?
              <MuseumView localhost={localhost} visible={modalAddVisible} onClose={closeAddModal} />
              : <ArtWorkView localhost={localhost} visible={modalAddVisible} onClose={closeAddModal} />
          }
        </Content>
				<Footer>@2021 - Adam Bednarz - Zadanie domowe - Laboratorium 8</Footer>
			</Layout>
	);
}

export default App;