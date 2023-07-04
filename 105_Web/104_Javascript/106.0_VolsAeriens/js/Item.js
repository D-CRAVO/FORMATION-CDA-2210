class Item{
    constructor(item){
        Object.assign(this, item);
    }

    getValues(){
        return Object.values(this);
    }
}

export {Item};