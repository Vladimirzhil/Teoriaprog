import React from 'react';
import { Button, Navbar, Nav } from "react-bootstrap";
import { Link } from 'react-router-dom';
import Styled from 'styled-components';


const Styles = Styled.div`
.navbar-brand{

    margin-left: 40px;
    font-size: 25px;
    text-decoration-line:none;
    &:hover {
        color:white;
    }
}
a, .navbar-nav .nav-link, .link{
    color: #2b2b2b;
    text-decoration:none;
    &:hover {
        color:white;
    }
}
`

export default function NaviBar() {
    return (
        <>
            <Styles>
                <Navbar collapseOnSelect expand="lg" bg="info" variant="info">
                    <Navbar.Brand href="/"><Link to='/'>Стройвован</Link></Navbar.Brand>
                    <Navbar.Toggle aria-controls="responsive-navbar-nav" />
                    <Navbar.Collapse id="responsive-navbar-nav">
                        <Nav className="mr-auto">
                            <Nav.Link> <Link to='/design'> Наши дизайн проекты </Link> </Nav.Link>
                            
                            <Nav.Link> <Link to='/form'> Сделать заказ </Link> </Nav.Link>
                        </Nav>
                    </Navbar.Collapse>
                </Navbar>
            </Styles>
        </>
    )
}