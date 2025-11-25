using System.Reflection.Metadata.Ecma335;

namespace pordhubertquizy;

public partial class playerturn : ContentPage
{
 
	public playerturn()
	{
		InitializeComponent();
        playerName.Loaded += (s, e) =>
        {
            if (data.Instance.Round % 2 != 0)
            {
                playerName.Text = $"{data.Instance.Player1}'s turn.";
            }
            else
            {
                playerName.Text = $"{data.Instance.Player2}'s turn.";
            }
        };
    }

    async private void playRound_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("//question");
    }
}