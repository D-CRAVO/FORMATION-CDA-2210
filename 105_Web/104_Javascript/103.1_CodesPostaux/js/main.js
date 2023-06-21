import { ZipCodes } from './ZipCodes.js';
import { Displays } from './Displays.js';

let zipcodeInput = document.getElementById('zipcode');

const zipCodes = new ZipCodes();
await zipCodes.getZipCodes();
console.log(zipCodes.collection)

zipcodeInput.addEventListener('keyup', (event) => {
    var reg = new RegExp('^[0-9]{5}$');
    // event.target = élément qui a déclenché l'évènement 
    let value = event.target.value; 

    if(reg.test(value)) {
        let result = zipCodes.search(value);
        let display = new Displays(result);
        display.displayResult();
    }
});