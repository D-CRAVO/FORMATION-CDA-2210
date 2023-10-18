package com.crm.domain;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class ListPersonnes {
    /*private ArrayList<Personne> personnes;*/

    /*public ArrayList<Personne> GetPersonnes() {return personnes;}*/

    /*public ListPersonnes(ArrayList<Personne> _personnes){
        this.personnes = _personnes;
    }*/

    /*public void AddPersonne(Personne _personne){
        personnes.add(_personne);
    }*/

    public List<Personne> getListPersonnes(){
        return Arrays.asList(
                new Personne("CRAVO", "David"),
                new Personne("CRAVO", "Océane")
        );
    }

    /*private static ListPersonnes instance;
    public static ListPersonnes getInstance(){
        if (instance == null){
            instance = new ListPersonnes();
        }
        return instance;
    }*/
}
