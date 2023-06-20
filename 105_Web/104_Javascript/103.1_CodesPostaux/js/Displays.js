class Displays{
    constructor(resultInit){
        this.result = resultInit;
        this.element = document.querySelector('#result');
    }

    //let element = document.getElementById('result');
    this.element.innerHTML = ""; // réinitialisation du contenu

    for(let city of result) {
        //element.innerHTML = "<li>"+ city.NomCommune+"</li>";

        let li = document.createElement('li'); // création d'un élément <li>
        li.innerText = city.nomCommune + " " + city.codeCommune; // ajout de contenu dans l'élément <li> créé
        element.appendChild(li); // ajout de l'élément <li> crée dans l'élément #result
    }
}