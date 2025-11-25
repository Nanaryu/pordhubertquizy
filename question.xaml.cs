using System.Collections.Specialized;

namespace pordhubertquizy;

public partial class question : ContentPage
{
    Dictionary<string, string[]> qsw = new Dictionary<string, string[]>
    {
        { "Co sie sta³o pod legnic¹?", ["kot sie zatru³ pylic¹","ch³op sie zesra³ jajecznic¹","baba kaszla³a gruŸlic¹","dziad sie ud³awi³ ¿ywic¹"] },
    };

    public question()
	{
		InitializeComponent();
        ans1.Loaded += (s, e) => { ans1.Text = qsw.ElementAt(data.Instance.Round - 1).Value[0];};
        ans2.Loaded += (s, e) => { ans2.Text = qsw.ElementAt(data.Instance.Round - 1).Value[1];};
        ans3.Loaded += (s, e) => { ans3.Text = qsw.ElementAt(data.Instance.Round - 1).Value[2];};
        ans4.Loaded += (s, e) => { ans4.Text = qsw.ElementAt(data.Instance.Round - 1).Value[3];};
    }

    private void checkAnswer(int ans)
    {
        data.Instance.Round++;
        if (ans == 1)
        {
            if (data.Instance.Round % 2 != 0)
            {
                data.Instance.Pts1++;
            }
            else
            {
                data.Instance.Pts2++;
            }
        }
    }

    async private void answer_Clicked1(object sender, EventArgs e)
    {
        checkAnswer(0);

        if (data.Instance.Round == 6)
        {
            await Shell.Current.GoToAsync("//leaderboard");
        }
        else
        {
            await Shell.Current.GoToAsync("//playerturn");
        }
    }
    async private void answer_Clicked2(object sender, EventArgs e)
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
    async private void answer_Clicked3(object sender, EventArgs e)
    {
        checkAnswer(2);

        if (data.Instance.Round == 6)
        {
            await Shell.Current.GoToAsync("//leaderboard");
        }
        else
        {
            await Shell.Current.GoToAsync("//playerturn");
        }
    }
    async private void answer_Clicked4(object sender, EventArgs e)
    {
        checkAnswer(3);

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