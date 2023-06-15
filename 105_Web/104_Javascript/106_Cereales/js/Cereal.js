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
}

export {Cereal};