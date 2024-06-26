class Event{
    static collection;
    static sortDirection = true; 

    static columnSort(e){
        Event.collection.sortCollection(e.target.dataset.name, Event.sortDirection);
        Event.sortDirection = !Event.sortDirection;
    }

    static sortPlaneRef(e){
        //console.log(e);
        //console.log(e.target.dataset.name);
        Event.collection.sortRef(e.target.dataset.name, Event.sortDirection);
        Event.sortDirection = !Event.sortDirection;
    }

    static search(e){
        Event.collection.searchCollection(e.target.value);
    }
}

export {Event}