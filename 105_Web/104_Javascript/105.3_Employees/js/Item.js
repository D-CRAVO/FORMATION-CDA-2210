class Item{
    constructor(item){
        //Object.assign(this, item);
        this.id = item.id;
        this.fullname = item.employee_name;
        this.email = this.getEmail(item);
    }

    getValues(){
        return Object.values(this);
    }

    getKeys(){
        return Object.keys(this);
    }

    getEmail(employee){
        let name = employee.employee_name.split(' ');
        return (name[0].substring(0, 1).toLowerCase() + '.' + name[1].toLowerCase())
    }
}

export {Item};