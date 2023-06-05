import {Employee} from "./Employee.js"

class Employees{
    constructor(url){
        this.source = url;
        this.employeesCollection = [];
    }

    async getData(){
        let response = await fetch(this.source);
        let json = await response.json();
        for(let data of json.data){
            this.employeesCollection.push(new Employee(data));
        }
    }



    
}

export{Employees};