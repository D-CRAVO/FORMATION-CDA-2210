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

    DeleteCereal(cerealId){
        this.collection = this.collection.filter(cereal => cereal.id != cerealId)
    }

    CompareValues(sort, value){
        if(sort == true){
            this.collection.sort((a,b) => a.value - b.value);
            console.log(a.value);
        }else{
            this.collection.sort((a,b) => a.value - b.value).reverse();
        }
    }

    calculateAverageCalories(){
        let arrayCalories = [];
        for(let i=0; i<this.collection.length; i++){
            arrayCalories.push(this.collection[i].calories);
        } 
        let sum = arrayCalories.reduce((a,b) => a + b, 0)
        console.log(sum);
        return Math.round(sum / arrayCalories.length);
    }
}

export {Cereals};