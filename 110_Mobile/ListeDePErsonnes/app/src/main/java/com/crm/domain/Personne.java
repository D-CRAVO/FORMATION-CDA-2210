package com.crm.domain;

import android.graphics.drawable.Drawable;

public class Personne {
    private String nom;
    private String prenom;
    private Drawable photo;

    public String getNom(){
        return nom;
    }
    public String getPrenom(){return prenom;}
    public Drawable getPhoto(){return photo;}
    public Personne(String _nom, String _prenom){
        this.nom = _nom;
        this.prenom = _prenom;
        //this.photo = _photo;
    }
}
