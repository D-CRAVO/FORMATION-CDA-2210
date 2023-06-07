import {Card} from "./Card.js";

class Cards{
    constructor(url){
        this.cardsCollection = [];
        this.source = url
    }

    async getCards(){
        let response = await fetch(this.source);
        let json = await response.json();
        console.log(json)
        for(let card of json){
            this.cardsCollection.push(new Card(card));
        }
        console.log(this.cardsCollection)
    }

    getFirst(){
        try{
            return this.cardsCollection[0];
        } catch(error){
            alert('La collection est vide !');
        }
    }
}

export {Cards};