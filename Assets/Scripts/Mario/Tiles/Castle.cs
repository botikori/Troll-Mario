using UnityEngine;

namespace Mario.Tiles
{
    public class Castle : Tile
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("smthing entered");
                GameManager gameManager = FindObjectOfType<GameManager>();

                if (gameManager != null)
                {
                    gameManager.GameWin();
                }
            }
        }
    }
}