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
    public partial class CadastroPersonagemView : ContentPage
    {

        private CadastroPersonagemView cadViewModel; 
        public CadastroPersonagemView()
        {
            InitializeComponent();

            cadViewModel = new CadastroPersonagemView();
            BindingContext = cadViewModel;
            Title = "Novo Personagem";
        }
    }
}