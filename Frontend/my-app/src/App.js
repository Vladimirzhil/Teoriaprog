import logo from './logo.svg';
import './App.css';
import React from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import NaviBar from './Components/Navibar';
import {BrowserRouter,Routes,Route,Link} from 'react-router-dom';
import {Home} from './Home';
import {Design} from './Design';
import Footer from './Components/Footer';
import {Form1} from './Form1';
import Workcatalog from './Workcatalog'



function App() {
  return (
    <>
      <BrowserRouter>
        <NaviBar />
        <Routes>
          <Route path="/" element={<Home/>} />
          <Route path="/design" element={<Design/>} />
          <Route path="/form" element={<Form1/>} />
          <Route path="/workcatalog" element={<Workcatalog/>} />
        </Routes>
      </BrowserRouter>
      <Footer/> 
    </>
  );
}

export default App;
