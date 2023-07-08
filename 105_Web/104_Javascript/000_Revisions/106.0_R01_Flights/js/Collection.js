import { Db } from "./Db.js";
import { Item } from "./Item.js";

class Collection{
    constructor(){
        this.collection = [];
        this.collectionWork = [];
        this.source = "/json/flights.json"; // ajouter la source json
    }

    async getCollection(){
        let data = await Db.fetchData(this.source);
        console.log(data);
        this.collection = data; //  attention au data
        this.collection = this.collection.map(i=>new Item(i));
        this.collectionWork = Array.from(this.collection);
        console.log(this.collection);
    }

    sortCollection(name, sortDirection){
        console.log(this.collection[0][name])
        if(typeof(this.collection[0][name]) != "string"){
            this.collection.sort((a,b) => a[name] - b[name]);
            console.log(`test number`);
        } else {
            this.collection.sort((a,b) => a[name].localeCompare(b[name]));
            console.log("test string")
        }
        if(!sortDirection){
            this.collection.reverse();
        }

        // Pourquoi a[name] devient undefined
        // this.collection.sort((a,b) => a[name].localeCompare(b[name]));
    }

    sortRef(name, sortDirection){
        if(typeof(this.collection[0].name) != "string"){
            console.log(typeof(this.collection[0][name]))
            this.collection.sort(function(a,b) {
                //let a1 = typeof(toString(a[name]));
                //let b1 = typeof(toString(b[name]));
                console.log(`a ${a[name]} b ${b[name]}`);
                //console.log(`a1 ${a1} b1 ${b1}`);
                return a[name] - b[name];
            });
        } else {
            
            this.collection.sort((a,b) => a[name].localeCompare(b[name]));
        }

        // this.collection.sort((a,b) => a[name].localeCompare(b[name]));

        if(!sortDirection){
            this.collection.reverse();
        }
        console.log(this.collection);
    }

    searchCollection(value){
        console.log(value);
        let search = value.trim().toLowerCase();
        console.log(search);
        if (search.length > 0){
            this.collection = this.collectionWork.filter(airlineName => airlineName.airline_name.toLowerCase().includes(search))
            console.log(this.collectionWork);
        }
    }

}

export {Collection};