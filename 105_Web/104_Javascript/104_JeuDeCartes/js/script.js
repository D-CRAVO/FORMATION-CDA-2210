class CardGame{
    constructor(){
        this.datasource = "/cardgame.json";
        this.cardgames = [];
    }

    async load(){
        try{
            let response = await fetch(this.datasource);
            this.cardgames = await response.json();
            console.log(this.cardgames);
            creerTBody(this.cardgames);
            creerTHead(this.cardgames, document.getElementById("table"));
            maxAttaque(this.cardgames, document.getElementById("tableMaxAttack"));
        }
        catch(error){

        }
    }
}

const cardgames = new CardGame();
cardgames.load();


const tab = document.getElementById("table")

function creerTBody(data)
{
    let tBody = tab.createTBody();
    for(let i=0; i<data.length; i++){
        let newRow = tBody.insertRow(i);
        for(let key in data[i]){
            let newCell = newRow.insertCell();
            newCell.textContent = data[i][key];
        }
    }
}

function creerTHead(data, tab)
{
    let tHead = tab.createTHead();
    let newRow = tHead.insertRow();
    newRow.setAttribute("id", "newRow");
    for(const key in data[0]){
        let newCell = document.createElement("th");
        newCell.textContent = key;
        document.getElementById("newRow").appendChild(newCell);
    }
}

function maxAttaque(data, tab)
{
    creerTHead(data, tab);
    let maxAttack = data[0].attack;
    let maxKey = 0
    console.log(maxAttack);
    for(let i=1; i<data.length; i++){
        if(data[i].attack > maxAttack){
            maxAttack = data[i].attack;
            maxKey = i;
        }
    }
    console.log(maxAttack);
    console.log(data[maxKey]);

}

function insert

/* fetch("/cardgame.json")
.then(function(response){
    return response.json()
})
.then(cardgames =>{
    console.log(cardgames);
    creerTBody(cardgames);
})
 */
