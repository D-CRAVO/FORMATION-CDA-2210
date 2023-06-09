import {Employee} from "./Employee.js";
import {Employees} from "./Employees.js";

let employees = new Employees ("/json/employees.json");
employees.getEmployees();

const tbody = document.getElementById("tbody");

console.log(employees.collection);

function createTable(){
    for(let employee of employees.collection){
        console.log(employee.employee_name)
    }
}
console.log ("toto");

createTable();