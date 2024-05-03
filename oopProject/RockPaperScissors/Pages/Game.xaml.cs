using System;
using Microsoft.Maui.Controls;
using RockPaperScissors.Database;

namespace RockPaperScissors.Pages;
public partial class Game : ContentPage
{
    private static readonly Random random = new Random();
    public Stats _database;

    public Game()
    {
        InitializeComponent();
        _database = new Stats();
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            string playerOption = button.ClassId;
            string computerOption = GetComputerOptions();
            string winner = FindWinner(playerOption, computerOption);
            DisplayResult(winner, playerOption, computerOption);
            UpdateStatistics(playerOption, winner);
            DisableChoiceButtons();
        }
    }

    private void UpdateStatistics(string playerChoice, string result)
    {
        _database.TotalGamesPlayed++;
        switch (playerChoice)
        {
            case "Rock":
                _database.PlayerChoseRock++;
                break;
            case "Paper":
                _database.PlayerChosePaper++;
                break;
            case "Scissors":
                _database.PlayerChoseScissors++;
                break;
        }
        if (result == "You win!")
            _database.PlayerWins++;
        else if (result == "You lose!")
            _database.AIWins++;

    }

    private void DisableChoiceButtons()
    {
        ScissorsButton.IsEnabled = false;
        RockButton.IsEnabled = false;
        PaperButton.IsEnabled = false;
    }

    private string GetComputerOptions()
    {
        string[] options = { "Rock", "Paper", "Scissors" };
        int index = random.Next(options.Length);
        return options[index];
    }

    private string FindWinner(string player, string computer)
    {
        if (player == computer) return "It's a draw!";
        if ((player == "Rock" && computer == "Scissors") ||
            (player == "Paper" && computer == "Rock") ||
            (player == "Scissors" && computer == "Paper"))
        {
            return "You win!";
        }
        return "You lose!";
    }

    private void DisplayResult(string result, string playerChoice, string computerChoice)
    {
        PlayerChoice.Text = GetEmojiForChoice(playerChoice);
        ComputerChoice.Text = GetEmojiForChoice(computerChoice);
        ResultLabel.Text = result;
    }

    private string GetEmojiForChoice(string choice)
    {
        return choice switch
        {
            "Rock" => "Rock",
            "Paper" => "Paper",
            "Scissors" => "Scissors",
            _ => string.Empty
        };
    }

    private void OnNextRoundClicked(object sender, EventArgs e)
    {
        ScissorsButton.IsEnabled = true;
        RockButton.IsEnabled = true;
        PaperButton.IsEnabled = true;
        PlayerChoice.Text = string.Empty;
        ComputerChoice.Text = string.Empty;
        ResultLabel.Text = string.Empty;
    }

    async void OnExitClicked(object sender, EventArgs e)
    {
        App.Current.Quit();
    }
}