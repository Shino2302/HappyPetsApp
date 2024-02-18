using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HappyPetsApp.ViewModels
{
    public class LogginViewModel : BaseViewModel
    {
        #region VARIABLES
        private string _email;
        private string _password;
        #endregion

        #region CONSTRUCTOR
        public LogginViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJECTS
        public string Email
        {
            get { return _email; }
            set { SetValue(ref _email, value); }
        }
        public string Password
        {
            get { return _password; }
            set { SetValue(ref _password, value); }
        }
        #endregion

        #region METHODS
        //public async Task LogginUser()
        //{
        //    try
        //    {
        //        var authentication = new FirebaseAuthProvider(new FirebaseConfig())
        //    }

        //}
        #endregion

        #region COMMANDS
        #endregion
    }
}
