import {Collection} from "./Collection.js";
import {Ui} from "./Ui.js";
import {Event} from "./Event.js";

let subjectCollection = new Collection();
Event.collection = subjectCollection;

await subjectCollection.getCollection();

let table = new Ui(subjectCollection);
table.generateTable();