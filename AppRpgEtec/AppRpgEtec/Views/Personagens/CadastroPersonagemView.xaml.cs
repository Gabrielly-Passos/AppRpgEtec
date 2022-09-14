using AppRpgEtec.Services.Personagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppRpgEtec.Views.Personagens
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroPersonagemView : ContentPage
    {    
        private PersonagemService pService { get; set; }
        public ICommand SalvarCommand { get; set; }

       public ICommand CancelarCommand { get; set; }

        private CadastroPersonagemView cadViewModel; 
        public CadastroPersonagemView()
        {
            InitializeComponent();

            cadViewModel = new CadastroPersonagemView();
            BindingContext = cadViewModel;
            Title = "Novo Personagem";
        }

        private async void CancelarCadastro()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}