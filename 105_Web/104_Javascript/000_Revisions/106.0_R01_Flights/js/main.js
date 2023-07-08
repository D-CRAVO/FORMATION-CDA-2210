import {Collection} from "./Collection.js";
import {UI} from "./UI.js";
import {Event} from "./Event.js";

let subjectCollection = new Collection();
Event.collection = subjectCollection;

await subjectCollection.getCollection();

let ui = new UI(subjectCollection);
ui.generateTable();

document.getElementById("airlineName").addEventListener("click", (e) =>{
    Event.columnSort(e);
    ui.generateTable();
})

// Pourquoi faut-il cliquer 2 fois sur l'en-tête pour que le tri soit fait
document.getElementById("planeRef").addEventListener("click", (e) =>{
    Event.sortPlaneRef(e);
    ui.generateTable();
})

document.getElementById("inputSearch").addEventListener("input", (e) =>{
    Event.search(e);
    ui.generateTable();
})

