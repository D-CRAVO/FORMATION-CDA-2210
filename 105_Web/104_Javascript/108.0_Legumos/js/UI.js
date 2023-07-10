class UI{
    constructor(_collection){
        this.collection = _collection;
        this.key;
        this.vegetable = this.collection.getFirst();
        this.tbody = document.getElementById("tbody");
        this.thead = document.getElementById("thead");
    }

    generateThead(){
        console.log(this.vegetable.getKeys())
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
        cell.dataset.name = key
        cell.textContent = key;
        return cell;
    }

    generateTable(){
        this.tbody.innerHTML = "";
        for(let item of this.collection.collection){
            let row = this.generateRow(item);
            this.tbody.appendChild(row);
            //console.log(item.Name)
            // let row = this.generateRow(item.Name);
            // this.tbody.appendChild(row);
            // console.log(item.Name)
        }
    }

    generateRow(item){
        let row = document.createElement("tr");
        for(let value of item.getValue()){
            let cell = this.generateCell(value);
            row.appendChild(cell);
        }
        // let cell = document.createElement("td");
        // console.log(item)
        // cell.textContent = item;
        // row.appendChild(cell)
        return row;
    }

    generateCell(value){
        let cell = document.createElement("td");
        cell.textContent = value; 
        return cell;
    }
} 

export {UI};