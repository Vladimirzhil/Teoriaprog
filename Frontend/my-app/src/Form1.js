import React, { Component } from "react";
import { Button, Modal, Form, input } from "react-bootstrap";
import "bootstrap/dist/css/bootstrap.min.css";

export class Form1 extends Component {
  static displayName = Form1.name;

  constructor(props) {
    super(props);
    this.state = {
      Customername: "",
      Phonenumber: "",
    };

    this.onInputChange = this.onInputChange.bind(this);
    this.sendClientData = this.sendClientData.bind(this);
  }

  onInputChange(event) {
    this.setState({
      [event.target.name]: event.target.value,
    });
  }

  render() {
    return (
      <div>
        <h1 style={{ padding: "10px" }}>Форма для заполнения продукта</h1>

        <Form style={{ padding: "10px" }}>
          <div class="form-row">
            <div class="form-group col-md-6">
              <label for="inputName">Фио</label>
              <input
                type="text"
                class="form-control"
                id="inputName"
                placeholder=""
                value={this.state.Customername}
                name="Customername"
                onChange={this.onInputChange}
              />
            </div>
          </div>
          <div class="form-group col-md-6">
            <label for="inputPhonenumber">Номер телефона</label>
            <input
              type="text"
              class="form-control"
              id="inputProtein"
              placeholder=""
              value={this.state.Phonenumber}
              name="Phonenumber"
              onChange={this.onInputChange}
            />
          </div>

          <Button
            variant="info"
            class="f-button "
            style={{ marginTop: "10px" }}
            onClick={this.sendClientData}
          >
            {" "}
            Отправить заявку
          </Button>
        </Form>
      </div>
    );
  }

  async sendClientData() {
    let client = {
        Customername: this.state.Customername,
        Phonenumber: this.state.Phonenumber,
    };
    console.log(client);

    const reponse = await fetch("/api/Domain/Client", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(client),
    });

    const data = await reponse.json();
    console.log(data);
  }
}
export default Form1;