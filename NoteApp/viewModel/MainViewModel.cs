﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;


namespace NoteApp.viewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel() 
        {
            items =new  ObservableCollection<string>();
        
        }

        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;

        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
            {
                return;
            }
            items.Add(text);    
            Text=string.Empty;
        }

        [RelayCommand]
        void Delete(string s) 
        {
            if (items.Contains(s)) 
            {
                items.Remove(s);   

            }
        }

        [RelayCommand]
        async Task Tap(string s)
        {
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}");
        }
    }
}
