import {Cereal} from "./Cereal.js"
import {Cereals} from "./Cereals.js";

const cereals = new Cereals("/json/cereals.json");
await cereals.getCereals();

const thead = document.getElementById("thead");
const tbody = document.getElementById("tbody");
const rowThead = document.getElementById("rowThead");
//console.log(thead);

function CreateTable(){
    CreateThead();
    createTbody();
}

function CreateThead(){
    let myCereal = cereals.getFirst();
    console.log(myCereal);
    for(let item of myCereal.getKeys()){
        CreateCell(rowThead, item.toUpperCase(), "th");
    }
}

function CreateCell(row, data, type){
    let cell = document.createElement(type);
    cell.textContent = data;
    row.appendChild(cell);
}

function createTbody(){
    for(let cereal of cereals.collection){
        let row = document.createElement('tr');
        for(let data of cereal.getValues()){
            CreateCell(row, data, "td")
        }
        tbody.appendChild(row);
    }
}

CreateTable();