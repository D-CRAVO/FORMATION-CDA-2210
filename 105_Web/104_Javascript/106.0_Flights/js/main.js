import {Collection} from "./Collection.js";
import {UI} from "./UI.js";
import {Event} from "./Event.js";

let flightsCollection = new Collection();
Event.collection = flightsCollection;


await flightsCollection.getCollection();

let ui = new UI(flightsCollection);
ui.generateTable();

let head = document.querySelectorAll(".keys");
for(let h of head){
    h.addEventListener("click", (e)=>{
        Event.columnSort(e);
        ui.generateTable();
    })
}

document.getElementById("search").addEventListener("input", (e) =>{
        Event.search(e);
        ui.generateTable();
    }
);
