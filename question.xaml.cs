namespace pordhubertquizy;

public partial class question : ContentPage
{
	public question()
	{
		InitializeComponent();
	}

    async private void answer_Clicked(object sender, EventArgs e)
    {
        data.Instance.Round++;
        Console.WriteLine($"RUNDA:!!!!!!!!!!!!!!!! {data.Instance.Round}");

		if (data.Instance.Round == 6)
		{
            await Shell.Current.GoToAsync("//leaderboard");
        }
        else
        {
            await Shell.Current.GoToAsync("//playerturn");
        }
    }
}