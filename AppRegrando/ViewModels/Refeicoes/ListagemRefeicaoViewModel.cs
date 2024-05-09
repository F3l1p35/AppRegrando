using AppRegrando.Models;
using AppRegrando.Services.Refeicoes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRegrando.ViewModels.Refeicoes
{
    public class ListagemRefeicaoViewModel : BaseViewModel
    {
        private RefeicaoService rService;

        public ObservableCollection<Refeicao> Refeicoes { get; set; }

        public ListagemRefeicaoViewModel()
        {
            string token = Preferences.Get("UsuarioToken", string.Empty);
            rService = new RefeicaoService(token);
            Refeicoes = new ObservableCollection<Refeicao>();

            _ = ObterRefeicoes();

        }

        public async Task ObterRefeicoes()
        {
            try
            {
                Refeicoes = await rService.GetRefeicoesAsync();
                OnPropertyChanged(nameof(Refeicoes));

            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Ops", ex.Message + "Detalhes:" + ex.InnerException, "Ok");
            }
        }
    }
}
