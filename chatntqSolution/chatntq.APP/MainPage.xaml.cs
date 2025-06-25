namespace chatntq.APP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await Task.Delay(1500);

            if(Application.Current?.Windows.FirstOrDefault() != null)
                Application.Current.Windows[0].Page = new NavigationPage(new UI.Login.LoginPage());
        }
    }

}
