import {Collection} from "./Collection.js";
import {Table} from "./Table.js";
import {Event} from "./Event.js";

let subjectCollection = new Collection();
Event.collection = subjectCollection;

await subjectCollection.getCollection();

let table = new Table(subjectCollection);
table.generateTable();