import React from 'react';
import Image from 'next/image';

export default class PokemonListe extends React.Component
{
    render()
    {
        return (
            <div>
                <h1>Liste des Pokemons</h1>
                <Image src="/images/Pikachu.png" width={1425} height={1775} alt="Pikachu"></Image>
            </div>
        );
    }
}



// export default function PokemonListe(){
//     return (
//         <h1>Liste des Pokemons</h1>
//     );
// }