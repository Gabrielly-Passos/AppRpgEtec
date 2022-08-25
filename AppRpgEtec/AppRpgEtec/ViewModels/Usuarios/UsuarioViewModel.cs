using System;
using System.Collections.Generic;
using System.Text;
using AppRpgEtec.ViewModels;
using AppRpgEtec.Services.Usuarios;
using AppRpgEtec.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppRpgEtec.ViewModels.Usuarios
{
    public class UsuarioViewModel : BaseViewModel
    {
        private UsuarioService uService;
        private Usuario Usuario; 

        public ICommand EntrarCommand { get; set;  }

    }

}
