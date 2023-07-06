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

    sortCollection(name, sortDirection){
        //console.log(name);
        if(typeof(this.collection[0][name]) != "string"){
            //console.log("test")
            this.collection.sort((a,b) => a[name] - b[name]);
            //console.log(this.collection.reverse());
        } else {
            //console.log("test");
            this.collection.sort((a,b) => a[name].localeCompare(b[name]));
            console.log(this.collection);
        }
        if(!sortDirection){
            console.log("test");
            this.collection.reverse();
        }
    }

    searchItem(value){
        //console.log("test Collection searchItem")
        this.collection = this.collectionWork.filter(item =>item.fullname.toLowerCase().includes(value.toLowerCase()));
        //console.log(this.collectionWork);
    }

    calculateNbEmployees(){
        return this.collection.length;
    }

    calculateTotalSalary(){
        let totalSalary = this.collection.reduce((accumulator, currentValue) => accumulator + parseFloat(currentValue.monthlySalary), 0)
        return totalSalary.toFixed(2);
    }

    test2(){
        console.log("test2");
    }
}

export {Collection};