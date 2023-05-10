import React from "react";
import Slider from "./Components/Slider";
import { Container, Row, Col, Card, Button } from "react-bootstrap";
import { Link } from 'react-router-dom';
import './App.css';
import design1_1 from './design1_1.png'
import design2_1 from './design2_1.png'
import design3_1 from './design3_1.png'




const ColoredLine=({colot})=>(
    <hr style={{
        colot:ColoredLine,
        backgroundColor:ColoredLine,
        height:10
    }}/>
)

export const Home = () =>
(
    <>
        <Slider />
        <ColoredLine color="black"/>
        <div style={{textAlign:"center"}}><h2>Наиболее популярные наши дизайны</h2>
        <Container style={{ paddingTop: '2rem', paddingBottom: '2rem' }}>
            <Row>
            <Col>
                    <Card style={{ width: '19rem', height: '19rem', whiteSpace: 'pre-wrap' }}>
                        <Card.Img cariant="top" style={{'height':'210px'}} src={design1_1}/>
                        <Card.Title>Домашний</Card.Title>
                        <Card.Text>
                        </Card.Text>
                        <Link to="/form" >
                            <Button variant="primary" style={{
                                backgroundColor: "#17a2b8",
                                borderStyle: "none",
                                float: "center",
                            }}>К заказу</Button>
                        </Link>
                    </Card>
                </Col>
                <Col>
                    <Card style={{ width: '19rem', height: '19rem', whiteSpace: 'pre-wrap' }}>
                        <Card.Img cariant="top" style={{'height':'210px'}} src={design2_1}/>
                        <Card.Title>Фиолетовое борроко</Card.Title>
                        <Card.Text>
                        </Card.Text>
                        <Link to="/form" >
                            <Button variant="primary" style={{
                                backgroundColor: "#17a2b8",
                                borderStyle: "none",
                                float: "center",
                            }}>К заказу</Button>
                        </Link>
                    </Card>
                </Col>
                <Col>
                    <Card style={{ width: '19rem', height: '19rem', whiteSpace: 'pre-wrap' }}>
                        <Card.Img cariant="top" style={{'height':'210px'}} src={design3_1}/>
                        <Card.Title> Лофт</Card.Title>
                        <Card.Text>
                        </Card.Text>
                        <Link to="/form" >
                            <Button variant="primary" style={{
                                backgroundColor: "#17a2b8",
                                borderStyle: "none",
                                float: "center",
                            }}>К заказу</Button>
                        </Link>
                    </Card>
                </Col>
            </Row>
        </Container>
        </div>
    </>
)
