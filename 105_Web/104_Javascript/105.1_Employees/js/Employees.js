import {Employee} from "./Employee.js";

class Employees{
    constructor(url){
        this.source = url;
        this.collection = [];
    }

    async getEmployees(){
        let response = await fetch(this.source);
        let json = await response.json();
        //console.log(json);
        for(let employee of json.data){
            this.collection.push(employee);
        }
    }
}


export {Employees};