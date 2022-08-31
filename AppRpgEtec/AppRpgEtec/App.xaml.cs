using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppRpgEtec.Views;
using AppRpgEtec.ViewModels.Usuarios;

namespace AppRpgEtec
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.Usuarios.LoginView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
