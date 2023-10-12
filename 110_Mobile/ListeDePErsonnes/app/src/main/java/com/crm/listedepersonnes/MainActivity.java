package com.crm.listedepersonnes;

import static java.security.AccessController.getContext;

import androidx.appcompat.app.AppCompatActivity;
import java.util.*;

import android.content.Context;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.util.DisplayMetrics;
import android.view.LayoutInflater;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.TextView;
import android.view.View;

import com.crm.domain.ListPersonnes;
import com.crm.domain.Personne;
import com.crm.domain.PersonneArrayAdapter;

import org.xml.sax.helpers.ParserAdapter;

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
        Personne personne1 = new Personne("CRAVO", "David");
        personnes.add(personne1);
        Personne personne2 = new Personne("CRAVO", "Océane");
        personnes.add(personne2);
        PersonneArrayAdapter array = new PersonneArrayAdapter(this,personnes);
        lv.setAdapter(array);
    }
/*

*/
}