package com.crm.domain;

import android.content.Context;
import android.util.DisplayMetrics;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import com.crm.listedepersonnes.R;

import java.util.ArrayList;

public class PersonneArrayAdapter extends ArrayAdapter<Personne> {
    private ListPersonnes personnes;

    public PersonneArrayAdapter(Context context, ListPersonnes personnes){
        super(context, R.layout.item_particulier,personnes);
        this.personnes = personnes;
    }

    public View getView(int i, View view, ViewGroup viewGroup){
        View v = view;
        if (v==null){
            LayoutInflater inflater = (LayoutInflater) getContext().getSystemService(Context.LAYOUT_INFLATER_SERVICE);
            v = inflater.inflate(R.layout.item_particulier, null);
        }

        Personne personneOfItem = (Personne) personnes.get(i);
        if (personneOfItem != null){
            TextView nomView = (TextView) v.findViewById(R.id.textViewNom);
            TextView prenomView = (TextView)  v.findViewById(R.id.textViewPrenom);
            ImageView photoView = (ImageView) v.findViewById(R.id.imageViewPhoto);
            if(nomView != null){
                nomView.setText(("Name: " + personneOfItem.getNom()));
            }
            if(prenomView != null){
                prenomView.setText("Prenom: " + personneOfItem.getPrenom());
            }
            if(photoView != null){
                if (personneOfItem.getPhoto()!=null){
                    photoView.setImageDrawable(personneOfItem.getPhoto());
                }
                else{
                    photoView.setImageDrawable(v.getResources().getDrawableForDensity(R.drawable.emoji, DisplayMetrics.DENSITY_XHIGH));
                }
            }
        }
        return v;
    }
}
