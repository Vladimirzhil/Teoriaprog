import React from 'react';
import { Carousel } from 'react-bootstrap';
import back1 from '../back1.jpg'
import remont from '../remont.jpg'
export default function Slider(){
    return(
        <Carousel>
            <Carousel.Item style={{'height':'500px'}}>
                <img
                className='d-block w-100'
                src={back1}
                alt="First slide"
                />
                <Carousel.Caption>
                    <h3 style={{color:'black',paddingTop:'10px'}}>Стройвован</h3>
                    <p style={{color:'black'}}></p>
                </Carousel.Caption>
            </Carousel.Item>
            <Carousel.Item style={{'height':'500px'}}>
                <img
                className='d-block w-100'
                src={remont}
                alt="First slide"
                />
                <Carousel.Caption>
                    <h3 style={{color:'black'}}> Никогда не подводим наших клиентов</h3>
                    <p style={{color:'black'}}></p>
                </Carousel.Caption>
            </Carousel.Item>
        </Carousel>
    )
}
