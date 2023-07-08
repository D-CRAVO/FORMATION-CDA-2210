<<<<<<<< HEAD:105_Web/104_Javascript/001_DossierVierge/js/UI.js
class UI{
========
class Ui{
>>>>>>>> 8f4747a6c2442ac521131ccaea65779f7632ce38:105_Web/104_Javascript/001_DossierVierge/js/Ui.js
    constructor(_collection){
        this.collection = _collection;
        this.tbody = document.getElementById("tbody");
    }

    generateTable(){
        this.tbody.innerHTML = ""
        for(let item of this.collection.collection){
            let row = this.generateRow(item);
            this.tbody.appendChild(row);
        }
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
}

<<<<<<<< HEAD:105_Web/104_Javascript/001_DossierVierge/js/UI.js
export {UI}
========
export {Ui}
>>>>>>>> 8f4747a6c2442ac521131ccaea65779f7632ce38:105_Web/104_Javascript/001_DossierVierge/js/Ui.js
