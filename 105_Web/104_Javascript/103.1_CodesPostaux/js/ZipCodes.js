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

        /*for(let city of this.zipcodes) {
            if(city.codePostal == zipcode) {
                result.push(city);
                console.log(result);
            }
        }*/

        // la ligne suivante effectue le même traitement que le for ci-dessus
        result = this.collection.filter(city => city.codePostal == zipcode);
        
        console.log(result);

        this.fillUi(result);


    }

    fillUi(result) 
    {
        //let element = document.getElementById('result');
        let element = document.querySelector('#result');
        element.innerHTML = ""; // réinitialisation du contenu

        for(let city of result) {
            //element.innerHTML = "<li>"+ city.NomCommune+"</li>";

            let li = document.createElement('li'); // création d'un élément <li>
            li.innerText = city.nomCommune + " " + city.codeCommune; // ajout de contenu dans l'élément <li> créé
            element.appendChild(li); // ajout de l'élément <li> crée dans l'élément #result
        }

    }


}

export { ZipCodes }