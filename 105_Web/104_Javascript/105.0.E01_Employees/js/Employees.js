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

    // added by mickael
    removeEmployee(id)
    {
        this.collection = this.collection.filter(emp => emp.id != id)
    }

    duplicateEmployee(id)
    {
        let oldEmp = this.collection.find(emp => emp.id == id);

        let newEmp = new Employee(oldEmp);

        let max = this.collection.sort((a,b)=> a.id - b.id)[this.collection.length-1].id;
        console.log(this.collection.length-1);
        console.log(max);
        // trouver l'identifiant le plus élevé dans la collection
        // incrémenter cet identifiant
        // l'affecter à  l'employé dupliqué

        newEmp.id = ++max // nouvel identifiant

        this.collection.push(newEmp);
        /* json = JSON.stringify(this.collection);
        console.log(json); */
    }

    
}

export {Employees};


    