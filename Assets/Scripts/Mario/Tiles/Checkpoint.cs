using UnityEngine;

namespace Mario
{
    public class Checkpoint : MonoBehaviour
    {
        [SerializeField] private int checkpointIndex;

        public int CheckpointIndex
        {
            get
            {
                return checkpointIndex;
            }
            set
            {
                checkpointIndex = value;
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            GameManager gameManager = FindObjectOfType<GameManager>();
            gameManager.SaveCheckpoint(checkpointIndex);
            Debug.Log(checkpointIndex);
        }
    }
}