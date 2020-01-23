﻿using EarablesKIT.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EarablesKIT.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MusicModePage : ContentPage
    {
        public MusicModePage()
        {
            InitializeComponent();
            BindingContext = new MusicModeViewModel();
        }
    }
}