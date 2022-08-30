using System;
using System.Collections.Generic;
using System.Text;
using AppRpgEtec.ViewModels;
using AppRpgEtec.Services.Usuarios;
using AppRpgEtec.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppRpgEtec.ViewModels.Usuarios
{
    public class UsuarioViewModel : BaseViewModel
    {
        private UsuarioService uService;
        private Usuario Usuario; 

        public ICommand EntrarCommand { get; set;  }

    }

    public async Task ConsultarUsuario()
    {
        try
        {
            //Próxima codificação

            Usuario u

        }
        catch (Exception ex)
        {
            await Application.Current.MainPage
                .DisplayAlert("Informação", ex.Message + "Detalhes: " + ex.InnerException, "Ok");
        }
    }

}
