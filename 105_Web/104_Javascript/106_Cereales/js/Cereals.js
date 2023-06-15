import {Cereal} from "./Cereal.js";

class Cereals{
    constructor(url){
        this.source = url;
        this.collection = [];
    }

    async getCereals(){
        let response = await fetch(this.source);
        let json = await response.json();
        for(let cereal of json.data){
            this.collection.push(new Cereal(cereal));
        }
        console.log(this.collection);
    }

    getFirst(){
        try {
            return this.collection[0];
        } catch (error) {
            alert("La collection est vide !");
        }
    }
}

export {Cereals};