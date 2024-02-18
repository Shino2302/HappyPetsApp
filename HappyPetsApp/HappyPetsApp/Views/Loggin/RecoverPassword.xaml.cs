using HappyPetsApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HappyPetsApp.Views.Loggin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecoverPassword : ContentPage
    {
        public RecoverPassword()
        {
            InitializeComponent();
            BindingContext = new RecoverPasswordViewModel(Navigation);
        }
    }
}