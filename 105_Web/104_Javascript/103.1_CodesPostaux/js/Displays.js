class Displays{
    constructor(resultInit){
        this.result = resultInit;
        this.element = document.querySelector('#result');
    }

    displayResult(){
        this.element.innerHTML = ""; 
        for(let city of this.result) {
            let li = this.generateElement(this.element, 'li'); 
            li.innerText = city.nomCommune + " " + city.codeCommune;
        }
    }

    generateElement(parent, element){
        let balise = document.createElement(element);
        parent.appendChild(balise);
        return balise
    }
}

export { Displays };