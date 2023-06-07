import {Employee} from "./Employee.js";

class Employees{
    constructor(url){
        this.collection = [];
        this.source = url;
    }

    async getEmployees(){
        let response = await fetch(this.source);
        let json = await response.json();
        for(let employee of json.data){
            this.collection.push(new Employee(employee));
        }
        console.log(this.collection)
    }

    
}

export {Employees};


    