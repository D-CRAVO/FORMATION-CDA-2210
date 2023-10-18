package com.example.domain;

import android.graphics.drawable.Drawable;

public class Furby {
    private String nom;
    private String prenom;
    private Drawable image;

    public Furby(String _nom, String _prenom){
        this(_nom, _prenom, null);
    }

    public Furby(String _nom, String _prenom, Drawable _image) {
        this.nom = _nom;
        this.prenom = _prenom;
        this.image = _image;
    }

    public Furby(Furby _from){
        this(_from.nom, _from.prenom, _from.image);
    }

    public Furby clone(){
        return new Furby(this);
    }

    public String getNom(){ return this.nom; }
    public String getPrenom() { return this.prenom;}
    public Drawable getImage() { return this.image; }


}
