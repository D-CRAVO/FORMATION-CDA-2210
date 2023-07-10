import{Db} from "./Db.js"
import{Item} from "./Item.js";

class LegumosCollection{
    constructor(){
        this.collection = [];
        this.source ="/json/legumos.json";
    }

    async getLegumosCollection(){
        let data = await Db.fetchData(this.source);
        this.collection = data;
        this.collection = this.collection.map(i=>new Item(i));
    }

    getFirst(){
        return this.collection[0];
    }
}

export {LegumosCollection};