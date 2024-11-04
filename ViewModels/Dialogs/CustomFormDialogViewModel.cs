﻿using System;
using System.Collections.Generic;
using Avalonia.Data;
using Avalonia.Themes.Neumorphism.Dialogs.ViewModels;
using Avalonia.Themes.Neumorphism.Dialogs.ViewModels.Elements;
using DeskAssist.Views.Dialogs;

namespace DeskAssist.ViewModels.Dialogs
{
    public sealed class CustomFormDialogViewModel : DialogWindowViewModel
    {
        private int? _number = 0;
        public int? Number
        {
            get { return _number; }
            set
            {
                _number = value;
                OnPropertyChanged(nameof(Number));
            }
        }


        private List<KeyValuePair<int, string>> _civilities;
        public List<KeyValuePair<int, string>> Civilities
        {
            get { return _civilities; }
            set
            {
                _civilities = value;
                OnPropertyChanged(nameof(Civilities));
            }
        }

        private KeyValuePair<int, string> _civility;
        public KeyValuePair<int, string> Civility
        {
            get { return _civility; }
            set
            {
                _civility = value;
                OnPropertyChanged(nameof(Civility));
            }
        }

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        private DateTime? _birthDate;
        public DateTime? BirthDate
        {
            get { return _birthDate; }
            set
            {
                if (value.HasValue)
                {
                    if (value < DateTime.Today)
                    {
                        _birthDate = value;
                        OnPropertyChanged(nameof(BirthDate));
                    }
                    else
                    {
                        throw new DataValidationException("Invalid birth date");
                    }
                }
            }
        }

        private ResultBasedDialogButtonViewModel _buttonOk;
        public ResultBasedDialogButtonViewModel ButtonOk
        {
            get { return _buttonOk; }
            set
            {
                _buttonOk = value;
                OnPropertyChanged(nameof(ButtonOk));
            }
        }

        private ResultBasedDialogButtonViewModel _buttonCancel;
        public ResultBasedDialogButtonViewModel ButtonCancel
        {
            get { return _buttonCancel; }
            set
            {
                _buttonCancel = value;
                OnPropertyChanged(nameof(ButtonCancel));
            }
        }




        public CustomFormDialogViewModel(CustomFormDialog dialog) : base(dialog)
        {
            Civilities =
            [
                new KeyValuePair<int, string>(1, "Mr."),
                new KeyValuePair<int, string>(2, "Ms."),
                new KeyValuePair<int, string>(3, "Miss")
            ];

            ButtonOk = new ResultBasedDialogButtonViewModel(this, "OK", "ok");
            ButtonCancel = new ResultBasedDialogButtonViewModel(this, "Cancel", "cancel");
        }
    }
}