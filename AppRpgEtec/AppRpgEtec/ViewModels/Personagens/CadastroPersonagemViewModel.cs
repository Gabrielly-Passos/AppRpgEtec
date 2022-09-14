using AppRpgEtec.Services.Personagens;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using AppRpgEtec.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Application = Xamarin.Forms.Application;
using System.Windows.Input;

namespace AppRpgEtec.ViewModels.Personagens
{
    public class CadastroPersonagemViewModel : BaseViewModel
    {
        private PersonagemService pService; 
        public ICommand SalvarCommand { get; set; }

        public CadastroPersonagemViewModel()
        {
            string token = Application.Current.Properties["UsuarioToken"].ToString();
            pService = new PersonagemService(token);
            _ = ObterClasse();
            SalvarCommand = new Command(async () => await SalvarPersonagem());
        }

        private int id;
        private string nome;
        private int pontosVida;
        private int forca;
        private int defesa;
        private int inteligencia;
        private int disputas;
        private int vitorias;
        private int derrotas;

        public int Id
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }
        public string Nome
        {
            get => nome;
            set
            {
                nome = value;
                OnPropertyChanged();
            }
        }
        public int PontosVida
        {
            get => pontosVida;
            set
            {
                pontosVida = value;
                OnPropertyChanged();
            }
        }
        public int Forca
        {
            get => forca;
            set
            {
                forca = value;
                OnPropertyChanged();

            }
        }
        public int Defesa
        {
            get => defesa;
            set
            {
                defesa = value;
                OnPropertyChanged();
            }
        }
        public int Inteligencia
        {
            get => inteligencia;
            set
            {
                inteligencia = value;
                OnPropertyChanged();
            }
        }
        public int Disputas
        {
            get => disputas;
            set
            {
                disputas = value;
                OnPropertyChanged();
            }
        }
        public int Vitorias
        {
            get => vitorias;
            set
            {
                vitorias = value;
                OnPropertyChanged();
            }
        }
        public int Derrotas
        {
            get => derrotas;
            set
            {
                derrotas = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<TipoClasse> listaTiposClasse;

        public ObservableCollection<TipoClasse> ListaTiposClasse
        {
            get { return listaTiposClasse; }
            set
            {
                if (value != null)
                {
                    listaTiposClasse = value;
                    OnPropertyChanged();
                }
            }

        }
        public async Task ObterClasse()
        {
            try
            {
                ListaTiposClasse = new ObservableCollection<TipoClasse>();
                ListaTiposClasse.Add(new TipoClasse() { Id = 1, Descricao = "Cavaleiro" });
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage
                    .DisplayAlert("Ops", ex.Message + "Detalhes: " + ex.InnerException, "Ok");
            }
        }

        private TipoClasse tiposClassesSelecionada;

        public TipoClasse TiposClassesSelecionada
        {
            get { return tiposClassesSelecionada; }
            set
            {
                if (value != null)
                {
                    tiposClassesSelecionada = value;
                    OnPropertyChanged();
                }
            }

        }

        public async Task SalvarPersonagem()
        {
            try
            { 
            Personagem model = new Personagem()
            {
                Nome = this.nome,
                PontosVida = this.pontosVida,
                Defesa = this.defesa,
                Derrotas = this.derrotas,
                Disputas = this.disputas,
                Forca = this.forca,
                Inteligencia = this.inteligencia,
                Vitorias = this.vitorias,
                Id = this.id,
                Classe = (ClasseEnum)tiposClassesSelecionada.Id

            };
            if (model.Id == 0)
                await pService.PostPersonagemAsync(model);

            await Application.Current.MainPage
                  .DisplayAlert("Mensagem", "Dados salvos com sucesso!", "Ok");
            await Shell.Current.GoToAsync("..");

        }
          catch (Exception ex)
            {
                await Application.Current.MainPage
                .DisplayAlert("Ops", ex.Message + "Detalhes " + ex.InnerException, "OK");
            }
          }

  






 }
}
