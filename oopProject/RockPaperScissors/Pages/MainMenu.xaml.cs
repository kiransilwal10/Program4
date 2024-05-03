namespace RockPaperScissors.Pages;

public partial class MainMenu : ContentPage
{
	public MainMenu()
	{
		InitializeComponent();
	}
    async void OnNewGameClicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new Game();
    }

    async void OnStatisticsClicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new Statistics();
    }

    async void OnExitClicked(object sender, EventArgs e)
    {
        App.Current.Quit();
    }
}