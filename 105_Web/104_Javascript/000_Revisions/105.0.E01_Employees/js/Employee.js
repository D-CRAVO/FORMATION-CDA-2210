class Employee{
    constructor(employee){
        Object.assign(this, employee);
    }

    getValues(){
        return Object.values();
    }

    getKeys(){
        return Object.keys();
    }
}

export {Employee};