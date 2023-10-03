package com.crm.domain;

import android.content.Context;
import android.widget.ArrayAdapter;

import com.crm.listedepersonnes.R;

import java.util.ArrayList;

public class PersonneArrayAdapter extends ArrayAdapter<Personne> {
    private ArrayList<Personne> personnes;

    public PersonneArrayAdapter(Context context, ArrayList<Personne> personnes){
        super(context, R.layout.item_particulier,personnes);
        this.personnes = personnes;
    }
}
