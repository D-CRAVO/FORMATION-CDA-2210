 import {Employees} from "./Employees.js"
 
 const employees = new Employees("/json/employees.json");
 await employees.getEmployees();

 tbody = document.getElementById('tbody')

 function createEid(){
    for(let employee of employees.collection){
        let row = document.createElement('tr');
        row.setAttribute('id', `row${employee.id}`)
        let cell = document.createElement('td');
        row.appendChild(cell);
        tbody.appendChild(row);
        cell.textContent = employee.id;
    }
 }

 function createFullName(){
    for(let employee of employees.collection){
        let row = document.getElementById(`row${employee.id}`);
        let cell = document.createElement('td');
        cell.textContent = employee.employee_name;
        row.appendChild(cell);
    }
 }

 function createEmail(){
    for(let employee)
 }

 function createRowCell(data){
    let row = document.createElement('tr');
    let cell = document.createElement('td');
    row.appendChild(cell);
    tbody.appendChild(row);
    cell.textContent = data;
 }

 function createCell(data){
    let cell = document.createElement('td');
    row.appendChild(cell);
    cell.textContent = data;
 }

 createEid();
 createFullName();
