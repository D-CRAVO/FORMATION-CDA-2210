package com.crm.listedepersonnes;

import androidx.appcompat.app.AppCompatActivity;
import java.util.*;

import android.os.Bundle;
import android.widget.ArrayAdapter;

public class MainActivity extends AppCompatActivity {

    String[] tab = new String[]{"membre1", "membre2", "membre3", "membre4", "membre5"};
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        ArrayAdapter arrayadp = new ArrayAdapter(this, android.R.layout.simple_list_item_1, tab);

    }

/*

*/
}