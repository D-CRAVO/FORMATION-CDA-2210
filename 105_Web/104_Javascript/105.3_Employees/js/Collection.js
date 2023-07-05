import { Db } from "./Db.js";
import { Item } from "./Item.js";

class Collection{
    constructor(){
        this.collection = [];
        this.collectionWork = [];
        this.source = "/json/employees.json"; // ajouter la source json
    }

    async getCollection(){
        let data = await Db.fetchData(this.source);
        //console.log(data);
        this.collection = data.data; //  attention au data
        this.collection = this.collection.map(i=>new Item(i));
        this.collectionWork = Array.from(this.collection);
        console.log(this.collection);
    }

    // sortCollection(name, sortDirection){
    //     if(typeof(this.collection[0][name]) != "string"){
    //         this.collection.sort((a,b) => a[name] - b[name]);
    //     } else {
    //         this.collection.sort((a,b) => a[name].localeCompare(b[name]));
    //     }
    //     if(!sortDirection){
    //         this.collection.reverse();
    //     }
    // }

    searchItem(value){
        console.log("test Collection searchItem")
        this.collectionWork = this.collection.filter(item => item.employee_name.toLowerCase().includes(value.toLowerCase()));
        console.log(this.collectionWork);
    }

    test2(){
        console.log("test2");
    }
}

export {Collection};