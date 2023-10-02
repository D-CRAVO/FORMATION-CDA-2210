package com.crm.lecompteur;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    private int value;
    private TextView textView;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        textView=(TextView)findViewById(R.id.compteur);
        value=savedInstanceState.getInt("value");
    }

    public void incrementer(View v){
        value++;
        changeText();
    }

    public void decrementer(){
        value--;
        changeText();
    }

    private void changeText(){
        textView.setText(String.valueOf(value));
    }

    @Override
    protected void onSaveInstanceState(@NonNull Bundle outState){
        super.onSaveInstanceState(outState);
        outState.putInt("value", value);
    }
}