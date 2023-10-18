package com.example.furbylist;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;

import com.example.domain.Furby;

import java.util.ArrayList;

public class FurbyAdapter extends ArrayAdapter<Furby> {

    private ArrayList<Furby> furbys;
    public FurbyAdapter(@NonNull Context _context, ArrayList<Furby> _furbys) {
        super(_context, R.layout.layout_listview_item_furby, _furbys);
        this.furbys = _furbys;
    }

    @Override
    public View getView(int i, View view, ViewGroup vg){
        LayoutInflater inflater = (LayoutInflater) getContext().getSystemService(Context.LAYOUT_INFLATER_SERVICE);
        View v = inflater.inflate(R.layout.layout_listview_item_furby, null);

        TextView textViewNom = v.findViewById(R.id.layout_listview_item_furby_textViewNom);
        TextView textViewPrenom = v.findViewById(R.id.layout_listview_item_furby_textViewPrenom);
        ImageView photoView = v.findViewById(R.id.layout_listview_item_furby_imageView);

        Furby currentFurby = furbys.get(i);

        if (textViewNom != null){
            textViewNom.setText(currentFurby.getNom());
        }

        if (textViewPrenom != null){
            textViewPrenom.setText(currentFurby.getPrenom());
        }

        if (photoView != null){
            if (currentFurby.getImage() != null){
                photoView.setImageDrawable(currentFurby.getImage());
            } else {
                // ICI MA RESSOURCE PAR DEFAUT
                photoView.setImageDrawable(v.getResources().getDrawable(R.drawable.img));
            }
        }

        return v;
    }
}
