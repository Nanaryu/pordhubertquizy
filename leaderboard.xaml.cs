namespace pordhubertquizy;

public partial class leaderboard : ContentPage
{
	public leaderboard()
	{
		InitializeComponent();
	}

    async private void RestartGame_Clicked(object sender, EventArgs e)
    {
        data.Instance.Player1 = "";
        data.Instance.Player2 = "";
        data.Instance.Round = 1;
        await Shell.Current.GoToAsync("//MainPage");
    }
}