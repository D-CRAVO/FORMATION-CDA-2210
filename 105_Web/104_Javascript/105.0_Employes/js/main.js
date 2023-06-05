import {Employee} from "./Employee.js";
import {Employees} from "./Employees.js";

const employees = new Employees("https://arfp.github.io/tp/web/frontend/employees/employees.json");
await employees.getData();
console.log(employees);

const tbody = document.getElementById("tbody");

function eid(){
    for(let data of employees.employeesCollection){
        let row = document.createElement("tr");
        row.setAttribute("id", `row${data.id}`);
        let cell = document.createElement("td");
        cell.textContent = data.id;
        row.appendChild(cell);
        tbody.appendChild(row);
    }
}

function fullName(){
    for(let data of employees.employeesCollection){
        let row = document.getElementById(`row${data.id}`);
        let cell = document.createElement("td");
        cell.textContent = data.employee_name;
        row.appendChild(cell);
    }
}

function email(){
    for(let data of employees.employeesCollection){
        let row = document.getElementById(`row${data.id}`);
        let cell = document.createElement("td");
        let fullname = data.employee_name.split(" ");
        cell.textContent = fullname[0].toLowerCase().substring(0,1) + fullname[1].toLowerCase() + "@email.com";
        row.appendChild(cell);
    }
}

function monthlySalary(){
    for(let data of employees.employeesCollection){
        let row = document.getElementById(`row${data.id}`);
        let cell = document.createElement("td");
        cell.textContent = (data.employee_salary/12).toFixed(2)+"€";
        row.appendChild(cell);
    }
}

function yearOfBirth(){
    for(let data of employees.employeesCollection){
        let row = document.getElementById(`row${data.id}`);
        let cell= document.createElement("td");
        cell.textContent = new Date().getFullYear() - data.employee_age;
        row.appendChild(cell);
    }
}

eid();
fullName();
email();
monthlySalary();
yearOfBirth();