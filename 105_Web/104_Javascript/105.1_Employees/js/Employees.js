import {Employee} from "./Employee.js";

class Employees{
    constructor(url){
        this.source = url;
        this.collection = [];
    }

    async getEmployees(){
        let response = await fetch(url);
        let json = await response.json();
        console.log(json);
    }
}

export {Employees};