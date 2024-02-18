using HappyPetsApp.ViewModels;
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
    public partial class MyPets : ContentPage
    {
        public MyPets()
        {
            InitializeComponent();
            BindingContext = new MyPetsViewModel(Navigation);
        }
    }
}