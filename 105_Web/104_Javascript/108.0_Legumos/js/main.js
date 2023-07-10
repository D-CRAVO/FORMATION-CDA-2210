import { LegumosCollection } from "./LegumosCollection.js";
import {Event} from "./Event.js"
import {UI} from "./UI.js"

let legumosCollection = new LegumosCollection();
Event.Collection = legumosCollection;

await legumosCollection.getLegumosCollection();

let ui = new UI(legumosCollection);
ui.generateThead();
ui.generateTable();


