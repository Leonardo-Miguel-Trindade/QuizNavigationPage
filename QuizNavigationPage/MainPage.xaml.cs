namespace QuizNavigationPage
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCliked(object sender, EventArgs e)
        {
            //PUSH: Navegar para a Próxima página
            await Navigation.PushAsync(new questao1());
        }
    }
}
