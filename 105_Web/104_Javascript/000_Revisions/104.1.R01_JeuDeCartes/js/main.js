import {Card} from "./Card.js";
import {Cards} from "./Cards.js";

//const cards = new Cards("/json/cardgame.json");
const cards = new Cards("https://arfp.github.io/tp/web/frontend/cardgame/cardgame.json")
await cards.getCards();

const tbody = document.getElementById('tbody');

console.log(cards.cardsCollection);

function createTable(){
    for(let card of cards.cardsCollection){
        let row = document.createElement('tr');
        for(let data of card.getValues()){
            let cell = document.createElement('td');
            cell.textContent = data;
            row.appendChild(cell);
        }
        tbody.appendChild(row);
    }
}

createTable();