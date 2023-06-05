import {Card} from "./Card.js";


class Cards{
    constructor(_url){
       this.cardsCollection = [] ;
       this.source = _url
    }

    async getCards(){
        let response = await fetch(this.source);
        let json = await response.json();
        for (let card of json){
            this.cardsCollection.push(new Card(card));
        }
    }

    getFirst(){
        try{
            return this.cardsCollection[0];
        } catch(error){
            alert("La collection est vide !")
        }
    }

    getHigherAttackCard(){
        return this.cardsCollection.sort((a,b)=>
        b.attack-a.attack)[0];
    }

    getHigherArmorCard(){
        return this.cardsCollection.sort((a,b)=>
        b.armor-a.armor)[0];
    }

    getHigherPlayedCard(){
        return this.cardsCollection.sort((a,b)=>(b.played-a.played))[0];
    }

    getHigherVictoriesCard(){
        return this.cardsCollection.sort((a,b)=>(b.victory-a.victory))[0];
    }
}

export {Cards};