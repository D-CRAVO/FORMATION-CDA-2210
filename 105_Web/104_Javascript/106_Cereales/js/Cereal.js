class Cereal{
    constructor(cereal){
        Object.assign(this, cereal);
    }

    getValues(){
        return Object.values(this);
    }

    getKeys(){
        return Object.keys(this);
    }

    CalculateNutriScore(){
        let data = this.rating
        let result = ""
        if(data >= 80){
            result = 'a';
        }else if (data>=70){
            result = 'b';
        }else if(data>=55){
            result = 'c';
        }else if(data>=35){
            result = 'd';
        }else{
            result = 'e';
        }
        return result;


    }

    
}

export {Cereal};