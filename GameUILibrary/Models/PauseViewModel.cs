﻿#region Copyright

// COPYRIGHT 2016 JUSTIN COX (CONJI)

#endregion Copyright

using EmptyKeys.UserInterface;
using EmptyKeys.UserInterface.Input;
using EmptyKeys.UserInterface.Mvvm;
using System.Diagnostics;

namespace GameUILibrary.Models
{
    public class PauseViewModel : ViewModelBase
    {
        public RelayCommand OptionsButtonCommand { get; set; }
        public RelayCommand QuitButtonCommand { get; set; }
        public RelayCommand ResumeButtonCommand { get; set; }
    }
}