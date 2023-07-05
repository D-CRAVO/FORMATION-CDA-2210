class Item{
    constructor(item){
        //Object.assign(this, item);
        this.id = item.id;
        this.fullname = item.employee_name;
        this.email = this.getEmail(item);
        this.monthlySalary = this.getMonthlySalary(item);
        this.yearOfBirth = this.getYearOfBirth(item);
    }

    getValues(){
        return Object.values(this);
    }

    getKeys(){
        return Object.keys(this);
    }

    getEmail(item){
        let name = item.employee_name.trim().split(' ');
        return (name[0].substring(0, 1).toLowerCase() + '.' + name[1].toLowerCase())
    }

    getMonthlySalary(item){
        return (item.employee_salary/12).toFixed(2);
    }

    getYearOfBirth(item){
        return new Date().getFullYear() - item.employee_age;
    }
}

export {Item};