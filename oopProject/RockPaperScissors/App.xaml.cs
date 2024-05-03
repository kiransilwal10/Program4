using RockPaperScissors.Pages;

namespace RockPaperScissors
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainMenu();
        }
    }
}
