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

    calculateNbEmployees(){
        return this.collection.length;
    }

    calculateTotalSalary(){
        totalSalary = 0;
        for(let emp of this.collection){
            let employee = new Employee(emp);
            totalSalary += parseFloat(employee.calculateMonthlySalary());
        }
        return (totalSalary.toFixed(2));
    }

    duplicateEmployee(employeeId){
        let currentEmployee = this.collection.find(emp => emp.id == employeeId)
        let newEmployee = new Employee(currentEmployee);
        let maxId = (this.collection.sort((a,b)=> a.id - b.id))[this.collection.length-1].id;
        newEmployee.id = ++maxId;
        this.collection.push(newEmployee);
    }

    deleteEmployee(employeeId){
        console.log(employeeId);
        this.collection = this.collection.filter(emp => emp.id !== employeeId);
        console.log(this.collection);

    }

    
}


export {Employees};