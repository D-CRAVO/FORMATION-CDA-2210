class Event{
    static collection;
    static sortDirection = true; 

    static columnSort(e){
        Event.collection.sortCollection(e.target.dataset[name], Event.sortDirection);
        Event.sortDirection = !Event.sortDirection;
    }

    static searchItem(value){
        Event.collection.searchItem(value);
    }

    static test(value){
        //console.log(value);
    }
}

export {Event}