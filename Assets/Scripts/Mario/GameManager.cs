using Mario.Characters;
using MenuManagement;
using UnityEngine;

namespace Mario
{
    public class GameManager : MonoBehaviour
    {
        private void Start()
        {
            
        }

        public void GameOver()
        {
            //Time.timeScale = 0f;
            GameOverMenu.Open();
        }

        public void GameWin()
        {
           LevelCompleteMenu.Open();
           Player player = FindObjectOfType<Player>();
           player.Disable();
           Debug.Log("game won");
        }
    }
}
