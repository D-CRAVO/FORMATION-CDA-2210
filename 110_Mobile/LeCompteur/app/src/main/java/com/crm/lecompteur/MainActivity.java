package com.crm.lecompteur;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    TextView textView;
    @SuppressLint("MissingInflatedId")
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        textView = (TextView)findViewById(R.id.compteur);
    }

    public void incrementer(){
        int t = Integer.parseInt(String.valueOf(textView));
        t++;
    t.
    }

    protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Button inc = (Button) findViewById(R.id.inc);
        inc.setOnClickListener(new OnClickListener());

        public void onClick(View v) {
            EditText mValue = (EditText) findViewById(R.id.compteur);
            int val=Integer.parseInt(mValue.getText().toString());
            --val;
            mValue.setText(Integer.toString(val));
        }
    }
}