package com.crm.domain;

import java.util.ArrayList;

public class ListPersonnes {
    private ArrayList<Personne> personnes;

    public ArrayList<Personne> GetPersonnes() {return personnes;}

    public ListPersonnes(ArrayList<Personne> _personnes){
        this.personnes = _personnes;
    }

    public void AddPersonne(Personne _personne){
        personnes.add(_personne);
    }
}
