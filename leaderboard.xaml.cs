namespace pordhubertquizy;

public partial class leaderboard : ContentPage
{
	public leaderboard()
	{
		InitializeComponent();
        ResultsPlayer1.Loaded += (s, e) => { ResultsPlayer1.Text = $"Punkty {data.Instance.Player1}: {data.Instance.Pts1}"; };
        ResultsPlayer2.Loaded += (s, e) => { ResultsPlayer2.Text = $"Punkty {data.Instance.Player2}: {data.Instance.Pts2}"; };
	}

    async private void RestartGame_Clicked(object sender, EventArgs e)
    {
        data.Instance.Player1 = "";
        data.Instance.Player2 = "";
        data.Instance.Round = 1;
        await Shell.Current.GoToAsync("//MainPage");
    }
}