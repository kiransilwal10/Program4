using RockPaperScissors.Database;

namespace RockPaperScissors.Pages;

public partial class Statistics : ContentPage
{
    private readonly Stats _database;

    public Statistics()
    {
        InitializeComponent();
        _database = new Stats();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await LoadStatisticsAsync();
    }

    private async Task LoadStatisticsAsync()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        TotalGamesLabel.Text = $"Total Games Played: {_database.TotalGamesPlayed}";
        PlayerWinsLabel.Text = $"Player Wins: {_database.PlayerWins}";
        AIWinsLabel.Text = $"AI Wins: {_database.AIWins}";
        PlayerChoiceLabel.Text = $"Player Choices: Rock ({_database.PlayerChoseRock}), Paper ({_database.PlayerChosePaper}), Scissors ({_database.PlayerChoseScissors})";
        DrawsLabel.Text = $"Draws: {_database.TotalGamesPlayed - (_database.PlayerWins + _database.AIWins)}";
    }

    private async void GoToMainMenu(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainMenu");
    }
}
