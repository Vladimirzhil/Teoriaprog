import { getValue } from "@testing-library/user-event/dist/utils";
import axios from "axios";
import { useEffect, useState } from "react";
import {
  Form,
  Table,
  Button,
  FormControl,
} from "react-bootstrap";

export default function Workcatalog() {
  const [data, setData] = useState([]);

  const [name,setName] = useState('')
  const [tempValue, setTempValue] = useState('');

  const handleButtonClick = () => {
    setTempValue(name);
  };

  const params = {
    name: name,
  };
  
  const queryString = params
    ? Object.keys(params)
        .map((key) => `${encodeURIComponent(key)}=${encodeURIComponent(params[key])}`)
        .join('&')
    : '';

  const baseUrl = '/api/Domain/Workcatalog/GetWorkcatalogByName';

  const url = queryString ? `${baseUrl}?${queryString}` : baseUrl;

  useEffect(() => {
    const fetchData = async() => {
      const response = await axios.get(url)

      setData(response.data)
    }
    fetchData()
  }, [tempValue]);



  return (
    <div>
      <h1>Каталог работы:</h1>
      <Table striped bordered hover variant="dark" style={{ width: 600 }}>
        <thead>
          <tr>
            <th>Название</th>
            <th>Цена работы</th>
          </tr>
        </thead>
        <tbody>
          {data.map((post) => {
            return (
              <tr>
                <td style={{ color: "#54B4D3" }}>{post.name}</td>
                <td style={{ color: "#54B4D3" }}>{post.pricework}</td>
                
              </tr>
            );
          })}
        </tbody>
      </Table>
      <div style={{}}>
        <h3>Фильтер</h3>
        <input
          type="text" 
          placeholder="Введите название" 
          style={{width:200}} 
          value={name}
          onChange={event => setName(event.target.value)}
        />
        <Button onClick={handleButtonClick}>Найти</Button>
      </div>
    </div>
  );
}