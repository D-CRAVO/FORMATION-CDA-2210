import {Employees} from "./Employees.js"
 
const employees = new Employees("/json/employees.json");
await employees.getEmployees();

tbody = document.getElementById('tbody')
tfoot = document.getElementById('tfoot')

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
   for(let employee of employees.collection){
      let row = document.getElementById(`row${employee.id}`);
      let cell = document.createElement('td');
      let fullname = employee.employee_name.split(' ');
      cell.textContent = `${fullname[0].toLowerCase().substring(0,1)}.${fullname[1].toLowerCase()}`;
      row.appendChild(cell);
   }
}

function createMonthlySalary(){
   for(let employee of employees.collection){
      let row = document.getElementById(`row${employee.id}`);
      let cell = document.createElement('td');
      cell.setAttribute("id", `monthlySalary${employee.id}`)
      cell.setAttribute("class", "monthlySalary")
      cell.textContent = (employee.employee_salary / 12).toFixed(2) + "€";
      row.appendChild(cell);
   }
}

function yearOfBirth(){
   for(let employee of employees.collection){
      let row = document.getElementById(`row${employee.id}`)
      let cell = document.createElement('td');
      cell.textContent = (new Date()).getFullYear()- employee.employee_age
      row.appendChild(cell);
   }
}

function createNbEmployees(){
   let cell = document.getElementById("nbEmployees");
   cell.textContent = tbody.querySelectorAll('tr').length;
}

function createTotalSalary(){
   // let nbEmployees = parseInt((document.getElementById('nbEmployees')).textContent);
   let nbEmployees = tbody.querySelectorAll('tr').length;
   let totalSalary = 0;
   for(let i=0; i< nbEmployees; i++){
      let tr = tbody.children[i];
      let monthlySalary = Number(tr.querySelector('.monthlySalary').textContent.split("€")[0])
      totalSalary += monthlySalary;
   }
   document.getElementById('totalSalary').textContent = totalSalary.toFixed(2) + "€";
}

function createButtonDuplicate(){
   let nbRows = tbody.querySelectorAll("tr").length;
   for(let i=0; i<nbRows; i++){
      let tr = tbody.children[i];
      let buttonDuplicate = document.createElement("button");
      
      let tdId = parseInt(tr.children[0].textContent);
      buttonDuplicate.classList.add('duplicate');
      buttonDuplicate.dataset.id = tdId;
      buttonDuplicate.addEventListener('click', (event) => {
         let emp_id = event.target.dataset.id;
         employees.duplicateEmployee(emp_id);
         generateTable();
      })

      buttonDuplicate.textContent = "Duplicate";
      tr.appendChild(buttonDuplicate);
   }
}

function createButtonDelete(){
   let nbRows = tbody.querySelectorAll("tr").length;
   for(let i=0; i<nbRows; i++){
      let tr = tbody.children[i];
      let tdId = parseInt(tr.children[0].textContent);
      // console.log(tdId);
      let buttonDelete = document.createElement("button");
      // modif Mickael
      buttonDelete.classList.add('delete');
      buttonDelete.dataset.id = tdId;
      buttonDelete.addEventListener('click', (event) => {
         let emp_id = event.target.dataset.id;
         employees.removeEmployee(emp_id);
         generateTable();
      })

      buttonDelete.textContent = "Delete"
      tr.appendChild(buttonDelete);
   }
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

function duplicateRow(){

}

function deleteRow(element){
   element.remove();
}

// modif mickael
function generateTable() 
{
   tbody.innerHTML = "";
   createEid();
   createFullName();
   createEmail();
   createMonthlySalary();
   yearOfBirth();
   createButtonDuplicate();
   createButtonDelete();
   createNbEmployees();
   createTotalSalary();
}

generateTable();