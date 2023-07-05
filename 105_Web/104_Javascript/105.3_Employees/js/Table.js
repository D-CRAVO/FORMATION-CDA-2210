import {Collection} from "./Collection.js"

class Table{
    constructor(_collection){
        this.collection = _collection;
        this.tbody = document.getElementById("tbody");
        this.nbEmployees = document.getElementById("nbEmployees");
        this.totalSalary = document.getElementById("totalSalary");
    }

    generateTable(){
        this.tbody.innerHTML = ""
        for(let item of this.collection.collection){
            let row = this.generateRow(item);
            this.tbody.appendChild(row);
        }
        this.generateNbEmployees();
        this.generateTotalSalary()
    }

    generateRow(item){
        let row = document.createElement("tr");
        for(let value of item.getValues()){
            let cell = this.generateCell(value);
            row.appendChild(cell);
        }
        return row;
    }

    generateCell(value){
        let cell = document.createElement("td");
        cell.textContent = value;
        return cell;
    }

    generateNbEmployees(){
        this.nbEmployees.textContent = this.collection.calculateNbEmployees();
    }

    generateTotalSalary(){
        this.totalSalary.textContent = this.collection.calculateTotalSalary();
    }
}

export {Table}