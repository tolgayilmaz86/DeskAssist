﻿using Avalonia.Themes.Neumorphism.Models;
using System;

namespace DeskAssist.Models
{
    public class CustomSnackbarModel : SnackbarModel
    {
        public CustomSnackbarModel(object content) : base(content)
        {

        }

        public CustomSnackbarModel(object content, TimeSpan? duration) : base(content, duration)
        {

        }
    }
}