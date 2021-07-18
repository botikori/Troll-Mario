using UnityEngine;

namespace Mario
{
    public class KillerBlock : Tile
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player")) ;
            {
                Player player = FindObjectOfType<Player>();

                if (player != null)
                {
                    player.Die();
                }
            }
        }
    }
}
