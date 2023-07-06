import {Collection} from "./Collection.js";
import {Table} from "./Table.js";
import {Event} from "./Event.js";

let subjectCollection = new Collection();
Event.collection = subjectCollection;

await subjectCollection.getCollection();

let table = new Table(subjectCollection);
table.generateTable();

document.getElementById("search").addEventListener("input", (e) =>{
    //console.log(e.target.value);
    //Event.test(e.target.value);
    Event.searchItem(e.target.value);
    table.generateTable();
});

document.querySelectorAll(".sort").addEventListener("click", (e) => {
    Event.columnSort(e.target.name);
    table.generateTable;
})