package com.crm.listedepersonnes;

import static java.security.AccessController.getContext;

import androidx.appcompat.app.AppCompatActivity;
import java.util.*;

import android.content.Context;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.ListAdapter;
import android.widget.ListView;
import android.widget.TextView;
import android.view.View;

import com.crm.domain.Personne;
import com.crm.domain.PersonneArrayAdapter;

public class MainActivity extends AppCompatActivity {
    private String[] tableau = new String[]{"membre1", "membre2", "membre3", "membre4", "membre5"};
    private ArrayList<Personne> personnes;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        ListView lv = (ListView)findViewById(R.id.listViewPersonne);
        /*ArrayAdapter arrayadp = new ArrayAdapter(this, android.R.layout.simple_list_item_1, this.tableau);
        lv.setAdapter(arrayadp);*/
        personnes =  new ArrayList<Personne>();
        Personne personne = new Personne("CRAVO", "David");
        personnes.add(personne);
        PersonneArrayAdapter array = new PersonneArrayAdapter(this,personnes);
        lv.setAdapter(array);
    }

    @override
    public View getView(int i, View view, ViewGroup viewGroup){
        View v = view;
        if (v==null){
            LayoutInflater inflater = (LayoutInflater) getContext().getSystemService(Context.LAYOUT_INFLATER_SERVICE);
            v = inflater.inflate(R.layout.item_particulier, null);
        }

        Personne personneOfItem = (Personne) getListPersonnes().get(i);
        if (personneOfItem != null){
            TextView nomView = (TextView) v.findViewById(R.id.textViewNom);
            TextView prenomView = (TextView)  v.findViewById(R.id.textViewPrenom);
            ImageView photoView = (ImageView) v.findViewById(R.id.imageViewPhoto);
            if(nomView != null){
                nomView.setText(("Name:" + personneOfItem.getNom()));
            }
        }
    }

}