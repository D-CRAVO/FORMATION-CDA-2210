import {Db} from "./Db.js";
import {Item} from "./Item.js";

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

    sortCollection(name, sortDirection){
        if(typeof(this.collection[0][name]) != "string"){
            this.collection.sort((a,b)=>a[name]-b[name]); 
        } else {
            this.collection.sort((a,b)=>a[name].localeCompare(b[name]));
        }
        if(!sortDirection){
            this.collection.reverse();
        }
    }

    searchCollection(e){
        search = e.target.trim();
        if(search.length > 0){
            this.collection = this.collection.filter(flight => flight.airline_name.includes(search))
        }
    }
}

export {Collection};