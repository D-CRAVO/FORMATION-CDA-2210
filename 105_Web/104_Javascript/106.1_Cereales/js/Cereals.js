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
        console.log(value)
        this.collection.sort((a,b) => a[value] - b[value]);

        if(sort === false){
            this.collection.reverse();
            console.log(a[value]);
        }
    }

    calculateAverageCalories(){
        let arrayCalories = [];
        for(let i=0; i<this.collection.length; i++){
            arrayCalories.push(this.collection[i].calories);
        } 
        let sum = arrayCalories.reduce((a,b) => a + b, 0)
        //console.log(sum);
        return Math.floor(sum / arrayCalories.length);
    }

    search(value){
       
        // let research = this.collection.find(cereal => (cereal.name).toLowerCase() == value);
        let research = this.collection.find(cereal => cereal.name.includes(value));
        console.log(research);
        if(research != null){
            this.collection = [];
            this.collection.push(research);
        }else{
            
            this.getCereals();
        }
    }
}

export {Cereals};