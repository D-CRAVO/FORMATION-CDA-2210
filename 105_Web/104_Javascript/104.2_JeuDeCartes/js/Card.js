class Card{
    constructor(card){
        Object.assign(this, card);
    }

    getValues(){
        return Object.values(this);
    }

    getKeys(){
        return Object.keys(this);
    }
}

export {Card};