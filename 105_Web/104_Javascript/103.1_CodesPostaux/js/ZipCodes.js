import {Db} from "./Db.js"

class ZipCodes 
{
    // constructeur Javascript
    constructor()
    {
        this.datasource = "/json/zipcodes.json";
        this.collection = [];
    }

    async getZipCodes() {
        let zipCodes = await Db.fetchData(this.datasource);
        for(let zipCode of zipCodes){
            this.collection.push(zipCode);
        }
        return this.collection;
    }


    /** 
     * Recherche des éléments dans la collection this.zipcodes
     * https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/filter
     * @param {int|string} zipcode le code postal ou nom de ville à rechercher
     */
    search(zipcode)
    {
        let result = [];

        result = this.collection.filter(city => city.codePostal == zipcode);
        console.log(result);
        return result;
    }
}

export { ZipCodes }