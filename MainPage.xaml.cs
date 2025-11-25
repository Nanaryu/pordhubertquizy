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
            data.Instance.Player1 = p1.Text;
            data.Instance.Player2 = p2.Text;
            data.Instance.Round = 1;
            await Shell.Current.GoToAsync("//playerturn");
        }
    }
}
