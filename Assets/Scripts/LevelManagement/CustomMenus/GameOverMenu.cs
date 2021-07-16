using LevelManagement;

namespace MenuManagement
{
    public class GameOverMenu : Menu<GameOverMenu>
    {
        public void OnRestartPressed()
        {
            base.OnBackPressed();
            LevelLoader.ReloadLevel();
        }

        public void OnMainMenuPressed()
        {
            LevelLoader.LoadMainMenu();
            MainMenu.Open();
        }
    }
}