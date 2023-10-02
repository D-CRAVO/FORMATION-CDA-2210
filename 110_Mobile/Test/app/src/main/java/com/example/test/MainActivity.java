package com.example.test;

import android.content.res.Configuration;
import android.os.Bundle;

import com.google.android.material.snackbar.Snackbar;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

import androidx.core.view.WindowCompat;
import androidx.navigation.NavController;
import androidx.navigation.Navigation;
import androidx.navigation.ui.AppBarConfiguration;
import androidx.navigation.ui.NavigationUI;

import com.example.test.databinding.ActivityMainBinding;

public class MainActivity extends AppCompatActivity {

    private EditText edt;
    private int value;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        if (this.getResources().getConfiguration().orientation == Configuration.ORIENTATION_LANDSCAPE){
            setContentView(R.layout.activity_main_landscape);
        } else {
            setContentView(R.layout.activity_main);
        }
        edt = (EditText) findViewById(R.id.mainlyt_edittext);
        if (savedInstanceState != null){
            value = savedInstanceState.getInt("value");
        }
        Toast.makeText(this,String.valueOf(value),Toast.LENGTH_LONG).show();
        changeText();
    }

    private void changeText(){
        edt.setText(String.valueOf(value));
    }

    public void decrementerCompteur(View v){
       value--;
       changeText();
    }

    public void incrementerCompteur(View v){
        value++;
        changeText();
    }

    @Override
    protected void onSaveInstanceState(@NonNull Bundle outState) {
        super.onSaveInstanceState(outState);
        outState.putInt("value",value);

    }

}