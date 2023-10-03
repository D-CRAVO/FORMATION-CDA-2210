package com.crm.domain;

public class Personne {
    private String nom;
    private String prenom;

    public String getNom(){
        return nom;
    }
    public Personne(String _nom, String _prenom){
        this.nom = _nom;
        this.prenom = _prenom;
    }
}
