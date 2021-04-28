import React, { Component } from 'react';


export class CardList extends Component {

    render() {
        return (
            <div>
                <h4>{this.props.title}</h4>
                <div className="card-deck">
                    {this.renderCards()}
                </div>
                
            </div>

        );
    }



    renderCards() {
      
        return this.props.cards.map(card => {
            return (
                <div key={card.id} className="card" style={{ maxWidth: "13rem", height: "20rem" }}>
                    <div className="card-body">
                        <h5 className="card-title">{card.value}</h5>
                    </div>                   
                </div>
            );
        })
    }
}

