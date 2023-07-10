class Item{
    constructor(item){
        this.name = item.Name;
        this.variety = item.Variety;
        this.primaryColor = item.PrimaryColor;
        this.lifeTime = item.LifeTime;
        this.fresh = this.determinateFresh(item);
    }

    getValue(){
        return Object.values(this);
    }

    getKeys(){
        return Object.keys(this);
    }

    determinateFresh(item){
        if(item.Fresh == 1){
            return "oui"
        }
        return "non"
    }
}

export {Item};