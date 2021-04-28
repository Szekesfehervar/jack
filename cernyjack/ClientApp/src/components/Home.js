import React, { Component } from 'react';
import authService from './api-authorization/AuthorizeService';
import { ApplicationPaths, QueryParameterNames } from './api-authorization/ApiAuthorizationConstants'
import axios from "axios";
import {CardList} from "./CardList"



export class Home extends Component {
    state = {
        dealerCards: [],
        userCards:[],
        currentUserEmail: "",
        isAuthenticated: false,
        hasEnded: false
    };

    componentDidMount() {
        this._subscription = authService.subscribe(() => this.populateState());
        this.populateState();
        
        
        
    }

    componentWillUnmount() {
        authService.unsubscribe(this._subscription);
    }

    async populateState() {
        const [isAuthenticated, user] = await Promise.all([authService.isAuthenticated(), authService.getUser()])
        console.log(user);
        this.setState({
            isAuthenticated
        });
        if (isAuthenticated) {
            this.setState({
                currentUserEmail: user.name
            });
        }
    /*    if (isAuthenticated) {
            axios.get("https://localhost:44382/api/usercards")
                .then(function (response) {
                    console.log(response)
                    this.setState({
                        usercards: response.data
                    })
                });
        }*/
        this.setState({
            userCards: [
                {
                    id: 1,
                    value:4
                },
                {
                    id: 2,
                    value: 8
                },
                {
                    id: 3,
                    value: 12
                }
            ],
            dealerCards: [
                {
                    id: 4,
                    value: 4
                },
                {
                    id: 5,
                    value: 8
                } 
            ]
        })
    }


    //deal = () => {
    //    let newCards = [...this.state.userCards];
    //    newCards.push({ id: 10, value: 5 });
    //    this.setState({ userCards: newCards });
    //}


    render() {
        const redirectUrl = `${ApplicationPaths.Login}`;
        if (!this.state.isAuthenticated) {
            return (
                <div>
                    <a className="button button-primary" href={redirectUrl}>Sign In to play</a>
                </div>
            );
        }
        return (
            <div className="container">
                <CardList cards={this.state.dealerCards} title="Dealer" />
                <div style={{ height: "15rem" }}> <button type="button" className="button button-success">Deal Card</button></div>
                <CardList cards={this.state.userCards} title="Player" />   
       </div>
    );
  }
}
