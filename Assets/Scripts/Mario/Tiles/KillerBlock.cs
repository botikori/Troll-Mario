using UnityEngine;

namespace Mario
{
    public class KillerBlock : Tile
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            Player player = FindObjectOfType<Player>();

            if (player != null)
            {
                player.Die();
            }
        }
    }
}
