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

    calculateEmail(){
        let fullName = this.employee_name.split(" ");
        return `${fullName[0].toLowerCase().substring(0,1)}.${fullName[1].toLowerCase()}`
    }

    calculateMonthlySalary(){
        return (this.employee_salary/12).toFixed(2);
    }

    calculateYearOfBirth(){
        return new Date().getFullYear() - this.employee_age;
    }
}

export {Employee};