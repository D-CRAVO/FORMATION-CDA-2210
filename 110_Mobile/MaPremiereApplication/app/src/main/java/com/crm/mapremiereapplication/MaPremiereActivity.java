package com.crm.mapremiereapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Toast;

public class MaPremiereActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_ma_premiere);
    }


    @Override
    protected void onStart(){
        super.onStart();
    }


    public void direBonjour(View v){
        Toast.makeText(this, R.string.coucou, Toast.LENGTH_LONG).show();
    }
}