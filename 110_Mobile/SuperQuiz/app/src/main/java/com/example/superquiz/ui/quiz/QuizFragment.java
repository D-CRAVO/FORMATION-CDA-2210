package com.example.superquiz.ui.quiz;

import android.os.Bundle;

import androidx.fragment.app.Fragment;
import androidx.lifecycle.ViewModelProvider;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import com.example.superquiz.databinding.FragmentQuizBinding;
import com.example.superquiz.injection.ViewModelFactory;

import org.jetbrains.annotations.Nullable;

public class QuizFragment extends Fragment{
    FragmentQuizBinding binding;
    private QuizViewModel viewModel;

    @Override
    public void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        viewModel = new ViewModelProvider(this, ViewModelFactory.getInstance()).get(QuizViewModel.class);
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState){
        binding = FragmentQuizBinding.inflate(inflater, container, false);
        return binding.getRoot();
    }

}


