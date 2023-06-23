console.log('toto');

const pokemon = require ('pokemon');
// import pokemon from 'pokemon';

// console.log(pokemon.all());

const collection = pokemon.all('fr');

for(let pok of collection){
    console.log(pok);
}