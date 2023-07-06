import {Collection} from "./Collection.js";
import {Table} from "./Table.js";
import {Event} from "./Event.js";

let flightsCollection = new Collection();
Event.collection = flightsCollection;


await flightsCollection.getCollection();

let table = new Table(flightsCollection);
table.generateTable();

let head = document.querySelectorAll(".keys");
for(let h of head){
    h.addEventListener("click", (e)=>{
        Event.columnSort(e);
        table.generateTable();
    })
}

document.getElementById("search").addEventListener("input", (e) =>{
        flightsCollection.searchCollection(e);
        table.generateTable();
    }
);
