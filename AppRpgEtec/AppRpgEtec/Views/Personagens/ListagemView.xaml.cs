using AppRpgEtec.Models;
using AppRpgEtec.ViewModels.Personagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppRpgEtec.Views.Personagens
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListagemView : ContentPage
    {
        private ListagemPersonagemViewModel viewModel;

        public ListagemView()
        {
            InitializeComponent();

            viewModel = new ListagemPersonagemViewModel();
            BindingContext = viewModel;

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _ = viewModel.ObterPersonagens();
        }

        private Personagem personagemSelecionado;

        public Personagem PersonagemSelecionado 
        {
            get { return personagemSelecionado; }
            set
            { 
                if(value !=null)
                personagemSelecionado = value;
                
                Shell.Current
                    .GoToAsync($"cadPersonagemView?pId ={personagemSelecionado.Id}" );
            
            }   }
    }
}