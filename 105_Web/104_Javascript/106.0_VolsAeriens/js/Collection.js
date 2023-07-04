import {Db} from "./Db.js";
import {Item} from "./Item.js"

class Collection{
    constructor(){
        this.collection = [];
        this.source = "/json/flights.json";
    }

    async getCollection(){
        let data = await Db.fetchData(this.source);
        this.collection = data;
        this.collection = this.collection.map(i=>new Item(i));
        console.log(this.collection);
    }

    sortCollection(name){
        this.collection.sort((a,b)=>a[name]-b[name]);
    }
}

export {Collection};