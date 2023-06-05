import {Card} from "./Card.js";
import {Cards} from "./Cards.js";

const cards = new Cards("https://arfp.github.io/tp/web/frontend/cardgame/cardgame.json")
await cards.getCards();


const myThead = document.getElementById("myThead");
const myTbody = document.getElementById("myTbody");
const myTfoot = document.getElementById("myTfoot");
const maxAttack = document.getElementById("maxAttack")

function createTable(){
    for (let card of cards.cardsCollection){
        let row = document.createElement("tr");
        for(let data of card.getValues()){
            let cell = document.createElement('td');
            cell.textContent = data;
            row.appendChild(cell);
        }
        myTbody.appendChild(row);
    }
    createTableHeader(myThead);
    createTableFooter();
}

function createTableHeader(tab){
    let myCard = cards.getFirst();
    let row = document.createElement("tr");
    for(let data of myCard.getKeys()){
        let cell = document.createElement("th");
        cell.textContent = data;
        row.appendChild(cell);
    }
    tab.appendChild(row);
}

function createTableFooter(){
    console.log(cards.getHigherAttackCard());
    createTableHeader(myTfoot);
    let myCard = cards.getHigherAttackCard();
    let row = document.createElement("tr");
    for(let data of myCard.getValues()){
        let cell = document.createElement("td")
        cell.textContent = data;
        row.appendChild(cell);
    }
    myTfoot.appendChild(row);
}

function addRow(tab, myCard){
    let row = document.createElement("tr");
    for(let data of myCard.getValues()){
        let cell = document.createElement("td")
        cell.textContent = data;
        row.appendChild(cell);
    }
    tab.appendChild(row);
}

function createTableMaxAttack(){
    createTableHeader(maxAttack);
    let myCard = cards.getHigherAttackCard();
    addRow(maxAttack, myCard);
}

function createTableMaxArmor(){
    let maxArmor = document.getElementById("maxArmor")
    createTableHeader(maxArmor);
    let myCard = cards.getHigherArmorCard();

    /*
    let row = document.createElement("tr");
    for(let data of myCard.getValues()){
        let cell = document.createElement("td");
        cell.textContent = data;
        row.appendChild(cell);
    }   
    maxArmor.appendChild(row); 
    */

    addRow(maxArmor, myCard);
}
    
function createTableMaxPlayed(){
    maxPlayed = document.getElementById("maxPlayed");

    

    createTableHeader(maxPlayed);
    let myCard = cards.getHigherPlayedCard();


    addRow(maxPlayed, myCard);
}

createTable();
createTableMaxAttack();
createTableMaxArmor();
createTableMaxPlayed();