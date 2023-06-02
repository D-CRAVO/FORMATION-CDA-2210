
let zipcodeInput = document.getElementById('zipcode');
console.log(zipcodeInput);

zipcodeInput.addEventListener('keyup', (event)=>{
    let reg = new RegExp('^[0-9]{5}$');
    let value = event.target.value;

    if(reg.test(value)){
        console.log(value)
    }
})

class ZipCode{
    constructor(){
        this.datasource = "/zipcodes.json";
        this.zipcodes = [];
    }


    async load(){
        try{
            let response = await fetch(this.datasource);
            this.zipcodes = await response.json();
            console.log(this.zipcodes);
        }
        catch(error){

        }
    }

    search(zipcode){

    }
}

const zipcodes = new ZipCode();
zipcodes.load();