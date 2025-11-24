namespace pordhubertquizy;

public partial class playerturn : ContentPage
{
	public playerturn()
	{
		InitializeComponent();
	}

    async private void playRound_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("");
    }
}