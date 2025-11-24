namespace pordhubertquizy
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void begin_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("");
        }
    }
}
