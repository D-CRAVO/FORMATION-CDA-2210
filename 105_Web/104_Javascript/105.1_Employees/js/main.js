import {Employee} from "./Employee.js";
import {Employees} from "./Employees.js";

const employees = new Employees ("/json/employees.json");
await employees.getEmployees();

const tbody = document.getElementById("tbody");
const buttonSort = document.getElementById('sortMonthlySalary');

let sort = true;

console.log(employees.collection);

function createTable(){
    tbody.innerHTML = "";
    for(let emp of employees.collection){

        let employee = new Employee(emp);

        let row = document.createElement('tr');
        row.dataset.id = `row${employee.id}`;
        tbody.appendChild(row);
        createId(employee, row);
        createFullName(employee, row);
        createEmail(employee, row);
        createMonthlySalary(employee, row);
        createYearOfBirth(employee, row);
        createNbEmployees();
        createTotalSalary();
        createButtonDuplicate(employee, row);
        createButtonDelete(employee, row);
        
    }   
}

buttonSort.addEventListener('click', ()=>{
    employees.compareSalaries(sort);
        createTable();
        sort = !sort;
    });
    

function createCell(row){
    let cell = document.createElement('td');
    row.appendChild(cell);
    return cell;
}

function createId(employee, row){
    createCell(row).textContent = employee.id;
}

function createFullName(employee, row){
    createCell(row).textContent = employee.employee_name;
}

function createEmail(employee, row){
    createCell(row).textContent = employee.calculateEmail();
}

function createMonthlySalary(employee, row){
    createCell(row).textContent = employee.calculateMonthlySalary() + "€";
}

function createYearOfBirth(employee, row){
    createCell(row).textContent = employee.calculateYearOfBirth()
}

function createNbEmployees(){
    document.getElementById('nbEmployees').textContent = employees.calculateNbEmployees();
}

function createTotalSalary(){
    document.getElementById('totalSalary').textContent = employees.calculateTotalSalary() + "€"
}

function createButtonDuplicate(employee, row){
    let buttonDuplicate = createButton(row, employee, "duplicate", "Duplicate");
    buttonDuplicate.classList.add('btn');
    buttonDuplicate.classList.add('btn-primary');
    buttonDuplicate.addEventListener('click', (event) => {
        let employeeId = event.target.dataset.id;
        employees.duplicateEmployee(employeeId);
        createTable();
    })
}

function createButtonDelete(employee, row){
    let buttonDelete = createButton(row, employee, "delete", "Delete");
    buttonDelete.classList.add('btn');
    buttonDelete.classList.add('btn-danger');
    buttonDelete.addEventListener('click', (event) => {
        let employeeId = event.target.dataset.id;
        employees.deleteEmployee(employeeId);
        console.log(employeeId);
        createTable();
    })
}

function createButton(row, employee, buttonClass, buttonValue){
    let button = document.createElement("button");
    button.dataset.id = `button${buttonValue}${employee.id}`;
    button.dataset.id = employee.id;
    button.textContent = buttonValue;
    button.classList.add(buttonClass);
    row.appendChild(button);
    return button
}

function essai(){
    let value = 3
    let arr = [1, 2, 3, 4, 5, 3]
    arr = arr.filter(item => item !== value)
    console.log(arr)
}

createTable();
essai();
//sortMonthlySalary();