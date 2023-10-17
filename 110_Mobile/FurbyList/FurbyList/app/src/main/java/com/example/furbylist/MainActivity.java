package com.example.furbylist;

import androidx.appcompat.app.AppCompatActivity;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.ContextMenu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ListView;

import com.example.domain.Furby;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    private  ArrayList<Furby> furbys;
    private ListView listView;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        listView = findViewById(R.id.activity_main_listView);
        furbys = new ArrayList<Furby>();
        furbys.add(new Furby("CRAVO", "David"));
        furbys.add(new Furby("BOUNATIROU", "Rodolphe"));
        furbys.add(new Furby("ROGNONE", "Gerard", getResources().getDrawable(R.drawable.img2)));
        listView.setAdapter(new FurbyAdapter(this, furbys));
        registerForContextMenu(listView);
    }

    @Override
    public void onCreateContextMenu(ContextMenu cm, View v, ContextMenu.ContextMenuInfo cmi){
        super.onCreateContextMenu(cm, v, cmi);
        MenuInflater inflater = getMenuInflater();
        inflater.inflate(R.menu.menu_listview, cm);
    }

    @Override
    public boolean onContextItemSelected(MenuItem mi){
        AdapterView.AdapterContextMenuInfo menuInfo = (AdapterView.AdapterContextMenuInfo) mi.getMenuInfo();
        FurbyAdapter furbyAdapter = (FurbyAdapter) listView.getAdapter();
        Furby itemSelect = furbyAdapter.getItem(menuInfo.position);
        if (mi.getItemId() == R.id.copie_furby){
            // ON COPIE L'ELEMENT
            ajouterUnFurby(itemSelect.clone());
        } else if (mi.getItemId() == R.id.delete_Furby){
            furbyAdapter.remove(itemSelect);
            furbyAdapter.notifyDataSetChanged();
        }
        return false;
    }


    public void ajouterUnFurby(Furby f){
        furbys.add(f);
        FurbyAdapter furbyAdapter = (FurbyAdapter) listView.getAdapter();
        furbyAdapter.notifyDataSetChanged();

    }

    public void demanderActiviteAjout(View v){
        Intent intent = new Intent(this, com.example.furbylist.AddFurbyActivity.class);
        startActivityForResult(intent, 1);
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data){
        super.onActivityResult(requestCode, resultCode, data);
        if (resultCode == Activity.RESULT_OK && requestCode == 1){
            String strNom, strPrenom;
            boolean alternatif;
            strNom = data.getStringExtra("furbyNom");
            strPrenom = data.getStringExtra("furbyPrenom");
            alternatif = data.getBooleanExtra("furbyAlternatif", false);
            Furby f = new Furby(strNom, strPrenom, alternatif ? getResources().getDrawable(R.drawable.img2) : null);
            ajouterUnFurby(f);
        }
    }

}