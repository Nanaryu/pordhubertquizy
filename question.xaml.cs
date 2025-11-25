using HealthKit;
using System.Collections.Specialized;

namespace pordhubertquizy;

public partial class question : ContentPage
{
	public question()
	{
		InitializeComponent();
        Dictionary<string, string[]> qsw = new Dictionary<string, string[]>
        {
            { "Co sie sta≥o pod legnicπ?", ["kot sie zatru≥ pylicπ","ch≥op sie zesra≥ jajecznicπ","baba kaszla≥a gruülicπ","dziad sie ud≥awi≥ øywicπ"] },
        };
    }

    private void checkAnswer(int ans)
    {
        data.Instance.Round++;
    }

    async private void answer_Clicked1(object sender, EventArgs e)
    {
        checkAnswer(1);

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