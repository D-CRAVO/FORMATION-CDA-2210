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
        cell.setAttribute("id", `monthlySalary${data.id}`);
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

function nbEmployees(){
    let cell = document.getElementById("nbEmployees");
    cell.textContent = tbody.querySelectorAll("tr").length;
}

/* function totalSalary(){
    let totalSalary = 0;
    let cell = document.getElementById("totalSalary");
    const rowLength = tbody.querySelectorAll("tr").length;
    console.log("tbody " + tbody)
    console.log("rowLength " + rowLength);
    let monthlySalaryTotal = 0;
    for(let i=1; i<=rowLength; i++){
        //let monthlySalary = document.querySelector('#monthlySalary' + i);
        let monthlySalary = document.getElementById(`monthlySalary${i}`);
        //if (monthlySalary != null){
            monthlySalaryTotal+= Number(monthlySalary.innerText.split('€')[0]);
        //}
            
        
        //totalSalary = totalSalary + 
    }
    console.log(monthlySalaryTotal);
} */

function totalSalary(){
    let totalSalary = 0;
    let cell = document.getElementById("totalSalary");
    const rowLength = tbody.querySelectorAll("tr").length;
    console.log("tbody " + tbody)
    console.log("rowLength " + rowLength);
    let monthlySalaryTotal = 0;
    for(let i=1; i<=rowLength; i++){
        //let monthlySalary = document.querySelector('#monthlySalary' + i);
        let monthlySalary = document.getElementById(`monthlySalary${i}`);
        //if (monthlySalary != null){
            monthlySalaryTotal+= Number(monthlySalary.innerText.split('€')[0]);
        //}
            
        
        //totalSalary = totalSalary + 
    }
    console.log(monthlySalaryTotal);
}

eid();
fullName();
email();
monthlySalary();
yearOfBirth();
nbEmployees();
totalSalary();
