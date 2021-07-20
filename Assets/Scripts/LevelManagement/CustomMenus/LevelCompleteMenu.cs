using LevelManagement;

namespace MenuManagement
{
    public class LevelCompleteMenu : Menu<LevelCompleteMenu>
    {
        public void OnNextLevelPressed()
        {
            base.OnBackPressed();
            LevelLoader.LoadNextLevel();
        }
        
        public void OnRestartPressed()
        {
            LevelLoader.ReloadLevel();
            GameMenu.Open();
        }

        public void OnMainMenuPressed()
        {
            LevelLoader.LoadMainMenu();
            MainMenu.Open();
        }
    }
}