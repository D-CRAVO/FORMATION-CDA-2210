class Item{
    constructor(item){
        Object.assign(this, item);
        this.duration = this.calculateDuration();
    }

    getValues(){
        return Object.values(this);
    }

    calculateDuration(){

        let hours = Math.floor(this.flight_duration/60)
        let minutes = this.flight_duration%60
        let time = `${hours}:${minutes}:00`;
        return time;

        //return new Date((this.flight_duration*60-3600)*1000).toLocaleTimeString();
    }   
}

export {Item};