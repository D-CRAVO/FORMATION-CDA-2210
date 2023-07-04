class Event{
    static collection;
    static sortDirection = true;

    static columnSort(e){
        if(typeof(Event.collection[0][e.target.dataset.name]) != "string"){
            Event.collection.sortCollection();
        }
    }
}

export {Event};