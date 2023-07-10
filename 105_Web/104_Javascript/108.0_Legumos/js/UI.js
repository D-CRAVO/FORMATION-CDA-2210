class UI{
    constructor(_collection){
        this.collection = _collection;
        this.keys = [];
        this.vegetable = this.collection.getFirst();
        this.tbody = document.getElementById("tbody");
        this.thead = document.getElementById("thead");
    }

    generateThead(){
        let row = this.generateRowThead();
        this.thead.appendChild(row);
    }

    generateRowThead(){
        let row = document.createElement("tr");
        for(let key of this.vegetable.getKeys()){
            let cell = this.generateCellThead(key);
            row.appendChild(cell);
        }
        return row;
    }

    generateCellThead(key){
        let cell = document.createElement("th");
        cell.dataset.name = key;
        cell.classList.add(key);
        cell.textContent = key;
        return cell;
    }

    generateTable(){
        this.tbody.innerHTML = "";
        for(let item of this.collection.collection){
            let row = this.generateRow(item);
            row.dataset.id = `row${item.Id}`;
            this.tbody.appendChild(row);
        }
    }

    generateRow(item){
        let row = document.createElement("tr");
        for(let value of item.getValue()){
            let cell = this.generateCell(value);
            row.appendChild(cell);
        }
        return row;
    }

    generateCell(value){
        let cell = document.createElement("td");
        cell.textContent = value;
        let head = document.querySelectorAll("th");
        console.log(head);
        return cell;
    }
} 

export {UI};