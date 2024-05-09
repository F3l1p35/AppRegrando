using AppRegrando.ViewModels.Usuarios;

namespace AppRegrando.Views.Usuarios;

public partial class CadastroView : ContentPage
{
	UsuarioViewModel viewModel;
	public CadastroView()
	{
		InitializeComponent();
		viewModel = new UsuarioViewModel();
		BindingContext = viewModel;
	}
}