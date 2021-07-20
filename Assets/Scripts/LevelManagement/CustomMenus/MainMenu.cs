using System.Collections;
using LevelManagement;
using LevelManagement.Utilities;
using UnityEngine;

namespace MenuManagement
{
    public class MainMenu : Menu<MainMenu>
    {
        [SerializeField] private float loadGameDelay = 0.5f;
        [SerializeField] private TransitionFader transitionFader;

        public void OnPlayPressed()
        {
            StartCoroutine(OnPlayPressedRoutine());
        }

        public void OnPlayerNameChanged()
        {
            
        }

        private IEnumerator OnPlayPressedRoutine()
        {
            TransitionFader.PlayTransition(transitionFader);
            LevelLoader.LoadNextLevel();
            yield return new WaitForSeconds(loadGameDelay);
            GameMenu.Open();
        }

        public void OnSettingsPressed()
        {
            SettingsMenu.Open();
        }

        public void OnCreditsPressed()
        {
            CreditsMenu.Open();
        }

        public override void OnBackPressed()
        {
            Application.Quit();
        }
    }
}