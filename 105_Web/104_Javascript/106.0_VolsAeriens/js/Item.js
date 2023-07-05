class Item{
    constructor(item){
        Object.assign(this, item);
        this.duration = this.getDuration();
    }

    getValues(){
        return Object.values(this);
    }

    getDuration(){
        return new Date((this.flight_duration*60-3600)*1000).toLocaleTimeString();
    }   
}

export {Item};