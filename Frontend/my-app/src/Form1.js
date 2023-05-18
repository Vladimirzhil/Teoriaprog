import React, { useEffect } from 'react';
import { useState } from 'react';
import { Button, Modal, Form, input } from 'react-bootstrap';
import { Link } from 'react-router-dom';

export function Form1() {
    const [formFields, setFormFields] = useState([
        { device: '' },
    ])

    const handleFormChange = (event, index) => {
        let data = [...formFields];
        data[index][event.target.name] = event.target.value;
        setFormFields(data);
    }

    const submit = (e) => {
        e.preventDefault();
        console.log(formFields)
    }

    const addFields = () => {
        let object = {
            device: ''
        }

        setFormFields([...formFields, object])
    }

    const removeFields = (index) => {
        let data = [...formFields];
        data.splice(index, 1)
        setFormFields(data)
    }
    //СуперПропс
    this.onInputChange = this.onInputChange.bind(this);


   const DesignUrl='/api/Domain/Designproject/GetDesignprojectByName'
   const [dataDesign,setDataDesign]=useState('')

    useEffect(() => {
        const fetchDataClient = async() => {
          const response = await axios.get(url)
    
          setData(response.data)
        }
        const fetchDataOrder = async() => {
            const response = await axios.get(url)
      
            setData(response.data)
          }
          const fetchDataTypework = async() => {
            const response = await axios.get(url)
      
            setData(response.data)
          }
          const fetchDataDesignproject = async() => {
            const response = await axios.get(DesignUrl)
      
            setDataDesign(response.dataDesign)
          }
          const fetchDataWorkcatalog = async() => {
            const response = await axios.get(DesignUrl)
      
            setDataWorkcatalog(response.dataWorkcatalog)
          }
          fetchDataClient(); fetchDataOrder(); fetchDataTypework(); fetchDataDesignproject();fetchDataWorkcatalog()
      }, [tempValue]);
    
    



    return (
        <div className="App">
            <h1 class="forma1">Форма заказа</h1>

            <h5 class="forma2">Введите свои данные</h5>
            <div class="form-row">
                <div class="form-group">
                    <label for="inputName">ФИО</label>
                    <input type="Name" class="form-control" id="inputFIO" placeholder="" />
                </div>
                <div class="form-group">
                    <label for="inputPhone">Телефон</label>
                    <input class="form-control" id="inputPhone" />
                </div>
            </div>
            <div class="form-group">
                <label for="inputAddress">Адрес</label>
                <input type="text" class="form-control" id="inputAddress" placeholder="Например : г.Рязань ул.Пушкина д.Колотушкина к.2" />
            </div>
            <div class="form-group">
                <label for="inputDesign">Выберите дизайн</label>
                <select id="inputDesign" class="form-control">
                    {dataDesign.map((post)=>{
                        return(
                            <option value={this.state} onChange={onInputChange}>{post.design_project_name}</option>
                        );
                    })}
                </select>
                <form onSubmit={submit}>
                    <h1 class="btn5">
                        <Button variant="info" onClick={addFields}>Добавить</Button>
                    </h1>
                    {formFields.map((form, index) => {
                        return (
                            <div class="forma-group">
                                <label for="inputProduct">Выберите необходиче работы</label>
                                <select id="inputState" class="form-control">
                                    <option selected>Выбрать</option>
                                    <option>Выравнивание стен</option>
                                    <option>Поклейка обоев</option>
                                    <option>Укладка плитки</option>
                                    <option>Коммуникация сантехники</option>
                                    <option>Прокладка проводки</option>
                                    <option>Монтаж потолоков</option>
                                    <option>Установка подрозетников</option>
                                    <option>Установка декоративных плинтусов</option>
                                    <option>Разработка дизайн проекта</option>
                                    <option>Установка оконной рамы</option>
                                    <option>Укладка ламинта</option>
                                    <option>Демонтаж напольного покрытия</option>
                                    <option>Демонтаж покрытий на стенах</option>
                                </select>
                                <h1 class="btn4">
                                    <Button variant="info"style={{width:96}} onClick={() => removeFields(index)} class="remove">Удалить</Button>
                                </h1>
                            </div>
                        )
                    })}
                </form>

                <br />

                <div class="btn1" >
                    <h1>
                        <h1 class="btn2">
                            <Button variant="info">
                                Заказать
                            </Button>
                        </h1>
                        <h1 class="btn3">
                            <Link to="/">
                                <Button variant="info">
                                    На главную
                                </Button>
                            </Link>
                        </h1>
                    </h1>
                </div>
            </div>
        </div>
    );
}