package com.example.furbylist;

import androidx.appcompat.app.AppCompatActivity;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.CheckBox;
import android.widget.EditText;

public class AddFurbyActivity extends AppCompatActivity {

    private EditText editNom;
    private EditText editPrenom;
    private CheckBox checkboxAlternatif;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add_furby);
        editNom = findViewById(R.id.activity_add_furby_editTextNom);
        editPrenom = findViewById(R.id.activity_add_furby_editTextPrenom);
        checkboxAlternatif = findViewById(R.id.activity_add_furby_checkboxAlternative);
    }

    public void envoiInfo(View v){
        Intent intent = getIntent();
        intent.putExtra("furbyNom", editNom.getText().toString());
        intent.putExtra("furbyPrenom", editPrenom.getText().toString());
        intent.putExtra("furbyAlternatif", checkboxAlternatif.isChecked());
        setResult(Activity.RESULT_OK, intent);
        this.finish();
    }
}