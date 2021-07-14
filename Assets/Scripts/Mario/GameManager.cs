using UnityEngine;
using UnityEngine.SceneManagement;

namespace Mario
{
    public class GameManager : MonoBehaviour
    {
        private static int _checkpointIndex = 0;

        private void Start()
        {
            Debug.Log(_checkpointIndex);
            LoadCheckpoint();
        }

        public void GameOver()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        public void GameWin()
        {
            //TODO show next level screen
            //Save level progress
        }

        public void SaveCheckpoint(int checkpointIndex)
        {
            checkpointIndex = _checkpointIndex;
        }

        private void LoadCheckpoint()
        {
            int loadedCheckpointIndex = PlayerPrefs.GetInt("CheckpointIndex");
            //if(loadedCheckpointIndex == null) {return;}    

            Player player = FindObjectOfType<Player>();
            Checkpoint[] checkpoints = FindObjectsOfType<Checkpoint>();
            
            foreach (var checkpoint in checkpoints)
            {
                if (checkpoint.CheckpointIndex == _checkpointIndex)
                {
                    Vector3 checkpointPosition =  checkpoint.transform.position;
                    player.transform.position = new Vector3(checkpointPosition.x, checkpointPosition.y + 2, checkpointPosition.z);
                    break;
                }
            }
        }
    }
}
