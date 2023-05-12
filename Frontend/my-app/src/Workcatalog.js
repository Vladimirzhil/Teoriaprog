import { useEffect, useState } from "react";
import {
  Form,
  Table,
  DropdownButton,
  Dropdown,
  Button,
} from "react-bootstrap";

export default function Client() {
  const [data, setData] = useState([]);

  useEffect(() => {
    fetch("/api/Domain/Workcatalog")
      .then((res) => res.json())
      .then((res) => {
        setData(res);
      });
  }, []);

  const [id,setId] = useState(1)


  return (
    <div>
      <h1>Виды представляемых работ:</h1>
      <Table striped bordered hover variant="dark" style={{ width: 600 }}>
        <thead>
          <tr>
            <th>Название работ</th>
            <th>Цена</th>
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
        <h3>Фильтр</h3>                     
        <Form.Control 
          id="id" 
          type="id" 
          placeholder="Enter id" 
          style={{width:200}} 
          value={id}
          onChange={event => setId(event.target.value)}
        />
      </div>
    </div>
  );
}
