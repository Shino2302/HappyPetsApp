﻿using HappyPetsApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HappyPetsApp.Views.MainMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Users : ContentPage
    {
        public Users()
        {
            InitializeComponent();
            BindingContext = new UsersViewModel(Navigation);
        }
    }
}