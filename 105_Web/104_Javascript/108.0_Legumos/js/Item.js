class Item{
    constructor(item){
        Object.assign(this, item);
    }

    getValue(){
        return Object.values(this);
    }

    getKeys(){
        return Object.keys(this);
    }
}

export {Item};