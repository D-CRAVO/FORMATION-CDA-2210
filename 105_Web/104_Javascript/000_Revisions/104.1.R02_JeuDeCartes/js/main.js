import {Cards} from "./Cards.js";

const cards = new Cards("/json/cardgame.json");
await cards.getCards();

tbody = document.getElementById("tbody");
thead = document.getElementById("thead");

function createTable(){
    for(let card of cards.cardsCollection){
        let row = document.createElement('tr');
        for(let data of card.getValues()){
            let cell = document.createElement('td');
            cell.textContent = data;
            row.appendChild(cell)
        }
        tbody.appendChild(row);
    }
    createThead(thead);
}

function createThead(tab){
    let myCard = cards.cardsCollection[0];
    let row = document.createElement('tr');
    for(let data of myCard.getKeys()){
        let cell = document.createElement('th');
        cell.textContent = data;
        row.appendChild(cell)
    }
    tab.appendChild(row);
}

createTable();