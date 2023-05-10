import React from "react";
import Styled from 'styled-components';

const Styles = Styled.div`
.col-md-6{
    width: 40%;
}
}
a, .navbar-nav .nav-link, .link{
    color: #b0b7c6;
    text-decoration:none;
    &:hover {
        color:white;
    }
`

const Footer = () => (
    <div className="footer">
        <Styles>
            <footer fluid style={{ backgroundColor: '#282828', color: '#b0b7c6' }}>
                <div className="container-fluid text-center text-md-left">
                    <div className="row">
                        <div className="col-md-6 mt-md-0 mt-3">
                            <h5 className="text">Стройвован</h5>
                            <p>Лучшие цены среди конкурентов</p>
                        </div>

                        <hr className="clearfix w-50 d-md-none pb-0" />

                        <div className="col-md-3 mb-md-0 mb-3">
                            <h5 className="text">Связаться с автором</h5>
                            <ul className="list-unstyled">
                                <li><a href="https://vk.com/id273082359">Сообщить о проблеме</a></li>
                            </ul>
                        </div>

                        <div className="col-md-3 mb-md-0 mb-3">
                            <h5 className="text">Проект</h5>
                            <ul className="list-unstyled">
                                <li><a href="https://github.com/Vadimka444/tp135">GitHub</a></li>
                            </ul>
                        </div>

                    </div>
                </div>

                <div className="footer-copyright text-center py-3">© 2023 Стройвован

                </div>

            </footer>
        </Styles>
    </div>

)
export default Footer;