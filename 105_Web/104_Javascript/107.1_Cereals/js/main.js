import {Cereal} from "./Cereal.js"
import {Cereals} from "./Cereals.js";

let cereals = new Cereals("/json/cereals.json");
await cereals.getCereals();

const table = document.getElementById('table');
const thead = document.getElementById("thead");
const tbody = document.getElementById("tbody");
const tfoot = document.getElementById('tfoot');
const rowThead = document.getElementById("rowThead");
const rowTfoot = document.getElementById("rowTfoot");
const searchInput = document.getElementById("search");

let sort = true;

searchInput.addEventListener('keyup', (event) => {
    let value = event.target.value;
    cereals.search(value);
    CreateTbody();
    CreateTfoot();

    
});

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
    // let button = CreateButton(row, 'td');
    // button.textContent = data.toUpperCase();
    // button.addEventListener('click', ()=>{
    //     cereals.CompareValues(sort, data);
    //     console.log(data);
    //     CreateTbody();
    //     sort = !sort;
    // })

    let cell = CreateBalise(row, 'td');
    let balise = CreateBalise(cell, 'a');
    balise.setAttribute('href', '#');
    balise.textContent = data.toUpperCase();
    balise.addEventListener('click', ()=>{
        cereals.CompareValues(sort, data);
        console.log(data);
        CreateTbody();
        sort = !sort;
    })
}

function CreateTbody(){
    tbody.innerHTML = "";

    console.log(cereals.collection);

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
    let balise = CreateBalise(row, 'i');
    balise.dataset.id = cereal.id;
    balise.classList.add('fa');
    balise.classList.add('fa-close');
    balise.addEventListener('click', (event)=>{
        let cerealId = event.target.dataset.id;
        //console.log(event)
        cereals.DeleteCereal(cerealId);
        CreateTbody();
        CreateTfoot();
    });
}

function CreateButton(row, type){
    let cell = document.createElement(type);
    let button = document.createElement('button');
    cell.appendChild(button);
    row.appendChild(cell);
    return button;
}

function CreateBalise(parent, balise){
    let cell = document.createElement(balise);
    parent.appendChild(cell);
    return cell;
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
    //console.log(cereals.collection.length);
}

function CreateAverageCalories(){
    let cellAverageCalories = document.getElementById('tfootcalories');
    cellAverageCalories.textContent = 'Moyenne calories ' + cereals.calculateAverageCalories();
}



CreateTable();