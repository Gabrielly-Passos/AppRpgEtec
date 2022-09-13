using AppRpgEtec.Models;
using AppRpgEtec.Services.Personagens;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace AppRpgEtec.ViewModels.Personagens
{
    public class ListagemPersonagemViewModel  : BaseViewModel
    {
        private PersonagemService pService;

        private ObservableCollection<Personagem> Personagens { get; set; }

        public ListagemPersonagemViewModel()
        {
            string token = Application.Current.Properties["UsuarioToken"].ToString();
            pService = new PersonagemService(token);
            Personagens = new ObservableCollection<Personagem>();
        }
    }
}
