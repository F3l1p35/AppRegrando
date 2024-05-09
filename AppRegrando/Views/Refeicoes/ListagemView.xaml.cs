using AppRegrando.ViewModels.Refeicoes;

namespace AppRegrando.Views.Refeicoes;

public partial class ListagemView : ContentPage
{
	ListagemRefeicaoViewModel viewModel;

	public ListagemView()
	{
		InitializeComponent();

		viewModel = new ListagemRefeicaoViewModel();
		BindingContext = viewModel;
		Title = "Refeicoes - App Regrando";
	}
}