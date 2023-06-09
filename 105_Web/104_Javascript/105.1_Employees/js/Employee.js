class Employee{
    constructor(employee){
        Object.assign(this, employee);
    }

    getValues(){
        Object.values(this);
    }

    getKeys(){
        Object.keys(this);
    }
}

export {Employee};