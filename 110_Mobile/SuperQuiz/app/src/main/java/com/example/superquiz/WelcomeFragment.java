package com.example.superquiz;

import android.os.Bundle;

import androidx.fragment.app.Fragment;

import android.text.Editable;
import android.text.TextWatcher;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import com.example.superquiz.databinding.FragmentWelcomeBinding;

public class WelcomeFragment extends Fragment {

    private FragmentWelcomeBinding binding;
    public static WelcomeFragment newInstance() {
        WelcomeFragment fragment = new WelcomeFragment();
        return fragment;
    }

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
    }
/*
    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        return inflater.inflate(R.layout.fragment_welcome, container, false);
    }
 */
    @Override
    public View onCreateView( LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        binding = FragmentWelcomeBinding.inflate(inflater, container, false);
        return binding.getRoot();
    }

    @Override
    public void onViewCreated( View view, Bundle savedInstanceState) {
        super.onViewCreated(view, savedInstanceState);
        binding.playButton.setEnabled(false);

        // Vérifier si la saisie de l'utilisateur n'est pas vide et dans ce cas autorisé le clic
        binding.usernameEditText.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence s, int start, int count, int after) {

            }

            @Override
            public void onTextChanged(CharSequence s, int start, int before, int count) {

            }

            @Override
            public void afterTextChanged(Editable s) {
                boolean isEmpty = s.toString().isEmpty();
                binding.playButton.setEnabled(!isEmpty);
            }
        });

        // Détecter le clic sur le bouton Let's Play pour démarrer le quiz
        binding.playButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // Naviguez vers le fragment quiz
                Log.d("David", "Click");
            }
        });
    }
}