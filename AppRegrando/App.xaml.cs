namespace AppRegrando
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new Views.Usuarios.LoginView());
            MainPage = new NavigationPage(new Views.Refeicoes.ListagemView());
        }
    }
}
