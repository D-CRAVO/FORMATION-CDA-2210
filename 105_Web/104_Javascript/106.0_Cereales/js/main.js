import {Cereal} from "./Cereal.js"
import {Cereals} from "./Cereals.js";

const cereals = new Cereals("/json/cereals.json");
await cereals.getCereals();

const table = document.getElementById('table');
const thead = document.getElementById("thead");
const tbody = document.getElementById("tbody");
const tfoot = document.getElementById('tfoot');
const rowThead = document.getElementById("rowThead");
const rowTfoot = document.getElementById("rowTfoot");
//console.log(thead);

let sort = true;

function CreateTable(){
    CreateThead();
    CreateTbody();
    CreateTfoot();
    
}

function CreateThead(){
    let myCereal = cereals.getFirst();
    //console.log(myCereal);
    for(let item of myCereal.getKeys()){
        CreateTheadCell(rowThead, item, 'th');
    }
    CreateTheadCell(rowThead, "ns".toUpperCase(), 'th');
    CreateCell(rowThead, "del".toUpperCase(), 'th');
}

function CreateCell(row, data, type){
    let cell = document.createElement(type);
    
    cell.textContent = data;
    row.appendChild(cell);
}

function CreateTheadCell(row, data, type){
    // utiliser le type
    let button = CreateButton(row, 'td');
    button.textContent = data.toUpperCase();
    button.addEventListener('click', ()=>{
        cereals.CompareValues(sort, data);
        console.log(data);
        CreateTbody();
        sort = !sort;
    })
}

function CreateTbody(){
    tbody.innerHTML = "";
    for(let cereal of cereals.collection){
        let row = document.createElement('tr');
        for(let data of cereal.getValues()){ 
            CreateCell(row, data, 'td')
        }
        CreateCell(row,cereal.CalculateNutriScore().toUpperCase(), 'td');
        CreateDelCell(row, cereal);
        tbody.appendChild(row);
    }
}

function CreateDelCell(row, cereal){
    let button = CreateButton(row, 'th')
    button.dataset.id = cereal.id;
    button.innerHTML = '<i class="fa-solid fa-xmark" style="color: #ff0000;"></i>';
    button.textContent = "Delete"
    button.addEventListener('click', (event)=>{
        let cerealId = event.target.dataset.id;
        //console.log(event)
        cereals.DeleteCereal(cerealId);
        CreateTbody();
    });
    
}

function CreateButton(row, type){
    let cell = document.createElement(type);
    let button = document.createElement('button');
    cell.appendChild(button);
    row.appendChild(cell);
    return button;
}

function CreateTfoot(){
    let myCereal = cereals.getFirst();
    for(let item of myCereal.getKeys()){
        CreateTfootCell(rowTfoot, item)
    }
    CreateTotalElements();
    CreateAverageCalories();
}

function CreateTfootCell(row, item){
    let cell = document.createElement('td');
    cell.dataset.id = `tfoot${item}`;
    cell.id = `tfoot${item}`;
    //cell.textContent = item
    row.appendChild(cell);
}

function CreateTotalElements(){
    let cellTotalElements = document.getElementById('tfootname');
    cellTotalElements.textContent = cereals.collection.length + ' éléments';
    console.log(cereals.collection.length);
}

function CreateAverageCalories(){
    let cellAverageCalories = document.getElementById('tfootcalories');
    cellAverageCalories.textContent = 'Moyenne calories ' + cereals.calculateAverageCalories();
}

CreateTable();